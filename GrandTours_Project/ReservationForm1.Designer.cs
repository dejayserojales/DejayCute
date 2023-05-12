
namespace GrandTours_Project
{
    partial class ReservationForm1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_firstName = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.cmb_Destination = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.tbx_lastName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_reserve_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_warnfirstname = new System.Windows.Forms.Label();
            this.lbl_warnLastname = new System.Windows.Forms.Label();
            this.lbl_warndestination = new System.Windows.Forms.Label();
            this.lbl_warndeparturedate = new System.Windows.Forms.Label();
            this.lbl_warndeaparturetime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departure Time  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Destination:";
            // 
            // tbx_firstName
            // 
            this.tbx_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_firstName.Location = new System.Drawing.Point(104, 111);
            this.tbx_firstName.Multiline = true;
            this.tbx_firstName.Name = "tbx_firstName";
            this.tbx_firstName.Size = new System.Drawing.Size(220, 31);
            this.tbx_firstName.TabIndex = 1;
            // 
            // dtp_Date
            // 
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(21, 289);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(134, 20);
            this.dtp_Date.TabIndex = 4;
            // 
            // dtp_Time
            // 
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Time.Location = new System.Drawing.Point(190, 289);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.ShowUpDown = true;
            this.dtp_Time.Size = new System.Drawing.Size(134, 20);
            this.dtp_Time.TabIndex = 5;
            // 
            // cmb_Destination
            // 
            this.cmb_Destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Destination.FormattingEnabled = true;
            this.cmb_Destination.Location = new System.Drawing.Point(104, 214);
            this.cmb_Destination.Name = "cmb_Destination";
            this.cmb_Destination.Size = new System.Drawing.Size(220, 21);
            this.cmb_Destination.TabIndex = 3;
            this.cmb_Destination.SelectedIndexChanged += new System.EventHandler(this.cmb_Destination_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 61);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(64, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reservation Form";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(219, 348);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(102, 43);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // tbx_lastName
            // 
            this.tbx_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_lastName.Location = new System.Drawing.Point(104, 161);
            this.tbx_lastName.Multiline = true;
            this.tbx_lastName.Name = "tbx_lastName";
            this.tbx_lastName.Size = new System.Drawing.Size(220, 31);
            this.tbx_lastName.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_reserve_date
            // 
            this.lbl_reserve_date.AutoSize = true;
            this.lbl_reserve_date.Location = new System.Drawing.Point(258, 73);
            this.lbl_reserve_date.Name = "lbl_reserve_date";
            this.lbl_reserve_date.Size = new System.Drawing.Size(0, 13);
            this.lbl_reserve_date.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_warnfirstname
            // 
            this.lbl_warnfirstname.AutoSize = true;
            this.lbl_warnfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnfirstname.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnfirstname.Location = new System.Drawing.Point(328, 111);
            this.lbl_warnfirstname.Name = "lbl_warnfirstname";
            this.lbl_warnfirstname.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnfirstname.TabIndex = 13;
            this.lbl_warnfirstname.Text = "!";
            // 
            // lbl_warnLastname
            // 
            this.lbl_warnLastname.AutoSize = true;
            this.lbl_warnLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warnLastname.ForeColor = System.Drawing.Color.Red;
            this.lbl_warnLastname.Location = new System.Drawing.Point(328, 161);
            this.lbl_warnLastname.Name = "lbl_warnLastname";
            this.lbl_warnLastname.Size = new System.Drawing.Size(22, 31);
            this.lbl_warnLastname.TabIndex = 14;
            this.lbl_warnLastname.Text = "!";
            // 
            // lbl_warndestination
            // 
            this.lbl_warndestination.AutoSize = true;
            this.lbl_warndestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warndestination.ForeColor = System.Drawing.Color.Red;
            this.lbl_warndestination.Location = new System.Drawing.Point(328, 206);
            this.lbl_warndestination.Name = "lbl_warndestination";
            this.lbl_warndestination.Size = new System.Drawing.Size(22, 31);
            this.lbl_warndestination.TabIndex = 15;
            this.lbl_warndestination.Text = "!";
            // 
            // lbl_warndeparturedate
            // 
            this.lbl_warndeparturedate.AutoSize = true;
            this.lbl_warndeparturedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warndeparturedate.ForeColor = System.Drawing.Color.Red;
            this.lbl_warndeparturedate.Location = new System.Drawing.Point(162, 278);
            this.lbl_warndeparturedate.Name = "lbl_warndeparturedate";
            this.lbl_warndeparturedate.Size = new System.Drawing.Size(22, 31);
            this.lbl_warndeparturedate.TabIndex = 16;
            this.lbl_warndeparturedate.Text = "!";
            // 
            // lbl_warndeaparturetime
            // 
            this.lbl_warndeaparturetime.AutoSize = true;
            this.lbl_warndeaparturetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_warndeaparturetime.ForeColor = System.Drawing.Color.Red;
            this.lbl_warndeaparturetime.Location = new System.Drawing.Point(330, 278);
            this.lbl_warndeaparturetime.Name = "lbl_warndeaparturetime";
            this.lbl_warndeaparturetime.Size = new System.Drawing.Size(22, 31);
            this.lbl_warndeaparturetime.TabIndex = 17;
            this.lbl_warndeaparturetime.Text = "!";
            // 
            // ReservationForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 403);
            this.Controls.Add(this.lbl_warndeaparturetime);
            this.Controls.Add(this.lbl_warndeparturedate);
            this.Controls.Add(this.lbl_warndestination);
            this.Controls.Add(this.lbl_warnLastname);
            this.Controls.Add(this.lbl_warnfirstname);
            this.Controls.Add(this.lbl_reserve_date);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbx_lastName);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_Destination);
            this.Controls.Add(this.dtp_Time);
            this.Controls.Add(this.dtp_Date);
            this.Controls.Add(this.tbx_firstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passenger";
            this.Load += new System.EventHandler(this.ReservationForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox cmb_Destination;
        public System.Windows.Forms.TextBox tbx_firstName;
        public System.Windows.Forms.DateTimePicker dtp_Date;
        public System.Windows.Forms.DateTimePicker dtp_Time;
        public System.Windows.Forms.TextBox tbx_lastName;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbl_reserve_date;
        private System.Windows.Forms.Label lbl_warnfirstname;
        private System.Windows.Forms.Label lbl_warnLastname;
        private System.Windows.Forms.Label lbl_warndestination;
        private System.Windows.Forms.Label lbl_warndeparturedate;
        private System.Windows.Forms.Label lbl_warndeaparturetime;
    }
}