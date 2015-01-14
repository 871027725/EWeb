using System;

namespace Tools.LogHelper
{
    public class LoggerManage
    {
        private ILogger log = new LoggerImp();
        private static LoggerManage lm = new LoggerManage();
        public static LoggerManage getInstance() {
              return lm;
        }
        public void error(Type t, string msg) 
        {
            log.error(t, msg);
        }
        public void error(Type t, string msg,string treadId)
        {
            log.error(t, msg, treadId);
        }
        public void error(Type t, string msg, string treadId, DateTime time)
        {
            log.error(t, msg, treadId, time);
        }

        public void info(Type t,string msg) 
        {
              log.info(t,msg);
        }

        public void info(Type t,string msg, string threadId) 
        {
            log.info(t,msg,threadId);
        }

        public void info(Type t,string msg,string threadId,DateTime time) 
        {
            log.info(t, msg, threadId, time);
        }

        public void debug(Type t, string msg)
        {
            log.debug(t, msg);
        }

        public void debug(Type t, string msg, string threadId)
        {
            log.debug(t, msg, threadId);
        }

        public void debug(Type t, string msg, string threadId, DateTime time)
        {
            log.debug(t, msg, threadId, time);
        }
    }
}
