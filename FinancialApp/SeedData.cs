using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinancialApp.Models;
using static FinancialApp.Models.FinanceContext;

namespace FinancialApp
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.GetRequiredService<IServiceScopeFactory>()
                    .CreateScope())
            {
                FinanceContext context = serviceScope.ServiceProvider.GetService<FinanceContext>();
                if (!context.Users.Any())
                {
                    
                    context.Users.AddRange(
                        new User() { UserName = "Charles", Password = "XxXNastyBoiCharlesXxX"},
                        new User() { UserName = "Denice", Password = "SecurePassword"},
                        new User() { UserName = "Hunter", Password = "Hunter2"},
                        new User() { UserName = "Jim", Password = "Jim"},
                        new User() { UserName = "Betty", Password = "BABA"}
                        );

                }
                if (!context.Accounts.Any())
                {

                    context.Accounts.AddRange(
                        new Account() { Balance = 100000,Overdraft = 0, DebitOrCredit = true, UserID = 1 },
                        new Account() { Balance = -10000, Overdraft = 50000, DebitOrCredit = false, UserID = 1 },
                        new Account() { Balance = 40000, Overdraft = 10000, DebitOrCredit = false, UserID = 1 },
                        new Account() { Balance = 999000, Overdraft = 0, DebitOrCredit = true, UserID = 2 },
                        new Account() { Balance = 150000, Overdraft = 0, DebitOrCredit = false, UserID = 2 },
                        new Account() { Balance = 600, Overdraft = 0, DebitOrCredit = true, UserID = 3 },
                        new Account() { Balance = 96400, Overdraft = 0, DebitOrCredit = true, UserID = 4 },
                        new Account() { Balance = 187000, Overdraft = 0, DebitOrCredit = true, UserID = 5 },
                        new Account() { Balance = 421000, Overdraft = 0, DebitOrCredit = false, UserID = 5 }
                       );
                }
                if (!context.Transactions.Any())
                {

                    context.Transactions.AddRange(
                        new Transaction() { FromAccountID = 1, ToAccountID = 5, Amount = 10000,Date = new DateTime(2018,01,15,12,14,13), IsRecurring = false },
                        new Transaction() { FromAccountID = 9, ToAccountID = 1, Amount = 100000, Date = new DateTime(2018, 03, 23, 18, 11, 10), IsRecurring = false },
                        new Transaction() { FromAccountID = 2, ToAccountID = 4, Amount = 1000, Date = new DateTime(2017, 04, 05, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 3, ToAccountID = 7, Amount = 2200, Date = new DateTime(2018, 09, 11, 01, 14, 13), IsRecurring = true },
                        new Transaction() { FromAccountID = 3, ToAccountID = 7, Amount = 5400, Date = new DateTime(2016, 01, 15, 12, 14, 13), IsRecurring = true },
                        new Transaction() { FromAccountID = 7, ToAccountID = 3, Amount = 7400, Date = new DateTime(2015, 01, 15, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 8, ToAccountID = 4, Amount = 40000, Date = new DateTime(2018, 01, 15, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 4, ToAccountID = 6, Amount = 10000, Date = new DateTime(2017, 02, 15, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 4, ToAccountID = 6, Amount = 10000, Date = new DateTime(2017, 03, 15, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 5, ToAccountID = 1, Amount = 2500, Date = new DateTime(2018, 01, 18, 16, 14, 13), IsRecurring = true },
                        new Transaction() { FromAccountID = 1, ToAccountID = 5, Amount = 5000, Date = new DateTime(2018, 01, 15, 12, 14, 13),IsRecurring = false },
                        new Transaction() { FromAccountID = 6, ToAccountID = 7, Amount = 7000, Date = new DateTime(2018, 10, 10, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 6, ToAccountID = 8, Amount = 6000, Date = new DateTime(2018, 09, 15, 12, 14, 13), IsRecurring = true },
                        new Transaction() { FromAccountID = 4, ToAccountID = 6, Amount = 1010000, Date = new DateTime(2018, 06, 20, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 6, ToAccountID = 4, Amount = 9900, Date = new DateTime(2018, 06, 15, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 3, ToAccountID = 7, Amount = 1600, Date = new DateTime(2018, 01, 15, 12, 14, 13), IsRecurring = true },
                        new Transaction() { FromAccountID = 7, ToAccountID = 1, Amount = 2300, Date = new DateTime(2018, 02, 15, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 7, ToAccountID = 5, Amount = 100000, Date = new DateTime(2018, 03, 15, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 2, ToAccountID = 8, Amount = 35300, Date = new DateTime(2018, 01, 15, 12, 14, 13), IsRecurring = false },
                        new Transaction() { FromAccountID = 9, ToAccountID = 2, Amount = 32200, Date = new DateTime(2018, 01, 15, 12, 14, 13), IsRecurring = true }
                       );
                }
                context.SaveChanges();
            }
        }
    }
}
