namespace BeautySalon
{
    partial class CancelReasonForm
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
            label1 = new Label();
            cmbReasons = new ComboBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 0;
            label1.Text = "Выберите причину отмены:";
            // 
            // cmbReasons
            // 
            cmbReasons.FormattingEnabled = true;
            cmbReasons.Items.AddRange(new object[] { "Клиент не пришёл, Клиент заболел, Отменено администратором" });
            cmbReasons.Location = new Point(12, 31);
            cmbReasons.Name = "cmbReasons";
            cmbReasons.Size = new Size(186, 23);
            cmbReasons.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(12, 60);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "Принять";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(123, 60);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CancelReasonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 101);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(cmbReasons);
            Controls.Add(label1);
            Name = "CancelReasonForm";
            Text = "Отмена записи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbReasons;
        private Button btnOK;
        private Button btnCancel;
    }
}