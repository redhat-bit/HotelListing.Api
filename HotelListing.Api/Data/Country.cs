namespace HotelListing.Api.Data;

public class Country
{
	public int countryId { get; set; }
	public string Name { get; set; }	
	public string shortName { get; set; }
	public IList<Hotel> Hotels { get; set; } = [];
}

