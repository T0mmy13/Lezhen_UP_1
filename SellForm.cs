using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2
{
    public partial class SellForm : Form
    {
        public SellForm(int count, string name, Shop shop)
        {
            InitializeComponent();
            label1.Text = $"Выберите кол-во продукта \"{name}\" для продажи";
            for (int i = 1; i <= count; i++)
            {
                comboBox1.Items.Add(i);
            }
        }
    }
}
