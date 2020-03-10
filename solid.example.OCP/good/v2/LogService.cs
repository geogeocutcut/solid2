using System;
using System.Collections.Generic;

namespace solid.example.OCP.good.v2
{
    public class LogService : ILogger
    {

        IList<ILogger> _Loggers;

        public LogService(IList<ILogger> loggers)
        {
            _Loggers = loggers;
        }
        public void WriteLog(string message)
        {
            foreach(var logger in _Loggers)
            {
                logger.WriteLog(message);
            }
        }

    }
}
