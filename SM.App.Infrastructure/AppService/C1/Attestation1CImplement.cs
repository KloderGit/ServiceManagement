using Mapster;
using ServiceLibrary1C.Interfaces;
using SM.App.Service.Interfaces.C1;
using SM.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM.App.Infrastructure.AppService.C1
{
    public class Attestation1CImplement : IAttestation1C
    {
        ICommonRepository<ServiceReference1C.ФормаКонтроля> source;

        public Attestation1CImplement(ICommonRepository<ServiceReference1C.ФормаКонтроля> source)
        {
            this.source = source;
        }

        public Attestation Get(string key)
        {
            return source.Get(key).Result
                        .Adapt<SM.Domain.Core.Models.Attestation>();
        }

        public IEnumerable<Attestation> GetList()
        {
            var result = source.GetList().Result;
            return result.Adapt<IEnumerable<SM.Domain.Core.Models.Attestation>>();
        }
    }
}
