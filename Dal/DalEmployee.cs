//using System;
//using System.Text;
//using System.Data;
//using System.Data.SqlClient;
//namespace Dal
//{
//    public class DalEmployee
//    {
//        private static Dal.DalEmployee dal = new Dal.DalEmployee();

//        public static Dal.DalEmployee getInstance()
//        {
//            return dal;
//        }
//        public int Add(Model.ModEmployee model)
//        {
//            StringBuilder strSql=new StringBuilder();
//            strSql.Append("insert into employee(");
//            strSql.Append("username,password)");
//            strSql.Append(" values (");
//            strSql.Append("@username,@password)");
//            strSql.Append(";select @@IDENTITY");
//            SqlParameter[] parameters = {
//                    new SqlParameter("@username", SqlDbType.VarChar,30),
//                    new SqlParameter("@password", SqlDbType.VarChar,200)};
//            parameters[0].Value = model.Username;
//            parameters[1].Value = model.Password;

//            object obj = DBUtils.DBHelper.getInstance().ExecuteCommand(strSql.ToString(), parameters);
//            if (obj == null)
//            {
//                return 0;
//            }
//            else
//            {
//                return Convert.ToInt32(obj);
//            }
//        }
//        public bool Update(Model.ModEmployee model)
//        {
//            StringBuilder strSql=new StringBuilder();
//            strSql.Append("update employee set ");
//            strSql.Append("username=@username,");
//            strSql.Append("password=@password,");
//            strSql.Append("logincount=@logincount,");
//            strSql.Append("createtime=@createtime,");
//            strSql.Append("status=@status,");
//            strSql.Append("lastLogin=@lastLogin,");
//            strSql.Append("type=@type");
//            strSql.Append(" where eid=@eid");
//            SqlParameter[] parameters = {
//                    new SqlParameter("@username", SqlDbType.VarChar,30),
//                    new SqlParameter("@password", SqlDbType.VarChar,200),
//                    new SqlParameter("@logincount", SqlDbType.Int,4),
//                    new SqlParameter("@createtime", SqlDbType.Date),
//                    new SqlParameter("@status", SqlDbType.SmallInt,2),
//                    new SqlParameter("@lastLogin", SqlDbType.Date),
//                    new SqlParameter("@type", SqlDbType.SmallInt),
//                    new SqlParameter("@eid", SqlDbType.Int,4)};
//            parameters[0].Value = model.Username;
//            parameters[1].Value = model.Password;
//            parameters[2].Value = model.Logincount;
//            parameters[3].Value = model.CreateTime;
//            parameters[4].Value = model.Status;
//            parameters[5].Value = model.Lastlogin;
//            parameters[6].Value = model.Type;
//            parameters[7].Value = model.Eid;

//            int rows = DBUtils.DBHelper.getInstance().ExecuteCommand(strSql.ToString(), parameters);
//            if (rows > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        public bool Delete(int eid)
//        {
//            StringBuilder strSql=new StringBuilder();
//            strSql.Append("delete from employee ");
//            strSql.Append(" where eid=@eid");
//            SqlParameter[] parameters = {
//                    new SqlParameter("@eid", SqlDbType.Int,4)
//            };
//            parameters[0].Value = eid;

//            int rows = DBUtils.DBHelper.getInstance().ExecuteCommand(strSql.ToString(), parameters);
//            if (rows > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }
//        public bool DeleteByBatch(string ids)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append("delete from employee ");
//            strSql.Append(" where eid in (" + ids + ")");
//            int rows = DBUtils.DBHelper.getInstance().ExecuteCommand(strSql.ToString());
//            if (rows > 0)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        /// <summary>
//        /// 得到一个对象实体
//        /// </summary>
//        public Model.ModEmployee GetModel(int eid)
//        {
//            StringBuilder strSql=new StringBuilder();
//            strSql.Append("select  top 1 eid,username,password,logincount,createtime,status,lastLogin,type from employee ");
//            strSql.Append(" where eid=@eid");
//            SqlParameter[] parameters = {
//                    new SqlParameter("@eid", SqlDbType.Int,4)
//            };
//            parameters[0].Value = eid;

//            Model.ModEmployee model=new Model.ModEmployee();
//            DataSet ds = DBUtils.DBHelper.getInstance().GetDataSet(strSql.ToString(), parameters);
//            if(ds.Tables[0].Rows.Count>0)
//            {
//                return DataRowToModel(ds.Tables[0].Rows[0]);
//            }
//            else
//            {
//                return null;
//            }
//        }

//        /// <summary>
//        /// 得到一个对象实体
//        /// </summary>
//        public Model.ModEmployee DataRowToModel(DataRow row)
//        {
//            Model.ModEmployee model=new Model.ModEmployee();
//            if (row != null)
//            {
//                if(row["eid"]!=null && row["eid"].ToString()!="")
//                {
//                    model.Eid=int.Parse(row["eid"].ToString());
//                }
//                if(row["username"]!=null)
//                {
//                    model.Username=row["username"].ToString();
//                }
//                if(row["password"]!=null)
//                {
//                    model.Password=row["password"].ToString();
//                }
//                if(row["logincount"]!=null && row["logincount"].ToString()!="")
//                {
//                    model.Logincount=int.Parse(row["logincount"].ToString());
//                }
//                if(row["createtime"]!=null && row["createtime"].ToString()!="")
//                {
//                    model.CreateTime=DateTime.Parse(row["createtime"].ToString());
//                }
//                if(row["status"]!=null && row["status"].ToString()!="")
//                {
//                    model.Status=int.Parse(row["status"].ToString());
//                }
//                if(row["lastLogin"]!=null && row["lastLogin"].ToString()!="")
//                {
//                    model.Lastlogin=DateTime.Parse(row["lastLogin"].ToString());
//                }
//                if (row["type"] != null && row["type"].ToString() != "")
//                {
//                    model.Type = int.Parse(row["type"].ToString());
//                }
//            }
//            return model;
//        }
//        /// <summary>
//        /// 登陆方法
//        /// </summary>
//        /// <param name="emp"></param>
//        /// <returns></returns>
//        public Model.ModEmployee login(string username, string password)
//        {
//            string sql = "select top 1 eid,username,password,logincount,createtime,status,lastLogin,type from employee where username=@uname and password=@pwd";
//            SqlParameter[] parameters = {
//                    new SqlParameter("@uname", SqlDbType.VarChar,100),
//                    new SqlParameter("@pwd",SqlDbType.VarChar,32)
//            };
//            parameters[0].Value = username;
//            parameters[1].Value = password;
//            DataTable dt = DBUtils.DBHelper.getInstance().GetDataTable(sql,pa);
//            try{
//                if (dt != null) {
//                    Model.ModEmployee employee = new Model.ModEmployee();
//                    employee.Eid = int.Parse(dt.Rows[0]["eid"].ToString());
//                    employee.Username = dt.Rows[0]["username"].ToString();
//                    employee.Password = dt.Rows[0]["password"].ToString();
//                    employee.Logincount = int.Parse(dt.Rows[0]["logincount"].ToString());
//                    employee.CreateTime = DateTime.Parse(dt.Rows[0]["createtime"].ToString());
//                    employee.Status = int.Parse(dt.Rows[0]["status"].ToString());
//                    employee.Lastlogin = DateTime.Parse(dt.Rows[0]["lastLogin"].ToString());
//                    employee.Type = int.Parse(dt.Rows[0]["type"].ToString());
//                    return employee;
//                 }
//            }catch(Exception e){
//                System.Console.Write(e.Message);
//                return null;
//            }
//            return null;
//        }
//    }
//}
