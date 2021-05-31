
namespace E_HealthCare.PresentationLayer
{
    partial class AdminPanel
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
            this.ehealthcareLabel = new System.Windows.Forms.Label();
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.doctorsListLabel = new System.Windows.Forms.Label();
            this.appointmentListLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.ambulanceDataGridView = new System.Windows.Forms.DataGridView();
            this.ambulanceLabel = new System.Windows.Forms.Label();
            this.addDoctorButton = new System.Windows.Forms.Button();
            this.removeDoctorButton = new System.Windows.Forms.Button();
            this.createAppointmentButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.userLabel = new System.Windows.Forms.Label();
            this.availableAmbulenceButton = new System.Windows.Forms.Button();
            this.removeProviderButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.viewDoctorByLabel = new System.Windows.Forms.Label();
            this.doctorDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.viewAmbulanceByLabel = new System.Windows.Forms.Label();
            this.findDoctorLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.doctorSearchButton = new System.Windows.Forms.Button();
            this.providerSearchButton = new System.Windows.Forms.Button();
            this.doctorNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userSearchTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userSearchButton = new System.Windows.Forms.Button();
            this.cancelAppointmentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.shiftComboBox = new System.Windows.Forms.ComboBox();
            this.locTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ehealthcareLabel
            // 
            this.ehealthcareLabel.AutoSize = true;
            this.ehealthcareLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ehealthcareLabel.Location = new System.Drawing.Point(562, 12);
            this.ehealthcareLabel.Name = "ehealthcareLabel";
            this.ehealthcareLabel.Size = new System.Drawing.Size(166, 24);
            this.ehealthcareLabel.TabIndex = 7;
            this.ehealthcareLabel.Text = "E-healthcare";
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Location = new System.Drawing.Point(56, 102);
            this.doctorDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.RowHeadersWidth = 51;
            this.doctorDataGridView.RowTemplate.Height = 24;
            this.doctorDataGridView.Size = new System.Drawing.Size(395, 150);
            this.doctorDataGridView.TabIndex = 8;
            this.doctorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorDataGridView_CellClick);
            // 
            // appointmentsDataGridView
            // 
            this.appointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentsDataGridView.Location = new System.Drawing.Point(56, 384);
            this.appointmentsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentsDataGridView.Name = "appointmentsDataGridView";
            this.appointmentsDataGridView.RowHeadersWidth = 51;
            this.appointmentsDataGridView.RowTemplate.Height = 24;
            this.appointmentsDataGridView.Size = new System.Drawing.Size(395, 150);
            this.appointmentsDataGridView.TabIndex = 9;
            this.appointmentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentsDataGridView_CellClick);
            // 
            // doctorsListLabel
            // 
            this.doctorsListLabel.AutoSize = true;
            this.doctorsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsListLabel.Location = new System.Drawing.Point(63, 82);
            this.doctorsListLabel.Name = "doctorsListLabel";
            this.doctorsListLabel.Size = new System.Drawing.Size(101, 18);
            this.doctorsListLabel.TabIndex = 10;
            this.doctorsListLabel.Text = "Doctors List";
            // 
            // appointmentListLabel
            // 
            this.appointmentListLabel.AutoSize = true;
            this.appointmentListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentListLabel.Location = new System.Drawing.Point(63, 363);
            this.appointmentListLabel.Name = "appointmentListLabel";
            this.appointmentListLabel.Size = new System.Drawing.Size(142, 18);
            this.appointmentListLabel.TabIndex = 11;
            this.appointmentListLabel.Text = "Appointments List";
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1212, 41);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(97, 32);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ambulanceDataGridView
            // 
            this.ambulanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ambulanceDataGridView.Location = new System.Drawing.Point(725, 102);
            this.ambulanceDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ambulanceDataGridView.Name = "ambulanceDataGridView";
            this.ambulanceDataGridView.RowHeadersWidth = 51;
            this.ambulanceDataGridView.RowTemplate.Height = 24;
            this.ambulanceDataGridView.Size = new System.Drawing.Size(385, 150);
            this.ambulanceDataGridView.TabIndex = 13;
            this.ambulanceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ambulanceDataGridView_CellClick);
            // 
            // ambulanceLabel
            // 
            this.ambulanceLabel.AutoSize = true;
            this.ambulanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulanceLabel.Location = new System.Drawing.Point(723, 82);
            this.ambulanceLabel.Name = "ambulanceLabel";
            this.ambulanceLabel.Size = new System.Drawing.Size(158, 18);
            this.ambulanceLabel.TabIndex = 14;
            this.ambulanceLabel.Text = "Ambulance Provider";
            // 
            // addDoctorButton
            // 
            this.addDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDoctorButton.Location = new System.Drawing.Point(491, 102);
            this.addDoctorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDoctorButton.Name = "addDoctorButton";
            this.addDoctorButton.Size = new System.Drawing.Size(111, 58);
            this.addDoctorButton.TabIndex = 15;
            this.addDoctorButton.Text = "Add Doctor";
            this.addDoctorButton.UseVisualStyleBackColor = true;
            this.addDoctorButton.Click += new System.EventHandler(this.addDoctorButton_Click);
            // 
            // removeDoctorButton
            // 
            this.removeDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDoctorButton.Location = new System.Drawing.Point(491, 194);
            this.removeDoctorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeDoctorButton.Name = "removeDoctorButton";
            this.removeDoctorButton.Size = new System.Drawing.Size(111, 58);
            this.removeDoctorButton.TabIndex = 16;
            this.removeDoctorButton.Text = "Remove Doctor";
            this.removeDoctorButton.UseVisualStyleBackColor = true;
            this.removeDoctorButton.Click += new System.EventHandler(this.removeDoctorButton_Click);
            // 
            // createAppointmentButton
            // 
            this.createAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAppointmentButton.Location = new System.Drawing.Point(477, 384);
            this.createAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAppointmentButton.Name = "createAppointmentButton";
            this.createAppointmentButton.Size = new System.Drawing.Size(135, 60);
            this.createAppointmentButton.TabIndex = 17;
            this.createAppointmentButton.Text = "Make Appointment";
            this.createAppointmentButton.UseVisualStyleBackColor = true;
            this.createAppointmentButton.Click += new System.EventHandler(this.createAppointmentButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(1220, 12);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(79, 18);
            this.welcomeLabel.TabIndex = 19;
            this.welcomeLabel.Text = "Welcome";
            // 
            // usersGridView
            // 
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Location = new System.Drawing.Point(725, 384);
            this.usersGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.RowHeadersWidth = 51;
            this.usersGridView.RowTemplate.Height = 24;
            this.usersGridView.Size = new System.Drawing.Size(385, 150);
            this.usersGridView.TabIndex = 20;
            this.usersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellClick);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(723, 363);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(123, 18);
            this.userLabel.TabIndex = 21;
            this.userLabel.Text = "Availavle Users";
            // 
            // availableAmbulenceButton
            // 
            this.availableAmbulenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableAmbulenceButton.Location = new System.Drawing.Point(1144, 102);
            this.availableAmbulenceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availableAmbulenceButton.Name = "availableAmbulenceButton";
            this.availableAmbulenceButton.Size = new System.Drawing.Size(139, 60);
            this.availableAmbulenceButton.TabIndex = 22;
            this.availableAmbulenceButton.Text = "Available Ambulence";
            this.availableAmbulenceButton.UseVisualStyleBackColor = true;
            this.availableAmbulenceButton.Click += new System.EventHandler(this.availableAmbulenceButton_Click);
            // 
            // removeProviderButton
            // 
            this.removeProviderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProviderButton.Location = new System.Drawing.Point(1144, 192);
            this.removeProviderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeProviderButton.Name = "removeProviderButton";
            this.removeProviderButton.Size = new System.Drawing.Size(139, 60);
            this.removeProviderButton.TabIndex = 23;
            this.removeProviderButton.Text = "Remove Provider";
            this.removeProviderButton.UseVisualStyleBackColor = true;
            this.removeProviderButton.Click += new System.EventHandler(this.removeProviderButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Location = new System.Drawing.Point(1144, 384);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(122, 60);
            this.addUserButton.TabIndex = 24;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // viewDoctorByLabel
            // 
            this.viewDoctorByLabel.AutoSize = true;
            this.viewDoctorByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewDoctorByLabel.Location = new System.Drawing.Point(53, 264);
            this.viewDoctorByLabel.Name = "viewDoctorByLabel";
            this.viewDoctorByLabel.Size = new System.Drawing.Size(221, 18);
            this.viewDoctorByLabel.TabIndex = 25;
            this.viewDoctorByLabel.Text = "View Doctor By Department:";
            // 
            // doctorDepartmentComboBox
            // 
            this.doctorDepartmentComboBox.FormattingEnabled = true;
            this.doctorDepartmentComboBox.Location = new System.Drawing.Point(303, 263);
            this.doctorDepartmentComboBox.Name = "doctorDepartmentComboBox";
            this.doctorDepartmentComboBox.Size = new System.Drawing.Size(121, 24);
            this.doctorDepartmentComboBox.TabIndex = 26;
            // 
            // viewAmbulanceByLabel
            // 
            this.viewAmbulanceByLabel.AutoSize = true;
            this.viewAmbulanceByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAmbulanceByLabel.Location = new System.Drawing.Point(734, 264);
            this.viewAmbulanceByLabel.Name = "viewAmbulanceByLabel";
            this.viewAmbulanceByLabel.Size = new System.Drawing.Size(142, 18);
            this.viewAmbulanceByLabel.TabIndex = 27;
            this.viewAmbulanceByLabel.Text = "View By Location:";
            // 
            // findDoctorLabel
            // 
            this.findDoctorLabel.AutoSize = true;
            this.findDoctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findDoctorLabel.Location = new System.Drawing.Point(53, 306);
            this.findDoctorLabel.Name = "findDoctorLabel";
            this.findDoctorLabel.Size = new System.Drawing.Size(159, 18);
            this.findDoctorLabel.TabIndex = 29;
            this.findDoctorLabel.Text = "Enter Doctor Name:";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(358, 548);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(93, 66);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "Update Shift";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(1144, 481);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(122, 60);
            this.removeButton.TabIndex = 31;
            this.removeButton.Text = "Remove User";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // doctorSearchButton
            // 
            this.doctorSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorSearchButton.Location = new System.Drawing.Point(447, 289);
            this.doctorSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorSearchButton.Name = "doctorSearchButton";
            this.doctorSearchButton.Size = new System.Drawing.Size(101, 38);
            this.doctorSearchButton.TabIndex = 32;
            this.doctorSearchButton.Text = "Search";
            this.doctorSearchButton.UseVisualStyleBackColor = true;
            this.doctorSearchButton.Click += new System.EventHandler(this.doctorSearchButton_Click);
            // 
            // providerSearchButton
            // 
            this.providerSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerSearchButton.Location = new System.Drawing.Point(1065, 264);
            this.providerSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.providerSearchButton.Name = "providerSearchButton";
            this.providerSearchButton.Size = new System.Drawing.Size(101, 38);
            this.providerSearchButton.TabIndex = 33;
            this.providerSearchButton.Text = "Search";
            this.providerSearchButton.UseVisualStyleBackColor = true;
            this.providerSearchButton.Click += new System.EventHandler(this.providerSearchButton_Click);
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(235, 305);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(189, 22);
            this.doctorNameTextBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(729, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Enter User Phone:";
            // 
            // userSearchTextBox
            // 
            this.userSearchTextBox.Location = new System.Drawing.Point(900, 547);
            this.userSearchTextBox.Name = "userSearchTextBox";
            this.userSearchTextBox.Size = new System.Drawing.Size(189, 22);
            this.userSearchTextBox.TabIndex = 36;
            // 
            // userSearchButton
            // 
            this.userSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearchButton.Location = new System.Drawing.Point(923, 576);
            this.userSearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userSearchButton.Name = "userSearchButton";
            this.userSearchButton.Size = new System.Drawing.Size(101, 38);
            this.userSearchButton.TabIndex = 37;
            this.userSearchButton.Text = "Search";
            this.userSearchButton.UseVisualStyleBackColor = true;
            this.userSearchButton.Click += new System.EventHandler(this.userSearchButton_Click);
            // 
            // cancelAppointmentButton
            // 
            this.cancelAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAppointmentButton.Location = new System.Drawing.Point(477, 481);
            this.cancelAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelAppointmentButton.Name = "cancelAppointmentButton";
            this.cancelAppointmentButton.Size = new System.Drawing.Size(135, 60);
            this.cancelAppointmentButton.TabIndex = 38;
            this.cancelAppointmentButton.Text = "Cancel Appointment";
            this.cancelAppointmentButton.UseVisualStyleBackColor = true;
            this.cancelAppointmentButton.Click += new System.EventHandler(this.cancelAppointmentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Update Shift:";
            // 
            // shiftComboBox
            // 
            this.shiftComboBox.FormattingEnabled = true;
            this.shiftComboBox.Location = new System.Drawing.Point(194, 561);
            this.shiftComboBox.Name = "shiftComboBox";
            this.shiftComboBox.Size = new System.Drawing.Size(121, 24);
            this.shiftComboBox.TabIndex = 40;
            // 
            // locTextBox
            // 
            this.locTextBox.Location = new System.Drawing.Point(882, 265);
            this.locTextBox.Name = "locTextBox";
            this.locTextBox.Size = new System.Drawing.Size(145, 22);
            this.locTextBox.TabIndex = 41;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 640);
            this.Controls.Add(this.locTextBox);
            this.Controls.Add(this.shiftComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelAppointmentButton);
            this.Controls.Add(this.userSearchButton);
            this.Controls.Add(this.userSearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorNameTextBox);
            this.Controls.Add(this.providerSearchButton);
            this.Controls.Add(this.doctorSearchButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.findDoctorLabel);
            this.Controls.Add(this.viewAmbulanceByLabel);
            this.Controls.Add(this.doctorDepartmentComboBox);
            this.Controls.Add(this.viewDoctorByLabel);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.removeProviderButton);
            this.Controls.Add(this.availableAmbulenceButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.usersGridView);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.createAppointmentButton);
            this.Controls.Add(this.removeDoctorButton);
            this.Controls.Add(this.addDoctorButton);
            this.Controls.Add(this.ambulanceLabel);
            this.Controls.Add(this.ambulanceDataGridView);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.appointmentListLabel);
            this.Controls.Add(this.doctorsListLabel);
            this.Controls.Add(this.appointmentsDataGridView);
            this.Controls.Add(this.doctorDataGridView);
            this.Controls.Add(this.ehealthcareLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambulanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ehealthcareLabel;
        private System.Windows.Forms.DataGridView doctorDataGridView;
        private System.Windows.Forms.DataGridView appointmentsDataGridView;
        private System.Windows.Forms.Label doctorsListLabel;
        private System.Windows.Forms.Label appointmentListLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridView ambulanceDataGridView;
        private System.Windows.Forms.Label ambulanceLabel;
        private System.Windows.Forms.Button addDoctorButton;
        private System.Windows.Forms.Button removeDoctorButton;
        private System.Windows.Forms.Button createAppointmentButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Button availableAmbulenceButton;
        private System.Windows.Forms.Button removeProviderButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label viewDoctorByLabel;
        private System.Windows.Forms.ComboBox doctorDepartmentComboBox;
        private System.Windows.Forms.Label viewAmbulanceByLabel;
        private System.Windows.Forms.Label findDoctorLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button doctorSearchButton;
        private System.Windows.Forms.Button providerSearchButton;
        private System.Windows.Forms.MaskedTextBox doctorNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox userSearchTextBox;
        private System.Windows.Forms.Button userSearchButton;
        private System.Windows.Forms.Button cancelAppointmentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shiftComboBox;
        private System.Windows.Forms.MaskedTextBox locTextBox;
    }
}