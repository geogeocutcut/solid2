using System;

namespace solid.example.OCP.good.v2
{
    public class ClassClient
    {
        private ILogger _Logger;
        public ClassClient(ILogger logger)
        {
            _Logger = logger;
        }

        public void DoSomething()
        {
            _Logger.WriteLog($"DoSomething start {DateTime.Now}");

            // Fait quelque chose ....

            _Logger.WriteLog($"DoSomething end {DateTime.Now}");
        }
    }
}
