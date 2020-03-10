using System;

namespace solid.example.OCP.bad.v2
{
    public class ClassClient
    {
        private Logger _Logger;
        public ClassClient()
        {
            _Logger = new Logger(1);
        }

        public void DoSomething()
        {
            _Logger.WriteLog($"DoSomething start {DateTime.Now}");

            // Fait quelque chose ....

            _Logger.WriteLog($"DoSomething end {DateTime.Now}");
        }
    }
}
