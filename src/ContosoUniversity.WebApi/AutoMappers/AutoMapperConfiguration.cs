using AutoMapper;

namespace ContosoUniversity.WebApi.AutoMappers
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.AddProfile<EntityToViewModelMappingProfile>();
            Mapper.AddProfile<ViewModelToEntityMappingProfile>();
        }
    }
}