using Memcached.ClientLibrary;
using System;
using Tools.LogHelper;
using Tools.CacheHelper.RCache.ErrorMonitor;
namespace Tools.CacheHelper.RCache.MemcacheManage
{
    public class MemcacheServer
    {
        private IErrorHandle<MemcacheServer> errorHandle;

        public IErrorHandle<MemcacheServer> ErrorHandle
        {
            get { return errorHandle; }
            set { errorHandle = value; }
        }

        //memcache管理
        private MemcachedClient mc = null;

        public void startServer()
        {
            if (mc == null)
            {
                string[] serverList = { "127.0.0.1:11211" };
                string poolname = "EWeb";
                SockIOPool pool = SockIOPool.GetInstance(poolname);
                pool.SetServers(serverList);
                pool.Initialize();
                mc = new MemcachedClient();
                mc.PoolName = poolname;
                mc.EnableCompression = true;
            }
        }
        public Boolean Set(string key, object value)
        {
            try
            {
                return mc.Set(key, value);
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
                this.errorHandle.CacheErrorOnSet(this, ex, key, value);
            }
            return false;
        }
        public Boolean Set(string key, object value, int expire)
        {
            try
            {
                LoggerManage.getInstance().error(this.GetType(),"开始写入内容: === " + key);
                return mc.Set(key, value, DateTime.Now.AddMinutes(expire));
            }
            catch (Exception ex)
            {
                LoggerManage.getInstance().error(this.GetType(), ex.Message);
            }
            return false;
        }
        public Boolean Add(string key, object value)
        {
            try
            {
                return mc.Add(key, value);
            }
            catch (Exception ex)
            {
                LoggerManage.getInstance().error(this.GetType(), ex.Message);
            }
            return false;
        }
        public Boolean Add(string key, object value, int expire)
        {
            try
            {
                return mc.Add(key, value, expire);
            }
            catch (Exception ex)
            {
                LoggerManage.getInstance().error(this.GetType(), ex.Message);
            }
            return false;
        }
        public Boolean keyExists(string key)
        {
            try
            {
                return mc.KeyExists(key);
            }
            catch (Exception ex)
            {
                LoggerManage.getInstance().error(this.GetType(), ex.Message);
            }
            return false;
        }
        public Boolean Delete(string key)
        {
            try
            {
                LoggerManage.getInstance().error(this.GetType(), "开始删除数据.... " + key);

                return mc.Delete(key);
            }
            catch (Exception ex)
            {
                LoggerManage.getInstance().error(this.GetType(), ex.Message);
            }
            return false;
        }

        public object Get(string key)
        {
            try
            {
                return mc.Get(key);
            }
            catch (Exception ex)
            {
                LoggerManage.getInstance().error(this.GetType(), ex.Message);
            }
            return null;
        }
    }
}
