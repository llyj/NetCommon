using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyBom.DataCenter.HttpApi.Config;
using EasyBom.DataCenter.HttpApi.IApi;
using EasyBom.DataCenter.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NetCommon.Redis;
using WebApiClientCore.Extensions.OAuths;
using WebApiClientCore.Extensions.OAuths.TokenProviders;

namespace EasyBom.DataCenter.HttpApi.Provider
{
    public class DataCenterTokenProvider : TokenProvider
    {
        private readonly EasyBomConfig _easyBomConfig;
        private const string TokenKey = "EasyBomAccessToken";

        public DataCenterTokenProvider(IServiceProvider services, IOptions<EasyBomConfig> easyBomConfig) : base(services)
        {
            _easyBomConfig = easyBomConfig.Value;
        }

        protected override async Task<TokenResult?> RequestTokenAsync(IServiceProvider serviceProvider)
        {
            var redisRepository = serviceProvider.GetRequiredService<IRedisRepository>();

            var clientToken = await redisRepository.Get<ClientToken?>(TokenKey);
            if (clientToken == null)
            {
                var param = $"client_id={_easyBomConfig.client_id}&client_secret={_easyBomConfig.client_secret}&grant_type=authorization_code&code={_easyBomConfig.code}";
                clientToken = await serviceProvider.GetRequiredService<IAuthenticationApi>().GetEasyBomToken(param);
                await redisRepository.Set(TokenKey, clientToken, TimeSpan.FromSeconds(clientToken.expires_in));
            }
            else
            {
                var timeToLive = await redisRepository.GetTimeToLive(TokenKey);
                clientToken.expires_in = (long)timeToLive.TotalSeconds;
            }

            var tokenResult = new TokenResult() { Access_token = clientToken.access_token, Expires_in = clientToken.expires_in, Refresh_token = clientToken.refresh_token };
            return tokenResult;
        }

        protected override async Task<TokenResult?> RefreshTokenAsync(IServiceProvider serviceProvider, string refresh_token)
        {
            var param = $"grant_type=refresh_token&refresh_token={refresh_token}";
            var clientToken = await serviceProvider.GetRequiredService<IAuthenticationApi>().RefreshEasyBomToken(param);

            var redisRepository = serviceProvider.GetRequiredService<IRedisRepository>();
            await redisRepository.Set(TokenKey, clientToken, TimeSpan.FromSeconds(clientToken.expires_in));

            var tokenResult = new TokenResult() { Access_token = clientToken.access_token, Expires_in = clientToken.expires_in, Refresh_token = clientToken.refresh_token };
            return tokenResult;
        }
    }
}