using Tools.CacheHelper.RCache.MemcacheManage;
using System.Collections.Generic;
namespace Tools.CacheHelper
{
    public class CacheManageFactory
    {
        private Dictionary<string, ICacheManage> dic = new Dictionary<string, ICacheManage>();

        private static CacheManageFactory factory = new CacheManageFactory();

        public static CacheManageFactory getFactory()
        {
            if (factory == null) factory = new CacheManageFactory();

            return factory;
        }
        /// <summary>
        /// 获取缓存对象
        /// </summary>
        /// <param name="t">memcache,redis</param>
        /// <returns></returns>
        public ICacheManage getCacheManage(string key)
        {
            ICacheManage cm = null;
            if (dic.ContainsKey(key))
            {
                cm = dic[key];
            }
            if (cm == null)
            {
                if (key.Equals(Common.ServiceProtocl.MEMCACHE))
                {
                    cm = MemcacheCacheManage.getMemcacheCacheManage();
                }
                else if (key.Equals(Common.ServiceProtocl.REDIS))
                {
                   // cm = new RedisCacheManage();
                }
                dic[key] = cm;
            }
            return cm;
        }
    }
}
