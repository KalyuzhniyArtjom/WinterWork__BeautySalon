namespace BeautySalon
{
    partial class MasterForm
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
            dtpDate = new DateTimePicker();
            dgvAppointments = new DataGridView();
            btnComplete = new Button();
            lblNoAppointments = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(21, 22);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 0;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(21, 60);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(597, 298);
            dgvAppointments.TabIndex = 1;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(21, 364);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(179, 23);
            btnComplete.TabIndex = 2;
            btnComplete.Text = "Отметить как выполненную";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // lblNoAppointments
            // 
            lblNoAppointments.AutoSize = true;
            lblNoAppointments.Font = new Font("Segoe UI", 10F);
            lblNoAppointments.Location = new Point(458, 26);
            lblNoAppointments.Name = "lblNoAppointments";
            lblNoAppointments.Size = new Size(160, 19);
            lblNoAppointments.TabIndex = 3;
            lblNoAppointments.Text = "На эту дату записей нет";
            lblNoAppointments.Visible = false;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 421);
            Controls.Add(lblNoAppointments);
            Controls.Add(btnComplete);
            Controls.Add(dgvAppointments);
            Controls.Add(dtpDate);
            Name = "MasterForm";
            Text = "Салон красоты \"Элегант\"";
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private DataGridView dgvAppointments;
        private Button btnComplete;
        private Label lblNoAppointments;
    }
}