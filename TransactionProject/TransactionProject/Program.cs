// See https://aka.ms/new-console-template for more information

using TransactionProject.Constants;

Console.WriteLine("Ожидание команды...");

var command = string.Empty;

while (command != "exit")
{
    command = Console.ReadLine();
    switch (command)
    {
        case CommandTypes.Add:
            Console.WriteLine("ввели add");
            break;
        case CommandTypes.Get:
            Console.WriteLine("ввели get");
            break;
        case CommandTypes.Exit:
            Console.WriteLine("Работа приложения завершена");
            break;
        default:
            Console.WriteLine("команда не распознана");
            break;
    }
}

Console.Read();
