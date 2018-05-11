using SM.App.Service.Interfaces.C1;
using System;
using System.Collections.Generic;
using System.Text;

namespace SM.App.Service.Interfaces
{
    public interface IDataManager1C
    {
        IProgram1C Programs { get; }
        IAttestation1C Attestations { get; }
    }
}
