/*****************************************************************
 * author : ywx
 * time   : 2013/08/02
 * version : 1.0
 * remark : 管理员登陆
 *****************************************************************/
using System;

namespace Model
{
   [Serializable]
   public class ModEmployee
   {
        private int eid;
        private string username;             //账号 
        private string password;             //密码
        private int logincount;              //登陆次数
        private DateTime createTime;         //创建时间
        private int status;                  //状态
        private DateTime lastlogin;          //最后登录时间
        private int type;                    //管理员类型 默认为0 超级管理员为 1
        public ModEmployee()
        {
            createTime = DateTime.Now;
            lastlogin = DateTime.Now;
            status = 0;
            type = 0;
            logincount = 0;
        }

        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Logincount
        {
            get { return logincount; }
            set { logincount = value; }
        }

        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public DateTime Lastlogin
        {
            get { return lastlogin; }
            set { lastlogin = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }

   }
}
