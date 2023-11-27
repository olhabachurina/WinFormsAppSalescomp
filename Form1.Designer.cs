namespace WinFormsAppSalescomp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameComboBox = new ComboBox();
            ComponentListBox = new ListBox();
            BasketListBox = new ListBox();
            panel1 = new Panel();
            CloseOrderButton = new Button();
            TotalCostTextBox = new TextBox();
            DiscpirButton = new Button();
            Addbutton = new Button();
            DeleteButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // NameComboBox
            // 
            NameComboBox.FormattingEnabled = true;
            NameComboBox.Location = new Point(12, 3);
            NameComboBox.Name = "NameComboBox";
            NameComboBox.Size = new Size(151, 28);
            NameComboBox.TabIndex = 0;
            NameComboBox.SelectedIndexChanged += NameComboBox_SelectedIndexChanged;
            // 
            // ComponentListBox
            // 
            ComponentListBox.FormattingEnabled = true;
            ComponentListBox.ItemHeight = 20;
            ComponentListBox.Location = new Point(174, 3);
            ComponentListBox.Name = "ComponentListBox";
            ComponentListBox.Size = new Size(404, 264);
            ComponentListBox.TabIndex = 1;
            // 
            // BasketListBox
            // 
            BasketListBox.FormattingEnabled = true;
            BasketListBox.HorizontalScrollbar = true;
            BasketListBox.ItemHeight = 20;
            BasketListBox.Location = new Point(631, 3);
            BasketListBox.Name = "BasketListBox";
            BasketListBox.Size = new Size(204, 224);
            BasketListBox.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(CloseOrderButton);
            panel1.Controls.Add(TotalCostTextBox);
            panel1.Controls.Add(DiscpirButton);
            panel1.Controls.Add(Addbutton);
            panel1.Location = new Point(0, 326);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 125);
            panel1.TabIndex = 3;
            // 
            // CloseOrderButton
            // 
            CloseOrderButton.Location = new Point(668, 61);
            CloseOrderButton.Name = "CloseOrderButton";
            CloseOrderButton.Size = new Size(154, 29);
            CloseOrderButton.TabIndex = 5;
            CloseOrderButton.Text = "Завершить заказ";
            CloseOrderButton.UseVisualStyleBackColor = true;
            CloseOrderButton.Click += CloseOrderButton_Click;
            // 
            // TotalCostTextBox
            // 
            TotalCostTextBox.Location = new Point(631, 3);
            TotalCostTextBox.Name = "TotalCostTextBox";
            TotalCostTextBox.ReadOnly = true;
            TotalCostTextBox.Size = new Size(204, 27);
            TotalCostTextBox.TabIndex = 4;
            // 
            // DiscpirButton
            // 
            DiscpirButton.Location = new Point(402, 0);
            DiscpirButton.Name = "DiscpirButton";
            DiscpirButton.Size = new Size(176, 29);
            DiscpirButton.TabIndex = 1;
            DiscpirButton.Text = "Описание";
            DiscpirButton.UseVisualStyleBackColor = true;
            DiscpirButton.Click += DiscpirButton_Click;
            // 
            // Addbutton
            // 
            Addbutton.Location = new Point(174, 0);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(205, 29);
            Addbutton.TabIndex = 0;
            Addbutton.Text = "Добавить";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteButton.ForeColor = Color.Red;
            DeleteButton.Location = new Point(631, 233);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(204, 67);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить выбранный товар";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 450);
            Controls.Add(DeleteButton);
            Controls.Add(panel1);
            Controls.Add(BasketListBox);
            Controls.Add(ComponentListBox);
            Controls.Add(NameComboBox);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox NameComboBox;
        private ListBox ComponentListBox;
        private ListBox BasketListBox;
        private Panel panel1;
        private Button DeleteButton;
        private Button DiscpirButton;
        private Button Addbutton;
        private TextBox TotalCostTextBox;
        private Button CloseOrderButton;
    }
}