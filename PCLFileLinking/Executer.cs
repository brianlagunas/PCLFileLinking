using System.Diagnostics;

namespace PCLFileLinking
{
    public class Executer
    {

#if WPF
          private string _message = "Message from WPF";
#elif SILVERLIGHT
        private string _message = "Message from Silverlight";
#else
        private string _message = "Message from PCL";
#endif

        public void Execute()
        {
            Debug.WriteLine(_message);
        }
    }
}
