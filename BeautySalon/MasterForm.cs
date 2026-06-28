using BeautySalonLib.Managers;
using BeautySalonLib.Model;
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
    public partial class MasterForm : Form
    {
        private User _currentUser;
        private MasterScheduleManager _scheduleManager;
        private int _masterId = 1;

        public MasterForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            _scheduleManager = new MasterScheduleManager(_masterId);
            this.Text = $"Салон красоты - Мастер ({_currentUser.FullName})";
            LoadSchedule();
        }

        private void LoadSchedule()
        {
            var appointments = _scheduleManager.GetAppointmentsByDate(dtpDate.Value.Date);

            if (appointments.Count == 0)
            {
                lblNoAppointments.Visible = true;
                dgvAppointments.DataSource = null;
                return;
            }

            lblNoAppointments.Visible = false;
            dgvAppointments.DataSource = null;
            dgvAppointments.DataSource = appointments;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = (Appointment)dgvAppointments.SelectedRows[0].DataBoundItem;

            if (selected.Status == "Выполнена")
            {
                MessageBox.Show("Эта запись уже выполнена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selected.Status != "Записана")
            {
                MessageBox.Show($"Эта запись уже имеет статус \"{selected.Status}\" и не может быть изменена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_scheduleManager.UpdateStatus(selected.Id, "Выполнена"))
            {
                MessageBox.Show("Запись отмечена как выполненная!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSchedule();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadSchedule();
        }
    }
}
