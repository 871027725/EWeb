using System;
using System.Collections.Generic;

namespace Tools.CacheHelper
{
   public interface ICacheManage
    {
         Boolean keyExists(string key);

         Boolean Delete(string key);

         Boolean Delete(String key, int expiry);

         Boolean Set(string key, object value);

         Boolean Set(string key, object value, int expiry);

         Boolean Set(String key, object value, int expiry, int hashCode);

         Boolean Add(String key, object value, int expiry);

         Boolean Add(string key, object value, int expiry, int hashCode);

         Boolean Replace(string key, object value);

         Boolean Replace(string key, Object value, int hashCode);

         Boolean Replace(string key, object value, int expiry, int hashCode);

         Boolean StoreCounter(string key, long counter);

         Boolean StoreCounter(string key, long counter, int hashCode);

         long GetCounter(string key);

         long GetCounter(string key, int hashCode);

         long AddOrIncr(string key);

         long addOrIncr(string key, long inc);

         long AddOrIncr(String key, long inc, int hashCode);

         long AddOrDecr(string key);

         long AddOrDecr(string key, long inc);

         long AddOrDecr(string key, long inc, int hashCode);

         long Incr(string key);

         long Incr(string key, long inc);

         long Incr(string key, long inc, int hashCode);

         long Decr(string key);

         long Decr(string key, long inc);

         long Decr(string key, long inc, int hashCode);

         object Get(string key);

         object Get(string key, int hashCode);

         object Get(string key, int hashCode, Boolean asString);

         object[] GetMultiArray(string[] keys);

         object[] GetMultiArray(string[] keys, int[] hashCodes);

         object[] GetMultiArray(string[] keys, int[] hashCodes, Boolean asString);

         Dictionary<string, object> GetMulti(string[] keys);

         Dictionary<string, object> GetMulti(string[] keys, int[] hashCodes);

         Dictionary<string, object> GetMulti(string[] keys, int[] hashCodes, Boolean asString);

         Boolean FlushAll();

         Boolean flushAll(string[] servers);

         Dictionary<string, object> Stats();

         Dictionary<string, object> Stats(string[] servers);

         Dictionary<string, object> statsItems();

         Dictionary<string, object> StatsItems(string[] servers);

         Dictionary<string, object> StatsSlabs();

         Dictionary<string, object> StatsSlabs(string[] servers);

         Dictionary<string, object> statsCacheDump(int slabNumber, int limit);

         Dictionary<string, object> StatsCacheDump(string[] servers, int slabNumber, int limit);
    }
}
