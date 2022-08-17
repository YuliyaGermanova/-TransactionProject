using System.Text.Json;
using TransactionProject.DAL.Entities;
using TransactionProject.DAL.Repositories;

namespace TransactionProject.Services
{
    /// <summary>
    /// Сервис для работы с транзакциями.
    /// </summary>
    internal class TransactionService
    {
        private readonly TransactionRepository _transactionRepository;
        public TransactionService()
        {
            _transactionRepository = new TransactionRepository();
        }

        public string Add(int id, DateTime transactionDate, decimal amount)
        {
            try
            {
                var transaction = new Transaction()
                {
                    Id = id,
                    TransactionDate = transactionDate,
                    Amount = amount
                };

                _transactionRepository.Add(transaction);

                return "Операция выполнена успешно";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Get(int id)
        {
            try
            {
                var transaction = _transactionRepository.GetById(id);

                if (transaction == null)
                {
                    return "Записи не существует";
                }

                var transactionJson = JsonSerializer.Serialize(transaction);

                return transactionJson;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
