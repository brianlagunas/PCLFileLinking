using System.Windows;
using System.Windows.Controls;
using PCLFileLinking;

namespace Sample.Silverlight
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Executer executer = new Executer();
            executer.Execute();
        }
    }
}
