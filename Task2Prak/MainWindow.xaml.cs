using System.Windows;

namespace Task2Prak
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConnectBD client = new ConnectBD();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Enter_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Reg_CheckBox.IsPressed)
            {
                if (Logic.CheckIfString(Login_TextBox.Text) && Logic.CheckIfNumeric(Password_TextBox.Password))
                {
                    PlaceholderError.Visibility = Visibility.Collapsed;

                    if (client.FindUser(Login_TextBox.Text) != null)
                    {
                        
                    }

                    else PlaceholderError.Visibility = Visibility.Visible;
                }

                else
                    PlaceholderError.Visibility = Visibility.Visible;
            }

            else
            { 
                if (Logic.CheckIfString(Login_TextBox.Text) && Logic.CheckIfNumeric(Password_TextBox.Password))
                    PlaceholderError.Visibility = Visibility.Collapsed;

                else
                    PlaceholderError.Visibility = Visibility.Visible;
            }
        }
    }
}
