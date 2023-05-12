
namespace GrandTours_Project
{
    partial class Update_User_Form
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
            this.lbl_warnRole = new System.Windows.Forms.Label();
            this.lbl_role_id = new System.Windows.Forms.Label();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_account_id = new System.Windows.Forms.Label();
            this.lbl_warnStatus = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_address = new System.Windows.Forms.TextBox();
            this.tbx_age = new System.Windows.Forms.TextBox();
            this.tbx_lastName = new System.Windows.Forms.TextBox();
            this.tbx_firstName = new System.Windows.Forms.TextBox();
            this.lbl_warnAddress = new System.Windows.Forms.Label();
            this.lbl_warnAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_warnLastname = new System.Windows.Forms.Label();
            this.lbl_warnfirstname = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_warnPassword = new System.Windows.Forms.Label();
            this.lbl_warnUsername = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_warnRole
            // 
            this.lbl_warnRole.AutoSize = true;
            this.lbl_warnRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnRole.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnRole.Location = new System.Drawing.Point(333, 271);
            this.lbl_warnRole.Name = "lbl_warnRole";
            this.lbl_warnRole.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnRole.TabIndex = 105;
            this.lbl_warnRole.Text = "!";
            this.lbl_warnRole.Visible = false;
            // 
            // lbl_role_id
            // 
            this.lbl_role_id.AutoSize = true;
            this.lbl_role_id.Location = new System.Drawing.Point(316, 277);
            this.lbl_role_id.Name = "lbl_role_id";
            this.lbl_role_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_role_id.TabIndex = 104;
            // 
            // cmb_role
            // 
            this.cmb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Items.AddRange(new object[] {
            ""});
            this.cmb_role.Location = new System.Drawing.Point(169, 271);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(140, 28);
            this.cmb_role.TabIndex = 103;
            this.cmb_role.SelectedIndexChanged += new System.EventHandler(this.cmb_role_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 102;
            this.label11.Text = "Role : ";
            // 
            // lbl_account_id
            // 
            this.lbl_account_id.AutoSize = true;
            this.lbl_account_id.Location = new System.Drawing.Point(166, 76);
            this.lbl_account_id.Name = "lbl_account_id";
            this.lbl_account_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_account_id.TabIndex = 101;
            // 
            // lbl_warnStatus
            // 
            this.lbl_warnStatus.AutoSize = true;
            this.lbl_warnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnStatus.Location = new System.Drawing.Point(692, 187);
            this.lbl_warnStatus.Name = "lbl_warnStatus";
            this.lbl_warnStatus.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnStatus.TabIndex = 100;
            this.lbl_warnStatus.Text = "!";
            this.lbl_warnStatus.Visible = false;
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Active",
            "Retired",
            "Dismissed"});
            this.cmb_status.Location = new System.Drawing.Point(546, 187);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(140, 28);
            this.cmb_status.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(489, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 96;
            this.label10.Text = "Status : ";
            // 
            // tbx_address
            // 
            this.tbx_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_address.Location = new System.Drawing.Point(169, 224);
            this.tbx_address.Multiline = true;
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(220, 31);
            this.tbx_address.TabIndex = 89;
            // 
            // tbx_age
            // 
            this.tbx_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_age.Location = new System.Drawing.Point(169, 187);
            this.tbx_age.Multiline = true;
            this.tbx_age.Name = "tbx_age";
            this.tbx_age.Size = new System.Drawing.Size(60, 31);
            this.tbx_age.TabIndex = 87;
            // 
            // tbx_lastName
            // 
            this.tbx_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_lastName.Location = new System.Drawing.Point(169, 142);
            this.tbx_lastName.Multiline = true;
            this.tbx_lastName.Name = "tbx_lastName";
            this.tbx_lastName.Size = new System.Drawing.Size(220, 31);
            this.tbx_lastName.TabIndex = 81;
            // 
            // tbx_firstName
            // 
            this.tbx_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_firstName.Location = new System.Drawing.Point(169, 92);
            this.tbx_firstName.Multiline = true;
            this.tbx_firstName.Name = "tbx_firstName";
            this.tbx_firstName.Size = new System.Drawing.Size(220, 31);
            this.tbx_firstName.TabIndex = 79;
            // 
            // lbl_warnAddress
            // 
            this.lbl_warnAddress.AutoSize = true;
            this.lbl_warnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnAddress.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnAddress.Location = new System.Drawing.Point(393, 226);
            this.lbl_warnAddress.Name = "lbl_warnAddress";
            this.lbl_warnAddress.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnAddress.TabIndex = 91;
            this.lbl_warnAddress.Text = "!";
            this.lbl_warnAddress.Visible = false;
            // 
            // lbl_warnAge
            // 
            this.lbl_warnAge.AutoSize = true;
            this.lbl_warnAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnAge.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnAge.Location = new System.Drawing.Point(393, 187);
            this.lbl_warnAge.Name = "lbl_warnAge";
            this.lbl_warnAge.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnAge.TabIndex = 90;
            this.lbl_warnAge.Text = "!";
            this.lbl_warnAge.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 88;
            this.label4.Text = "Address :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 86;
            this.label3.Text = "Age :";
            // 
            // lbl_warnLastname
            // 
            this.lbl_warnLastname.AutoSize = true;
            this.lbl_warnLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnLastname.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnLastname.Location = new System.Drawing.Point(393, 142);
            this.lbl_warnLastname.Name = "lbl_warnLastname";
            this.lbl_warnLastname.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnLastname.TabIndex = 85;
            this.lbl_warnLastname.Text = "!";
            this.lbl_warnLastname.Visible = false;
            // 
            // lbl_warnfirstname
            // 
            this.lbl_warnfirstname.AutoSize = true;
            this.lbl_warnfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnfirstname.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnfirstname.Location = new System.Drawing.Point(393, 92);
            this.lbl_warnfirstname.Name = "lbl_warnfirstname";
            this.lbl_warnfirstname.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnfirstname.TabIndex = 84;
            this.lbl_warnfirstname.Text = "!";
            this.lbl_warnfirstname.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(521, 264);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 30);
            this.btn_cancel.TabIndex = 83;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(650, 264);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 30);
            this.btn_save.TabIndex = 82;
            this.btn_save.Text = "Update";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Last Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "First Name : ";
            // 
            // lbl_warnPassword
            // 
            this.lbl_warnPassword.AutoSize = true;
            this.lbl_warnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnPassword.Location = new System.Drawing.Point(772, 142);
            this.lbl_warnPassword.Name = "lbl_warnPassword";
            this.lbl_warnPassword.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnPassword.TabIndex = 111;
            this.lbl_warnPassword.Text = "!";
            this.lbl_warnPassword.Visible = false;
            // 
            // lbl_warnUsername
            // 
            this.lbl_warnUsername.AutoSize = true;
            this.lbl_warnUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnUsername.Location = new System.Drawing.Point(772, 92);
            this.lbl_warnUsername.Name = "lbl_warnUsername";
            this.lbl_warnUsername.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnUsername.TabIndex = 110;
            this.lbl_warnUsername.Text = "!";
            this.lbl_warnUsername.Visible = false;
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(546, 141);
            this.tbx_password.Multiline = true;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(220, 31);
            this.tbx_password.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(466, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 108;
            this.label9.Text = "Password : ";
            // 
            // tbx_username
            // 
            this.tbx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_username.Location = new System.Drawing.Point(546, 92);
            this.tbx_username.Multiline = true;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(220, 31);
            this.tbx_username.TabIndex = 107;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 106;
            this.label8.Text = "Username : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 73);
            this.panel1.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(37, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 34);
            this.label5.TabIndex = 113;
            this.label5.Text = "Update ";
            // 
            // Update_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_warnPassword);
            this.Controls.Add(this.lbl_warnUsername);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_warnRole);
            this.Controls.Add(this.lbl_role_id);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_account_id);
            this.Controls.Add(this.lbl_warnStatus);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_address);
            this.Controls.Add(this.tbx_age);
            this.Controls.Add(this.tbx_lastName);
            this.Controls.Add(this.tbx_firstName);
            this.Controls.Add(this.lbl_warnAddress);
            this.Controls.Add(this.lbl_warnAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_warnLastname);
            this.Controls.Add(this.lbl_warnfirstname);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_User_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_User_Form";
            this.Load += new System.EventHandler(this.Update_User_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_warnRole;
        private System.Windows.Forms.Label lbl_role_id;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_account_id;
        private System.Windows.Forms.Label lbl_warnStatus;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbx_address;
        public System.Windows.Forms.TextBox tbx_age;
        public System.Windows.Forms.TextBox tbx_lastName;
        public System.Windows.Forms.TextBox tbx_firstName;
        private System.Windows.Forms.Label lbl_warnAddress;
        private System.Windows.Forms.Label lbl_warnAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_warnLastname;
        private System.Windows.Forms.Label lbl_warnfirstname;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_warnPassword;
        private System.Windows.Forms.Label lbl_warnUsername;
        public System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}