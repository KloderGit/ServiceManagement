using Mapster;
using ServiceReference1C;
using SM.Domain.Core.Models;
using System;

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
                .Map(dest => dest.Variant, src => src.viewProgram)
                .Map(dest => dest.Department, src => src.category)
                .Map(dest => dest.EducationForm, src => src.formEducation)
                .Map(dest => dest.Subjects, src => src.listOfSubjects);


            config.NewConfig<formEdu, SM.Domain.Core.Models.EducationForm>()
                .Map(dest => dest.Guid, src => src.GUIDFormEducation)
                .Map(dest => dest.Title, src => src.Name);


            config.NewConfig<ГруппаПрограммыОбучения, SM.Domain.Core.Models.Department>()
                .Map(dest => dest.Guid, src => src.ГУИД)
                .Map(dest => dest.Title, src => src.Наименование);

            config.NewConfig<category, SM.Domain.Core.Models.Department>()
                .Map(dest => dest.Guid, src => src.GUID)
                .Map(dest => dest.Title, src => src.Name);

            config.NewConfig<subject, SM.Domain.Core.Models.Subject>()
                .Map(dest => dest.Guid, src => src.GUIDsubject)
                .Map(dest => dest.Title, src => src.subjectName)
                .Map(dest => dest.Duration, src => src.duration)
                .Map(dest => dest.Attestation, src => String.IsNullOrEmpty(src.Attestation.formControl.GUIDFormControl) ? null : src.Attestation.formControl);


            config.NewConfig<ФормаКонтроля, SM.Domain.Core.Models.Attestation>()
                .Map(dest => dest.Guid, src => src.ГУИД)
                .Map(dest => dest.Title, src => src.Наименование);

            config.NewConfig<formControl, SM.Domain.Core.Models.Attestation>()
                .Map(dest => dest.Guid, src => src.GUIDFormControl)
                .Map(dest => dest.Title, src => src.Name);
        }
    }
}
