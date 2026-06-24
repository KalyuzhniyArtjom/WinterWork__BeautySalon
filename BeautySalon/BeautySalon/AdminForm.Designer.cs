namespace BeautySalon
{
    partial class AdminForm
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
            tabControl1 = new TabControl();
            txtComment = new TabPage();
            btnSaveAppointment = new Button();
            textBox2 = new TextBox();
            label6 = new Label();
            txtTime = new TextBox();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            cmbMaster = new ComboBox();
            label3 = new Label();
            cmbService = new ComboBox();
            label2 = new Label();
            cmbClient = new ComboBox();
            label1 = new Label();
            btnRefreshAppointments = new Button();
            btnReceipt = new Button();
            btnCancelAppointment = new Button();
            btnAddAppointment = new Button();
            dgvAppointments = new DataGridView();
            txtSearch = new TextBox();
            tabPage2 = new TabPage();
            btnDeleteService = new Button();
            btnEditService = new Button();
            btnAddService = new Button();
            label11 = new Label();
            txtServiceName = new TextBox();
            txtServicePrice = new TextBox();
            txtServiceDuration = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dgvServices = new DataGridView();
            btnSearchService = new Button();
            label7 = new Label();
            txtSearchService = new TextBox();
            tabPage3 = new TabPage();
            btnDeleteMaster = new Button();
            btnEditMaster = new Button();
            btnAddMaster = new Button();
            cmbSkillLevel = new ComboBox();
            cmbSpecialization = new ComboBox();
            txtMasterPhone = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            txtMasterName = new TextBox();
            label13 = new Label();
            dgvMasters = new DataGridView();
            btnSearchMaster = new Button();
            txtSearchMaster = new TextBox();
            label12 = new Label();
            tabPage1 = new TabPage();
            btnDeleteClient = new Button();
            btnEditClient = new Button();
            btnAddClient = new Button();
            txtClientName = new TextBox();
            txtClientComment = new TextBox();
            txtClientPhone = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            dgvClients = new DataGridView();
            btnSearchClient = new Button();
            txtSearchClient = new TextBox();
            label17 = new Label();
            tabControl1.SuspendLayout();
            txtComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMasters).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(txtComment);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(990, 648);
            tabControl1.TabIndex = 0;
            // 
            // txtComment
            // 
            txtComment.Controls.Add(btnSaveAppointment);
            txtComment.Controls.Add(textBox2);
            txtComment.Controls.Add(label6);
            txtComment.Controls.Add(txtTime);
            txtComment.Controls.Add(dtpDate);
            txtComment.Controls.Add(label5);
            txtComment.Controls.Add(label4);
            txtComment.Controls.Add(cmbMaster);
            txtComment.Controls.Add(label3);
            txtComment.Controls.Add(cmbService);
            txtComment.Controls.Add(label2);
            txtComment.Controls.Add(cmbClient);
            txtComment.Controls.Add(label1);
            txtComment.Controls.Add(btnRefreshAppointments);
            txtComment.Controls.Add(btnReceipt);
            txtComment.Controls.Add(btnCancelAppointment);
            txtComment.Controls.Add(btnAddAppointment);
            txtComment.Controls.Add(dgvAppointments);
            txtComment.Controls.Add(txtSearch);
            txtComment.Location = new Point(4, 24);
            txtComment.Name = "txtComment";
            txtComment.Padding = new Padding(3);
            txtComment.Size = new Size(982, 620);
            txtComment.TabIndex = 0;
            txtComment.Text = "Записи";
            txtComment.UseVisualStyleBackColor = true;
            // 
            // btnSaveAppointment
            // 
            btnSaveAppointment.Location = new Point(8, 539);
            btnSaveAppointment.Name = "btnSaveAppointment";
            btnSaveAppointment.Size = new Size(75, 23);
            btnSaveAppointment.TabIndex = 20;
            btnSaveAppointment.Text = "Сохранить";
            btnSaveAppointment.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(384, 493);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(255, 495);
            label6.Name = "label6";
            label6.Size = new Size(123, 19);
            label6.TabIndex = 18;
            label6.Text = "📝 Комментарий:";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(384, 454);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(121, 23);
            txtTime.TabIndex = 17;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(384, 417);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(121, 23);
            dtpDate.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(303, 455);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 13;
            label5.Text = "⏰ Время:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(303, 417);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 12;
            label4.Text = "📅 Дата:";
            // 
            // cmbMaster
            // 
            cmbMaster.FormattingEnabled = true;
            cmbMaster.Location = new Point(104, 494);
            cmbMaster.Name = "cmbMaster";
            cmbMaster.Size = new Size(121, 23);
            cmbMaster.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(23, 494);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 10;
            label3.Text = "👨 Мастер:";
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Location = new Point(104, 455);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(121, 23);
            cmbService.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(23, 455);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 8;
            label2.Text = "💇 Услуга:";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(105, 417);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(121, 23);
            cmbClient.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(23, 417);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 6;
            label1.Text = "👤 Клиент:";
            // 
            // btnRefreshAppointments
            // 
            btnRefreshAppointments.Location = new Point(251, 376);
            btnRefreshAppointments.Name = "btnRefreshAppointments";
            btnRefreshAppointments.Size = new Size(75, 23);
            btnRefreshAppointments.TabIndex = 5;
            btnRefreshAppointments.Text = "Обновить";
            btnRefreshAppointments.UseVisualStyleBackColor = true;
            btnRefreshAppointments.Click += btnRefreshAppointments_Click;
            // 
            // btnReceipt
            // 
            btnReceipt.Location = new Point(170, 376);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(75, 23);
            btnReceipt.TabIndex = 4;
            btnReceipt.Text = "Чек";
            btnReceipt.UseVisualStyleBackColor = true;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // btnCancelAppointment
            // 
            btnCancelAppointment.Location = new Point(89, 376);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new Size(75, 23);
            btnCancelAppointment.TabIndex = 3;
            btnCancelAppointment.Text = "Отменить";
            btnCancelAppointment.UseVisualStyleBackColor = true;
            btnCancelAppointment.Click += btnCancelAppointment_Click;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Location = new Point(8, 376);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(75, 23);
            btnAddAppointment.TabIndex = 2;
            btnAddAppointment.Text = "Добавить";
            btnAddAppointment.UseVisualStyleBackColor = true;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(8, 47);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.Size = new Size(772, 312);
            dgvAppointments.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(23, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск: [Введите имя или телефон]";
            txtSearch.Size = new Size(314, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteService);
            tabPage2.Controls.Add(btnEditService);
            tabPage2.Controls.Add(btnAddService);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(txtServiceName);
            tabPage2.Controls.Add(txtServicePrice);
            tabPage2.Controls.Add(txtServiceDuration);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(dgvServices);
            tabPage2.Controls.Add(btnSearchService);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtSearchService);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(982, 620);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Услуги";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Location = new Point(242, 545);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(75, 23);
            btnDeleteService.TabIndex = 13;
            btnDeleteService.Text = "Удалить";
            btnDeleteService.UseVisualStyleBackColor = true;
            btnDeleteService.Click += btnDeleteService_Click;
            // 
            // btnEditService
            // 
            btnEditService.Location = new Point(123, 545);
            btnEditService.Name = "btnEditService";
            btnEditService.Size = new Size(96, 23);
            btnEditService.TabIndex = 12;
            btnEditService.Text = "Редактировать";
            btnEditService.UseVisualStyleBackColor = true;
            btnEditService.Click += btnEditService_Click;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(23, 545);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(75, 23);
            btnAddService.TabIndex = 11;
            btnAddService.Text = "Добавить";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(325, 506);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 10;
            label11.Text = "Минут";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(149, 426);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(170, 23);
            txtServiceName.TabIndex = 9;
            // 
            // txtServicePrice
            // 
            txtServicePrice.Location = new Point(149, 461);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(170, 23);
            txtServicePrice.TabIndex = 8;
            // 
            // txtServiceDuration
            // 
            txtServiceDuration.Location = new Point(149, 498);
            txtServiceDuration.Name = "txtServiceDuration";
            txtServiceDuration.Size = new Size(170, 23);
            txtServiceDuration.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(23, 498);
            label10.Name = "label10";
            label10.Size = new Size(122, 19);
            label10.TabIndex = 6;
            label10.Text = "⏱ Длительность:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(23, 461);
            label9.Name = "label9";
            label9.Size = new Size(82, 19);
            label9.TabIndex = 5;
            label9.Text = "💰 Цена, ₽:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(23, 426);
            label8.Name = "label8";
            label8.Size = new Size(95, 19);
            label8.TabIndex = 4;
            label8.Text = "📝 Название:";
            // 
            // dgvServices
            // 
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new Point(23, 59);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new Size(725, 348);
            dgvServices.TabIndex = 3;
            dgvServices.SelectionChanged += dgvServices_SelectionChanged;
            // 
            // btnSearchService
            // 
            btnSearchService.Location = new Point(340, 30);
            btnSearchService.Name = "btnSearchService";
            btnSearchService.Size = new Size(75, 23);
            btnSearchService.TabIndex = 2;
            btnSearchService.Text = "Найти";
            btnSearchService.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(23, 31);
            label7.Name = "label7";
            label7.Size = new Size(118, 19);
            label7.TabIndex = 1;
            label7.Text = "🔍 Поиск услуги:";
            // 
            // txtSearchService
            // 
            txtSearchService.Location = new Point(147, 30);
            txtSearchService.Name = "txtSearchService";
            txtSearchService.Size = new Size(170, 23);
            txtSearchService.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnDeleteMaster);
            tabPage3.Controls.Add(btnEditMaster);
            tabPage3.Controls.Add(btnAddMaster);
            tabPage3.Controls.Add(cmbSkillLevel);
            tabPage3.Controls.Add(cmbSpecialization);
            tabPage3.Controls.Add(txtMasterPhone);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(txtMasterName);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(dgvMasters);
            tabPage3.Controls.Add(btnSearchMaster);
            tabPage3.Controls.Add(txtSearchMaster);
            tabPage3.Controls.Add(label12);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(982, 620);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Мастера";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMaster
            // 
            btnDeleteMaster.Location = new Point(217, 568);
            btnDeleteMaster.Name = "btnDeleteMaster";
            btnDeleteMaster.Size = new Size(75, 23);
            btnDeleteMaster.TabIndex = 16;
            btnDeleteMaster.Text = "Удалить";
            btnDeleteMaster.UseVisualStyleBackColor = true;
            btnDeleteMaster.Click += btnDeleteMaster_Click;
            // 
            // btnEditMaster
            // 
            btnEditMaster.Location = new Point(104, 568);
            btnEditMaster.Name = "btnEditMaster";
            btnEditMaster.Size = new Size(96, 23);
            btnEditMaster.TabIndex = 15;
            btnEditMaster.Text = "Редактировать";
            btnEditMaster.UseVisualStyleBackColor = true;
            btnEditMaster.Click += btnEditMaster_Click;
            // 
            // btnAddMaster
            // 
            btnAddMaster.Location = new Point(8, 568);
            btnAddMaster.Name = "btnAddMaster";
            btnAddMaster.Size = new Size(75, 23);
            btnAddMaster.TabIndex = 14;
            btnAddMaster.Text = "Добавить";
            btnAddMaster.UseVisualStyleBackColor = true;
            btnAddMaster.Click += btnAddMaster_Click;
            // 
            // cmbSkillLevel
            // 
            cmbSkillLevel.FormattingEnabled = true;
            cmbSkillLevel.Items.AddRange(new object[] { "Парикмахер, Маникюр, Косметолог, Визажист" });
            cmbSkillLevel.Location = new Point(148, 525);
            cmbSkillLevel.Name = "cmbSkillLevel";
            cmbSkillLevel.Size = new Size(121, 23);
            cmbSkillLevel.TabIndex = 13;
            // 
            // cmbSpecialization
            // 
            cmbSpecialization.FormattingEnabled = true;
            cmbSpecialization.Items.AddRange(new object[] { "Парикмахер, Маникюр, Косметолог, Визажист" });
            cmbSpecialization.Location = new Point(148, 488);
            cmbSpecialization.Name = "cmbSpecialization";
            cmbSpecialization.Size = new Size(121, 23);
            cmbSpecialization.TabIndex = 12;
            // 
            // txtMasterPhone
            // 
            txtMasterPhone.Location = new Point(148, 453);
            txtMasterPhone.Name = "txtMasterPhone";
            txtMasterPhone.Size = new Size(118, 23);
            txtMasterPhone.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(3, 525);
            label16.Name = "label16";
            label16.Size = new Size(146, 19);
            label16.TabIndex = 8;
            label16.Text = "📊 Уровень навыков:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(8, 488);
            label15.Name = "label15";
            label15.Size = new Size(133, 19);
            label15.TabIndex = 7;
            label15.Text = "🏷 Специализация:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(24, 453);
            label14.Name = "label14";
            label14.Size = new Size(89, 19);
            label14.TabIndex = 6;
            label14.Text = "📞 Телефон:";
            // 
            // txtMasterName
            // 
            txtMasterName.Location = new Point(148, 416);
            txtMasterName.Name = "txtMasterName";
            txtMasterName.Size = new Size(118, 23);
            txtMasterName.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(24, 416);
            label13.Name = "label13";
            label13.Size = new Size(121, 19);
            label13.TabIndex = 4;
            label13.Text = "👤 ФИО мастера:";
            // 
            // dgvMasters
            // 
            dgvMasters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasters.Location = new Point(24, 49);
            dgvMasters.Name = "dgvMasters";
            dgvMasters.Size = new Size(785, 340);
            dgvMasters.TabIndex = 3;
            dgvMasters.Click += dgvMasters_SelectionChanged;
            // 
            // btnSearchMaster
            // 
            btnSearchMaster.Location = new Point(308, 20);
            btnSearchMaster.Name = "btnSearchMaster";
            btnSearchMaster.Size = new Size(75, 23);
            btnSearchMaster.TabIndex = 2;
            btnSearchMaster.Text = "Найти";
            btnSearchMaster.UseVisualStyleBackColor = true;
            // 
            // txtSearchMaster
            // 
            txtSearchMaster.Location = new Point(159, 20);
            txtSearchMaster.Name = "txtSearchMaster";
            txtSearchMaster.Size = new Size(122, 23);
            txtSearchMaster.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(24, 20);
            label12.Name = "label12";
            label12.Size = new Size(129, 19);
            label12.TabIndex = 0;
            label12.Text = "🔍 Поиск мастера:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeleteClient);
            tabPage1.Controls.Add(btnEditClient);
            tabPage1.Controls.Add(btnAddClient);
            tabPage1.Controls.Add(txtClientName);
            tabPage1.Controls.Add(txtClientComment);
            tabPage1.Controls.Add(txtClientPhone);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(dgvClients);
            tabPage1.Controls.Add(btnSearchClient);
            tabPage1.Controls.Add(txtSearchClient);
            tabPage1.Controls.Add(label17);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(982, 620);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Клиенты";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Location = new Point(237, 511);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(75, 23);
            btnDeleteClient.TabIndex = 12;
            btnDeleteClient.Text = "Удалить";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(118, 511);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(95, 23);
            btnEditClient.TabIndex = 11;
            btnEditClient.Text = "Редактировать";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(21, 511);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(75, 23);
            btnAddClient.TabIndex = 10;
            btnAddClient.Text = "Добавить";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(150, 399);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(148, 23);
            txtClientName.TabIndex = 9;
            // 
            // txtClientComment
            // 
            txtClientComment.Location = new Point(150, 463);
            txtClientComment.Name = "txtClientComment";
            txtClientComment.Size = new Size(148, 23);
            txtClientComment.TabIndex = 8;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(150, 431);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.Size = new Size(148, 23);
            txtClientPhone.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.Location = new Point(21, 464);
            label20.Name = "label20";
            label20.Size = new Size(123, 19);
            label20.TabIndex = 6;
            label20.Text = "📝 Комментарий:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F);
            label19.Location = new Point(39, 432);
            label19.Name = "label19";
            label19.Size = new Size(89, 19);
            label19.TabIndex = 5;
            label19.Text = "📞 Телефон:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F);
            label18.Location = new Point(21, 399);
            label18.Name = "label18";
            label18.Size = new Size(120, 19);
            label18.TabIndex = 4;
            label18.Text = "👤 ФИО клиента:";
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(21, 53);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(738, 326);
            dgvClients.TabIndex = 3;
            dgvClients.SelectionChanged += dgvClients_SelectionChanged;
            // 
            // btnSearchClient
            // 
            btnSearchClient.Location = new Point(330, 24);
            btnSearchClient.Name = "btnSearchClient";
            btnSearchClient.Size = new Size(75, 23);
            btnSearchClient.TabIndex = 2;
            btnSearchClient.Text = "Найти";
            btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // txtSearchClient
            // 
            txtSearchClient.Location = new Point(164, 24);
            txtSearchClient.Name = "txtSearchClient";
            txtSearchClient.Size = new Size(148, 23);
            txtSearchClient.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F);
            label17.Location = new Point(30, 25);
            label17.Name = "label17";
            label17.Size = new Size(128, 19);
            label17.TabIndex = 0;
            label17.Text = "🔍 Поиск клиента:";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 648);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            Text = "Салон красоты \"Элегант\"";
            tabControl1.ResumeLayout(false);
            txtComment.ResumeLayout(false);
            txtComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServices).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMasters).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage txtComment;
        private TabPage tabPage2;
        private Button btnAddAppointment;
        private DataGridView dgvAppointments;
        private TextBox txtSearch;
        private TabPage tabPage3;
        private ComboBox cmbService;
        private Label label2;
        private ComboBox cmbClient;
        private Label label1;
        private Button btnRefreshAppointments;
        private Button btnReceipt;
        private Button btnCancelAppointment;
        private ComboBox cmbMaster;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label6;
        private TextBox txtTime;
        private DateTimePicker dtpDate;
        private Label label5;
        private Button btnSaveAppointment;
        private Button btnSearchService;
        private Label label7;
        private TextBox txtSearchService;
        private Button btnDeleteService;
        private Button btnEditService;
        private Button btnAddService;
        private Label label11;
        private TextBox txtServiceName;
        private TextBox txtServicePrice;
        private TextBox txtServiceDuration;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView dgvServices;
        private ComboBox cmbSpecialization;
        private TextBox txtMasterPhone;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox txtMasterName;
        private Label label13;
        private DataGridView dgvMasters;
        private Button btnSearchMaster;
        private TextBox txtSearchMaster;
        private Label label12;
        private ComboBox cmbSkillLevel;
        private Button btnDeleteMaster;
        private Button btnEditMaster;
        private Button btnAddMaster;
        private TabPage tabPage1;
        private TextBox txtSearchClient;
        private Label label17;
        private Button btnDeleteClient;
        private Button btnEditClient;
        private Button btnAddClient;
        private TextBox txtClientName;
        private TextBox txtClientComment;
        private TextBox txtClientPhone;
        private Label label20;
        private Label label19;
        private Label label18;
        private DataGridView dgvClients;
        private Button btnSearchClient;
    }
}