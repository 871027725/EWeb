using log4net;
using System;
namespace Tools.LogHelper
{
   public class LoggerImp : ILogger
   {
       private static ILog log = LogManager.GetLogger("Logging");

        void ILogger.error(Type t,string msg)
        {
           // if (log.IsErrorEnabled) 
            //{
                log.Error(" 当前执行类 : === "+ t.FullName + msg);
          //  }
        }

        void ILogger.error(Type t,string msg, string threadId)
        {
 	        if (log.IsErrorEnabled) 
            {
                log.Error(" 当前执行类 : === "+ t.FullName + msg + "当前线程: === " + threadId);
            }
        }

        void ILogger.error(Type t,string msg, string threadId, DateTime time)
        {
 	       if (log.IsErrorEnabled) 
            {
                log.Error(" 当前执行类 : === "+ t.FullName + msg + "当前线程: === " + threadId + " 出现时间 : ===== " + time);
            }
        }

        void ILogger.info(Type t,string msg)
        {
 	        if (log.IsInfoEnabled) 
            {
                log.Info(" 当前执行类 : === "+ t.FullName + msg);
            }
        }

        void ILogger.info(Type t,string msg, string threadId)
        {
 	        if (log.IsInfoEnabled) 
            {
                log.Info(" 当前执行类 : === "+ t.FullName + msg + "当前线程: === " + threadId);
            }
        }

        void ILogger.info(Type t,string msg, string threadId, DateTime time)
        {
 	        if (log.IsInfoEnabled) 
            {
                log.Info(" 当前执行类 : === "+ t.FullName + msg + "当前线程: === " + threadId + " 出现时间 : ===== " + time);
            }
        }

        void ILogger.debug(Type t,string msg)
        {
 	        if (log.IsDebugEnabled) 
            {
                log.Debug(" 当前执行类 : === "+ t.FullName + msg);
            }
        }

        void ILogger.debug(Type t,string msg, string threadId)
        {
 	        if (log.IsDebugEnabled) 
            {
                log.Debug(" 当前执行类 : === "+ t.FullName + msg + "当前线程: === " + threadId);
            }
        }

        void ILogger.debug(Type t,string msg, string threadId, DateTime time)
        {
 	        if (log.IsDebugEnabled) 
            {
                log.Debug(" 当前执行类 : === " + t.FullName + msg + "当前线程: === " + threadId + " 出现时间 : ===== " + time);
            }
        }
    }   
}
