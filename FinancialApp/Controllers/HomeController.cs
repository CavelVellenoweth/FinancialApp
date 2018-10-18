using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using FinancialApp.Models;

namespace FinancialApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly FinanceContext db;

        public HomeController(FinanceContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult UserHome()
        {
            ViewData["MyAccounts"] = db.Accounts.Where(m => m.UserID == 1); //replace 1 with users ID later
            return View();
        }
        public IActionResult Account()
        {
            int selected;           
            Int32.TryParse(RouteData.Values.GetValueOrDefault("id").ToString(),out selected);
            ViewData["MyID"] = selected;
            ViewData["MyTransactions"] = db.Transactions.Where(m => m.FromAccountID == selected || m.ToAccountID == selected);
            
            return View();
        }
        public IActionResult Budget()
        {
            List<IQueryable<FinanceContext.Transaction>> test = new List<IQueryable<FinanceContext.Transaction>>();
            //I think i have to change the database so that transactions contains user ID so I can access all the transactions for the user. :(
            ViewData["MyAccounts"] = db.Accounts.Where(m => m.UserID == 1); //replace 1 with users ID later
            foreach (var account in ViewData["MyAccounts"] as IEnumerable<FinancialApp.Models.FinanceContext.Account>)
            {
                test.Add(db.Transactions.Where(m => m.FromAccountID == account.AccountID || m.FromAccountID == account.AccountID));
            }
            ViewData["MyTransactions"] = test;
            
            return View();
        }
        public IActionResult Payment()
        {
            if (RouteData.Values.GetValueOrDefault("filterType").ToString() == "New")
            {
                List<int> accountList = new List<int>();
                ViewData["MyAccount"] = db.Accounts.Where(m => m.AccountID == (int)RouteData.Values.GetValueOrDefault("id")); //replace 1 with users ID later
                var accounts = db.Accounts
                                                    .Select(m => new 
                                                    {
                                                        ID = m.AccountID
                                                    })
                                                    .Where(m => m.ID != (int)RouteData.Values.GetValueOrDefault("id")).ToList();
                foreach(var account in accounts)
                {
                    accountList.Add(account.ID);
                }
                ViewData["AvailableAccounts"] = accountList;
            }
            else
            {
                ViewData["Transactions"] = db.Transactions.Where(m => m.FromAccountID == (int)RouteData.Values.GetValueOrDefault("id") && m.Date > DateTime.Now);
            }
            return View();
        }

        [HttpPost]
        public IActionResult MakePayment(int myAccount, int ID, int amount, DateTime date,bool isRecurring)
        {
            FinanceContext.Transaction newTransaction = new FinanceContext.Transaction
            {
                FromAccountID = myAccount,
                ToAccountID = ID,
                Amount = amount,
                Date = date,
                IsRecurring = Convert.ToBoolean(isRecurring)               
            };
            db.Transactions.Add(newTransaction);
            db.SaveChanges();
            UpdateBalances(myAccount,ID,amount);
            return RedirectToAction("UserHome");
        }
        [HttpPost]
        public IActionResult CancelPayment(int transactionID,int fromID, int toID, int amount)
        {
            var transaction = db.Transactions.Where(m => m.TransactionID == transactionID);
            db.Remove(transaction.FirstOrDefault());
            db.SaveChanges();
            UpdateBalances(fromID, toID, -amount);
            return RedirectToAction("UserHome");
        }
        private void UpdateBalances(int fromID, int toID, int amount)
        {
            var accounts = db.Accounts.Where(m => m.AccountID == fromID || m.AccountID == toID);
            foreach (var account in accounts)
            {
                if (account.AccountID == toID)
                {
                    account.Balance += amount;
                }
                else account.Balance -= amount;
                db.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                
            }
            db.SaveChanges();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
