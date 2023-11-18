using System;
using System.Collections.Generic;
using System.Windows.Forms;
using oop8_orders;

namespace oop8_orders
{
    public partial class StatusForm : Form
    {
        private List<MainForm.Order> orders; // Поле для збереження списку замовлень

        public StatusForm(List<MainForm.Order> existingOrders)
        {
            InitializeComponent();
            orders = existingOrders;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeStatus_Click_1(object sender, EventArgs e)
        {
            // Отримуємо номер замовлення і новий статус
            if (string.IsNullOrWhiteSpace(txtOrderNumber.Text) || string.IsNullOrWhiteSpace(txtNewStatus.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(txtOrderNumber.Text, out int orderNumberToChange))
            {
                string newStatus = txtNewStatus.Text;

                // Пошук замовлення за номером
                MainForm.Order orderToChange = orders.Find(o => o.OrderNumber == orderNumberToChange);

                // Перевірка, чи знайдено замовлення
                if (orderToChange != null)
                {
                    // Зміна статусу замовлення
                    orderToChange.OrderStatus = newStatus;
                    MessageBox.Show($"Статус замовлення №{orderNumberToChange} успішно змінено на \"{newStatus}\".", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Замовлення №{orderNumberToChange} не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний номер замовлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Очистка полів для вводу номера та нового статусу
            txtOrderNumber.Clear();
            txtNewStatus.Clear();
        }
    }
}
