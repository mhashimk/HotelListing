using HotelListing.API.CoreModels.Hotel;

namespace HotelListing.API.CoreModels.Country
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }

    
}

