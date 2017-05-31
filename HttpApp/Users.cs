namespace HttpApp
{
    public class Users{
        public string id;
        public string name;
        public string email;
        public Address address;
      
    }

    public class Address
    {
        public string street;
        public string suite;
        public string city;
        public string zipcode;
        public Geo geo;
    }

    public class Geo
    {
        public string lat;
        public string lng;
    }
}