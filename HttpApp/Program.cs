using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace HttpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessJSON().Wait();
        }

        private static async Task ProcessJSON()
        {

            var client = new HttpClient();
            var serializer = new DataContractJsonSerializer(typeof(List<Users>));
            var response = client.GetStreamAsync("https://jsonplaceholder.typicode.com/users");
            var users = serializer.ReadObject(await response) as List<Users>;

            foreach (var user in users)
            {
                Console.WriteLine("User ID: {0}",user.name);

                Console.WriteLine("City: {0}", user.address.city);

                Console.WriteLine("Lat: {0}", user.address.geo.lat);
                Console.WriteLine("Lng: {0}", user.address.geo.lng);
         

            }

        }
    }
}
