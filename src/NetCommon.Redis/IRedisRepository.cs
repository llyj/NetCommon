namespace NetCommon.Redis
{
    public interface IRedisRepository
    {
        #region String类型操作

        /// <summary>
        /// 设置键值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        Task Set<T>(string key, T value);

        /// <summary>
        /// 设置键值，及过期时间
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expiredTimeSeconds">过期时间</param>
        /// <returns></returns>
        Task Set<T>(string key, T value, int expiredTimeSeconds);

        /// <summary>
        /// 设置键值，及过期时间
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="expiredTime"></param>
        /// <returns></returns>
        Task Set<T>(string key, T value, TimeSpan? expiredTime);

        /// <summary>
        /// 设置多个key/value
        /// </summary>
        Task Set<T>(Dictionary<string, T> dic);

        /// <summary>
        /// 追加：在原有key的value值之后追加value
        /// </summary>
        Task<long> Append<T>(string key, T value);

        /// <summary>
        /// 获取key的剩余有效时间
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<TimeSpan> GetTimeToLive(string key);

        /// <summary>
        /// 获取值：获取key的value值
        /// </summary>
        Task<string> Get(string key);

        /// <summary>
        /// 获取值：获取key的value值
        /// </summary>
        Task<T> Get<T>(string key);

        /// <summary>
        /// 获取多个key的value值
        /// </summary>
        Task<List<string>> Get(List<string> keys);

        /// <summary>
        /// 获取多个key的value值
        /// </summary>
        Task<List<T>> Get<T>(List<string> keys);

        /// <summary>
        /// 获取旧值并设置新值
        /// </summary>
        Task<string> GetAndSetValue(string key, string value);

        /// <summary>
        /// 获取值的长度
        /// </summary>
        Task<long> GetCount(string key);

        /// <summary>
        /// 自增1，返回自增后的值
        /// </summary>
        Task<long> Incr(string key);

        /// <summary>
        /// 自增任意整型count，返回自增后的值
        /// </summary>
        Task<long> IncrBy(string key, long count);

        /// <summary>
        /// 自增任意小数floatNum，返回自增后的值
        /// </summary>
        Task<decimal> IncrFloatBy(string key, decimal floatNum);

        /// <summary>
        /// 自减1，返回自减后的值
        /// </summary>
        Task<long> Decr(string key);

        /// <summary>
        /// 自减count ，返回自减后的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<long> DecrBy(string key, int count);

        #endregion String类型操作
    }
}