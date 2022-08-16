namespace TransactionProject.DAL.Entities
{
    public class Transaction
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Дата.
        /// </summary>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Сумма.
        /// </summary>
        public decimal Amount { get; set; }
    }
}
