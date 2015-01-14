using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.CacheHelper
{
    public class FunUtil
    {
        /// <summary>
        /// 随即获取散列值
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public static int UUID(int len)
        {
            int hash = Math.Abs(Guid.NewGuid().GetHashCode());
            int h = hash % len;
            return h;
        }
    }
}
