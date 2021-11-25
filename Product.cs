using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Название товара (строка), Цена(число), Изображение(строка - путь к файлу с изображением), Категория(перечисление, возможные значения – Еда, Бытовая техника).

namespace Lab_2_14
{
    public enum Category
    {
        Food,
        HomeAppliances
    }
    public class Product
    {
        public string NameProduct { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        public override string ToString()
        {
            return NameProduct;
        }
    }

}
