using RRQMCore.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zzfw
{
    public class MsgLog : ILog
    {
        public MsgLog(Action<string> action)
        {
            this.action = action;
        }

        private Action<string> action;

        public void Debug(LogType logType, object source, string message, Exception exception)
        {
            this.Debug(logType, source, message);
        }

        public void Debug(LogType logType, object source, string message)
        {
            this.action.Invoke($"类型：{logType},消息：{message}");
        }
    }
}
