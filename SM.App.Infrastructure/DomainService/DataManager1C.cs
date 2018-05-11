
using SM.App.Infrastructure.AppService.C1;
using SM.App.Service.Interfaces;
using SM.App.Service.Interfaces.C1;

namespace SM.App.Infrastructure.DomainService
{
    public class DataManager1C : Service.Interfaces.IDataManager1C
    {
        ServiceLibrary1C.Interfaces.IDataManager dataManager;

        public DataManager1C()
        {
            dataManager = new ServiceLibrary1C.UnitOfWork();
        }

        Service.Interfaces.C1.IProgram1C EducationPrograms;
        Service.Interfaces.C1.IAttestation1C EduAttestations;

        public Service.Interfaces.C1.IProgram1C Programs => EducationPrograms ?? (EducationPrograms = new AppService.C1.Program1CImplement(dataManager.Programs));

        public Service.Interfaces.C1.IAttestation1C Attestations => EduAttestations ?? (EduAttestations = new AppService.C1.Attestation1CImplement(dataManager.Attestations));
    }
}
