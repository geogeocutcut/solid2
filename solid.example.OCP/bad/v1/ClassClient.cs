using System;

namespace solid.example.OCP.bad.v1
{
    public class ClassClient
    {
        private Logger _Logger;
        public ClassClient()
        {
            _Logger = new Logger();
        }

        public void DoSomething()
        {
            _Logger.WriteInFile($"DoSomething start {DateTime.Now}");

            // Fait quelque chose ....

            _Logger.WriteInFile($"DoSomething end {DateTime.Now}");
        }
    }
}
