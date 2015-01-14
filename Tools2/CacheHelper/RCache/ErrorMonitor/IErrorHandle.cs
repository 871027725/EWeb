using System;

namespace Tools.CacheHelper.RCache.ErrorMonitor
{
    public interface IErrorHandle<T>
    {
        /// <summary>
        /// 删除异常
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        /// <param name="key"></param>
        void CacheErrorOnDel(T t,Exception ex, string key);
        /// <summary>
        /// 添加异常
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void CacheErrorOnAdd(T t, Exception ex, string key, object value);
        /// <summary>
        /// 设置内容异常
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void CacheErrorOnSet(T t, Exception ex, string key, object value);
        /// <summary>
        /// 获取数据异常
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        /// <param name="key"></param>
        void CacheErrorOnGet(T t,Exception ex,string key);

    }
}
