namespace WinFormsAppSalescomp
{
    partial class OrderConfirmationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            confirmButton = new Button();
            SuspendLayout();
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(243, 294);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(184, 29);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Подтвердить заказ";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // OrderConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(confirmButton);
            Name = "OrderConfirmationForm";
            Text = "OrderConfirmationForm";
            ResumeLayout(false);
        }

        #endregion

        private Button confirmButton;
    }
}