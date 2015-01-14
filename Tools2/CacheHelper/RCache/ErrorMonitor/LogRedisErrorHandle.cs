using System;
using System.Text;
using Tools.LogHelper;
using Tools.CacheHelper.RCache.ErrorMonitor;
namespace Tools.CacheHelper.RCache.ErrorMonitor
{
    public class LogRedisErrorHandle<T> : IErrorHandle<T>
    {
        private StringBuilder str = new StringBuilder();

        void IErrorHandle<T>.CacheErrorOnDel(T t, Exception ex, string key)
        {
            str.Clear();
            str.Append("RedisCacheErrorOnDel, cacheKey: ").Append(key).Append(" Exception : ").Append(ex.Message);
            LoggerManage.getInstance().error(typeof(T), str.ToString());
        }
        void IErrorHandle<T>.CacheErrorOnAdd(T t, Exception ex, string key, object value)
        {
            str.Clear();
            str.Append("RedisCacheErrorOnAdd, cacheKey: ").Append(key).Append(" ,cacheValue : ").Append(value).Append(" Exception : ").Append(ex.Message);
            LoggerManage.getInstance().error(typeof(T), str.ToString());
        }
        void IErrorHandle<T>.CacheErrorOnSet(T t, Exception ex, string key, object value)
        {
            str.Clear();
            str.Append("RedisCacheErrorOnSet, cacheKey: ").Append(key).Append(" ,cacheValue : ").Append(value).Append(" Exception : ").Append(ex.Message);
            LoggerManage.getInstance().error(typeof(T), str.ToString());
        }
        void IErrorHandle<T>.CacheErrorOnGet(T t, Exception ex, string key)
        {
            str.Clear();
            str.Append("RedisCacheErrorOnGet, cacheKey: ").Append(key).Append(" Exception : ").Append(ex.Message);
            LoggerManage.getInstance().error(typeof(T), str.ToString());
        }
    }
}
