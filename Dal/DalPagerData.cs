
//using System;
//using System.Data;
//using System.Data.SqlClient;

//namespace Dal
//{
//    public class DalPagerData
//    {
//        private static DalPagerData dd = new DalPagerData();
//        public static DalPagerData Instance()
//        {
//            return dd;
//        }

//        #region 存储过程分页
//        /// <summary>
//        /// 分页1 wsd_page_1： 根据唯一字段唯一值按大小排序，如ID 
//        /// </summary>
//        /// <param name="tb">表名</param>
//        /// <param name="collist">要查询出的字段列表,*表示全部字段</param>
//        /// <param name="condition">查询条件 ,不带where</param>
//        /// <param name="col">排序列 例：ID</param>
//        /// <param name="coltype">列的类型,0-数字类型,1-字符类型</param>
//        /// <param name="orderby">--排序,FALSE-顺序,TRUE-倒序</param>
//        /// <param name="pagesize">每页记录数</param>
//        /// <param name="page">当前页</param>
//        /// <param name="records">总记录数：为0则计算总记录数</param>
//        /// <returns>分页记录</returns>
//        public DataSet GetPageList1(string tb, string collist, string condition, string col, int coltype, bool orderby, int pagesize, int page, ref int records)
//        {
//            DataSet Datalist = new DataSet();
//            SqlParameter[] parms = new SqlParameter[]
//            { 
//                new SqlParameter("@tb",SqlDbType.VarChar,200),
//                new SqlParameter("@collist",SqlDbType.VarChar,800),
//                new SqlParameter("@condition",SqlDbType.VarChar,800),
//                new SqlParameter("@col",SqlDbType.VarChar,50),
//                new SqlParameter("@coltype",SqlDbType.SmallInt,2),
//                new SqlParameter("@orderby",SqlDbType.Bit,1),
//                new SqlParameter("@pagesize",SqlDbType.Int,4),
//                new SqlParameter("@page",SqlDbType.Int,4),
//                new SqlParameter("@records",SqlDbType.Int,4)
//            };
//            parms[0].Value = tb;
//            parms[1].Value = collist;
//            parms[2].Value = condition;
//            parms[3].Value = col;
//            parms[4].Value = coltype;
//            parms[5].Value = orderby;
//            parms[6].Value = pagesize;
//            parms[7].Value = page;
//            parms[8].Value = records;
//            parms[8].Direction = ParameterDirection.InputOutput;

//            Datalist = DBUtils.DBHelper.getInstance().ExecuteDataset(CommandType.StoredProcedure, "sagetta_page_1", parms);
//            records = Convert.ToInt32(parms[8].Value.ToString());
//            return Datalist;

//        }
//        #endregion

//        #region 获取列表记录
//        /// <summary>
//        /// 获取列表记录
//        /// by PengJun 2011-1-4-1
//        /// </summary>
//        /// <param name="top">获取记录条数(不限则为0)</param>
//        /// <param name="col">需要获取的字段</param>
//        /// <param name="table">数据库表名</param> 
//        /// <param name="where">where条件,不带where关键字.例: classid = 1</param>
//        /// <param name="orderby">order by 条件,不带order by</param>
//        /// <returns></returns>
//        public DataTable GetSelectList(int top, string col, string table, string where, string orderby)
//        {
//            string selectTop = "";
//            if (top < 0) { top = 0; }
//            if (top > 0) { selectTop = " top " + top.ToString(); }
//            if (string.IsNullOrEmpty(col))
//            {
//                col = "*";
//            }
//            if (!string.IsNullOrEmpty(where))
//            {
//                where = " where " + where;
//            }
//            if (!string.IsNullOrEmpty(orderby))
//            {
//                orderby = " order by " + orderby;
//            }
//            string sql = string.Format("select {3} {0} from {4} {1} {2}", col, where, orderby, selectTop, table);
//            DataTable dt = DBUtils.DBHelper.getInstance().GetDataSet(sql).Tables[0];
//            return dt;
//        }
//        #endregion

//    }
//}

