using System;
using ConsumeApiMvc.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsumeApiMvc.WebServices
{
    public class PokeApiClient : IPokeApiClient
    {
        private readonly IHttpCommunicator _httpCommunicator;

        public PokeApiClient(IHttpCommunicator httpCommunicator)
        {
            _httpCommunicator = httpCommunicator;
            _httpCommunicator.BaseAddress = "http://pokeapi.co/api/v1/";
        }

        public async Task<Ability> GetAbility(int id)
        {
            return await SendGetRequestAsync<Ability>("ability" + id);
        }

        public async Task<Pokemon> GetPokemon(int id)
        {
            return await SendGetRequestAsync<Pokemon>("pokemon/" + id);
        }

        public async Task<Models.Type> GetType(int id)
        {
            return await SendGetRequestAsync<Models.Type>("type/" + id);
        }

        private async Task<T> SendGetRequestAsync<T>(string uri)
        {
            string jsonResponse = await _httpCommunicator.SendGetRequestAsync(uri);
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }
    }
}