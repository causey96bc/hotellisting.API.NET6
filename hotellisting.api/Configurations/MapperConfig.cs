using AutoMapper;
using hotellisting.api.Data;
using hotellisting.api.Models;

namespace hotellisting.api.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryModel>().ReverseMap();
            CreateMap<Country, GetCountryModel>().ReverseMap();
            CreateMap<Country, GetCountryDetailsModel>().ReverseMap();
            CreateMap<Hotel, GetHotelModel>().ReverseMap();
            CreateMap<Country, UpdateCountryModel>().ReverseMap();


        }

    }
}
