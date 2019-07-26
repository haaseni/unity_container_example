using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper.Init();
            Initiator initiator = DependencyInjector.Retrieve<Initiator>();

            var data = initiator.FetchData();

            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
