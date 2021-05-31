
namespace E_HealthCare.PresentationLayer
{
    partial class MakeAppoinmentPanel
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
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
            this.ehealthcareLabel = new System.Windows.Forms.Label();
            this.doctorsListLabel = new System.Windows.Forms.Label();
            this.searchDoctorLabel = new System.Windows.Forms.Label();
            this.doctorSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.selectShiftComboBox = new System.Windows.Forms.ComboBox();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.selectShiftLabel = new System.Windows.Forms.Label();
            this.makeAppointmentButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.problemTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patientIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Location = new System.Drawing.Point(61, 163);
            this.doctorDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.RowHeadersWidth = 51;
            this.doctorDataGridView.RowTemplate.Height = 24;
            this.doctorDataGridView.Size = new System.Drawing.Size(840, 200);
            this.doctorDataGridView.TabIndex = 27;
            this.doctorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorDataGridView_CellClick);
            // 
            // ehealthcareLabel
            // 
            this.ehealthcareLabel.AutoSize = true;
            this.ehealthcareLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ehealthcareLabel.Location = new System.Drawing.Point(390, 21);
            this.ehealthcareLabel.Name = "ehealthcareLabel";
            this.ehealthcareLabel.Size = new System.Drawing.Size(166, 24);
            this.ehealthcareLabel.TabIndex = 28;
            this.ehealthcareLabel.Text = "E-healthcare";
            // 
            // doctorsListLabel
            // 
            this.doctorsListLabel.AutoSize = true;
            this.doctorsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsListLabel.Location = new System.Drawing.Point(73, 143);
            this.doctorsListLabel.Name = "doctorsListLabel";
            this.doctorsListLabel.Size = new System.Drawing.Size(140, 18);
            this.doctorsListLabel.TabIndex = 29;
            this.doctorsListLabel.Text = "Available Doctors";
            // 
            // searchDoctorLabel
            // 
            this.searchDoctorLabel.AutoSize = true;
            this.searchDoctorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDoctorLabel.Location = new System.Drawing.Point(203, 88);
            this.searchDoctorLabel.Name = "searchDoctorLabel";
            this.searchDoctorLabel.Size = new System.Drawing.Size(159, 18);
            this.searchDoctorLabel.TabIndex = 30;
            this.searchDoctorLabel.Text = "Enter Doctor Name:";
            // 
            // doctorSearchTextBox
            // 
            this.doctorSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorSearchTextBox.Location = new System.Drawing.Point(383, 82);
            this.doctorSearchTextBox.Name = "doctorSearchTextBox";
            this.doctorSearchTextBox.Size = new System.Drawing.Size(145, 28);
            this.doctorSearchTextBox.TabIndex = 37;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(757, 74);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 36);
            this.searchButton.TabIndex = 38;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.Location = new System.Drawing.Point(567, 65);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(161, 18);
            this.departmentLabel.TabIndex = 39;
            this.departmentLabel.Text = "ShowByDepartment:";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(570, 86);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(145, 24);
            this.departmentComboBox.TabIndex = 40;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameTextBox.Location = new System.Drawing.Point(341, 384);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.Size = new System.Drawing.Size(145, 28);
            this.doctorNameTextBox.TabIndex = 41;
            // 
            // selectShiftComboBox
            // 
            this.selectShiftComboBox.FormattingEnabled = true;
            this.selectShiftComboBox.Location = new System.Drawing.Point(341, 458);
            this.selectShiftComboBox.Name = "selectShiftComboBox";
            this.selectShiftComboBox.Size = new System.Drawing.Size(145, 24);
            this.selectShiftComboBox.TabIndex = 42;
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameLabel.Location = new System.Drawing.Point(203, 390);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(114, 18);
            this.doctorNameLabel.TabIndex = 43;
            this.doctorNameLabel.Text = "Doctor Name:";
            // 
            // selectShiftLabel
            // 
            this.selectShiftLabel.AutoSize = true;
            this.selectShiftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectShiftLabel.Location = new System.Drawing.Point(218, 459);
            this.selectShiftLabel.Name = "selectShiftLabel";
            this.selectShiftLabel.Size = new System.Drawing.Size(99, 18);
            this.selectShiftLabel.TabIndex = 44;
            this.selectShiftLabel.Text = "Select Shift:";
            // 
            // makeAppointmentButton
            // 
            this.makeAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeAppointmentButton.Location = new System.Drawing.Point(439, 557);
            this.makeAppointmentButton.Name = "makeAppointmentButton";
            this.makeAppointmentButton.Size = new System.Drawing.Size(146, 59);
            this.makeAppointmentButton.TabIndex = 45;
            this.makeAppointmentButton.Text = "Make Appointment";
            this.makeAppointmentButton.UseVisualStyleBackColor = true;
            this.makeAppointmentButton.Click += new System.EventHandler(this.makeAppointmentButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(821, 557);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 33);
            this.backButton.TabIndex = 46;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Problem:";
            // 
            // problemTextBox
            // 
            this.problemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemTextBox.Location = new System.Drawing.Point(341, 500);
            this.problemTextBox.Name = "problemTextBox";
            this.problemTextBox.Size = new System.Drawing.Size(145, 28);
            this.problemTextBox.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "Patient ID:";
            // 
            // patientIdTextBox
            // 
            this.patientIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIdTextBox.Location = new System.Drawing.Point(654, 384);
            this.patientIdTextBox.Name = "patientIdTextBox";
            this.patientIdTextBox.Size = new System.Drawing.Size(145, 28);
            this.patientIdTextBox.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 51;
            this.label3.Text = "Patient Name:";
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameTextBox.Location = new System.Drawing.Point(654, 426);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(145, 28);
            this.patientNameTextBox.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(339, 423);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(147, 22);
            this.dateTimePicker.TabIndex = 54;
            // 
            // MakeAppoinmentPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 632);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patientIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.problemTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.makeAppointmentButton);
            this.Controls.Add(this.selectShiftLabel);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.selectShiftComboBox);
            this.Controls.Add(this.doctorNameTextBox);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.doctorSearchTextBox);
            this.Controls.Add(this.searchDoctorLabel);
            this.Controls.Add(this.doctorsListLabel);
            this.Controls.Add(this.ehealthcareLabel);
            this.Controls.Add(this.doctorDataGridView);
            this.Name = "MakeAppoinmentPanel";
            this.Text = "MakeAppoinmentPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MakeAppoinmentPanel_FormClosing);
            this.Load += new System.EventHandler(this.MakeAppoinmentPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView doctorDataGridView;
        private System.Windows.Forms.Label ehealthcareLabel;
        private System.Windows.Forms.Label doctorsListLabel;
        private System.Windows.Forms.Label searchDoctorLabel;
        private System.Windows.Forms.TextBox doctorSearchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.TextBox doctorNameTextBox;
        private System.Windows.Forms.ComboBox selectShiftComboBox;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label selectShiftLabel;
        private System.Windows.Forms.Button makeAppointmentButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox problemTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patientIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}