using hotellisting.api.Data;

namespace hotellisting.api.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    { 
        Task<Country> GetDetails(int id);
    }
}
