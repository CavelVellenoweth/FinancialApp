using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace FinancialApp.Models
{
    public class FinanceContext : DbContext
    {
        public enum Months { Jan = 1, Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec }
        public FinanceContext(DbContextOptions<FinanceContext> options)
            : base(options)
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public class User
        {
            [DisplayName("User ID")]
            [Key]
            public int UserID { get; set; }
            [DisplayName("User Name")]
            [Required(AllowEmptyStrings = false)]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string UserName { get; set; }
            [DisplayName("Password")]
            [Required(AllowEmptyStrings = false)]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            public string Password { get; set; }
            [DisplayName("DailyBudget")]
            public int DailyBudget { get; set; }
            [DisplayName("WeeklyBudget")]
            public int WeeklyBudget { get; set; }
            [DisplayName("MonthlyBudget")]
            public int MonthlyBudget { get; set; }
            [DisplayName("YearlyBudget")]
            public int YearlyBudget { get; set; }
        }

        public class Account
        {
            [DisplayName("Account ID")]
            [Key]
            public int AccountID { get; set; }
            [DisplayName("User ID")]
            [ForeignKey("User")]
            public int UserID { get; set; }
            [DisplayName("Balance")]
            [Required]
            public int Balance { get; set; }
            [DisplayName("Overdraft")]
            [Required]
            public int Overdraft { get; set; }
            [DisplayName("Debit Or Credit?")]
            [Required]
            public bool DebitOrCredit { get; set; }
            [DisplayName("DailyBudget")]
            public int DailyBudget { get; set; }
            [DisplayName("WeeklyBudget")]
            public int WeeklyBudget { get; set; }
            [DisplayName("MonthlyBudget")]
            public int MonthlyBudget { get; set; }
            [DisplayName("YearlyBudget")]
            public int YearlyBudget { get; set; }
        }

        public class Transaction
        {
            [DisplayName("Transaction ID")]
            [Key]
            public int TransactionID { get; set; }
            [DisplayName("Account ID")]
            [ForeignKey("Account")]
            public int FromAccountID { get; set; }
            [DisplayName("From Account ID")]
            [ForeignKey("Account")]
            public int ToAccountID { get; set; }
            [DisplayName("Amount")]
            [Required]
            public int Amount { get; set; }
            [DisplayName("Date")]
            [Required]
            public DateTime Date { get; set; }
            [DisplayName("Is Recurring?")]
            [Required]
            public bool IsRecurring { get; set; }
        }
    }
}
