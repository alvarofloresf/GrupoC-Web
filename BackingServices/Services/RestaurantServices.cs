using BackingServices.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BackingServices.Services
{
    public class RestaurantServices
    {
        public async Task<Restaurant> GetRestaurantServicesAsync()
        {
            try
            {
                Console.WriteLine("Pidinedo info de Restaurant");
                using (HttpClient client = new HttpClient())
                {
                    string RestaurantURL = "https://random-data-api.com/api/restaurant/random_restaurant";

                    HttpResponseMessage response = await client.GetAsync(RestaurantURL);
                    if (response.IsSuccessStatusCode)
                    {
                        string restaurantBody = await response.Content.ReadAsStringAsync();
                        Restaurant restaurant = JsonConvert.DeserializeObject<Restaurant>(restaurantBody);
                        return restaurant;
                        /*
                        var ResRestaurant = await response.Content.ReadAsStringAsync();
                        dynamic res = JsonConvert.DeserializeObject(ResRestaurant);
                        return res;
                        */
                    }
                    else
                    {
                        throw new Exception("Error");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al esperar la respuesta del restaurant");
                Console.WriteLine(ex.Message + ex.StackTrace);
                throw;
            }
        }
    }
}
