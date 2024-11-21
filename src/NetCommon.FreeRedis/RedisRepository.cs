using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeRedis;
using NetCommon.Redis;

namespace NetCommon.FreeRedis
{
    public class RedisRepository : IRedisRepository
    {
        private readonly RedisClient _redisClient;

        public RedisRepository(RedisClient redisClient)
        {
            _redisClient = redisClient;
        }

        public async Task Set<T>(string key, T value)
        {
            await this.Set(key, value, null);
        }

        public async Task Set<T>(string key, T value, int expiredTimeSeconds)
        {
            await this.Set(key, value, TimeSpan.FromSeconds(expiredTimeSeconds));
        }

        public async Task Set<T>(string key, T value, TimeSpan? expiredTime)
        {
            if (expiredTime.HasValue)
            {
                await _redisClient.SetAsync(key, value, expiredTime.Value);
            }
            else
            {
                await _redisClient.SetAsync(key, value);
            }
        }

        public async Task Set<T>(Dictionary<string, T> dic)
        {
            await _redisClient.MSetAsync(dic);
        }

        public async Task<long> Append<T>(string key, T value)
        {
            return await _redisClient.AppendAsync(key, value);
        }

        public async Task<TimeSpan> GetTimeToLive(string key)
        {
            var idleSeconds = await _redisClient.ObjectIdleTimeAsync(key);
            return TimeSpan.FromSeconds(idleSeconds);
        }

        public async Task<string> Get(string key)
        {
            return await this.Get<string>(key);
        }

        public async Task<T> Get<T>(string key)
        {
            try
            {
                return await _redisClient.GetAsync<T>(key);
            }
            catch (Exception e)
            {
                return default;
            }
        }

        public async Task<List<string>> Get(List<string> keys)
        {
            return await this.Get<string>(keys);
        }

        public async Task<List<T>> Get<T>(List<string> keys)
        {
            var result = await _redisClient.MGetAsync<T>(keys.ToArray());
            return result.ToList();
        }

        public async Task<string> GetAndSetValue(string key, string value)
        {
            return await _redisClient.GetSetAsync(key, value);
        }

        public async Task<long> GetCount(string key)
        {
            return await _redisClient.StrLenAsync(key);
        }

        public async Task<long> Incr(string key)
        {
            return await _redisClient.IncrAsync(key);
        }

        public async Task<long> IncrBy(string key, long count)
        {
            return await _redisClient.IncrByAsync(key, count);
        }

        public async Task<decimal> IncrFloatBy(string key, decimal floatNum)
        {
            return await _redisClient.IncrByFloatAsync(key, floatNum);
        }

        public async Task<long> Decr(string key)
        {
            return await _redisClient.DecrAsync(key);
        }

        public async Task<long> DecrBy(string key, int count)
        {
            return await _redisClient.DecrByAsync(key, count);
        }
    }
}