// See https://aka.ms/new-console-template for more information
using TransactionProject.Constants;
using TransactionProject.Helpers;
using TransactionProject.Services;

TransactionService _transactionService = new TransactionService();
MigrationHelper _migrationHelper = new MigrationHelper();

_migrationHelper.UpdateDatabase();

Console.WriteLine("Ожидание команды...");

var command = string.Empty;

while (command != "exit")
{
    command = Console.ReadLine();
    switch (command)
    {
        case CommandTypes.Add:
            Add();
            break;
        case CommandTypes.Get:
            Get();
            break;
        case CommandTypes.Exit:
            Console.WriteLine("Работа приложения завершена");
            break;
        default:
            Console.WriteLine("Команда не распознана");
            break;
    }
}

void Add()
{
    Console.WriteLine("Введите Id:");
    var id = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите дату:");
    var transactionDate = Convert.ToDateTime(Console.ReadLine());

    Console.WriteLine("Введите сумму:");
    var amount = Convert.ToDecimal(Console.ReadLine());

    var result = _transactionService.Add(id, transactionDate, amount);

    Console.WriteLine(result);
}

void Get()
{
    Console.WriteLine("Введите Id:");
    var id = Convert.ToInt32(Console.ReadLine());

    var result = _transactionService.Get(id);

    Console.WriteLine(result);
}
