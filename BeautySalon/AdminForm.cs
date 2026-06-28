using BeautySalonLib.Managers;
using BeautySalonLib.Model;
using Microsoft.VisualBasic;
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
    public partial class AdminForm : Form
    {
        private User _currentUser;
        private AppointmentManager _appointmentManager = new AppointmentManager();
        private List<Appointment> _allAppointments = new List<Appointment>();
        private List<Service> _services = new List<Service>();
        private List<Master> _masters = new List<Master>();
        private List<Client> _clients = new List<Client>();

        public AdminForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
            this.Text = $"Салон красоты - Администратор ({_currentUser.FullName})";
            LoadAllData();
        }

        private void LoadAllData()
        {
            LoadAppointments();
            LoadServices();
            LoadMasters();
            LoadClients();
            LoadComboBoxes();
        }

        private void LoadAppointments()
        {
            _allAppointments = _appointmentManager.GetAllAppointments();
            FilterAppointments();
        }

        private void LoadServices()
        {
            _services = _appointmentManager.GetAllServices();
            dgvServices.DataSource = null;
            dgvServices.DataSource = _services;
        }

        private void LoadMasters()
        {
            _masters = _appointmentManager.GetAllMasters();
            dgvMasters.DataSource = null;
            dgvMasters.DataSource = _masters;
        }

        private void LoadClients()
        {
            _clients = _appointmentManager.GetAllClients();
            dgvClients.DataSource = null;
            dgvClients.DataSource = _clients;
        }

        private void LoadComboBoxes()
        {
            cmbClient.DataSource = null;
            cmbClient.DataSource = _clients;
            cmbClient.DisplayMember = "Name";
            cmbClient.ValueMember = "Id";

            cmbService.DataSource = null;
            cmbService.DataSource = _services;
            cmbService.DisplayMember = "Name";
            cmbService.ValueMember = "Id";

            cmbMaster.DataSource = null;
            cmbMaster.DataSource = _masters;
            cmbMaster.DisplayMember = "FullName";
            cmbMaster.ValueMember = "Id";
        }

        private void FilterAppointments()
        {
            string searchText = txtSearch.Text.Trim();
            var filtered = _allAppointments;

            if (!string.IsNullOrEmpty(searchText))
            {
                filtered = _allAppointments
                    .Where(a => a.ClientName.ToLower().Contains(searchText.ToLower()) ||
                               a.ClientPhone.Contains(searchText))
                    .ToList();
            }

            dgvAppointments.DataSource = null;
            dgvAppointments.DataSource = filtered;
        }

        // ============ ЗАПИСИ ============
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbService.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите услугу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbMaster.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите мастера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TimeSpan.TryParse(txtTime.Text, out TimeSpan time))
            {
                MessageBox.Show("Введите корректное время (например, 14:30)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var appointment = new Appointment
            {
                ClientId = (int)cmbClient.SelectedValue,
                ServiceId = (int)cmbService.SelectedValue,
                MasterId = (int)cmbMaster.SelectedValue,
                Date = dtpDate.Value.Date,
                Time = time,
                Status = "Записана",
                ClientComment = txtComment.Text.Trim()
            };

            if (_appointmentManager.CreateAppointment(appointment))
            {
                MessageBox.Show("Запись успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
                ClearAppointmentFields();
            }
            else
            {
                MessageBox.Show("Это время уже занято. Выберите другое время", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = (Appointment)dgvAppointments.SelectedRows[0].DataBoundItem;

            var reasonForm = new CancelReasonForm();
            if (reasonForm.ShowDialog() == DialogResult.OK)
            {
                _appointmentManager.CancelAppointment(selected.Id, reasonForm.SelectedReason);
                MessageBox.Show("Запись отменена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAppointments();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для печати чека", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selected = (Appointment)dgvAppointments.SelectedRows[0].DataBoundItem;
            var receiptForm = new ReceiptForm(selected);
            receiptForm.ShowDialog();
        }

        private void btnRefreshAppointments_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterAppointments();
        }

        private void ClearAppointmentFields()
        {
            cmbClient.SelectedIndex = -1;
            cmbService.SelectedIndex = -1;
            cmbMaster.SelectedIndex = -1;
            txtTime.Clear();
            
            dtpDate.Value = DateTime.Now;
        }

        // ============ УСЛУГИ ============
        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Введите название услуги", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtServicePrice.Text, out decimal price))
            {
                MessageBox.Show("Ошибка: в поле \"Цена\" должно быть указано число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtServiceDuration.Text, out int duration))
            {
                MessageBox.Show("Ошибка: в поле \"Длительность\" должно быть указано целое число минут", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Здесь код добавления в БД
            MessageBox.Show("Услуга добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadServices();
            ClearServiceFields();
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите услугу для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Услуга отредактирована!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadServices();
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите услугу для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Вы действительно хотите удалить эту услугу?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Услуга удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadServices();
            }
        }

        private void dgvServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                var service = (Service)dgvServices.SelectedRows[0].DataBoundItem;
                txtServiceName.Text = service.Name;
                txtServicePrice.Text = service.Price.ToString();
                txtServiceDuration.Text = service.DurationMinutes.ToString();
            }
        }

        private void ClearServiceFields()
        {
            txtServiceName.Clear();
            txtServicePrice.Clear();
            txtServiceDuration.Clear();
        }

        // ============ МАСТЕРА ============
        private void btnAddMaster_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMasterName.Text))
            {
                MessageBox.Show("Пожалуйста, заполните имя мастера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMasterPhone.Text))
            {
                MessageBox.Show("Пожалуйста, заполните номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Мастер добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMasters();
            ClearMasterFields();
        }

        private void btnEditMaster_Click(object sender, EventArgs e)
        {
            if (dgvMasters.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите мастера для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Данные мастера обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMasters();
        }

        private void btnDeleteMaster_Click(object sender, EventArgs e)
        {
            if (dgvMasters.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите мастера для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Мастер удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMasters();
        }

        private void dgvMasters_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMasters.SelectedRows.Count > 0)
            {
                var master = (Master)dgvMasters.SelectedRows[0].DataBoundItem;
                txtMasterName.Text = master.FullName;
                txtMasterPhone.Text = master.Phone;
                cmbSpecialization.Text = master.Specialization;
                cmbSkillLevel.Text = master.SkillLevel;
            }
        }

        private void ClearMasterFields()
        {
            txtMasterName.Clear();
            txtMasterPhone.Clear();
            cmbSpecialization.SelectedIndex = -1;
            cmbSkillLevel.SelectedIndex = -1;
        }

        // ============ КЛИЕНТЫ ============
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientName.Text))
            {
                MessageBox.Show("Пожалуйста, заполните имя клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtClientPhone.Text))
            {
                MessageBox.Show("Пожалуйста, заполните номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Клиент добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadClients();
            ClearClientFields();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Данные клиента обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadClients();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Клиент удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadClients();
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.SelectedRows.Count > 0)
            {
                var client = (Client)dgvClients.SelectedRows[0].DataBoundItem;
                txtClientName.Text = client.Name;
                txtClientPhone.Text = client.Phone;
            }
        }

        private void ClearClientFields()
        {
            txtClientName.Clear();
            txtClientPhone.Clear();
        }
    }
}
