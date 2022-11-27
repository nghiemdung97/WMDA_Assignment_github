using Newtonsoft.Json;
using SearchMatchAPI.DTOs;
using SearchMatchAPI.Models;
using System.Diagnostics.Contracts;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace SearchMatchAPI.Services
{
    public class MatchServices : IMatchService
    {
        private readonly HttpClient _httpClient;

        public MatchServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Match(int searchID, Patient patient)
        {
            string endpointUrl = string.Empty;
            if (searchID == 1) 
            {
                endpointUrl = "https://ptsv2.com/t/czssr-1669197881/post";
                var searchJson = new StringContent(
                    JsonConvert.SerializeObject(patient.AsEngine1DTO(), new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto }),
                    Encoding.UTF8,
                    Application.Json);
                await PostSearch(endpointUrl, searchJson);
            }
            else if (searchID == 2)
            {
                endpointUrl = "https://ptsv2.com/t/ez7y6-1669197966/post";
                var searchJson = new StringContent(
                    JsonConvert.SerializeObject(patient.AsEngine2DTO(),new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto }),
                    Encoding.UTF8,
                    Application.Json);
                await PostSearch(endpointUrl, searchJson);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Match Engine ID not found"); 
            }



        }

        private async Task PostSearch(string URI, StringContent data)
        {
            using var result = await _httpClient.PostAsync(URI, data);
            result.EnsureSuccessStatusCode();
        }
    }
}
