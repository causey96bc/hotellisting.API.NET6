using AutoMapper;
using hotellisting.api.Data;

namespace hotellisting.api.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryModel>().ReverseMap();  
        }
        
    }
}
