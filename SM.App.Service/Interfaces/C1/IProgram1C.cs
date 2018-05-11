using SM.Domain.Core.Models;
using SM.Domain.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM.App.Service.Interfaces.C1
{
    public interface IProgram1C : IGetData<EducationProgram>
    {
        //IEnumerable<EducationProgram> GetList(DateTime? startDate, DateTime? endDate);
    }
}
