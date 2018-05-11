using Mapster;
using ServiceReference1C;
using SM.Domain.Core.Models;

namespace SM.App.Common.Mapster
{
    public class EntityAnd1C : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<ProgramEdu, EducationProgram>()
                .Map(dest => dest.Guid, src => src.XML_ID)
                .Map(dest => dest.Title, src => src.name)
                .Map(dest => dest.Active, src => src.active == "Активный" ? true : false)
                .Map(dest => dest.Accepted, src => src.acceptDate)
                .Map(dest => dest.Type, src => src.typeProgram)
                .Map(dest => dest.Class, src => src.viewProgram);
        }
    }
}
