namespace AirlineApplication
{
    partial class BookTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTicket));
            this.bookTicketTabs = new System.Windows.Forms.TabControl();
            this.selectFlightTab = new System.Windows.Forms.TabPage();
            this.bookTicketGridView = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bookTicketTab = new System.Windows.Forms.TabPage();
            this.passengerFullNameLabel = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.flightIdLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ticketIdLabel = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passengerIdLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.airplaneLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.seatLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.seat18 = new System.Windows.Forms.Button();
            this.seat17 = new System.Windows.Forms.Button();
            this.seat16 = new System.Windows.Forms.Button();
            this.seat15 = new System.Windows.Forms.Button();
            this.seat14 = new System.Windows.Forms.Button();
            this.seat13 = new System.Windows.Forms.Button();
            this.seat12 = new System.Windows.Forms.Button();
            this.seat11 = new System.Windows.Forms.Button();
            this.seat10 = new System.Windows.Forms.Button();
            this.seat9 = new System.Windows.Forms.Button();
            this.seat8 = new System.Windows.Forms.Button();
            this.seat7 = new System.Windows.Forms.Button();
            this.seat6 = new System.Windows.Forms.Button();
            this.seat5 = new System.Windows.Forms.Button();
            this.seat4 = new System.Windows.Forms.Button();
            this.seat3 = new System.Windows.Forms.Button();
            this.seat2 = new System.Windows.Forms.Button();
            this.seat1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button37 = new System.Windows.Forms.Button();
            this.submitBookTicketBtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bookTicketTabs.SuspendLayout();
            this.selectFlightTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookTicketGridView)).BeginInit();
            this.bookTicketTab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bookTicketTabs
            // 
            this.bookTicketTabs.Controls.Add(this.selectFlightTab);
            this.bookTicketTabs.Controls.Add(this.bookTicketTab);
            this.bookTicketTabs.Location = new System.Drawing.Point(0, 1);
            this.bookTicketTabs.Name = "bookTicketTabs";
            this.bookTicketTabs.SelectedIndex = 0;
            this.bookTicketTabs.Size = new System.Drawing.Size(860, 485);
            this.bookTicketTabs.TabIndex = 0;
            // 
            // selectFlightTab
            // 
            this.selectFlightTab.BackColor = System.Drawing.Color.CornflowerBlue;
            this.selectFlightTab.Controls.Add(this.bookTicketGridView);
            this.selectFlightTab.Controls.Add(this.logoutBtn);
            this.selectFlightTab.Controls.Add(this.button1);
            this.selectFlightTab.Location = new System.Drawing.Point(4, 22);
            this.selectFlightTab.Name = "selectFlightTab";
            this.selectFlightTab.Padding = new System.Windows.Forms.Padding(3);
            this.selectFlightTab.Size = new System.Drawing.Size(852, 459);
            this.selectFlightTab.TabIndex = 0;
            this.selectFlightTab.Text = "Select Flight";
            // 
            // bookTicketGridView
            // 
            this.bookTicketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookTicketGridView.Location = new System.Drawing.Point(35, 40);
            this.bookTicketGridView.Name = "bookTicketGridView";
            this.bookTicketGridView.Size = new System.Drawing.Size(780, 398);
            this.bookTicketGridView.TabIndex = 48;
            this.bookTicketGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.bookTicketGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(749, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(95, 32);
            this.logoutBtn.TabIndex = 47;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 31);
            this.button1.TabIndex = 46;
            this.button1.Text = "LOAD FLIGHTS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookTicketTab
            // 
            this.bookTicketTab.Controls.Add(this.passengerFullNameLabel);
            this.bookTicketTab.Controls.Add(this.label201);
            this.bookTicketTab.Controls.Add(this.flightIdLabel);
            this.bookTicketTab.Controls.Add(this.label7);
            this.bookTicketTab.Controls.Add(this.ticketIdLabel);
            this.bookTicketTab.Controls.Add(this.departureLabel);
            this.bookTicketTab.Controls.Add(this.destinationLabel);
            this.bookTicketTab.Controls.Add(this.sourceLabel);
            this.bookTicketTab.Controls.Add(this.usernameLabel);
            this.bookTicketTab.Controls.Add(this.passengerIdLabel);
            this.bookTicketTab.Controls.Add(this.button2);
            this.bookTicketTab.Controls.Add(this.costLabel);
            this.bookTicketTab.Controls.Add(this.label6);
            this.bookTicketTab.Controls.Add(this.airplaneLabel);
            this.bookTicketTab.Controls.Add(this.label2);
            this.bookTicketTab.Controls.Add(this.label3);
            this.bookTicketTab.Controls.Add(this.label4);
            this.bookTicketTab.Controls.Add(this.label5);
            this.bookTicketTab.Controls.Add(this.seatLabel);
            this.bookTicketTab.Controls.Add(this.panel2);
            this.bookTicketTab.Controls.Add(this.label8);
            this.bookTicketTab.Controls.Add(this.label9);
            this.bookTicketTab.Controls.Add(this.label10);
            this.bookTicketTab.Controls.Add(this.label11);
            this.bookTicketTab.Controls.Add(this.button37);
            this.bookTicketTab.Controls.Add(this.submitBookTicketBtn);
            this.bookTicketTab.Controls.Add(this.pictureBox4);
            this.bookTicketTab.Location = new System.Drawing.Point(4, 22);
            this.bookTicketTab.Name = "bookTicketTab";
            this.bookTicketTab.Size = new System.Drawing.Size(852, 459);
            this.bookTicketTab.TabIndex = 2;
            this.bookTicketTab.Text = "Book Ticket";
            this.bookTicketTab.UseVisualStyleBackColor = true;
            // 
            // passengerFullNameLabel
            // 
            this.passengerFullNameLabel.AutoSize = true;
            this.passengerFullNameLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerFullNameLabel.Location = new System.Drawing.Point(151, 15);
            this.passengerFullNameLabel.Name = "passengerFullNameLabel";
            this.passengerFullNameLabel.Size = new System.Drawing.Size(14, 19);
            this.passengerFullNameLabel.TabIndex = 126;
            this.passengerFullNameLabel.Text = " ";
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label201.Location = new System.Drawing.Point(24, 15);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(65, 16);
            this.label201.TabIndex = 125;
            this.label201.Text = "Full Name";
            // 
            // flightIdLabel
            // 
            this.flightIdLabel.AutoSize = true;
            this.flightIdLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightIdLabel.Location = new System.Drawing.Point(153, 63);
            this.flightIdLabel.Name = "flightIdLabel";
            this.flightIdLabel.Size = new System.Drawing.Size(12, 16);
            this.flightIdLabel.TabIndex = 124;
            this.flightIdLabel.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 123;
            this.label7.Text = "Flight ID";
            // 
            // ticketIdLabel
            // 
            this.ticketIdLabel.AutoSize = true;
            this.ticketIdLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ticketIdLabel.Location = new System.Drawing.Point(152, 99);
            this.ticketIdLabel.Name = "ticketIdLabel";
            this.ticketIdLabel.Size = new System.Drawing.Size(12, 17);
            this.ticketIdLabel.TabIndex = 122;
            this.ticketIdLabel.Text = " ";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.departureLabel.Location = new System.Drawing.Point(152, 295);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(12, 17);
            this.departureLabel.TabIndex = 121;
            this.departureLabel.Text = " ";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.destinationLabel.Location = new System.Drawing.Point(152, 254);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(12, 17);
            this.destinationLabel.TabIndex = 120;
            this.destinationLabel.Text = " ";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.sourceLabel.Location = new System.Drawing.Point(152, 212);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(12, 17);
            this.sourceLabel.TabIndex = 119;
            this.sourceLabel.Text = " ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.usernameLabel.Location = new System.Drawing.Point(152, 174);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(12, 17);
            this.usernameLabel.TabIndex = 118;
            this.usernameLabel.Text = " ";
            // 
            // passengerIdLabel
            // 
            this.passengerIdLabel.AutoSize = true;
            this.passengerIdLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.passengerIdLabel.Location = new System.Drawing.Point(152, 139);
            this.passengerIdLabel.Name = "passengerIdLabel";
            this.passengerIdLabel.Size = new System.Drawing.Size(12, 17);
            this.passengerIdLabel.TabIndex = 117;
            this.passengerIdLabel.Text = " ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button2.Location = new System.Drawing.Point(320, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 116;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.costLabel.Location = new System.Drawing.Point(152, 337);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(12, 17);
            this.costLabel.TabIndex = 115;
            this.costLabel.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 114;
            this.label6.Text = "Cost";
            // 
            // airplaneLabel
            // 
            this.airplaneLabel.AutoSize = true;
            this.airplaneLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airplaneLabel.Location = new System.Drawing.Point(535, 12);
            this.airplaneLabel.Name = "airplaneLabel";
            this.airplaneLabel.Size = new System.Drawing.Size(14, 19);
            this.airplaneLabel.TabIndex = 111;
            this.airplaneLabel.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 110;
            this.label2.Text = "Airplane";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 108;
            this.label4.Text = "Passenger ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 107;
            this.label5.Text = "Ticket ID";
            // 
            // seatLabel
            // 
            this.seatLabel.AutoSize = true;
            this.seatLabel.Location = new System.Drawing.Point(152, 382);
            this.seatLabel.Name = "seatLabel";
            this.seatLabel.Size = new System.Drawing.Size(10, 13);
            this.seatLabel.TabIndex = 103;
            this.seatLabel.Text = " ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.seat18);
            this.panel2.Controls.Add(this.seat17);
            this.panel2.Controls.Add(this.seat16);
            this.panel2.Controls.Add(this.seat15);
            this.panel2.Controls.Add(this.seat14);
            this.panel2.Controls.Add(this.seat13);
            this.panel2.Controls.Add(this.seat12);
            this.panel2.Controls.Add(this.seat11);
            this.panel2.Controls.Add(this.seat10);
            this.panel2.Controls.Add(this.seat9);
            this.panel2.Controls.Add(this.seat8);
            this.panel2.Controls.Add(this.seat7);
            this.panel2.Controls.Add(this.seat6);
            this.panel2.Controls.Add(this.seat5);
            this.panel2.Controls.Add(this.seat4);
            this.panel2.Controls.Add(this.seat3);
            this.panel2.Controls.Add(this.seat2);
            this.panel2.Controls.Add(this.seat1);
            this.panel2.Location = new System.Drawing.Point(517, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 383);
            this.panel2.TabIndex = 102;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // seat18
            // 
            this.seat18.Location = new System.Drawing.Point(223, 305);
            this.seat18.Name = "seat18";
            this.seat18.Size = new System.Drawing.Size(75, 23);
            this.seat18.TabIndex = 17;
            this.seat18.Text = "Seat18";
            this.seat18.UseVisualStyleBackColor = true;
            this.seat18.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat17
            // 
            this.seat17.Location = new System.Drawing.Point(124, 305);
            this.seat17.Name = "seat17";
            this.seat17.Size = new System.Drawing.Size(75, 23);
            this.seat17.TabIndex = 16;
            this.seat17.Text = "Seat17";
            this.seat17.UseVisualStyleBackColor = true;
            this.seat17.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat16
            // 
            this.seat16.Location = new System.Drawing.Point(22, 305);
            this.seat16.Name = "seat16";
            this.seat16.Size = new System.Drawing.Size(75, 23);
            this.seat16.TabIndex = 15;
            this.seat16.Text = "Seat16";
            this.seat16.UseVisualStyleBackColor = true;
            this.seat16.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat15
            // 
            this.seat15.Location = new System.Drawing.Point(223, 251);
            this.seat15.Name = "seat15";
            this.seat15.Size = new System.Drawing.Size(75, 23);
            this.seat15.TabIndex = 14;
            this.seat15.Text = "Seat15";
            this.seat15.UseVisualStyleBackColor = true;
            this.seat15.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat14
            // 
            this.seat14.Location = new System.Drawing.Point(124, 251);
            this.seat14.Name = "seat14";
            this.seat14.Size = new System.Drawing.Size(75, 23);
            this.seat14.TabIndex = 13;
            this.seat14.Text = "Seat14";
            this.seat14.UseVisualStyleBackColor = true;
            this.seat14.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat13
            // 
            this.seat13.Location = new System.Drawing.Point(22, 251);
            this.seat13.Name = "seat13";
            this.seat13.Size = new System.Drawing.Size(75, 23);
            this.seat13.TabIndex = 12;
            this.seat13.Text = "Seat13";
            this.seat13.UseVisualStyleBackColor = true;
            this.seat13.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat12
            // 
            this.seat12.Location = new System.Drawing.Point(223, 195);
            this.seat12.Name = "seat12";
            this.seat12.Size = new System.Drawing.Size(75, 23);
            this.seat12.TabIndex = 11;
            this.seat12.Text = "Seat12";
            this.seat12.UseVisualStyleBackColor = true;
            this.seat12.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat11
            // 
            this.seat11.Location = new System.Drawing.Point(121, 195);
            this.seat11.Name = "seat11";
            this.seat11.Size = new System.Drawing.Size(75, 23);
            this.seat11.TabIndex = 10;
            this.seat11.Text = "Seat11";
            this.seat11.UseVisualStyleBackColor = true;
            this.seat11.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat10
            // 
            this.seat10.Location = new System.Drawing.Point(22, 195);
            this.seat10.Name = "seat10";
            this.seat10.Size = new System.Drawing.Size(75, 23);
            this.seat10.TabIndex = 9;
            this.seat10.Text = "Seat10";
            this.seat10.UseVisualStyleBackColor = true;
            this.seat10.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat9
            // 
            this.seat9.Location = new System.Drawing.Point(223, 138);
            this.seat9.Name = "seat9";
            this.seat9.Size = new System.Drawing.Size(75, 23);
            this.seat9.TabIndex = 8;
            this.seat9.Text = "Seat9";
            this.seat9.UseVisualStyleBackColor = true;
            this.seat9.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat8
            // 
            this.seat8.Location = new System.Drawing.Point(124, 138);
            this.seat8.Name = "seat8";
            this.seat8.Size = new System.Drawing.Size(72, 23);
            this.seat8.TabIndex = 7;
            this.seat8.Text = "Seat8";
            this.seat8.UseVisualStyleBackColor = true;
            this.seat8.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat7
            // 
            this.seat7.Location = new System.Drawing.Point(22, 138);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(75, 23);
            this.seat7.TabIndex = 6;
            this.seat7.Text = "Seat7";
            this.seat7.UseVisualStyleBackColor = true;
            this.seat7.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat6
            // 
            this.seat6.Location = new System.Drawing.Point(223, 83);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(75, 23);
            this.seat6.TabIndex = 5;
            this.seat6.Text = "Seat6";
            this.seat6.UseVisualStyleBackColor = true;
            this.seat6.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat5
            // 
            this.seat5.Location = new System.Drawing.Point(124, 85);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(75, 23);
            this.seat5.TabIndex = 4;
            this.seat5.Text = "Seat5";
            this.seat5.UseVisualStyleBackColor = true;
            this.seat5.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat4
            // 
            this.seat4.Location = new System.Drawing.Point(22, 85);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(75, 23);
            this.seat4.TabIndex = 3;
            this.seat4.Text = "Seat4";
            this.seat4.UseVisualStyleBackColor = true;
            this.seat4.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat3
            // 
            this.seat3.Location = new System.Drawing.Point(223, 31);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(75, 23);
            this.seat3.TabIndex = 2;
            this.seat3.Text = "Seat3";
            this.seat3.UseVisualStyleBackColor = true;
            this.seat3.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat2
            // 
            this.seat2.Location = new System.Drawing.Point(124, 31);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(75, 23);
            this.seat2.TabIndex = 1;
            this.seat2.Text = "Seat2";
            this.seat2.UseVisualStyleBackColor = true;
            this.seat2.Click += new System.EventHandler(this.SeatSelect);
            // 
            // seat1
            // 
            this.seat1.Location = new System.Drawing.Point(22, 31);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(75, 23);
            this.seat1.TabIndex = 0;
            this.seat1.Text = "Seat1";
            this.seat1.UseVisualStyleBackColor = true;
            this.seat1.Click += new System.EventHandler(this.SeatSelect);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 100;
            this.label8.Text = "Seat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 99;
            this.label9.Text = "Departure";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 98;
            this.label10.Text = "To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 97;
            this.label11.Text = "From";
            // 
            // button37
            // 
            this.button37.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.Location = new System.Drawing.Point(189, 412);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(75, 35);
            this.button37.TabIndex = 96;
            this.button37.Text = "Back";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // submitBookTicketBtn
            // 
            this.submitBookTicketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBookTicketBtn.Location = new System.Drawing.Point(76, 412);
            this.submitBookTicketBtn.Name = "submitBookTicketBtn";
            this.submitBookTicketBtn.Size = new System.Drawing.Size(75, 35);
            this.submitBookTicketBtn.TabIndex = 95;
            this.submitBookTicketBtn.Text = "Submit";
            this.submitBookTicketBtn.UseVisualStyleBackColor = true;
            this.submitBookTicketBtn.Click += new System.EventHandler(this.submitBookTicketBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(852, 459);
            this.pictureBox4.TabIndex = 73;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // BookTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(860, 484);
            this.Controls.Add(this.bookTicketTabs);
            this.Name = "BookTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookTicket";
            this.Load += new System.EventHandler(this.BookTicket_Load);
            this.bookTicketTabs.ResumeLayout(false);
            this.selectFlightTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookTicketGridView)).EndInit();
            this.bookTicketTab.ResumeLayout(false);
            this.bookTicketTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl bookTicketTabs;
        private System.Windows.Forms.TabPage selectFlightTab;
        private System.Windows.Forms.TabPage bookTicketTab;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label airplaneLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label seatLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button seat18;
        private System.Windows.Forms.Button seat17;
        private System.Windows.Forms.Button seat16;
        private System.Windows.Forms.Button seat15;
        private System.Windows.Forms.Button seat14;
        private System.Windows.Forms.Button seat13;
        private System.Windows.Forms.Button seat12;
        private System.Windows.Forms.Button seat11;
        private System.Windows.Forms.Button seat10;
        private System.Windows.Forms.Button seat9;
        private System.Windows.Forms.Button seat8;
        private System.Windows.Forms.Button seat7;
        private System.Windows.Forms.Button seat6;
        private System.Windows.Forms.Button seat5;
        private System.Windows.Forms.Button seat4;
        private System.Windows.Forms.Button seat3;
        private System.Windows.Forms.Button seat2;
        private System.Windows.Forms.Button seat1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button submitBookTicketBtn;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView bookTicketGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ticketIdLabel;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passengerIdLabel;
        private System.Windows.Forms.Label flightIdLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.Label passengerFullNameLabel;
    }
}