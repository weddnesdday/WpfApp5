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
using System.Windows.Shapes;

namespace WpfApp5
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow w = new MainWindow();
            w.ShowDialog();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login2.Text = "";
            password2.Password = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var context = new okokEntities4())
            {
                string username = login2.Text;
                string password = password2.Password;


                context.User.Add(new User
                {
                    login = username,
                    password = password,
                }) ;

                int result = context.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show("Вы успешно зарегистрированы!");
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так. Попробуйте еще раз.");
                }
            }
        }
    }
}

