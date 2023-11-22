using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using oop8_orders;

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
                // Помилка: не всі поля заповнені
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!IsPhoneNumberValid(phoneNumber))
                {
                    // Помилка: некоректний номер телефону
                    MessageBox.Show("Некоректний номер телефону. Введіть 10 цифр.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Перевірка номера пошти
                if (!IsPostalCodeValid(postalCode))
                {
                    // Помилка: некоректний номер пошти
                    MessageBox.Show("Некоректний номер пошти. Введіть числове значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

                // Повідомлення: клієнт успішно доданий
                MessageBox.Show("Клієнта успішно додано.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очистка полів після додавання клієнта
                txtFullName.Clear();
                txtPhoneNumber.Clear();
                txtCity.Clear();
                txtPostalCode.Clear();
            }
        }
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Перевірка, чи номер телефону складається лише з цифр та має довжину 10
            return phoneNumber.All(char.IsDigit) && phoneNumber.Length == 10;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Закриття форми
            this.Close();
        }

        // Метод для перевірки коректності номера пошти
        private bool IsPostalCodeValid(string postalCode)
        {
            // Перевірка, чи номер пошти складається лише з цифр
            return postalCode.All(char.IsDigit);
        }
    }
}
