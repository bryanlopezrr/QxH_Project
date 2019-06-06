using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CouchbaseDI.Models;
using Couchbase.Extensions.DependencyInjection;
using Couchbase.N1QL;

namespace CouchbaseDI.Controllers
{
    public class HomeController : Controller
    {
        private IBucketProvider _bucketProvider;

        public HomeController(IBucketProvider bucketProvider)
        {
            _bucketProvider = bucketProvider;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Airline()
        {
            var bucket = _bucketProvider.GetBucket("travel-sample");
            var n1ql = @"SELECT META(a).id, a.name, a.country, a.callsign 
                        FROM `travel-sample` a
                        WHERE a.type='airline' 
                        LIMIT 20; ";
            var query = QueryRequest.Create(n1ql);
            var results = bucket.Query<Airline>(query);

            return View(results.Rows);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
