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

    var isIdValid = int.TryParse(Console.ReadLine(), out var id);
    if (!isIdValid)
    {
        Console.WriteLine("Данные введены некорректно");
        return;
    }

    Console.WriteLine("Введите дату:");

    var isDateValid = DateTime.TryParse(Console.ReadLine(), out var transactionDate);
    if (!isDateValid)
    {
        Console.WriteLine("Данные введены некорректно");
        return;
    }

    Console.WriteLine("Введите сумму:");

    var isAmountValid = decimal.TryParse(Console.ReadLine(), out var amount);
    if (!isAmountValid)
    {
        Console.WriteLine("Данные введены некорректно");
        return;
    }

    var result = _transactionService.Add(id, transactionDate, amount);

    Console.WriteLine(result);
}

void Get()
{
    Console.WriteLine("Введите Id:");

    var isIdValid = int.TryParse(Console.ReadLine(), out var id);
    if (!isIdValid)
    {
        Console.WriteLine("Данные введены некорректно");
        return;
    }

    var result = _transactionService.Get(id);

    Console.WriteLine(result);
}
