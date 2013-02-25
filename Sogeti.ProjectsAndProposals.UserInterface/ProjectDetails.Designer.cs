namespace Sogeti.ProjectsAndProposals.UserInterface
{
    partial class ProjectDetails
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dtp_revisedDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_endDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.cb_administrator = new System.Windows.Forms.ComboBox();
            this.cb_deliveryManager = new System.Windows.Forms.ComboBox();
            this.cb_accountManager = new System.Windows.Forms.ComboBox();
            this.cb_practitioner = new System.Windows.Forms.ComboBox();
            this.cb_client = new System.Windows.Forms.ComboBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_revisedDate = new System.Windows.Forms.Label();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_administrator = new System.Windows.Forms.Label();
            this.lbl_deliveryManager = new System.Windows.Forms.Label();
            this.lbl_accountManager = new System.Windows.Forms.Label();
            this.lbl_sogetiPractitioner = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_client = new System.Windows.Forms.Label();
            this.lbl_projectName = new System.Windows.Forms.Label();
            this.btn_LoadNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(494, 308);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(97, 35);
            this.btn_exit.TabIndex = 36;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(323, 308);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 35);
            this.btn_cancel.TabIndex = 35;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(154, 308);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(83, 35);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // dtp_revisedDate
            // 
            this.dtp_revisedDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_revisedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_revisedDate.Location = new System.Drawing.Point(131, 244);
            this.dtp_revisedDate.Name = "dtp_revisedDate";
            this.dtp_revisedDate.Size = new System.Drawing.Size(151, 20);
            this.dtp_revisedDate.TabIndex = 33;
            // 
            // dtp_endDate
            // 
            this.dtp_endDate.AllowDrop = true;
            this.dtp_endDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_endDate.Location = new System.Drawing.Point(474, 203);
            this.dtp_endDate.Name = "dtp_endDate";
            this.dtp_endDate.Size = new System.Drawing.Size(157, 20);
            this.dtp_endDate.TabIndex = 31;
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startDate.Location = new System.Drawing.Point(131, 197);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(151, 20);
            this.dtp_startDate.TabIndex = 29;
            // 
            // cb_administrator
            // 
            this.cb_administrator.DisplayMember = "firstName";
            this.cb_administrator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_administrator.FormattingEnabled = true;
            this.cb_administrator.Location = new System.Drawing.Point(474, 150);
            this.cb_administrator.Name = "cb_administrator";
            this.cb_administrator.Size = new System.Drawing.Size(157, 21);
            this.cb_administrator.TabIndex = 28;
            this.cb_administrator.ValueMember = "personID";
            // 
            // cb_deliveryManager
            // 
            this.cb_deliveryManager.DisplayMember = "firstName";
            this.cb_deliveryManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_deliveryManager.FormattingEnabled = true;
            this.cb_deliveryManager.Location = new System.Drawing.Point(131, 150);
            this.cb_deliveryManager.Name = "cb_deliveryManager";
            this.cb_deliveryManager.Size = new System.Drawing.Size(151, 21);
            this.cb_deliveryManager.TabIndex = 25;
            this.cb_deliveryManager.ValueMember = "personID";
            // 
            // cb_accountManager
            // 
            this.cb_accountManager.DisplayMember = "firstName";
            this.cb_accountManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_accountManager.FormattingEnabled = true;
            this.cb_accountManager.Location = new System.Drawing.Point(474, 104);
            this.cb_accountManager.Name = "cb_accountManager";
            this.cb_accountManager.Size = new System.Drawing.Size(157, 21);
            this.cb_accountManager.TabIndex = 23;
            this.cb_accountManager.ValueMember = "personID";
            // 
            // cb_practitioner
            // 
            this.cb_practitioner.DisplayMember = "firstName";
            this.cb_practitioner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_practitioner.FormattingEnabled = true;
            this.cb_practitioner.Location = new System.Drawing.Point(131, 104);
            this.cb_practitioner.Name = "cb_practitioner";
            this.cb_practitioner.Size = new System.Drawing.Size(151, 21);
            this.cb_practitioner.TabIndex = 21;
            this.cb_practitioner.ValueMember = "personID";
            // 
            // cb_client
            // 
            this.cb_client.DisplayMember = "clientName";
            this.cb_client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_client.FormattingEnabled = true;
            this.cb_client.Location = new System.Drawing.Point(474, 14);
            this.cb_client.Name = "cb_client";
            this.cb_client.Size = new System.Drawing.Size(157, 21);
            this.cb_client.TabIndex = 18;
            this.cb_client.ValueMember = "clientID";
            // 
            // tb_description
            // 
            this.tb_description.Location = new System.Drawing.Point(131, 57);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(500, 20);
            this.tb_description.TabIndex = 20;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(131, 14);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(188, 20);
            this.tb_name.TabIndex = 15;
            // 
            // lbl_revisedDate
            // 
            this.lbl_revisedDate.AutoSize = true;
            this.lbl_revisedDate.Location = new System.Drawing.Point(24, 250);
            this.lbl_revisedDate.Name = "lbl_revisedDate";
            this.lbl_revisedDate.Size = new System.Drawing.Size(72, 13);
            this.lbl_revisedDate.TabIndex = 32;
            this.lbl_revisedDate.Text = "Revised Date";
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(364, 209);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(52, 13);
            this.lbl_endDate.TabIndex = 30;
            this.lbl_endDate.Text = "End Date";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(24, 203);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_startDate.TabIndex = 27;
            this.lbl_startDate.Text = "Start Date";
            // 
            // lbl_administrator
            // 
            this.lbl_administrator.AutoSize = true;
            this.lbl_administrator.Location = new System.Drawing.Point(364, 153);
            this.lbl_administrator.Name = "lbl_administrator";
            this.lbl_administrator.Size = new System.Drawing.Size(67, 13);
            this.lbl_administrator.TabIndex = 26;
            this.lbl_administrator.Text = "Administrator";
            // 
            // lbl_deliveryManager
            // 
            this.lbl_deliveryManager.AutoSize = true;
            this.lbl_deliveryManager.Location = new System.Drawing.Point(24, 153);
            this.lbl_deliveryManager.Name = "lbl_deliveryManager";
            this.lbl_deliveryManager.Size = new System.Drawing.Size(90, 13);
            this.lbl_deliveryManager.TabIndex = 24;
            this.lbl_deliveryManager.Text = "Delivery Manager";
            // 
            // lbl_accountManager
            // 
            this.lbl_accountManager.AutoSize = true;
            this.lbl_accountManager.Location = new System.Drawing.Point(364, 107);
            this.lbl_accountManager.Name = "lbl_accountManager";
            this.lbl_accountManager.Size = new System.Drawing.Size(92, 13);
            this.lbl_accountManager.TabIndex = 22;
            this.lbl_accountManager.Text = "Account Manager";
            // 
            // lbl_sogetiPractitioner
            // 
            this.lbl_sogetiPractitioner.AutoSize = true;
            this.lbl_sogetiPractitioner.Location = new System.Drawing.Point(24, 107);
            this.lbl_sogetiPractitioner.Name = "lbl_sogetiPractitioner";
            this.lbl_sogetiPractitioner.Size = new System.Drawing.Size(93, 13);
            this.lbl_sogetiPractitioner.TabIndex = 19;
            this.lbl_sogetiPractitioner.Text = "Sogeti Practitioner";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(24, 60);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(60, 13);
            this.lbl_description.TabIndex = 17;
            this.lbl_description.Text = "Description";
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(364, 17);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(33, 13);
            this.lbl_client.TabIndex = 16;
            this.lbl_client.Text = "Client";
            // 
            // lbl_projectName
            // 
            this.lbl_projectName.AutoSize = true;
            this.lbl_projectName.Location = new System.Drawing.Point(24, 17);
            this.lbl_projectName.Name = "lbl_projectName";
            this.lbl_projectName.Size = new System.Drawing.Size(71, 13);
            this.lbl_projectName.TabIndex = 14;
            this.lbl_projectName.Text = "Project Name";
            // 
            // btn_LoadNext
            // 
            this.btn_LoadNext.Location = new System.Drawing.Point(27, 308);
            this.btn_LoadNext.Name = "btn_LoadNext";
            this.btn_LoadNext.Size = new System.Drawing.Size(83, 35);
            this.btn_LoadNext.TabIndex = 37;
            this.btn_LoadNext.Text = "Load Next";
            this.btn_LoadNext.UseVisualStyleBackColor = true;
            this.btn_LoadNext.Click += new System.EventHandler(this.btn_LoadNext_Click);
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 346);
            this.Controls.Add(this.btn_LoadNext);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dtp_revisedDate);
            this.Controls.Add(this.dtp_endDate);
            this.Controls.Add(this.dtp_startDate);
            this.Controls.Add(this.cb_administrator);
            this.Controls.Add(this.cb_deliveryManager);
            this.Controls.Add(this.cb_accountManager);
            this.Controls.Add(this.cb_practitioner);
            this.Controls.Add(this.cb_client);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_revisedDate);
            this.Controls.Add(this.lbl_endDate);
            this.Controls.Add(this.lbl_startDate);
            this.Controls.Add(this.lbl_administrator);
            this.Controls.Add(this.lbl_deliveryManager);
            this.Controls.Add(this.lbl_accountManager);
            this.Controls.Add(this.lbl_sogetiPractitioner);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.lbl_projectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProjectDetails";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Details";
            this.Load += new System.EventHandler(this.ProjectDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dtp_revisedDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.ComboBox cb_administrator;
        private System.Windows.Forms.ComboBox cb_deliveryManager;
        private System.Windows.Forms.ComboBox cb_accountManager;
        private System.Windows.Forms.ComboBox cb_practitioner;
        private System.Windows.Forms.ComboBox cb_client;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_revisedDate;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.Label lbl_administrator;
        private System.Windows.Forms.Label lbl_deliveryManager;
        private System.Windows.Forms.Label lbl_accountManager;
        private System.Windows.Forms.Label lbl_sogetiPractitioner;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Label lbl_projectName;
        private System.Windows.Forms.Button btn_LoadNext;
    }
}