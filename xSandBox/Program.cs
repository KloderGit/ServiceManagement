using SM.App.Common.Mapster;
using SM.App.Infrastructure.DomainService;
using System;

namespace xSandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            new RegisterMapsterConfig();

            Console.WriteLine("Hello World!");

            var ttt = new DataManager1C();

            var mmm = ttt.Programs.GetList();
        }
    }
}
