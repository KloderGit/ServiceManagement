using SM.App.Common.Mapster;
using SM.App.Infrastructure.DomainService;
using SM.App.Service.Interfaces;
using System;
using ServiceLibrary1C.Repositories;
using ServiceReference1C;
using System.Linq;

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

            var kkk = mmmv.SelectMany(p => p.Subjects.Where(s => s.Attestation != null));



            //var ddd = new ПФ_ПорталДПОPortTypeClient(ПФ_ПорталДПОPortTypeClient.EndpointConfiguration.ПФ_ПорталДПОSoap);

            //var asd = new ProgramRepository(ddd);

            //var dsfe = asd.GetList().Result;

        }
    }
}
