namespace HotelListing.API.CoreExceptions
{
    public class NotFoundException:ApplicationException
    {
        public NotFoundException(string name, object key): base($"{name} ({key}) was not found")
        {

        }
    }
}
