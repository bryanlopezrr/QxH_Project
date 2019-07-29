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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace QxHDashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBucketProvider _bucketProvider;
        
        //private readonly TimedHostedService _hostedService;

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

        private readonly List<SelectListItem> _countries = new List<SelectListItem>
        {
            new SelectListItem {Value = "0", Text = "USA"},
            new SelectListItem {Value = "1", Text = "EUR"},
            new SelectListItem {Value = "2", Text = "JPN"}
        };

        private readonly List<SelectListItem> _cards = new List<SelectListItem>
        {
            new SelectListItem {Value = "0", Text = "A"},
            new SelectListItem {Value = "1", Text = "B"},
            new SelectListItem {Value = "2", Text = "C"},
            new SelectListItem {Value = "3", Text = "D"},
            new SelectListItem {Value = "4", Text = "E"},
            new SelectListItem {Value = "5", Text = "F"},
            new SelectListItem {Value = "6", Text = "G"},
            new SelectListItem {Value = "7", Text = "H"},
            new SelectListItem {Value = "8", Text = "I"},
            new SelectListItem {Value = "9", Text = "J"},
            new SelectListItem {Value = "10", Text = "K"},
            new SelectListItem {Value = "11", Text = "L"},
            new SelectListItem {Value = "12", Text = "M"},
            new SelectListItem {Value = "13", Text = "N"},
            new SelectListItem {Value = "14", Text = "O"},
            new SelectListItem {Value = "15", Text = "P"},
            new SelectListItem {Value = "16", Text = "Q"},
            new SelectListItem {Value = "17", Text = "R"},
            new SelectListItem {Value = "18", Text = "S"},
            new SelectListItem {Value = "19", Text = "T"},
            new SelectListItem {Value = "20", Text = "U"},
            new SelectListItem {Value = "21", Text = "V"},
            new SelectListItem {Value = "22", Text = "W"},
            new SelectListItem {Value = "23", Text = "X"},
            new SelectListItem {Value = "24", Text = "Y"},
            new SelectListItem {Value = "25", Text = "Z"},
        };

        private readonly List<SelectListItem> _networks = new List<SelectListItem>
        {
            new SelectListItem {Value = "0", Text = "Global"},
            new SelectListItem {Value = "1", Text = "HSN"},
            new SelectListItem {Value = "2", Text = "HSN.com"},
            new SelectListItem {Value = "3", Text = "HSN2"}
        };

        public IActionResult SelectDDView()
        {
            var model = new MerchandiseViewModel { countries = _countries };
            GetMerchandise(model);
            return View(model);
        }

        public IActionResult GetState(MerchandiseViewModel model)
        {
            model.countries = _countries;
            model.cards = _cards;
            model.networks = _networks;
            model.SelectedCountry = (from c in model.countries
                                     where c.Value == model.SelectedCountryId.ToString()
                                     select new Country
                                     {
                                         CountryId = int.Parse(c.Value),
                                         CountryName = c.Text
                                     }).FirstOrDefault();

            model.SelectedCard = (from d in model.cards
                                  where d.Value == model.SelectedCardId.ToString()
                                  select new Card
                                  {
                                      CardId = int.Parse(d.Value),
                                      CardLetter = d.Text
                                  }).FirstOrDefault();

            model.SelectedNetwork = (from n in model.networks
                                     where n.Value == model.SelectedNetworkId.ToString()
                                     select new Network
                                     {
                                         NetworkId = int.Parse(n.Value),
                                         NetworkName = n.Text
                                     }).FirstOrDefault();

            string countryName = FindCountryName(model.SelectedCountry.CountryId);
            var bucket = _bucketProvider.GetBucket(countryName);
            var n1ql = @"SELECT g.*, META(g).id
                        FROM `" + countryName + "` g " +
                        "WHERE g.companyId = " + model.SelectedCountry.CountryId + " " +
                        "AND g.showCd = '" + model.SelectedCard.CardLetter + "' " +
                        "AND g.networkId = " + model.SelectedNetwork.NetworkId + " " +
                        "LIMIT 20;";
            var query = QueryRequest.Create(n1ql);
            var results = bucket.Query<Merchandise>(query);
            try
            {
                model.merchandise = results.Rows;
            }
            catch (global::System.Exception)
            {
                throw;
            }
            return View(model);
        }

        public IActionResult GetMerchandise(MerchandiseViewModel model)
        {            
            GetState(model);
            //TimerStart(model);
            return View(model);
        }

        [HttpPost]
        public IActionResult SelectDDView(MerchandiseViewModel model)
        {            
            GetState(model);
            //TimerStart(model);
            return View(model);
        }

        private string FindCountryName(int countryId)
        {
            string countryName;

            if (countryId == 0)
                countryName = "MerchUSA";
            else if (countryId == 1)
                countryName = "MerchEUR";
            else
                countryName = "MerchJPN";

            return countryName;
        }      

        private static void TimerTask(object timerState)
        {
            var state = timerState as TimerState;
            Interlocked.Increment(ref state.Counter);
        }

        private IActionResult TimerStart(MerchandiseViewModel model)
        {
            Timer timer;
            var timerState = new TimerState { Counter = 0 };
            timer = new Timer(
                callback: new TimerCallback(TimerTask),
                state: timerState,
                dueTime: 1000,
                period: 1000);

            while (timerState.Counter > -1)
            {
                if (timerState.Counter > 5)
                {
                    timerState.Counter = 0;
                    return RedirectToAction("GetState");
                }
                GetState(model);
                return View(model);
            }
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    class TimerState
    {
        public int Counter;
    }    
}
