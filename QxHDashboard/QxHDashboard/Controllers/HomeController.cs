using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using Couchbase.Extensions.DependencyInjection;
using Couchbase.N1QL;
using Microsoft.AspNetCore.Mvc;
using QxHDashboard.Models;
using System.Threading;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace QxHDashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly SemaphoreSlim _updateMerchOrdersSold = new SemaphoreSlim(1, 1);
        private readonly IBucketProvider _bucketProvider;
        private readonly ConcurrentDictionary<string, Merchandise> _merchandise = new ConcurrentDictionary<string, Merchandise>();
        private readonly Subject<Merchandise> _subject = new Subject<Merchandise>();
        private volatile bool _updateMerchSold;

        public HomeController(IBucketProvider bucketProvider)
        {
            _bucketProvider = bucketProvider;
        }       

        private async void UpdateMerchSold(object state)
        {
            await _updateMerchOrdersSold.WaitAsync();
            try
            {
                if(!_updateMerchSold)
                {
                    _updateMerchSold = true;

                    foreach(var merch in _merchandise.Values)
                    {
                        TryUpdateMerchSold(merch);
                        _subject.OnNext(merch);
                    }

                    _updateMerchSold = false;
                }
            }
            finally
            {
                _updateMerchOrdersSold.Release();
            }
        }

        private bool TryUpdateMerchSold(Merchandise merchandise)
        {
            merchandise.OrderSldTdy += merchandise.OrderQuantity;
            return true;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Merchandise(Countries selCountry, ShowCards selCards)
        {          
            switch (selCountry)
            {
                case Countries.USA:
                    var bucket = _bucketProvider.GetBucket("MerchUSA");
                    var n1ql = @"SELECT g.*, META(g).id
                                FROM `MerchUSA` g
                                WHERE g.CompanyId = 0
                                AND g.ShowCd = '" + selCards + "' " +
                                "LIMIT 20;";
                    var query = QueryRequest.Create(n1ql);
                    var results = bucket.Query<Merchandise>(query);
                    UpdateMerchSold(results.Rows);
                    return View(results.Rows);
                case Countries.EUR:
                    var bucket2 = _bucketProvider.GetBucket("MerchEUR");
                    var n1ql2 = @"SELECT g.*, META(g).id
                                FROM `MerchEUR` g
                                WHERE g.CompanyId = 1
                                AND g.ShowCd = '" + selCards + "' " +
                                "LIMIT 20;";
                    var query2 = QueryRequest.Create(n1ql2);
                    var results2 = bucket2.Query<Merchandise>(query2);
                    UpdateMerchSold(results2.Rows);
                    return View(results2.Rows);
                case Countries.JPN:
                    var bucket3 = _bucketProvider.GetBucket("MerchJPN");
                    var n1ql3 = @"SELECT g.*, META(g).id
                                FROM `MerchJPN` g
                                WHERE g.CompanyId = 2
                                AND ShowCd = '" + selCards + "' " +
                                "LIMIT 20;";
                    var query3 = QueryRequest.Create(n1ql3);
                    var results3 = bucket3.Query<Merchandise>(query3);
                    UpdateMerchSold(results3.Rows);
                    return View(results3.Rows);
            }
            return View();
        }

        //public IActionResult ShowCards(ShowCards selCards)
        //{            
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
