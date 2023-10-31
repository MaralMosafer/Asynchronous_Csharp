using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleWPF_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SynchBtn_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "";
            DoWork(); //Freeze 
            txt.Text = $"{txt.Text} + Synch Operation Finished!!!!";
        }

        private async void AsynchBtn_Click(object sender, RoutedEventArgs e)
        {
            txt.Text = "";
            await DoWorkAsync();
            txt.Text = $"{txt.Text} + Asynch Operation Finished!!!!";
        }

        void DoWork()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(5000); 
            }
        }

        async Task DoWorkAsync()
        {
            await Task.Run(() => //wait until this operation finish on other Thread =>Free
             {
                 for (int i = 0; i < 5; i++)
                 {
                     Thread.Sleep(5000);
                 }
             });
        }

    }
}