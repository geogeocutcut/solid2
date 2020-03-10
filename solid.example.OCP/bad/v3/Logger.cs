

namespace solid.example.OCP.bad.v3
{
    public class Logger
    {

        private TypeLog _typelog;

        public Logger(TypeLog typelog)
        {
            _typelog = typelog;
        }

        public void WriteLog(string message)
        {
            switch (_typelog)
            {
                case TypeLog.File:
                    WriteInFile(message);
                    break;
                case TypeLog.DataBase:
                    WriteInDataBase(message);
                    break;
                case TypeLog.Log4net:
                    WriteInLog4net(message);
                    break;
                default:
                    break;
            }
        }

        private void WriteInFile(string message)
        {
            //Fait le travail
        }

        private void WriteInDataBase(string message)
        {
            //Fait le travail
        }

        private void WriteInLog4net(string message)
        {
            //Fait le travail
        }
    }

    public enum TypeLog
    {
        File,
        DataBase,
        Log4net
    }
}
