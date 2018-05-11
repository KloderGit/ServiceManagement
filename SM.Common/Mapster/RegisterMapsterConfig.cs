using Mapster;
using System.Reflection;

namespace SM.App.Common.Mapster
{
    public class RegisterMapsterConfig
    {
        public RegisterMapsterConfig()
        {
            Assembly assem = typeof(EntityAnd1C).GetTypeInfo().Assembly;

            TypeAdapterConfig.GlobalSettings.Scan(assem);
        }
    }
}
