using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppSalescomp
{
    public partial class SalesForm : Form
    {
        private Product[] products;
        public SalesForm(Product[] products)
        {
            InitializeComponent();
            this.products = products;
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = products;
            InitializeDescriptionTextBox();
            InitializeSaveButton();
        }

        private void InitializeSaveButton()
        {
            Button saveButton = new Button();
            saveButton.Text = "Сохранить описание";
            saveButton.Dock = DockStyle.Bottom;
            saveButton.Click += SaveButton_Click;
            Controls.Add(saveButton);
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            // Получаем введенное описание
            string description = Controls.OfType<TextBox>()
                              .FirstOrDefault(tb => tb.PlaceholderText == "Введите описание...")
                              ?.Text;

            // Применяем описание к выбранным товарам
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.DataBoundItem is Product selectedProduct)
                {
                    selectedProduct.Description = description;
                    // Обновляем ячейку с описанием в DataGridView
                    dataGridView1.Refresh();
                }
            }
        }


        private void InitializeDescriptionTextBox()
        {
            TextBox descriptionTextBox = new TextBox();
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Dock = DockStyle.Bottom;
            descriptionTextBox.PlaceholderText = "Введите описание...";
            Controls.Add(descriptionTextBox);
        }
    }
}
