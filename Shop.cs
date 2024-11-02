using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public class Shop
    {
        private Dictionary<Product, int> products; // словарь для хранения экземпляров класса Product и их количества
        public Shop() // конструктор класса Shop
        {
            products = new Dictionary<Product, int>();
        }
        public Product FindByName(string name) // нахождение экземпляра класса по его имени в словаре products
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
        public void CreateProduct(string name, decimal price, int count) // создание экземпляра класса Product с последующим добавлением в словарь products 
        {
            products.Add(new Product(name, price), count);
        }
        public void WriteAllProducts(ListBox list) // вывод всех лежащих в словаре products продуктов в ListBox list
        {
            list.Items.Add("Список продуктов: ");
            foreach (var product in products)
            {
                list.Items.Add(product.Key.GetInfo() + "; Количество: " + product.Value);
            }
        }
        public void WriteAllProductsForSale(CheckedListBox list) // вывод всех лежащих в словаре products продуктов в ListBox list
        {
            foreach (var product in products)
            {
                list.Items.Add($"{product.Key.Name}");
            }
        }
        
        public void Add(string ProductName, int count) // добавление count к количеству продуктов определённого класса
        {
            Product ToAdd = FindByName(ProductName);
            if (ToAdd == null)
            {
                MessageBox.Show("Товар не найден!");
            }
            else
            {
                products[ToAdd] += count;
            }
            
        }
        public void Sell(Product product, TextBox txt) // уменьшение количества определённого продукта в словаре products при условии что количество и так не равно или не меньше 0
        {
            if (products.ContainsKey(product))
            {
                if (products[product] <= 0)
                {
                    Console.WriteLine("Нет в наличии!");
                }
                else
                {
                    products[product]--;
                    RestartStoncs(product.Price, txt);
                }
            }
            else
            {
                Console.WriteLine("Товар не найден!");
            }
        }
        public void Sell(string ProductName, TextBox txt)//инициализация введённого класса и проверка найден ли он
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell, txt);
            }
            else
            {
                Console.WriteLine("Товар не найден!");
            }
        }
        public void RestartStoncs(decimal price, TextBox txt) // нахождение всей суммы проданных товаров и вписывание суммы того что было и того что продано в textbox
        {
            decimal stoncs = decimal.Parse(txt.Text);
            stoncs += price;
            txt.Text = $"{stoncs}";
        }
        public int ReturnCountInDictionary(Product product)
        {
            return products[product];
        }
    }
}
