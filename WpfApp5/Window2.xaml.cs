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
    public partial class Window2 : Window
    {
        public Window2()
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            Window3 w = new Window3();
            w.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow w = new MainWindow();
            w.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var context = new okokEntities4())
            {
                string typeAuthor = Author.Text;
                string decorName = Name.Text;
                string decorTheYearOfPublishing = TheYearOfPublishing.Text;
                string decorPublisher = Publisher.Text;
                string decorAnnotation = Annotation.Text;
                string decorCategory = Category.Text;
                int maxId = context.UserType.Any() ? context.UserType.Max(o => o.Id) : 0;

                context.UserType.Add(new UserType
                {
                    Author = typeAuthor,
                    Name = decorName,
                    Year = decorTheYearOfPublishing,
                    Publisher = decorPublisher,
                    Annotations = decorAnnotation,
                    Category = decorCategory,
                    Id = maxId + 1
                });
                int result = context.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show("Книга успешно добавлена!");
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так. Попробуйте еще раз.");
                }
            }
        }
    }
}
