
using System;
using Tools.CacheHelper;
using Tools.LogHelper;
namespace Service
{
    public class Demo
    {
        public static void Main()
        {
            CacheManageFactory cm = CacheManageFactory.getFactory();
            ICacheManage cache = cm.getCacheManage("memcache");


            for (int i = 0; i < 1000; i++)
            {
                if (cache.Set("a" + i, "aa" + i))
                {
                    System.Console.WriteLine(cache.Get("a" + i));
                }
                else
                {
                    throw new Exception("保存数据失败...");
                }
            }

           // cache.Delete("a" + 1);
            System.Console.WriteLine("删除是否成功 " + cache.Get("a" + 1));
        }
    }
}
