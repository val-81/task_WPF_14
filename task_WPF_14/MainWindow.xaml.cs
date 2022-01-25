using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace task_WPF_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;

        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Арбуз",
                Price = 15,
                Image = "/Data/Арбуз.jpg",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Говядина",
                Price = 350,
                Image = "/Data/Говядина.jpg",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Ноутбук",
                Price = 80000,
                Image = "/Data/Ноутбук.jpg",
                Category = Category.HouseholdAppliances
            });
            products.Add(new Product()
            {
                NameProduct = "Диван",
                Price = 120000,
                Image = "/Data/Диван.jpg",
                Category = Category.Furniture
            });
            IstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                NameProduct = "Мотоцикл",
                Price = 600000,
                Image = "/Data/Урал.jpg",
                Category = Category.Transport
            });
        }
    }
}
