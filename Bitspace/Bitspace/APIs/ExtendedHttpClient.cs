using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bitspace.APIs
{
    public class ExtendedHttpClient : IHttpClient
    {
        private readonly HttpClient _client;

        public ExtendedHttpClient()
        {
            _client = new HttpClient();
        }

        public Task<HttpResponseMessage> GetAsync(Uri uri)
        {
            return _client.GetAsync(uri);
        }
    }
}
