using SM.App.Common.Mapster;
using SM.App.Infrastructure.DomainService;
using SM.App.Service.Interfaces;
using System;

namespace xSandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            new RegisterMapsterConfig();

            Console.WriteLine("Hello World!");

            IDataManager1C ttt = new DataManager1C();

            var mmm = ttt.Attestations.GetList();

            var mmmv = ttt.Programs.GetList();
        }
    }
}
