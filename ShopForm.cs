using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class ShopForm : Form
    {
        int checkedItems = 0;
        private Shop shop = new Shop();
        public ShopForm()
        {
            InitializeComponent();
        }
        private void CreateProductBtn_Click(object sender, EventArgs e)
        {
            PanelCreateProduct.Visible = true;
            SellProductPanel.Visible = false;
            AddProductPanel.Visible = false;

        }
        private void SellProductBtn_Click(object sender, EventArgs e)
        {
            SellProductPanel.Visible = true;
            PanelCreateProduct.Visible = false;
            AddProductPanel.Visible = false;
        }
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductPanel.Visible = true;
            PanelCreateProduct.Visible = false;
            SellProductPanel.Visible = false;

        }
        private void StartCreateProductBtn_Click(object sender, EventArgs e)
        {
            if (EnterValueOk(CreateProductName.Text, CreateProductCount.Text, CreateProductPrice.Text))
            {
                if (shop.FindByName(CreateProductName.Text) == null)
                {
                    shop.CreateProduct(CreateProductName.Text.ToLower(), decimal.Parse(CreateProductPrice.Text), int.Parse(CreateProductCount.Text));
                }
                else
                {
                    MessageBox.Show("Такой товар уже добавлен");
                }
                PanelCreateProduct.Visible = false;
                listBoxProducts.Items.Clear();
                shop.WriteAllProducts(listBoxProducts);
            }           
        }
        private void StartSellProductBtn_Click(object sender, EventArgs e)
        {
            if (EnterValueOk(SellProductName.Text, SellProductCount.Text))
            {
                Product pr = shop.FindByName(SellProductName.Text);
                int count = int.Parse(SellProductCount.Text);
                for (int i = 0; i < count; i++)
                {
                    shop.Sell(SellProductName.Text, textBoxStoncs);
                }
                listBoxProducts.Items.Clear();
                shop.WriteAllProducts(listBoxProducts);
            }
            
        }
        private void StartAddProductBtn_Click(object sender, EventArgs e)
        {
            if (EnterValueOk(AddProductName.Text, AddProductCount.Text, CreateProductPrice.Text))
            {
                shop.Add(AddProductName.Text.ToLower(), int.Parse(AddProductCount.Text));
            }
            listBoxProducts.Items.Clear();
            shop.WriteAllProducts(listBoxProducts);
            PanelCreateProduct.Visible = false;
        }
        private bool EnterValueOk(string name, string count) // проверка правильности ввода данных в 2 строк
        {
            foreach (char ch in name)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Неверный ввод в поле имени");
                    return false;
                }
            }
            foreach (char ch in count)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Неверный ввод в поле количества");
                    return false;
                }
            }
            return true;
        }
        private bool EnterValueOk(string name, string count, string price) // проверка правильности ввода данных в 3 строки, перегрузка EnterValueOk(string name, string count)
        {
            if (int.Parse(price) <= 0)
            {
                MessageBox.Show("Мы не можем работать в убыток");
                return false;
            }
            if (int.Parse(count) <= 0)
            {
                MessageBox.Show("Товаров не может быть 0 или меньше");
                return false;
            }
            foreach (char ch in name)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Неверный ввод в поле имени");
                    return false;
                }
            }
            foreach (char ch in price)
            {
                if (!char.IsDigit(ch))
                {
                    if (ch == ',')
                    {

                    }
                    else
                    {
                        MessageBox.Show("Неверный ввод в поле цены");
                        return false;
                    }
                }
            }
            foreach (char ch in count)
            {
                if (!char.IsDigit(ch))
                {
                    MessageBox.Show("Неверный ввод в поле количества");
                    return false;
                }
            }
            return true;
        }
        private void goTo3QuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoundForm form2 = new SoundForm();
            form2.ShowDialog();
            this.Show();
        }
    }
}
