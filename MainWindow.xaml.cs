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

//Определить класс Product для хранения информации о товаре. Класс должен содержать характеристики
//Название товара (строка), Цена(число), Изображение(строка - путь к файлу с изображением), Категория(перечисление, возможные значения – Еда, Бытовая техника).
//Разработать шаблон данных для отображения списка товаров в компоненте ListBox.
//При помощи триггеров определите разный шаблон для товаров категории Еда и категории Бытовая техника.
namespace Lab_2_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct = "Яблоки",
                Price = 20,
                Image = "/Data/1.jpg",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Апельсин",
                Price = 40,
                Image = "/Data/2.jpg",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Компьютер",
                Price = 200,
                Image = "/Data/3.jpg",
                Category = Category.HomeAppliances
            });
            products.Add(new Product()
            {
                NameProduct = "Телевизор",
                Price = 100,
                Image = "/Data/4.jpg",
                Category = Category.HomeAppliances
            });
            IstBox.ItemsSource = products;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                NameProduct = "Холодильник",
                Price = 150,
                Image = "/Data/5.jpg",
                Category = Category.HomeAppliances
            });

        }
    }
}
