
namespace E_HealthCare.PresentationLayer
{
    partial class DoctorPanel
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
            this.appoinmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.oldNewTriggerButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.appoinmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.appoinmentPanelButton = new System.Windows.Forms.Button();
            this.profilePanelButton = new System.Windows.Forms.Button();
            this.selector = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.appoinmentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appoinmentsGroupBox
            // 
            this.appoinmentsGroupBox.Controls.Add(this.checkButton);
            this.appoinmentsGroupBox.Controls.Add(this.oldNewTriggerButton);
            this.appoinmentsGroupBox.Controls.Add(this.doneButton);
            this.appoinmentsGroupBox.Controls.Add(this.appoinmentsDataGridView);
            this.appoinmentsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoinmentsGroupBox.Location = new System.Drawing.Point(205, 88);
            this.appoinmentsGroupBox.Name = "appoinmentsGroupBox";
            this.appoinmentsGroupBox.Size = new System.Drawing.Size(413, 274);
            this.appoinmentsGroupBox.TabIndex = 0;
            this.appoinmentsGroupBox.TabStop = false;
            this.appoinmentsGroupBox.Text = "Appoinments";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(174, 223);
            this.checkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(56, 23);
            this.checkButton.TabIndex = 3;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // oldNewTriggerButton
            // 
            this.oldNewTriggerButton.Location = new System.Drawing.Point(5, 224);
            this.oldNewTriggerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oldNewTriggerButton.Name = "oldNewTriggerButton";
            this.oldNewTriggerButton.Size = new System.Drawing.Size(56, 23);
            this.oldNewTriggerButton.TabIndex = 2;
            this.oldNewTriggerButton.Text = "Old";
            this.oldNewTriggerButton.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(332, 224);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // appoinmentsDataGridView
            // 
            this.appoinmentsDataGridView.AllowUserToAddRows = false;
            this.appoinmentsDataGridView.AllowUserToDeleteRows = false;
            this.appoinmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appoinmentsDataGridView.Location = new System.Drawing.Point(5, 20);
            this.appoinmentsDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appoinmentsDataGridView.Name = "appoinmentsDataGridView";
            this.appoinmentsDataGridView.ReadOnly = true;
            this.appoinmentsDataGridView.RowHeadersWidth = 51;
            this.appoinmentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appoinmentsDataGridView.Size = new System.Drawing.Size(404, 199);
            this.appoinmentsDataGridView.TabIndex = 0;
            this.appoinmentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appoinmentsDataGridView_CellContentClick);
            // 
            // appoinmentPanelButton
            // 
            this.appoinmentPanelButton.Location = new System.Drawing.Point(11, 88);
            this.appoinmentPanelButton.Name = "appoinmentPanelButton";
            this.appoinmentPanelButton.Size = new System.Drawing.Size(83, 126);
            this.appoinmentPanelButton.TabIndex = 3;
            this.appoinmentPanelButton.Text = "Appoinments";
            this.appoinmentPanelButton.UseVisualStyleBackColor = true;
            // 
            // profilePanelButton
            // 
            this.profilePanelButton.Location = new System.Drawing.Point(11, 236);
            this.profilePanelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilePanelButton.Name = "profilePanelButton";
            this.profilePanelButton.Size = new System.Drawing.Size(83, 131);
            this.profilePanelButton.TabIndex = 5;
            this.profilePanelButton.Text = "Profile";
            this.profilePanelButton.UseVisualStyleBackColor = true;
            this.profilePanelButton.Click += new System.EventHandler(this.profilePanelButton_Click);
            // 
            // selector
            // 
            this.selector.AutoSize = true;
            this.selector.Location = new System.Drawing.Point(132, 142);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(0, 13);
            this.selector.TabIndex = 6;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(11, 11);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(98, 33);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(511, 14);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(73, 16);
            this.welcomeLabel.TabIndex = 9;
            this.welcomeLabel.Text = "Welcome";
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 378);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.profilePanelButton);
            this.Controls.Add(this.appoinmentPanelButton);
            this.Controls.Add(this.appoinmentsGroupBox);
            this.Name = "DoctorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoctorPanel_FormClosing);
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            this.appoinmentsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appoinmentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox appoinmentsGroupBox;
        private System.Windows.Forms.Button oldNewTriggerButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.DataGridView appoinmentsDataGridView;
        private System.Windows.Forms.Button appoinmentPanelButton;
        private System.Windows.Forms.Button profilePanelButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label selector;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeLabel;
    }
}