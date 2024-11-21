using EasyBom.DataCenter.Model;
using WebApiClientCore.Attributes;

namespace EasyBom.DataCenter.HttpApi.IApi;

[HttpHost("http://localhost:5000/")]
public interface IAuthenticationApi
{
    [HttpPost("/auth/oauth2/token")]
    Task<ClientToken> GetEasyBomToken([RawStringContent("text/plain")] string text);

    [HttpPost("/auth/oauth2/token")]
    Task<ClientToken> RefreshEasyBomToken([RawStringContent("text/plain")] string text);
}