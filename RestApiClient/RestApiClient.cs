using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using BikeStore.Models;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace BikeStore.RestApiClient
{
    public static class RestClient
    {
        private const string Url = "http://localhost:8080";
        public static async Task<IEnumerable<Manufacturer>> GetManufacturerNamesAsync()
        {
            using var httpClient = new HttpClient();
            return JsonSerializer.Deserialize<List<Manufacturer>>(
                await httpClient.GetStringAsync($"{Url}/api/manufacturer/GetAll"));
        }
        public static async Task<Manufacturer> GetManufacturerAsync(int id)
        {
            using var httpClient = new HttpClient();
            return JsonSerializer.Deserialize<Manufacturer>(
                await httpClient.GetStringAsync($"{Url}/api/manufacturer/" + id));
        }
        private static async Task<int> AddOrUpdateManufacturerAsync(Manufacturer manufacturer, string url, string request)
        {
            using var requestMessage = new HttpRequestMessage(new HttpMethod(request), url);
            using (requestMessage.Content = new StringContent(JsonConvert.SerializeObject(manufacturer), Encoding.UTF8, "application/json"))
            using (var httpClient = new HttpClient())
            {
                var responseMessage = await httpClient.SendAsync(requestMessage);
                responseMessage.EnsureSuccessStatusCode();
                return Convert.ToInt32(await responseMessage.Content.ReadAsStringAsync());
            }
        }
        public static async Task<int> AddManufacturerAsync(Manufacturer manufacturer)
        {
            return await AddOrUpdateManufacturerAsync(manufacturer, $"{Url}/api/manufacturer", "POST");
        }
        public static async Task<int> UpdateManufacturerAsync(Manufacturer manufacturer)
        {
            return await AddOrUpdateManufacturerAsync(manufacturer, $"{Url}/api/manufacturer", "PUT");
        }
        public static async Task DeleteManufacturerAsync(int id)
        {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync($"{Url}/api/manufacturer/" + id);
            responseMessage.EnsureSuccessStatusCode();
        }
        public static async Task<IEnumerable<Order>> GetOrderNamesAsync()
        {
            using var httpClient = new HttpClient();
            return JsonSerializer.Deserialize<List<Order>>(
                await httpClient.GetStringAsync($"{Url}/api/order/GetAll"));
        }
        public static async Task<Order> GetOrderAsync(int id)
        {
            using var httpClient = new HttpClient();
            return JsonSerializer.Deserialize<Order>(
                await httpClient.GetStringAsync($"{Url}/api/order/" + id));
        }
        private static async Task<int> AddOrUpdateOrderAsync(Order order, string url, string request)
        {
            using var requestMessage = new HttpRequestMessage(new HttpMethod(request), url);
            using (requestMessage.Content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json"))
            using (var httpClient = new HttpClient())
            {
                var responseMessage = await httpClient.SendAsync(requestMessage);
                responseMessage.EnsureSuccessStatusCode();
                return Convert.ToInt32(await responseMessage.Content.ReadAsStringAsync());
            }
        }
        public static async Task<int> AddOrderAsync(Order order)
        {
            return await AddOrUpdateOrderAsync(order, $"{Url}/api/order", "POST");
        }
        public static async Task<int> UpdateOrderAsync(Order order)
        {
            return await AddOrUpdateOrderAsync(order, $"{Url}/api/order", "PUT");
        }
        public static async Task DeleteOrderAsync(int id)
        {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync($"{Url}/api/order/" + id);
            responseMessage.EnsureSuccessStatusCode();
        }
        public static async Task<IEnumerable<ElectricBike>> GetElectricBikeNamesAsync()
        {
            using var httpClient = new HttpClient();
            return JsonSerializer.Deserialize<List<ElectricBike>>(
                await httpClient.GetStringAsync($"{Url}/api/electricbike/GetAll"));
        }
        public static async Task<ElectricBike> GetElectricBikeAsync(int id)
        {
            using var httpClient = new HttpClient();
            return JsonSerializer.Deserialize<ElectricBike>(
                await httpClient.GetStringAsync($"{Url}/api/electricbike/" + id));
        }
        private static async Task<int> AddOrUpdateElectricBikeAsync(ElectricBike electricBike, string url, string request)
        {
            using var requestMessage = new HttpRequestMessage(new HttpMethod(request), url);
            using (requestMessage.Content = new StringContent(JsonConvert.SerializeObject(electricBike), Encoding.UTF8, "application/json"))
            using (var httpClient = new HttpClient())
            {
                var responseMessage = await httpClient.SendAsync(requestMessage);
                responseMessage.EnsureSuccessStatusCode();
                return Convert.ToInt32(await responseMessage.Content.ReadAsStringAsync()); // why is this returning an int?
            }
        }
        public static async Task<int> AddElectricBikeAsync(ElectricBike electricBike)
        {
            return await AddOrUpdateElectricBikeAsync(electricBike, $"{Url}/api/electricbike", "POST");
        }
        public static async Task<int> UpdateElectricBikeAsync(ElectricBike electricBike)
        {
            return await AddOrUpdateElectricBikeAsync(electricBike, $"{Url}/api/electricbike", "PUT");
        }
        public static async Task DeleteElectricBikeAsync(int id)
        {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync($"{Url}/api/electricbike/" + id);
            responseMessage.EnsureSuccessStatusCode();
        }
        public static async Task<IEnumerable<RoadBike>> GetRoadBikeNamesAsync()
        {
            using var httpClient = new HttpClient();
            return JsonSerializer.Deserialize<List<RoadBike>>(
                await httpClient.GetStringAsync($"{Url}/api/roadbike/GetAll"));
        }
        public static async Task<RoadBike> GetRoadBikeAsync(int id)
        {
            using var httpClient = new HttpClient();
            return JsonSerializer.Deserialize<RoadBike>(
                await httpClient.GetStringAsync($"{Url}/api/roadbike/" + id));
        }

        private static async Task<int> AddOrUpdateRoadBikeAsync(RoadBike roadBike, string url, string request)
        {
            using var requestMessage = new HttpRequestMessage(new HttpMethod(request), url);
            using (requestMessage.Content = new StringContent(JsonConvert.SerializeObject(roadBike), Encoding.UTF8, "application/json"))
            using (var httpClient = new HttpClient())
            {
                var responseMessage = await httpClient.SendAsync(requestMessage);
                responseMessage.EnsureSuccessStatusCode();
                return Convert.ToInt32(await responseMessage.Content.ReadAsStringAsync()); // why is this returning an int?
            }
        }
        public static async Task<int> AddRoadBikeAsync(RoadBike roadBike)
        {
            return await AddOrUpdateRoadBikeAsync(roadBike, $"{Url}/api/roadbike", "POST");
        }
        public static async Task<int> UpdateRoadBikeAsync(RoadBike roadBike)
        {
            return await AddOrUpdateRoadBikeAsync(roadBike, $"{Url}/api/roadbike", "PUT");
        }
        public static async Task DeleteRoadBikeAsync(int id)
        {
            using var httpClient = new HttpClient();
            var responseMessage = await httpClient.DeleteAsync($"{Url}/api/roadbike/" + id);
            responseMessage.EnsureSuccessStatusCode();
        }
    }
}