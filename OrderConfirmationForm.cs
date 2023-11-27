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
    public partial class OrderConfirmationForm : Form
    {
        private Product[] selectedProducts;
        private TextBox cityTextBox;
        private TextBox postOfficeTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox orderDetailsTextBox;



        public OrderConfirmationForm(Product[] selectedProducts)
        {
            InitializeComponent();

            this.selectedProducts = selectedProducts;

            // Создаем панели для компоновки элементов
            FlowLayoutPanel productListPanel = CreateProductListPanel();
            FlowLayoutPanel orderDetailsPanel = CreateInfoPanel("Информация о заказе", out orderDetailsTextBox);
            FlowLayoutPanel recipientInfoPanel = CreateRecipientInfoPanel();

            
            TableLayoutPanel mainTable = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(20)
            };

            mainTable.Controls.Add(productListPanel, 0, 0);
            mainTable.Controls.Add(orderDetailsPanel, 1, 0);
            mainTable.Controls.Add(recipientInfoPanel, 2, 0);
            mainTable.Controls.Add(confirmButton, 1, 1);

           
            Controls.Add(mainTable);
        }

        private FlowLayoutPanel CreateProductListPanel()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                Margin = new Padding(10)
            };

            foreach (Product product in selectedProducts)
            {
                panel.Controls.Add(new Label
                {
                    Text = $"{product.Name} - {product.Price:F2}грн - {product.Description}",
                    AutoSize = true,
                    Margin = new Padding(0, 5, 0, 0)
                });
            }

            return panel;
        }

        private FlowLayoutPanel CreateInfoPanel(string title, out TextBox textBox)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                Margin = new Padding(10)
            };

            Label titleLabel = new Label
            {
                Text = title,
                AutoSize = true,
                Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold),
                Margin = new Padding(0, 10, 0, 0),
                ForeColor = Color.Blue
            };

            textBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical,
                Height = 200
            };

            panel.Controls.Add(titleLabel);
            panel.Controls.Add(textBox);

            return panel;
        }

        private FlowLayoutPanel CreateInputField(string label, out TextBox textBox)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                Padding = new Padding(0, 5, 0, 0)
            };

            Label labelControl = new Label
            {
                Text = label,
                AutoSize = true,
                ForeColor = Color.Blue
            };

            textBox = new TextBox
            {
                Dock = DockStyle.Top,
                Size = new Size(200, 20)
            };

            panel.Controls.Add(labelControl);
            panel.Controls.Add(textBox);

            return panel;
        }

        private FlowLayoutPanel CreateRecipientInfoPanel()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                Margin = new Padding(10)
            };

            panel.Controls.Add(CreateInputField("Город", out cityTextBox));
            panel.Controls.Add(CreateInputField("Отделение Новой Почты", out postOfficeTextBox));
            panel.Controls.Add(CreateInputField("Номер телефона", out phoneNumberTextBox));
            panel.Controls.Add(CreateInputField("Фамилия", out lastNameTextBox));
            panel.Controls.Add(CreateInputField("Имя", out firstNameTextBox));

            return panel;
        }
       
        private void confirmButton_Click(object sender, EventArgs e)
        {
            string recipientCity = cityTextBox.Text;
            string recipientPostOffice = postOfficeTextBox.Text;
            string recipientPhoneNumber = phoneNumberTextBox.Text;
            string recipientLastName = lastNameTextBox.Text;
            string recipientFirstName = firstNameTextBox.Text;
            StringBuilder orderInfo = new StringBuilder();
            orderInfo.AppendLine("Информация о заказе::");
            orderInfo.AppendLine("Выбранные продукты:");
            foreach (Product product in selectedProducts)
            {
                orderInfo.AppendLine($"{product.Name} - {product.Price:F2}грн - {product.Description}");
            }

            orderInfo.AppendLine("Данные получателя:");
            orderInfo.AppendLine($"Город: {recipientCity}");
            orderInfo.AppendLine($"Отделение Новой Почты: {recipientPostOffice}");
            orderInfo.AppendLine($"Номер телефона: {recipientPhoneNumber}");
            orderInfo.AppendLine($"Фамилия: {recipientLastName}");
            orderInfo.AppendLine($"Имя: {recipientFirstName}");

            orderDetailsTextBox.Text = orderInfo.ToString();
            MessageBox.Show(orderInfo.ToString(), "Order Confirmation");

            this.DialogResult = DialogResult.OK;
            this.Close();
           
        }
    }
}