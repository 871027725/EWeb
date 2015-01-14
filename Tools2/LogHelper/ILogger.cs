using System;

namespace Tools.LogHelper
{
   public interface ILogger
   {
       void error(Type t,string msg);

       void error(Type t,string msg, string threadId);

       void error(Type t,string msg, string threadId, DateTime time);

       void info(Type t,string msg);

       void info(Type t,string msg, string threadId);

       void info(Type t, string msg, string threadId, DateTime time);

       void debug(Type t,string msg);

       void debug(Type t,string msg, string threadId);

       void debug(Type t,string msg, string threadId, DateTime time);

   }
}
