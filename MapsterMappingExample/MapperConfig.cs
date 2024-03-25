using Mapster;
using MapsterMappingExample.Models;

namespace MapsterMappingExample
{
    public class MapperConfig
    {
        public static void ConfigMapster()
        {
            TypeAdapterConfig<GameCharacter, GameCharacterDto>.NewConfig()
                .Map(dest => dest.FullName, src => src.Name);

            TypeAdapterConfig<Location, LocationDto>.NewConfig()
                .Map(dest => dest.Name, src => src.Name.ToUpper());
        }
    }
}
