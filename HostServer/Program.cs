using System;
using System.ServiceModel;

namespace HostServer
{
    internal class Program
    {
        private static string addr = "http://localhost:8080/";
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес сервера. Если оставить поле пустым, то будет использован стандартный адрес \"http://localhost:8080/\"");
            Console.Write("Адрес: ");
            string readLine = Console.ReadLine();

            if (!string.IsNullOrEmpty(readLine))
                addr = readLine;

            Type serverType = typeof(Cryptography.Cryptography);
            Uri serverUri = new Uri(addr);

            ServiceHost host = new ServiceHost(serverType, serverUri);
            host.Open();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            foreach(var baseAddr in host.BaseAddresses)
                Console.WriteLine($"Сервер инициализирован с адресом - {baseAddr}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\bНажмите любую клавишу для остановки сервиса!!!");
            Console.ReadKey();
            host.Close();
            Console.ResetColor();
        }
    }
}
