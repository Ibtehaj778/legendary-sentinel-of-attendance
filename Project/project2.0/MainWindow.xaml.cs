using System.IO;
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

namespace project2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string name = "";
        private string password = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name = USERNAME.Text;
            password = PASSWORD.Text;
            string csvFilePath = "C:\\Users\\093a2\\Desktop\\practice\\project2.0\\project2.0\\Credentials.txt"; // Replace this with the path to your CSV file
            bool isAuthenticated = false;

            try
            {
                using (StreamReader reader = new StreamReader(csvFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 2 && parts[0].Trim() == name && parts[1].Trim() == password)
                        {
                            isAuthenticated = true;
                            break;
                        }
                    }
                }
                if (isAuthenticated)
                {
                    Interface MainPage= new Interface();
                    this.Content = MainPage;
                    
                }
                else
                {
                    MessageBox.Show("Authentication failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading Credentials");
            }
        }
    }
}