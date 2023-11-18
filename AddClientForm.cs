using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq; // Додайте цей рядок
using oop8_orders; // Додайте цей рядок, якщо AddClientForm не знаходить простір імен oop8_orders

namespace oop8_orders
{
    public partial class AddClientForm : Form
    {
        private List<MainForm.Order> orders;

        public AddClientForm(List<MainForm.Order> existingOrders)
        {
            InitializeComponent();
            orders = existingOrders;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Отримуємо значення з полів введення
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string city = txtCity.Text;
            string postalCode = txtPostalCode.Text;

            // Перевірка на заповненість полів
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(postalCode))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Отримання нового номера замовлення
                int newOrderNumber = GetNextOrderNumber();

                // Додавання нового клієнта (замовлення) до списку
                orders.Add(new MainForm.Order
                {
                    OrderNumber = newOrderNumber,
                    CustomerName = fullName,
                    ContactPhone = phoneNumber,
                    City = city,
                    PostalCode = postalCode,
                    OrderStatus = "В обробці"
                });

                MessageBox.Show("Клієнта успішно додано.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очистка полів після додавання клієнта
                txtFullName.Clear();
                txtPhoneNumber.Clear();
                txtCity.Clear();
                txtPostalCode.Clear();
            }
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
