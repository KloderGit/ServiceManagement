using SM.App.Infrastructure.AppService.C1;
using SM.App.Service.Interfaces;
using SM.App.Service.Interfaces.C1;

namespace SM.App.Infrastructure.DomainService
{
    public class DataManager1C : IDataManager1C
    {
        _1CServiceLibrary.UnitOfWork dataManager;

        public DataManager1C()
        {
            dataManager = new _1CServiceLibrary.UnitOfWork();
        }

        IProgram1C EducationPrograms;

        public IProgram1C Programs => EducationPrograms ?? (EducationPrograms = new Program1CImplement(dataManager.Programs));

    }
}
