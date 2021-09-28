
using System.Threading.Tasks;
using System.Text.Json;

namespace OneInch.Api
{
    public class TokenClient : ITokenClient
    {
        IApiAdapter _api;
        public TokenClient(IApiAdapter apiAdapter)
        {            
            _api = apiAdapter;
        }

        public async Task<TokenList> GetAll()
        {
            var response = await _api.SendRequest(Paths.API.Tokens); 
            return JsonSerializer.Deserialize<TokenList>(response);
        }
    }

}