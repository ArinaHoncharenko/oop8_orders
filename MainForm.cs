using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace oop8_orders
{
    public partial class MainForm : Form
    {
        // Клас для представлення замовлення
        public class Order
        {
            public int OrderNumber { get; set; }
            public string CustomerName { get; set; }
            public string ContactPhone { get; set; }
            public string City { get; set; }
            public string PostalCode { get; set; }
            public string OrderStatus { get; set; }
        }

        // Шлях до файлу для збереження/завантаження даних
        private string filePath = @"C:\Users\1\source\repos\oop8_orders\oop8_orders\orders.json";

        // Список для зберігання замовлень
        private List<Order> orders;

        public MainForm()
        {
            InitializeComponent();

            // Завантаження замовлень з файлу при запуску додатку
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                // Перевірка наявності файлу перед завантаженням
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    orders = JsonConvert.DeserializeObject<List<Order>>(json);

                    // Заповнення таблиці даними при завантаженні
                    PopulateTable();
                }
                else
                {
                    // Якщо файл відсутній, ініціалізуємо порожній список
                    orders = new List<Order>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveOrders()
        {
            try
            {
                string json = JsonConvert.SerializeObject(orders, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateTable()
        {
            // Очищення таблиці перед заповненням
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("OrderNumber", "Номер замовлення");
            dataGridView1.Columns.Add("CustomerName", "ПІБ клієнта");
            dataGridView1.Columns.Add("ContactPhone", "Номер телефону");
            dataGridView1.Columns.Add("City", "Місто");
            dataGridView1.Columns.Add("PostalCode", "Номер пошти");
            dataGridView1.Columns.Add("OrderStatus", "Статус");

            // Додавання замовлень до таблиці
            foreach (var order in orders)
            {
                dataGridView1.Rows.Add(
                    order.OrderNumber,
                    order.CustomerName,
                    order.ContactPhone,
                    order.City,
                    order.PostalCode,
                    order.OrderStatus
                );
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Збереження замовлень у файл при закритті форми
            SaveOrders();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Створюємо нову форму "AddClientForm" і показуємо її
            AddClientForm addClientForm = new AddClientForm(orders);
            addClientForm.ShowDialog();

            // Поновлення таблиці після можливого додавання клієнта
            PopulateTable();
        }

        private int GetNextOrderNumber()
        {
            // Отримання наступного номера замовлення
            if (orders.Count > 0)
            {
                return orders.Max(o => o.OrderNumber) + 1;
            }
            else
            {
                return 1; // Перший замовлення
            }
        }

    }
}
