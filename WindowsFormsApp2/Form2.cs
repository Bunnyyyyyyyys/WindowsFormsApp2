using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public static List<Order> OrdersList = new List<Order>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order { Заказы = textBox1.Text };
            OrderRepository.Orders.Add(newOrder);
            textBox1.Text = ""; // Очистить текстовое поле после добавления заказа
            MessageBox.Show("Заказ успешно добавлен");

            // Обновление данных на Form3
            Form3 form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();
            if (form3 != null)
            {
                form3.dataGridView1.DataSource = null;
                form3.dataGridView1.DataSource = OrderRepository.Orders;
            }

        }
    }
}
