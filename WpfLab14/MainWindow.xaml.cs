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

namespace WpfLab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    //Задание 1. Определить класс Product для хранения информации о товаре.Класс должен содержать характеристики Название товара (строка),
    //Цена (число), Изображение (строка - путь к файлу с изображением), Категория(перечисление, возможные значения – Еда, Бытовая техника).
    //Разработать шаблон данных для отображения списка товаров в компоненте ListBox
    //При помощи триггеров определите разный шаблон для товаров категории Еда и категории Бытовая техника.


    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Name = "Вино",
                Price = 675,
                ImagePath = "Data/Wine.jpg",
                ProductType = ProductTypes.Еда

            });
            products.Add(new Product()
            {
                Name = "Сыр",
                Price = 360,
                ImagePath = "Data/Cheese.jpeg",
                ProductType = ProductTypes.Еда

            });
            products.Add(new Product()
            {
                Name = "Пылесос",
                Price = 19999,
                ImagePath = "Data/VCleaner.jpg",
                ProductType = ProductTypes.Техника

            });
            products.Add(new Product()
            {
                Name = "Виноград",
                Price = 356,
                ImagePath = "Data/Grape.jpg",
                ProductType = ProductTypes.Еда

            });
            products.Add(new Product()
            {
                Name = "Телевизор",
                Price = 35789,
                ImagePath = "Data/TV.jpg",
                ProductType = ProductTypes.Техника

            });
            products.Add(new Product()
            {
                Name = "Мед",
                Price = 999,
                ImagePath = "Data/Honey.jpg",
                ProductType = ProductTypes.Еда

            });
            lstBox.ItemsSource = products;

        
        }
    }
}
