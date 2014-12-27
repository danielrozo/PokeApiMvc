using System.Threading.Tasks;

namespace ConsumeApiMvc.WebServices
{
    public interface IHttpCommunicator
    {
        string BaseAddress { get; set; }

        Task<string> SendGetRequestAsync(string uri);
        Task<string> SendPostRequestAsync<T>(string uri, T data);
    }
}
