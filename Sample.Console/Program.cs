using PCLFileLinking;

namespace Sample.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Executer executer = new Executer();
            executer.Execute();

            System.Console.WriteLine("check output windows for message");
            System.Console.ReadKey();
        }
    }
}
