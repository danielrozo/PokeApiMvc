using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsumeApiMvc.WebServices
{
    public class HttpCommunicator : IHttpCommunicator
    {
        private HttpClient _client;

        public HttpCommunicator()
        {
            _client = new HttpClient();

            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public string BaseAddress
        {
            get
            {
                return _client.BaseAddress.AbsoluteUri;
            }

            set
            {
                _client.BaseAddress = new Uri(value);
            }
        }

        public async Task<string> SendGetRequestAsync(string uri)
        {
            var response = await _client.GetAsync(uri);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> SendPostRequestAsync<T>(string uri, T data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var response = await _client.PostAsync(uri, new StringContent(jsonData));
            return await response.Content.ReadAsStringAsync();
        }
    }
}