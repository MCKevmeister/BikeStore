using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BikeStore.Models;

namespace BikeStore.RestApiClient
{
    public static class RestClient
    {
        private const string Url = "http://localhost:8080";

        public static async Task<List<Manufacturer>> GetManufacturerNamesAsync()
        {
            using var httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync($"{Url}/api/manufacturer/listnames");
            return JsonSerializer.Deserialize<List<Manufacturer>>(result);
        }


        // public static async Task<IList<Manufacturer>> ListArtistAsync()
        // {
        //     using var httpClient = new HttpClient();
        //     var result = await httpClient.GetStringAsync($"{Url}/api/manufacturer/list");
        //     return JsonSerializer.Deserialize<List<ArtistModel>>(result);
        // }
        //
        // public static async Task<ArtistModel> GetArtistAsync(int id)
        // {
        //     using var httpClient = new HttpClient();
        //     return JsonSerializer.Deserialize<ArtistModel>(
        //         await httpClient.GetStringAsync($"{Url}/api/artist/get?id=" + id));
        // }
        //
        // private static async Task<int> AddOrUpdateAsync<T>(T model, string url, string request)
        // {
        //     using var requestMessage = new HttpRequestMessage(new HttpMethod(request), url);
        //     using (requestMessage.Content =
        //         new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json"))
        //     using (var httpClient = new HttpClient())
        //     {
        //         var responseMessage = await httpClient.SendAsync(requestMessage);
        //         responseMessage.EnsureSuccessStatusCode();
        //         return Convert.ToInt32(await responseMessage.Content.ReadAsStringAsync());
        //     }
        // }
        //
        // public static async Task<int> AddManufacturerAsync(Manufacturer manufacturer)
        // {
        //     return await AddOrUpdateAsync(manufacturer, $"{Url}/api/manufacturer/add", "POST");
        // }
        //
        // public static async Task<int> UpdateArtistAsync(Manufacturer manufacturer)
        // {
        //     return await AddOrUpdateAsync(manufacturer, $"{Url}/api/manufacturer/update", "PUT");
        // }
        //
        // public static async Task DeleteArtistAsync(int id)
        // {
        //     using var httpClient = new HttpClient();
        //     var responseMessage = await httpClient.DeleteAsync(($"{Url}/api/artist/delete?id={id}"));
        //     responseMessage.EnsureSuccessStatusCode();
        // }
    }
}