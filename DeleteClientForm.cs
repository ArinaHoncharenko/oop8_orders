using System;
using System.Collections.Generic;
using System.Windows.Forms;
using oop8_orders;

namespace oop8_orders
{
    public partial class DeleteClientForm : Form
    {
        private List<MainForm.Order> orders; // Додано поле для збереження списку замовлень

        public DeleteClientForm(List<MainForm.Order> existingOrders)
        {
            InitializeComponent();
            orders = existingOrders;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Отримуємо номер замовлення для видалення
            if (int.TryParse(txtOrderNumber.Text, out int orderNumberToDelete))
            {
                // Пошук замовлення за номером
                MainForm.Order orderToDelete = orders.Find(o => o.OrderNumber == orderNumberToDelete);

                // Перевірка, чи знайдено замовлення
                if (orderToDelete != null)
                {
                    // Видалення замовлення зі списку
                    orders.Remove(orderToDelete);
                    MessageBox.Show($"Замовлення №{orderNumberToDelete} успішно видалено.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Замовлення №{orderNumberToDelete} не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть коректний номер замовлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Очистка поля для вводу номера замовлення
            txtOrderNumber.Clear();
        }
    }
}
