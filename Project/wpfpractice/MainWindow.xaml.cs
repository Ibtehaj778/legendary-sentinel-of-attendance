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

namespace wpfpractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Mouse_Enter = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void HOME_MouseEnter(object sender, MouseEventArgs e)
        {
            if(Mouse_Enter)
            {

            }
        }
    }
}