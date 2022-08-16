using Microsoft.EntityFrameworkCore;
using TransactionProject.DAL.Entities;

namespace TransactionProject.DAL
{
    public class TransactionContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite($"Data Source=Transactions.db");
    }
}
