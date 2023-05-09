using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = AppData.db.User.FirstOrDefault(u => u.login.Equals(login.Text) && u.password.Equals(password.Password));

            if (currentUser != null)
            {
              
                    AppData.currentUser = currentUser;

                Hide();
                Window3 w = new Window3();
                w.ShowDialog();
            }
            else
            {
                MessageBox.Show("Данного пользователя не существует", "Ошибка");
            }
        }

        void hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Window1 w = new Window1();
            w.ShowDialog();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
