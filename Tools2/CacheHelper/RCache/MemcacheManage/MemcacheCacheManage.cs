using System;
using System.Collections.Generic;

namespace Tools.CacheHelper.RCache.MemcacheManage
{
    public class MemcacheCacheManage : ICacheManage
    {
        private static MemcacheCacheManage cache = null;

        public static MemcacheCacheManage getMemcacheCacheManage()
        {
            if (cache == null)
            {
                cache = new MemcacheCacheManage();
                cache.init();
            }
            return cache;
        }
        

        private MemcacheServer ms = null;

        public MemcacheServer getMs()
        {
            init();
            return ms;
        }
        private void init()
        {
            if (ms == null)
            {
                ms = new MemcacheServer();
                ms.ErrorHandle = new ErrorMonitor.LogMemErrorHandle<MemcacheServer>();
                ms.startServer();
            }
        }
        bool ICacheManage.keyExists(string key)
        {
            return ms.keyExists(key);
        }

        bool ICacheManage.Delete(string key)
        {
            return ms.Delete(key);
        }

        bool ICacheManage.Delete(string key, int expiry)
        {
            return ms.Delete(key);
        }

        bool ICacheManage.Set(string key, object value)
        {
           return ms.Set(key,value);
        }

        bool ICacheManage.Set(string key, object value, int expiry)
        {
            return ms.Set(key,value,expiry);
        }

        bool ICacheManage.Set(string key, object value, int expiry, int hashCode)
        {
            throw new NotImplementedException();
        }

        bool ICacheManage.Add(string key, object value, int expiry)
        {
            throw new NotImplementedException();
        }

        bool ICacheManage.Add(string key, object value, int expiry, int hashCode)
        {
            throw new NotImplementedException();
        }

        bool ICacheManage.Replace(string key, object value)
        {
            throw new NotImplementedException();
        }

        bool ICacheManage.Replace(string key, object value, int expiry)
        {
            throw new NotImplementedException();
        }

        bool ICacheManage.Replace(string key, object value, int expiry, int hashCode)
        {
            throw new NotImplementedException();
        }

        bool ICacheManage.StoreCounter(string key, long counter)
        {
            throw new NotImplementedException();
        }

        bool ICacheManage.StoreCounter(string key, long counter, int hashCode)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.GetCounter(string key)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.GetCounter(string key, int hashCode)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.AddOrIncr(string key)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.addOrIncr(string key, long inc)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.AddOrIncr(string key, long inc, int hashCode)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.AddOrDecr(string key)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.AddOrDecr(string key, long inc)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.AddOrDecr(string key, long inc, int hashCode)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.Incr(string key)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.Incr(string key, long inc)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.Incr(string key, long inc, int hashCode)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.Decr(string key)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.Decr(string key, long inc)
        {
            throw new NotImplementedException();
        }

        long ICacheManage.Decr(string key, long inc, int hashCode)
        {
            throw new NotImplementedException();
        }

        object ICacheManage.Get(string key)
        {
            return ms.Get(key);
        }

        object ICacheManage.Get(string key, int hashCode)
        {
            throw new NotImplementedException();
        }

        object ICacheManage.Get(string key, int hashCode, bool asString)
        {
            throw new NotImplementedException();
        }

        object[] ICacheManage.GetMultiArray(string[] keys)
        {
            throw new NotImplementedException();
        }

        object[] ICacheManage.GetMultiArray(string[] keys, int[] hashCodes)
        {
            throw new NotImplementedException();
        }

        object[] ICacheManage.GetMultiArray(string[] keys, int[] hashCodes, bool asString)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.GetMulti(string[] keys)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.GetMulti(string[] keys, int[] hashCodes)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.GetMulti(string[] keys, int[] hashCodes, bool asString)
        {
            throw new NotImplementedException();
        }

        bool ICacheManage.FlushAll()
        {
            throw new NotImplementedException();
        }

        bool ICacheManage.flushAll(string[] servers)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.Stats()
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.Stats(string[] servers)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.statsItems()
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.StatsItems(string[] servers)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.StatsSlabs()
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.StatsSlabs(string[] servers)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.statsCacheDump(int slabNumber, int limit)
        {
            throw new NotImplementedException();
        }

        Dictionary<string, object> ICacheManage.StatsCacheDump(string[] servers, int slabNumber, int limit)
        {
            throw new NotImplementedException();
        }
    }
}
