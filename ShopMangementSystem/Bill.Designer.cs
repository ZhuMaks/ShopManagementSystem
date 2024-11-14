namespace ShopMangementSystem
{
    partial class Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CusIdCb = new System.Windows.Forms.ComboBox();
            this.ProNameCb = new System.Windows.Forms.ComboBox();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProQuanTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BillIdTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CusNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BillDgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logoutlbl = new System.Windows.Forms.Label();
            this.Billlbl = new System.Windows.Forms.Label();
            this.Productlbl = new System.Windows.Forms.Label();
            this.Customerlbl = new System.Windows.Forms.Label();
            this.CrossBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UPTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductDgv = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(524, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(271, 49);
            this.label1.TabIndex = 28;
            this.label1.Text = "ElectronicStore";
            // 
            // CusIdCb
            // 
            this.CusIdCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CusIdCb.FormattingEnabled = true;
            this.CusIdCb.Location = new System.Drawing.Point(13, 268);
            this.CusIdCb.Name = "CusIdCb";
            this.CusIdCb.Size = new System.Drawing.Size(222, 33);
            this.CusIdCb.TabIndex = 29;
            this.CusIdCb.SelectionChangeCommitted += new System.EventHandler(this.CusIdCb_SelectionChangeCommitted);
            // 
            // ProNameCb
            // 
            this.ProNameCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProNameCb.FormattingEnabled = true;
            this.ProNameCb.Items.AddRange(new object[] {
            "iPhone 14 Pro Max",
            "Samsung Galaxy S23 Ultra",
            "MacBook Air M2",
            "Dell XPS 15",
            "Sony PlayStation 5",
            "Microsoft Xbox Series X",
            "Nintendo Switch OLED",
            "Bose QuietComfort 45",
            "Sony WH-1000XM5",
            "JBL Flip 6",
            "Apple Watch Series 8",
            "Fitbit Charge 5",
            "GoPro HERO10 Black",
            "DJI Mavic Air 2",
            "Kindle Paperwhite",
            "Samsung Galaxy Tab S8",
            "Apple iPad Pro 12.9",
            "Logitech MX Master 3S",
            "Razer DeathAdder V2",
            "ASUS ROG Swift PG259QN",
            "Philips Hue Smart Bulb",
            "Google Nest Hub Max",
            "Amazon Echo Dot (4th Gen)",
            "Ring Video Doorbell 4",
            "Arlo Pro 4 Spotlight Camera",
            "Samsung 55\" QLED 4K Smart TV",
            "LG 48\" OLED C1",
            "Sonos Beam (Gen 2)",
            "NVIDIA Shield TV Pro",
            "AMD Ryzen 9 5950X",
            "Intel Core i9-12900K",
            "Samsung 980 PRO SSD 1TB",
            "WD My Passport 4TB External HDD",
            "Canon EOS R5",
            "Nikon Z7 II",
            "Fujifilm X-T4",
            "Sigma 35mm F1.4 Art DG HSM Lens",
            "Tamron 28-75mm F/2.8 for Sony E",
            "Garmin Fenix 6X Pro",
            "Polar Vantage V2",
            "Anker PowerCore 20100mAh",
            "Belkin Boost Charge 10W Qi Wireless Charging Pad",
            "Corsair K95 RGB Platinum",
            "SteelSeries Arctis Pro Wireless",
            "Oculus Quest 2",
            "HTC Vive Cosmos",
            "Tile Pro (2022)",
            "Xiaomi Mi Electric Scooter Pro 2",
            "Philips Sonicare DiamondClean Smart",
            "Dyson V11 Absolute",
            "Roomba s9+",
            "Netgear Nighthawk AX12",
            "TP-Link Deco X60",
            "Belkin 12-Outlet Power Strip Surge Protector",
            "Apple AirTag",
            "Samsung Portable SSD T7 Touch",
            "Elgato Stream Deck",
            "Wacom Intuos Pro",
            "Blue Yeti USB Microphone",
            "HyperX Cloud II Gaming Headset"});
            this.ProNameCb.Location = new System.Drawing.Point(13, 192);
            this.ProNameCb.Name = "ProNameCb";
            this.ProNameCb.Size = new System.Drawing.Size(222, 33);
            this.ProNameCb.TabIndex = 28;
            // 
            // PriceTb
            // 
            this.PriceTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceTb.Location = new System.Drawing.Point(13, 591);
            this.PriceTb.Multiline = true;
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(222, 27);
            this.PriceTb.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 542);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Size = new System.Drawing.Size(153, 37);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total Price";
            // 
            // ProQuanTb
            // 
            this.ProQuanTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProQuanTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProQuanTb.Location = new System.Drawing.Point(13, 433);
            this.ProQuanTb.Multiline = true;
            this.ProQuanTb.Name = "ProQuanTb";
            this.ProQuanTb.Size = new System.Drawing.Size(222, 27);
            this.ProQuanTb.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Size = new System.Drawing.Size(238, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Product Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Size = new System.Drawing.Size(176, 37);
            this.label9.TabIndex = 22;
            this.label9.Text = "Customer id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Size = new System.Drawing.Size(124, 37);
            this.label8.TabIndex = 20;
            this.label8.Text = "Product";
            // 
            // BillIdTb
            // 
            this.BillIdTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BillIdTb.Location = new System.Drawing.Point(13, 118);
            this.BillIdTb.Multiline = true;
            this.BillIdTb.Name = "BillIdTb";
            this.BillIdTb.Size = new System.Drawing.Size(222, 27);
            this.BillIdTb.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.UPTb);
            this.panel1.Controls.Add(this.CusNameTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CusIdCb);
            this.panel1.Controls.Add(this.ProNameCb);
            this.panel1.Controls.Add(this.PriceTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProQuanTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BillIdTb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 671);
            this.panel1.TabIndex = 31;
            // 
            // CusNameTb
            // 
            this.CusNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CusNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CusNameTb.Location = new System.Drawing.Point(13, 354);
            this.CusNameTb.Multiline = true;
            this.CusNameTb.Name = "CusNameTb";
            this.CusNameTb.Size = new System.Drawing.Size(222, 27);
            this.CusNameTb.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Size = new System.Drawing.Size(226, 37);
            this.label4.TabIndex = 30;
            this.label4.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Size = new System.Drawing.Size(94, 37);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bill id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(95, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Size = new System.Drawing.Size(71, 42);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bill";
            // 
            // BillDgv
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.BillDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.BillDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDgv.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.BillDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDgv.EnableHeadersVisualStyles = false;
            this.BillDgv.Location = new System.Drawing.Point(272, 268);
            this.BillDgv.Name = "BillDgv";
            this.BillDgv.Size = new System.Drawing.Size(686, 284);
            this.BillDgv.TabIndex = 33;
            this.BillDgv.DoubleClick += new System.EventHandler(this.BillDgv_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.Logoutlbl);
            this.panel2.Controls.Add(this.Billlbl);
            this.panel2.Controls.Add(this.Productlbl);
            this.panel2.Controls.Add(this.Customerlbl);
            this.panel2.Location = new System.Drawing.Point(258, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1367, 85);
            this.panel2.TabIndex = 32;
            // 
            // Logoutlbl
            // 
            this.Logoutlbl.AutoSize = true;
            this.Logoutlbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Logoutlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logoutlbl.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logoutlbl.ForeColor = System.Drawing.Color.White;
            this.Logoutlbl.Location = new System.Drawing.Point(1126, 21);
            this.Logoutlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Logoutlbl.Name = "Logoutlbl";
            this.Logoutlbl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Logoutlbl.Size = new System.Drawing.Size(121, 42);
            this.Logoutlbl.TabIndex = 16;
            this.Logoutlbl.Text = "Logout";
            this.Logoutlbl.Click += new System.EventHandler(this.Logoutlbl_Click);
            // 
            // Billlbl
            // 
            this.Billlbl.AutoSize = true;
            this.Billlbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Billlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Billlbl.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Billlbl.ForeColor = System.Drawing.Color.White;
            this.Billlbl.Location = new System.Drawing.Point(862, 21);
            this.Billlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Billlbl.Name = "Billlbl";
            this.Billlbl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Billlbl.Size = new System.Drawing.Size(71, 42);
            this.Billlbl.TabIndex = 15;
            this.Billlbl.Text = "Bill";
            // 
            // Productlbl
            // 
            this.Productlbl.AutoSize = true;
            this.Productlbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Productlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Productlbl.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Productlbl.ForeColor = System.Drawing.Color.White;
            this.Productlbl.Location = new System.Drawing.Point(491, 21);
            this.Productlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Productlbl.Name = "Productlbl";
            this.Productlbl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Productlbl.Size = new System.Drawing.Size(132, 42);
            this.Productlbl.TabIndex = 14;
            this.Productlbl.Text = "Product";
            this.Productlbl.Click += new System.EventHandler(this.Productlbl_Click);
            // 
            // Customerlbl
            // 
            this.Customerlbl.AutoSize = true;
            this.Customerlbl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Customerlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Customerlbl.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Customerlbl.ForeColor = System.Drawing.Color.White;
            this.Customerlbl.Location = new System.Drawing.Point(129, 21);
            this.Customerlbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Customerlbl.Name = "Customerlbl";
            this.Customerlbl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Customerlbl.Size = new System.Drawing.Size(156, 42);
            this.Customerlbl.TabIndex = 13;
            this.Customerlbl.Text = "Customer";
            this.Customerlbl.Click += new System.EventHandler(this.Customerlbl_Click);
            // 
            // CrossBtn
            // 
            this.CrossBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CrossBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrossBtn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrossBtn.ForeColor = System.Drawing.Color.White;
            this.CrossBtn.Location = new System.Drawing.Point(1575, 0);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(50, 42);
            this.CrossBtn.TabIndex = 29;
            this.CrossBtn.Text = "X";
            this.CrossBtn.UseVisualStyleBackColor = false;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetBtn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetBtn.ForeColor = System.Drawing.Color.White;
            this.ResetBtn.Location = new System.Drawing.Point(926, 591);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(186, 42);
            this.ResetBtn.TabIndex = 37;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(272, 591);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(186, 42);
            this.AddBtn.TabIndex = 34;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-283, -228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1908, 959);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // UPTb
            // 
            this.UPTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UPTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UPTb.Location = new System.Drawing.Point(13, 512);
            this.UPTb.Multiline = true;
            this.UPTb.Name = "UPTb";
            this.UPTb.Size = new System.Drawing.Size(222, 27);
            this.UPTb.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 463);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Size = new System.Drawing.Size(146, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "Unit Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(594, 223);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Size = new System.Drawing.Size(71, 42);
            this.label10.TabIndex = 17;
            this.label10.Text = "Bill";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1250, 223);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Size = new System.Drawing.Size(132, 42);
            this.label11.TabIndex = 38;
            this.label11.Text = "Product";
            // 
            // ProductDgv
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ProductDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDgv.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProductDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDgv.EnableHeadersVisualStyles = false;
            this.ProductDgv.Location = new System.Drawing.Point(984, 268);
            this.ProductDgv.Name = "ProductDgv";
            this.ProductDgv.Size = new System.Drawing.Size(621, 284);
            this.ProductDgv.TabIndex = 39;
            this.ProductDgv.DoubleClick += new System.EventHandler(this.ProductDgv_DoubleClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(491, 591);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(186, 42);
            this.UpdateBtn.TabIndex = 40;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelBtn.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(704, 591);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(186, 42);
            this.DelBtn.TabIndex = 41;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 670);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.ProductDgv);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BillDgv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CrossBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CusIdCb;
        private System.Windows.Forms.ComboBox ProNameCb;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProQuanTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BillIdTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView BillDgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Logoutlbl;
        private System.Windows.Forms.Label Billlbl;
        private System.Windows.Forms.Label Productlbl;
        private System.Windows.Forms.Label Customerlbl;
        private System.Windows.Forms.Button CrossBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CusNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UPTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView ProductDgv;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DelBtn;
    }
}