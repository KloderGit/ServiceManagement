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
                .Map(dest => dest.Variety, src => src.typeProgram)
                .Map(dest => dest.Type, src => src.viewProgram);


            config.NewConfig<ФормаКонтроля, SM.Domain.Core.Models.Attestation>()
                .Map(dest => dest.Guid, src => src.ГУИД)
                .Map(dest => dest.Title, src => src.Наименование);
        }
    }
}
