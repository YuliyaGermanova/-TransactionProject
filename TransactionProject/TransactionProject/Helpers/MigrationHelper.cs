using Microsoft.EntityFrameworkCore;
using TransactionProject.DAL;

namespace TransactionProject.Helpers
{
    /// <summary>
    /// Помощник для работы с миграциями.
    /// </summary>
    public class MigrationHelper
    {
        public void UpdateDatabase()
        {
            using (var db = new TransactionContext())
            {
                db.Database.Migrate();
            }
        }
    }
}
