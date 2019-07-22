using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QxHOracleLoader.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Dapper;

namespace QxHOracleLoader.Controllers
{
    public class ItemsController : Controller
    {
        private readonly LoaderContext _context;        

        public ItemsController(LoaderContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            List<Item> itemList = new List<Item>();

            itemList = (from Item in _context.Item
                        select Item).ToList();

            return View(itemList);
        }

        [HttpPost]
        public IActionResult Index(List<Item> objItems)
        {
            var countChecked = 0;
            var countUnChecked = 0;

            SqlConnection sc = new SqlConnection();

            for (int i = 0; i < objItems.Count(); i++)
            {
                if(objItems[i].CheckboxAnswer == true)
                {
                    //List<Item> items = new List<Item>();
                    countChecked += 1;
                    try
                    {
                        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
                        {
                            DataSource = "blazinsql.database.windows.net",
                            UserID = "qxhadmin",
                            Password = "user$123",
                            InitialCatalog = "blazinsql"
                        };
                        sc.ConnectionString = builder.ConnectionString;
                        sc.Open();

                        var sqlStatement = @"INSERT INTO USA (ItemId,PlanSeqId,ItemDescription,OrderQuantity,OrderSldTdy,PlannedMinutesQty,ActualMinutesQty,NetworkId,CompanyId,AvaiForSaleQty,ShowDate,ShowCd) 
                                            VALUES (@ItemId,@PlanSeqId,@ItemDescription,@OrderQuantity,@OrderSldTdy,@PlannedMinutesQty,@ActualMinutesQty,@NetworkId,@CompanyId,@AvaiForSaleQty,@ShowDate,@ShowCd)";

                        sc.ExecuteAsync(sqlStatement, objItems);                        
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    countUnChecked += 1;
                }
            }
            return View(objItems);
        }        
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemId,PlanSeqId,ItemDescription,OrderQuantity,OrderSldTdy,PlannedMinutesQty,ActualMinutesQty,NetworkId,CompanyId,AvaiForSaleQty,ShowDate,ShowCd")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemId,PlanSeqId,ItemDescription,OrderQuantity,OrderSldTdy,PlannedMinutesQty,ActualMinutesQty,NetworkId,CompanyId,AvaiForSaleQty,ShowDate,ShowCd")] Item item)
        {
            if (id != item.ItemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItemId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.ItemId == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Item.FindAsync(id);
            _context.Item.Remove(item);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }
    }
}
