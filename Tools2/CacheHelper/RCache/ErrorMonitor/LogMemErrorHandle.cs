using System;
using System.Text;
using Tools.LogHelper;
namespace Tools.CacheHelper.RCache.ErrorMonitor
{
    public class LogMemErrorHandle<T> : IErrorHandle<T>
    {
       private StringBuilder str = new StringBuilder();

       void IErrorHandle<T>.CacheErrorOnAdd(T t, Exception ex, string key, object value)
       {
           str.Clear();
           str.Append("MemcacheCacheErrorOnAdd, cacheKey: ").Append(key).Append(" ,cacheValue : ").Append(value).Append(" Exception : ").Append(ex.Message);
           LoggerManage.getInstance().error(typeof(T), str.ToString());
       }
       void IErrorHandle<T>.CacheErrorOnSet(T t, Exception ex, string key, object value)
       {
           str.Clear();
           str.Append("MemcacheCacheErrorOnSet, cacheKey: ").Append(key).Append(" ,cacheValue : ").Append(value).Append(" Exception : ").Append(ex.Message);
           LoggerManage.getInstance().error(typeof(T), str.ToString());
       }
       void IErrorHandle<T>.CacheErrorOnGet(T t, Exception ex, string key)
       {
           str.Clear();
           str.Append("MemcacheCacheErrorOnGet, cacheKey: ").Append(key).Append(" Exception : ").Append(ex.Message);
           LoggerManage.getInstance().error(typeof(T), str.ToString());
       }

       void IErrorHandle<T>.CacheErrorOnDel(T t, Exception ex, string key)
       {
           str.Clear();
           str.Append("MemcacheCacheErrorOnDel, cacheKey: ").Append(key).Append(" Exception : ").Append(ex.Message);
           LoggerManage.getInstance().error(typeof(T), str.ToString());
       }
    }
}
