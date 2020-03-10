using System;

namespace solid.example.OCP.bad.v3
{
    public class ClassClient
    {
        private Logger _Logger;
        public ClassClient()
        {
            _Logger = new Logger(TypeLog.File);
        }

        public void DoSomething()
        {
            _Logger.WriteLog($"DoSomething start {DateTime.Now}");

            // Fait quelque chose ....

            _Logger.WriteLog($"DoSomething end {DateTime.Now}");
        }
    }
}
