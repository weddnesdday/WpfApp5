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
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hide();
            Window2 w = new Window2();
            w.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            Window4 w = new Window4();
            w.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow w = new MainWindow();
            w.ShowDialog();
        }
    }
}
