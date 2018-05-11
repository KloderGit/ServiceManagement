using Mapster;
using ServiceLibrary1C.Interfaces;
using SM.App.Service.Interfaces.C1;
using SM.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace SM.App.Infrastructure.AppService.C1
{
    public class Program1CImplement : IProgram1C
    {
        ICommonRepository<ServiceReference1C.ProgramEdu> source;

        public Program1CImplement(ICommonRepository<ServiceReference1C.ProgramEdu> source)
        {
            this.source = source;
        }

        public EducationProgram Get(string Guid)
        {
            return source.Get(Guid).Result
                        .Adapt<EducationProgram>();
        }

        public IEnumerable<EducationProgram> GetList()
        {
            var result = source.GetList().Result;
            return result.Adapt<IEnumerable<EducationProgram>>();
        }

    }
}
