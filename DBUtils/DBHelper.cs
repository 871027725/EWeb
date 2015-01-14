//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;
//namespace DBUtils
//{
//    public class DBHelper
//    {
//        private static string conSring = @"edu";

//        private static DBHelper dbHelper = new DBHelper();

//        public static DBHelper getInstance()
//        {
//            return dbHelper;
//        }
//        private static SqlConnection connection;

//        public static SqlConnection getConnnection()
//        {
//            try
//            {
//                string connectionString = ConfigurationManager.ConnectionStrings[conSring].ConnectionString;
//                connection = new SqlConnection(connectionString);
//                connection.Open();
//            }
//            catch (Exception ex) {
//                LoggerManage.getInstance().error("数据连接错误====== " + ex.Message);
//            }
//            return connection;
//        }
//        public void closeConnection()
//        {
//            if (connection != null)
//            {
//                if (connection != null && connection.State == System.Data.ConnectionState.Closed)
//                {
//                    connection.Close();
//                    connection = null;
//                }
//            }
//        }
//        public int ExecuteCommand(string safeSql)
//        {
//            try {
//                SqlCommand cmd = new SqlCommand(safeSql, getConnnection());
//                 int result = cmd.ExecuteNonQuery();
//                 return result;
//            } catch(Exception ex) {
//                 LoggerManage.getInstance().error("数据执行异常 ====== " + ex.Message);
//                 return 0;
//            }finally {
//                this.closeConnection();
//            }
//        }
//        public int ExecuteCommand(string sql, params SqlParameter[] values)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand(sql, getConnnection());
//                cmd.Parameters.AddRange(values);
//                return cmd.ExecuteNonQuery();
//            }
//            catch (System.Exception ex)
//            {
//                LoggerManage.getInstance().error("数据执行异常 ====== " + ex.Message);
//                return 0;
            	
//            } finally {
//                 this.closeConnection();
//            }
           
//        }
//        public int GetScalar(string safeSql)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand(safeSql, getConnnection());
//                int result = Convert.ToInt32(cmd.ExecuteScalar());
//                return result;
//            }
//            catch (Exception)
//            {
//                return 0;
//            }
//            finally {
//               this.closeConnection();
//            }

//        }
//        public int GetScalar(string sql, params SqlParameter[] values)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand(sql, getConnnection());
//                cmd.Parameters.AddRange(values);
//                int result = Convert.ToInt32(cmd.ExecuteScalar());
//                return result;
//            }
//            catch (Exception)
//            {
//                return 0;
//            }
//            finally {
//                this.closeConnection();
//            }
//        }
//        public SqlDataReader GetReader(string safeSql)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand(safeSql, getConnnection());
//                SqlDataReader reader = cmd.ExecuteReader();
//                return reader;
//            }
//            catch (Exception)
//            {
//                return null;
//            }
//            finally {
//                this.closeConnection();
//            }

//        }
//        public SqlDataReader GetReader(string sql, params SqlParameter[] values)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand(sql, getConnnection());
//                cmd.Parameters.AddRange(values);
//                SqlDataReader reader = cmd.ExecuteReader();
//                return reader;
//            }
//            catch (Exception)
//            {
//                return null;
//            }
//            finally {
//                this.closeConnection();
//            }
//        }
//        //public DataTable GetTable(string safeSql)
//        //{
//        //    try
//        //    {
//        //        DataSet ds = new DataSet();
//        //        SqlCommand cmd = new SqlCommand(safeSql, getConnnection());
//        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
//        //        da.Fill(ds);
//        //        return ds.Tables[0];
//        //    }
//        //    catch (Exception e) {
//        //        return null;
//        //    }
//        //    finally
//        //    {
//        //       this.closeConnection();
//        //    }
//        //}
//        public DataTable GetDataTable(string sql, params SqlParameter[] values)
//        {
//            try {
//                DataSet ds = new DataSet();
//                SqlCommand cmd = new SqlCommand(sql, getConnnection());
//                cmd.Parameters.AddRange(values);
//                SqlDataAdapter da = new SqlDataAdapter(cmd);
//                da.Fill(ds);
//                return ds.Tables[0];
//            }
//            catch (Exception e) {
//               return null;
//            }finally{
//                this.closeConnection();
//            }
//        }
//        public DataSet GetDataSet(string sql, params SqlParameter[] values)
//        {
//            try
//            {
//                DataSet ds = new DataSet();
//                SqlCommand cmd = new SqlCommand(sql, getConnnection());
//                cmd.Parameters.AddRange(values);
//                SqlDataAdapter da = new SqlDataAdapter(cmd);
//                da.Fill(ds);
//                return ds;
//            }
//            catch (Exception e)
//            {
//                return null;
//            }
//            finally
//            {
//                this.closeConnection();
//            }
           
//        }
//        public string ReturnStringScalar(string safeSql)
//        {
//            try{
//                SqlCommand cmd = new SqlCommand(safeSql, getConnnection());
//                string result = cmd.ExecuteScalar().ToString();
//                return result;
//            }
//            catch (Exception e){
//                return "";
//            }finally {
//                this.closeConnection();
//            }
//        }
//        /// <summary>
//        /// 分页
//        /// </summary>
//        /// <param name="connectionString"></param>
//        /// <param name="commandType"></param>
//        /// <param name="commandText"></param>
//        /// <param name="commandParameters"></param>
//        /// <returns></returns>
//        public static DataSet ExecuteDataset(CommandType commandType, string commandText, params SqlParameter[] commandParameters)
//        {
//            SqlCommand cmd = new SqlCommand();
//            bool mustCloseConnection = false;
//            PrepareCommand(cmd, getConnnection(), (SqlTransaction)null, commandType, commandText, commandParameters, out mustCloseConnection);
//            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
//            {
//                DataSet ds = new DataSet();
//                da.Fill(ds);
//                cmd.Parameters.Clear();
//                if (mustCloseConnection) {
//                    getConnnection();
//                }
//                return ds;
//            }
//        }
//        private static void PrepareCommand(SqlCommand command, SqlConnection conn ,SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, out bool mustCloseConnection)
//        {
//            if (command == null) throw new ArgumentNullException("command");
//            if (commandText == null || commandText.Length == 0) throw new ArgumentNullException("commandText");
//            if (conn == null) throw new NullReferenceException("connection null");
//            if (conn.State != ConnectionState.Open)
//            {
//                mustCloseConnection = true;
//                conn.Open();
//            }
//            else
//            {
//                mustCloseConnection = false;
//            }
//            command.Connection = conn;
//            command.CommandText = commandText;
//            if (transaction != null)
//            {
//                if (transaction.Connection == null) throw new ArgumentException("The transaction was rollbacked or commited, please provide an open transaction.", "transaction");
//                command.Transaction = transaction;
//            }

//            command.CommandType = commandType;

           
//            if ( commandParameters != null)
//            {
//                AttachParameters(command, commandParameters);
//            }
//            return;
//        }
//        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
//        {
//            if (command == null) throw new ArgumentNullException("command");
//            if (commandParameters != null)
//            {
//                foreach (SqlParameter p in commandParameters)
//                {
//                    if (p != null)
//                    {
//                        if ((p.Direction == ParameterDirection.InputOutput || p.Direction == ParameterDirection.Input) &&(p.Value == null))
//                        {
//                            p.Value = DBNull.Value;
//                        }
//                        command.Parameters.Add(p);
//                    }
//                }
//            }
//        }
//    }

//}
