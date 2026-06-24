namespace BeautySalon
{
    partial class ReceiptForm
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
            lblSalonName = new Label();
            lblSalonAddress = new Label();
            lblSalonPhone = new Label();
            lblReceiptNumber = new Label();
            lblDateTime = new Label();
            lblClientName = new Label();
            lblServiceName = new Label();
            lblMasterName = new Label();
            lblPrice = new Label();
            lblStatus = new Label();
            btnPrint = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lblSalonName
            // 
            lblSalonName.AutoSize = true;
            lblSalonName.Font = new Font("Segoe UI", 10F);
            lblSalonName.Location = new Point(36, 9);
            lblSalonName.Name = "lblSalonName";
            lblSalonName.Size = new Size(196, 19);
            lblSalonName.TabIndex = 0;
            lblSalonName.Text = "САЛОН КРАСОТЫ \"ЭЛЕГАНТ\"";
            // 
            // lblSalonAddress
            // 
            lblSalonAddress.AutoSize = true;
            lblSalonAddress.Font = new Font("Segoe UI", 10F);
            lblSalonAddress.Location = new Point(36, 49);
            lblSalonAddress.Name = "lblSalonAddress";
            lblSalonAddress.Size = new Size(182, 19);
            lblSalonAddress.TabIndex = 1;
            lblSalonAddress.Text = "г. Торжок, ул. Ленина, д. 10";
            // 
            // lblSalonPhone
            // 
            lblSalonPhone.AutoSize = true;
            lblSalonPhone.Font = new Font("Segoe UI", 10F);
            lblSalonPhone.Location = new Point(36, 68);
            lblSalonPhone.Name = "lblSalonPhone";
            lblSalonPhone.Size = new Size(166, 19);
            lblSalonPhone.TabIndex = 2;
            lblSalonPhone.Text = "Тел.: +7 (48251) 2-34-56";
            // 
            // lblReceiptNumber
            // 
            lblReceiptNumber.AutoSize = true;
            lblReceiptNumber.Font = new Font("Segoe UI", 10F);
            lblReceiptNumber.Location = new Point(36, 102);
            lblReceiptNumber.Name = "lblReceiptNumber";
            lblReceiptNumber.Size = new Size(104, 19);
            lblReceiptNumber.TabIndex = 3;
            lblReceiptNumber.Text = "Чек № 000001";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 10F);
            lblDateTime.Location = new Point(36, 136);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(210, 19);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = "Дата и время: 20.06.2026 14:30";
            // 
            // lblClientName
            // 
            lblClientName.AutoSize = true;
            lblClientName.Font = new Font("Segoe UI", 10F);
            lblClientName.Location = new Point(36, 174);
            lblClientName.Name = "lblClientName";
            lblClientName.Size = new Size(166, 19);
            lblClientName.TabIndex = 5;
            lblClientName.Text = "Клиент: Смирнова Ольга";
            // 
            // lblServiceName
            // 
            lblServiceName.AutoSize = true;
            lblServiceName.Font = new Font("Segoe UI", 10F);
            lblServiceName.Location = new Point(36, 193);
            lblServiceName.Name = "lblServiceName";
            lblServiceName.Size = new Size(111, 19);
            lblServiceName.TabIndex = 6;
            lblServiceName.Text = "Услуга: Стрижка";
            // 
            // lblMasterName
            // 
            lblMasterName.AutoSize = true;
            lblMasterName.Font = new Font("Segoe UI", 10F);
            lblMasterName.Location = new Point(36, 212);
            lblMasterName.Name = "lblMasterName";
            lblMasterName.Size = new Size(153, 19);
            lblMasterName.TabIndex = 7;
            lblMasterName.Text = "Мастер: Иванова Анна";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.Location = new Point(36, 246);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(132, 19);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Стоимость: 1 500 ₽";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(36, 280);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(116, 19);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Статус: Записана";
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(12, 316);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "Печать";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(177, 316);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 11;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 28);
            label1.Name = "label1";
            label1.Size = new Size(217, 15);
            label1.TabIndex = 12;
            label1.Text = "------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 87);
            label2.Name = "label2";
            label2.Size = new Size(217, 15);
            label2.TabIndex = 13;
            label2.Text = "------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 121);
            label3.Name = "label3";
            label3.Size = new Size(217, 15);
            label3.TabIndex = 14;
            label3.Text = "------------------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 155);
            label4.Name = "label4";
            label4.Size = new Size(217, 15);
            label4.TabIndex = 15;
            label4.Text = "------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 231);
            label5.Name = "label5";
            label5.Size = new Size(217, 15);
            label5.TabIndex = 16;
            label5.Text = "------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 265);
            label6.Name = "label6";
            label6.Size = new Size(217, 15);
            label6.TabIndex = 17;
            label6.Text = "------------------------------------------";
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 346);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnPrint);
            Controls.Add(lblStatus);
            Controls.Add(lblPrice);
            Controls.Add(lblMasterName);
            Controls.Add(lblServiceName);
            Controls.Add(lblClientName);
            Controls.Add(lblDateTime);
            Controls.Add(lblReceiptNumber);
            Controls.Add(lblSalonPhone);
            Controls.Add(lblSalonAddress);
            Controls.Add(lblSalonName);
            Name = "ReceiptForm";
            Text = "Чек";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalonName;
        private Label lblSalonAddress;
        private Label lblSalonPhone;
        private Label lblReceiptNumber;
        private Label lblDateTime;
        private Label lblClientName;
        private Label lblServiceName;
        private Label lblMasterName;
        private Label lblPrice;
        private Label lblStatus;
        private Button btnPrint;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}