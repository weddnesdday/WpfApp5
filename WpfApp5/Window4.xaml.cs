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
    public partial class Window4 : Window
    {
        public static short _id = 0;

        public Window4()
        {
            InitializeComponent();
            Loaded += Window2_Loaded;
        }
        private void Window2_Loaded(object sender, RoutedEventArgs e)
        {
            BookGrid.ItemsSource = AppData.db.UserType.ToList();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить книгу?", "уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var CurrentClient = BookGrid.SelectedItem as UserType;
                 AppData.db.UserType.Remove(CurrentClient);
                AppData.db.SaveChanges();
                BookGrid.ItemsSource = AppData.db.UserType.ToList();
                MessageBox.Show("Успех!");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow w = new MainWindow();
            w.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            Window3 w = new Window3();
            w.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите изменить данные?", "уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                AppData.db.SaveChanges();
                BookGrid.ItemsSource = AppData.db.UserType.ToList();
                MessageBox.Show("Изменено!");
            }
            AppData.db.SaveChanges();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
