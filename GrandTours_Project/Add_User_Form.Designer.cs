
namespace GrandTours_Project
{
    partial class Add_User_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_Saverole = new System.Windows.Forms.Button();
            this.tbx_role = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_warnRole = new System.Windows.Forms.Label();
            this.lbl_role_id = new System.Windows.Forms.Label();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_account_id = new System.Windows.Forms.Label();
            this.lbl_warnStatus = new System.Windows.Forms.Label();
            this.lbl_warnPassword = new System.Windows.Forms.Label();
            this.lbl_warnUsername = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_warnAddress = new System.Windows.Forms.Label();
            this.lbl_warnAge = new System.Windows.Forms.Label();
            this.tbx_address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_warnLastname = new System.Windows.Forms.Label();
            this.lbl_warnfirstname = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tbx_lastName = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbx_firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userFormToolStripMenuItem,
            this.roleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 29);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userFormToolStripMenuItem
            // 
            this.userFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.userFormToolStripMenuItem.Name = "userFormToolStripMenuItem";
            this.userFormToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.userFormToolStripMenuItem.Text = "User Form";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // roleToolStripMenuItem
            // 
            this.roleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRoleToolStripMenuItem});
            this.roleToolStripMenuItem.Name = "roleToolStripMenuItem";
            this.roleToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.roleToolStripMenuItem.Text = "Role";
            // 
            // addRoleToolStripMenuItem
            // 
            this.addRoleToolStripMenuItem.Name = "addRoleToolStripMenuItem";
            this.addRoleToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.addRoleToolStripMenuItem.Text = "Add Role";
            this.addRoleToolStripMenuItem.Click += new System.EventHandler(this.addRoleToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 427);
            this.tabControl1.TabIndex = 51;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btn_Saverole);
            this.tabPage2.Controls.Add(this.tbx_role);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(856, 401);
            this.tabPage2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 72);
            this.panel2.TabIndex = 79;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Add Role Form";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(274, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 56;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(242, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(318, 126);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Role";
            this.Column1.HeaderText = "Role Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Edit";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = "Delete";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // btn_Saverole
            // 
            this.btn_Saverole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Saverole.Location = new System.Drawing.Point(438, 182);
            this.btn_Saverole.Name = "btn_Saverole";
            this.btn_Saverole.Size = new System.Drawing.Size(99, 28);
            this.btn_Saverole.TabIndex = 2;
            this.btn_Saverole.Text = "Add";
            this.btn_Saverole.UseVisualStyleBackColor = true;
            this.btn_Saverole.Click += new System.EventHandler(this.btn_Saverole_Click);
            // 
            // tbx_role
            // 
            this.tbx_role.Location = new System.Drawing.Point(274, 131);
            this.tbx_role.Multiline = true;
            this.tbx_role.Name = "tbx_role";
            this.tbx_role.Size = new System.Drawing.Size(263, 37);
            this.tbx_role.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(321, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Company Role";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lbl_warnRole);
            this.tabPage1.Controls.Add(this.lbl_role_id);
            this.tabPage1.Controls.Add(this.cmb_role);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.lbl_account_id);
            this.tabPage1.Controls.Add(this.lbl_warnStatus);
            this.tabPage1.Controls.Add(this.lbl_warnPassword);
            this.tabPage1.Controls.Add(this.lbl_warnUsername);
            this.tabPage1.Controls.Add(this.cmb_status);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tbx_password);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tbx_username);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lbl_warnAddress);
            this.tabPage1.Controls.Add(this.lbl_warnAge);
            this.tabPage1.Controls.Add(this.tbx_address);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbx_age);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbl_warnLastname);
            this.tabPage1.Controls.Add(this.lbl_warnfirstname);
            this.tabPage1.Controls.Add(this.btn_cancel);
            this.tabPage1.Controls.Add(this.tbx_lastName);
            this.tabPage1.Controls.Add(this.btn_save);
            this.tabPage1.Controls.Add(this.tbx_firstName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(856, 401);
            this.tabPage1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 72);
            this.panel1.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Add User Form";
            // 
            // lbl_warnRole
            // 
            this.lbl_warnRole.AutoSize = true;
            this.lbl_warnRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnRole.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnRole.Location = new System.Drawing.Point(339, 309);
            this.lbl_warnRole.Name = "lbl_warnRole";
            this.lbl_warnRole.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnRole.TabIndex = 77;
            this.lbl_warnRole.Text = "!";
            this.lbl_warnRole.Visible = false;
            // 
            // lbl_role_id
            // 
            this.lbl_role_id.AutoSize = true;
            this.lbl_role_id.Location = new System.Drawing.Point(262, 318);
            this.lbl_role_id.Name = "lbl_role_id";
            this.lbl_role_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_role_id.TabIndex = 76;
            // 
            // cmb_role
            // 
            this.cmb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Items.AddRange(new object[] {
            ""});
            this.cmb_role.Location = new System.Drawing.Point(115, 312);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(140, 28);
            this.cmb_role.TabIndex = 5;
            this.cmb_role.SelectedIndexChanged += new System.EventHandler(this.cmb_role_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(58, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 74;
            this.label11.Text = "Role : ";
            // 
            // lbl_account_id
            // 
            this.lbl_account_id.AutoSize = true;
            this.lbl_account_id.Location = new System.Drawing.Point(122, 106);
            this.lbl_account_id.Name = "lbl_account_id";
            this.lbl_account_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_account_id.TabIndex = 73;
            // 
            // lbl_warnStatus
            // 
            this.lbl_warnStatus.AutoSize = true;
            this.lbl_warnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnStatus.Location = new System.Drawing.Point(718, 217);
            this.lbl_warnStatus.Name = "lbl_warnStatus";
            this.lbl_warnStatus.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnStatus.TabIndex = 72;
            this.lbl_warnStatus.Text = "!";
            this.lbl_warnStatus.Visible = false;
            // 
            // lbl_warnPassword
            // 
            this.lbl_warnPassword.AutoSize = true;
            this.lbl_warnPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnPassword.Location = new System.Drawing.Point(718, 172);
            this.lbl_warnPassword.Name = "lbl_warnPassword";
            this.lbl_warnPassword.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnPassword.TabIndex = 71;
            this.lbl_warnPassword.Text = "!";
            this.lbl_warnPassword.Visible = false;
            // 
            // lbl_warnUsername
            // 
            this.lbl_warnUsername.AutoSize = true;
            this.lbl_warnUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnUsername.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnUsername.Location = new System.Drawing.Point(718, 122);
            this.lbl_warnUsername.Name = "lbl_warnUsername";
            this.lbl_warnUsername.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnUsername.TabIndex = 70;
            this.lbl_warnUsername.Text = "!";
            this.lbl_warnUsername.Visible = false;
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Active",
            "Retired",
            "Dismissed"});
            this.cmb_status.Location = new System.Drawing.Point(492, 217);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(140, 28);
            this.cmb_status.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(435, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 68;
            this.label10.Text = "Status : ";
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(492, 171);
            this.tbx_password.Multiline = true;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(220, 31);
            this.tbx_password.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(412, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "Password : ";
            // 
            // tbx_username
            // 
            this.tbx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_username.Location = new System.Drawing.Point(492, 122);
            this.tbx_username.Multiline = true;
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(220, 31);
            this.tbx_username.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(409, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "Username : ";
            // 
            // lbl_warnAddress
            // 
            this.lbl_warnAddress.AutoSize = true;
            this.lbl_warnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnAddress.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnAddress.Location = new System.Drawing.Point(339, 267);
            this.lbl_warnAddress.Name = "lbl_warnAddress";
            this.lbl_warnAddress.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnAddress.TabIndex = 63;
            this.lbl_warnAddress.Text = "!";
            this.lbl_warnAddress.Visible = false;
            // 
            // lbl_warnAge
            // 
            this.lbl_warnAge.AutoSize = true;
            this.lbl_warnAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnAge.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnAge.Location = new System.Drawing.Point(339, 217);
            this.lbl_warnAge.Name = "lbl_warnAge";
            this.lbl_warnAge.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnAge.TabIndex = 62;
            this.lbl_warnAge.Text = "!";
            this.lbl_warnAge.Visible = false;
            // 
            // tbx_address
            // 
            this.tbx_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_address.Location = new System.Drawing.Point(115, 265);
            this.tbx_address.Multiline = true;
            this.tbx_address.Name = "tbx_address";
            this.tbx_address.Size = new System.Drawing.Size(220, 31);
            this.tbx_address.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Address :";
            // 
            // tbx_age
            // 
            this.tbx_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_age.Location = new System.Drawing.Point(115, 217);
            this.tbx_age.Multiline = true;
            this.tbx_age.Name = "tbx_age";
            this.tbx_age.Size = new System.Drawing.Size(60, 31);
            this.tbx_age.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Age :";
            // 
            // lbl_warnLastname
            // 
            this.lbl_warnLastname.AutoSize = true;
            this.lbl_warnLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnLastname.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnLastname.Location = new System.Drawing.Point(339, 172);
            this.lbl_warnLastname.Name = "lbl_warnLastname";
            this.lbl_warnLastname.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnLastname.TabIndex = 57;
            this.lbl_warnLastname.Text = "!";
            this.lbl_warnLastname.Visible = false;
            // 
            // lbl_warnfirstname
            // 
            this.lbl_warnfirstname.AutoSize = true;
            this.lbl_warnfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnfirstname.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnfirstname.Location = new System.Drawing.Point(339, 122);
            this.lbl_warnfirstname.Name = "lbl_warnfirstname";
            this.lbl_warnfirstname.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnfirstname.TabIndex = 56;
            this.lbl_warnfirstname.Text = "!";
            this.lbl_warnfirstname.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(492, 321);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 30);
            this.btn_cancel.TabIndex = 55;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // tbx_lastName
            // 
            this.tbx_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_lastName.Location = new System.Drawing.Point(115, 173);
            this.tbx_lastName.Multiline = true;
            this.tbx_lastName.Name = "tbx_lastName";
            this.tbx_lastName.Size = new System.Drawing.Size(220, 31);
            this.tbx_lastName.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(621, 321);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(91, 30);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_next_Click_1);
            // 
            // tbx_firstName
            // 
            this.tbx_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_firstName.Location = new System.Drawing.Point(115, 122);
            this.tbx_firstName.Multiline = true;
            this.tbx_firstName.Name = "tbx_firstName";
            this.tbx_firstName.Size = new System.Drawing.Size(220, 31);
            this.tbx_firstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Last Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "First Name : ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::GrandTours_Project.Properties.Resources.x_logo3;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(821, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 26);
            this.button2.TabIndex = 80;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(36)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(864, 462);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Add_User_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_User_Form";
            this.Load += new System.EventHandler(this.Add_User_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_account_id;
        private System.Windows.Forms.Label lbl_warnStatus;
        private System.Windows.Forms.Label lbl_warnPassword;
        private System.Windows.Forms.Label lbl_warnUsername;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_warnAddress;
        private System.Windows.Forms.Label lbl_warnAge;
        public System.Windows.Forms.TextBox tbx_address;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbx_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_warnLastname;
        private System.Windows.Forms.Label lbl_warnfirstname;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.TextBox tbx_lastName;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox tbx_firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRoleToolStripMenuItem;
        private System.Windows.Forms.Button btn_Saverole;
        private System.Windows.Forms.TextBox tbx_role;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_role_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_warnRole;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}