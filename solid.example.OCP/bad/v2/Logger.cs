

namespace solid.example.OCP.bad.v2
{
    public class Logger
    {

        private int _typelog;

        public Logger(int typelog)
        {
            _typelog = typelog;
        }

        public void WriteLog(string message)
        {
            switch (_typelog)
            {
                case 1:
                    WriteInFile(message);
                    break;
                case 2:
                    WriteInDataBase(message);
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
        
    }
    
}
