using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2;
using static System.Windows.Forms.DataFormats;

namespace YourAppName.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void TestAddOrderAndUpdateList()
        {
            // Создаем новый заказ
            Order newOrder = new Order { Заказы = "Новый заказ" };

            // Добавляем заказ
            OrderRepository.Orders.Add(newOrder);

            // Проверяем, что заказ был успешно добавлен
            Assert.IsTrue(OrderRepository.Orders.Contains(newOrder));

            // Проверяем обновление списка заказов
            Form3 form3 = new Form3();
            form3.dataGridView1.DataSource = null;
            form3.dataGridView1.DataSource = OrderRepository.Orders;

            // Проверяем, что список заказов был успешно обновлен на Form3
            Assert.AreEqual(OrderRepository.Orders.Count, form3.dataGridView1.Rows.Count);
        }
    }
}

