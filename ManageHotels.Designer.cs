namespace horizon_travels_and_tours
{
    partial class ManageHotels
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridView_hotel = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_hotelId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_deletehm = new System.Windows.Forms.Button();
            this.dateTimePicker2h = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.button_clearhm = new System.Windows.Forms.Button();
            this.button_updatehm = new System.Windows.Forms.Button();
            this.button_uploadh = new System.Windows.Forms.Button();
            this.pictureBox_Hotel = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_hphone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox_hprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1h = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox_hname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_searchhm = new System.Windows.Forms.TextBox();
            this.button_searchm = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_hotel)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 56);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(345, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Hotel Details....!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(281, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DataGridView_hotel
            // 
            this.DataGridView_hotel.AllowUserToAddRows = false;
            this.DataGridView_hotel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_hotel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_hotel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_hotel.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_hotel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_hotel.ColumnHeadersHeight = 24;
            this.DataGridView_hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_hotel.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_hotel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_hotel.Location = new System.Drawing.Point(0, 107);
            this.DataGridView_hotel.Name = "DataGridView_hotel";
            this.DataGridView_hotel.RowHeadersVisible = false;
            this.DataGridView_hotel.RowHeadersWidth = 30;
            this.DataGridView_hotel.RowTemplate.Height = 80;
            this.DataGridView_hotel.Size = new System.Drawing.Size(918, 320);
            this.DataGridView_hotel.TabIndex = 6;
            this.DataGridView_hotel.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_hotel.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_hotel.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_hotel.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_hotel.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_hotel.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.DataGridView_hotel.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_hotel.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_hotel.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_hotel.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_hotel.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_hotel.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_hotel.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_hotel.ThemeStyle.ReadOnly = false;
            this.DataGridView_hotel.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_hotel.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_hotel.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_hotel.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_hotel.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_hotel.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_hotel.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBox_hotelId);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button_deletehm);
            this.panel2.Controls.Add(this.dateTimePicker2h);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.guna2RatingStar1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.textBox_location);
            this.panel2.Controls.Add(this.button_clearhm);
            this.panel2.Controls.Add(this.button_updatehm);
            this.panel2.Controls.Add(this.button_uploadh);
            this.panel2.Controls.Add(this.pictureBox_Hotel);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.textBox_hphone);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.textBox_hprice);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dateTimePicker1h);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.textBox_hname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 276);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(370, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 1);
            this.panel3.TabIndex = 87;
            // 
            // textBox_hotelId
            // 
            this.textBox_hotelId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_hotelId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_hotelId.Location = new System.Drawing.Point(370, 195);
            this.textBox_hotelId.Name = "textBox_hotelId";
            this.textBox_hotelId.Size = new System.Drawing.Size(237, 23);
            this.textBox_hotelId.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(275, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 85;
            this.label9.Text = "Hotel Id:";
            // 
            // button_deletehm
            // 
            this.button_deletehm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_deletehm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_deletehm.FlatAppearance.BorderSize = 0;
            this.button_deletehm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_deletehm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_deletehm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_deletehm.ForeColor = System.Drawing.Color.White;
            this.button_deletehm.Location = new System.Drawing.Point(395, 231);
            this.button_deletehm.Name = "button_deletehm";
            this.button_deletehm.Size = new System.Drawing.Size(111, 33);
            this.button_deletehm.TabIndex = 84;
            this.button_deletehm.Text = "Delete";
            this.button_deletehm.UseVisualStyleBackColor = false;
            this.button_deletehm.Click += new System.EventHandler(this.button_deletehm_Click);
            // 
            // dateTimePicker2h
            // 
            this.dateTimePicker2h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2h.Location = new System.Drawing.Point(520, 151);
            this.dateTimePicker2h.Name = "dateTimePicker2h";
            this.dateTimePicker2h.Size = new System.Drawing.Size(237, 30);
            this.dateTimePicker2h.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(420, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 66;
            this.label3.Text = "Check Out:";
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(517, 37);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(120, 28);
            this.guna2RatingStar1.TabIndex = 65;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(120, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 1);
            this.panel4.TabIndex = 64;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel7.Location = new System.Drawing.Point(0, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(918, 10);
            this.panel7.TabIndex = 51;
            // 
            // textBox_location
            // 
            this.textBox_location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_location.Location = new System.Drawing.Point(120, 75);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.Size = new System.Drawing.Size(634, 23);
            this.textBox_location.TabIndex = 63;
            // 
            // button_clearhm
            // 
            this.button_clearhm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clearhm.BackColor = System.Drawing.Color.Green;
            this.button_clearhm.FlatAppearance.BorderSize = 0;
            this.button_clearhm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_clearhm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clearhm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clearhm.ForeColor = System.Drawing.Color.White;
            this.button_clearhm.Location = new System.Drawing.Point(512, 231);
            this.button_clearhm.Name = "button_clearhm";
            this.button_clearhm.Size = new System.Drawing.Size(111, 33);
            this.button_clearhm.TabIndex = 50;
            this.button_clearhm.Text = "Clear";
            this.button_clearhm.UseVisualStyleBackColor = false;
            this.button_clearhm.Click += new System.EventHandler(this.button_clearhm_Click);
            // 
            // button_updatehm
            // 
            this.button_updatehm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_updatehm.BackColor = System.Drawing.Color.Red;
            this.button_updatehm.FlatAppearance.BorderSize = 0;
            this.button_updatehm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_updatehm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updatehm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updatehm.ForeColor = System.Drawing.Color.White;
            this.button_updatehm.Location = new System.Drawing.Point(278, 231);
            this.button_updatehm.Name = "button_updatehm";
            this.button_updatehm.Size = new System.Drawing.Size(111, 33);
            this.button_updatehm.TabIndex = 49;
            this.button_updatehm.Text = "Update";
            this.button_updatehm.UseVisualStyleBackColor = false;
            this.button_updatehm.Click += new System.EventHandler(this.button_updatehm_Click);
            // 
            // button_uploadh
            // 
            this.button_uploadh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_uploadh.BackColor = System.Drawing.Color.White;
            this.button_uploadh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_uploadh.FlatAppearance.BorderSize = 10;
            this.button_uploadh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_uploadh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_uploadh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_uploadh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_uploadh.Location = new System.Drawing.Point(790, 140);
            this.button_uploadh.Name = "button_uploadh";
            this.button_uploadh.Size = new System.Drawing.Size(111, 33);
            this.button_uploadh.TabIndex = 48;
            this.button_uploadh.Text = "Upload Image";
            this.button_uploadh.UseVisualStyleBackColor = false;
            this.button_uploadh.Click += new System.EventHandler(this.button_uploadh_Click);
            // 
            // pictureBox_Hotel
            // 
            this.pictureBox_Hotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_Hotel.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox_Hotel.Location = new System.Drawing.Point(790, 18);
            this.pictureBox_Hotel.Name = "pictureBox_Hotel";
            this.pictureBox_Hotel.Size = new System.Drawing.Size(111, 116);
            this.pictureBox_Hotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Hotel.TabIndex = 47;
            this.pictureBox_Hotel.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(520, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 1);
            this.panel5.TabIndex = 46;
            // 
            // textBox_hphone
            // 
            this.textBox_hphone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_hphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_hphone.Location = new System.Drawing.Point(517, 115);
            this.textBox_hphone.Name = "textBox_hphone";
            this.textBox_hphone.Size = new System.Drawing.Size(237, 23);
            this.textBox_hphone.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(401, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Phone Number:";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(120, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(237, 1);
            this.panel6.TabIndex = 43;
            // 
            // textBox_hprice
            // 
            this.textBox_hprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_hprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_hprice.Location = new System.Drawing.Point(120, 117);
            this.textBox_hprice.Name = "textBox_hprice";
            this.textBox_hprice.Size = new System.Drawing.Size(237, 23);
            this.textBox_hprice.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(25, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "Price:";
            // 
            // dateTimePicker1h
            // 
            this.dateTimePicker1h.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1h.Location = new System.Drawing.Point(143, 154);
            this.dateTimePicker1h.Name = "dateTimePicker1h";
            this.dateTimePicker1h.Size = new System.Drawing.Size(237, 30);
            this.dateTimePicker1h.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(24, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Check In:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(447, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Rating:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(25, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Location:";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Location = new System.Drawing.Point(120, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(237, 1);
            this.panel8.TabIndex = 29;
            // 
            // textBox_hname
            // 
            this.textBox_hname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_hname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_hname.Location = new System.Drawing.Point(120, 37);
            this.textBox_hname.Name = "textBox_hname";
            this.textBox_hname.Size = new System.Drawing.Size(237, 23);
            this.textBox_hname.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hotel  Name:";
            // 
            // textBox_searchhm
            // 
            this.textBox_searchhm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_searchhm.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_searchhm.Location = new System.Drawing.Point(622, 66);
            this.textBox_searchhm.Name = "textBox_searchhm";
            this.textBox_searchhm.Size = new System.Drawing.Size(166, 30);
            this.textBox_searchhm.TabIndex = 83;
            // 
            // button_searchm
            // 
            this.button_searchm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_searchm.BackColor = System.Drawing.Color.Blue;
            this.button_searchm.FlatAppearance.BorderSize = 0;
            this.button_searchm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_searchm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_searchm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchm.ForeColor = System.Drawing.Color.White;
            this.button_searchm.Location = new System.Drawing.Point(794, 62);
            this.button_searchm.Name = "button_searchm";
            this.button_searchm.Size = new System.Drawing.Size(111, 33);
            this.button_searchm.TabIndex = 82;
            this.button_searchm.Text = "Search";
            this.button_searchm.UseVisualStyleBackColor = false;
            this.button_searchm.Click += new System.EventHandler(this.button_searchm_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // ManageHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 709);
            this.Controls.Add(this.textBox_searchhm);
            this.Controls.Add(this.button_searchm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView_hotel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageHotels";
            this.Text = "ManageHotels";
            this.Load += new System.EventHandler(this.ManageHotels_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_hotel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_hotel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2h;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox_location;
        private System.Windows.Forms.Button button_clearhm;
        private System.Windows.Forms.Button button_updatehm;
        private System.Windows.Forms.Button button_uploadh;
        private System.Windows.Forms.PictureBox pictureBox_Hotel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox_hphone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox_hprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1h;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox_hname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_searchhm;
        private System.Windows.Forms.Button button_searchm;
        private System.Windows.Forms.Button button_deletehm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_hotelId;
        private System.Windows.Forms.Label label9;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}