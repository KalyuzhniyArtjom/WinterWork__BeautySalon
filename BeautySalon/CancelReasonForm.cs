using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class CancelReasonForm : Form
    {
        public string SelectedReason { get; private set; }

        public CancelReasonForm()
        {
            InitializeComponent();
            cmbReasons.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (cmbReasons.SelectedItem != null)
            {
                SelectedReason = cmbReasons.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите причину отмены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
