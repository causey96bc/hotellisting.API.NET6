namespace hotellisting.api.Models
{
    public class GetCountryModel: BaseCountryModel
    {
        public int Id { get; set; }
    }
    public class GetCountryDetailsModel: BaseCountryModel
    {
        public int Id { get; set; 
        public List<GetHotelModel> Hotels { get; set; }
    }
}
