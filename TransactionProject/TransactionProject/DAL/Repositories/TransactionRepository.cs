using TransactionProject.DAL.Entities;

namespace TransactionProject.DAL.Repositories
{
    /// <summary>
    /// Репозиторий для работы с транзакциями.
    /// </summary>
    internal class TransactionRepository
    {
        public void Add(Transaction transaction)
        {
            using (var db = new TransactionContext())
            {
                db.Add(transaction);
                db.SaveChanges();
            }
        }

        public Transaction GetById(int id)
        {
            using (var db = new TransactionContext())
            {
                var transaction = db.Transactions.FirstOrDefault(x => x.Id == id);
                return transaction;
            }
        }
    }
}
