namespace AirlineApplication
{
    partial class PassengerForm
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
            this.viewAirplaneBtn = new System.Windows.Forms.Button();
            this.viewAirports = new System.Windows.Forms.Button();
            this.passengerSearchBtn = new System.Windows.Forms.Button();
            this.passengerSearchTextBox = new System.Windows.Forms.TextBox();
            this.passengerComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.loadBookedFilghts = new System.Windows.Forms.Button();
            this.loadFlightsBtn = new System.Windows.Forms.Button();
            this.bookTicketBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAirplaneBtn
            // 
            this.viewAirplaneBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAirplaneBtn.Location = new System.Drawing.Point(35, 312);
            this.viewAirplaneBtn.Name = "viewAirplaneBtn";
            this.viewAirplaneBtn.Size = new System.Drawing.Size(95, 49);
            this.viewAirplaneBtn.TabIndex = 35;
            this.viewAirplaneBtn.Text = "View Airplanes";
            this.viewAirplaneBtn.UseVisualStyleBackColor = true;
            this.viewAirplaneBtn.Click += new System.EventHandler(this.viewAirplaneBtn_Click);
            // 
            // viewAirports
            // 
            this.viewAirports.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAirports.Location = new System.Drawing.Point(35, 238);
            this.viewAirports.Name = "viewAirports";
            this.viewAirports.Size = new System.Drawing.Size(95, 53);
            this.viewAirports.TabIndex = 34;
            this.viewAirports.Text = "View AirPorts";
            this.viewAirports.UseVisualStyleBackColor = true;
            this.viewAirports.Click += new System.EventHandler(this.viewAirports_Click);
            // 
            // passengerSearchBtn
            // 
            this.passengerSearchBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerSearchBtn.Location = new System.Drawing.Point(263, 44);
            this.passengerSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.passengerSearchBtn.Name = "passengerSearchBtn";
            this.passengerSearchBtn.Size = new System.Drawing.Size(91, 30);
            this.passengerSearchBtn.TabIndex = 33;
            this.passengerSearchBtn.Text = "Search";
            this.passengerSearchBtn.UseVisualStyleBackColor = true;
            this.passengerSearchBtn.Click += new System.EventHandler(this.passengerSearchBtn_Click);
            // 
            // passengerSearchTextBox
            // 
            this.passengerSearchTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerSearchTextBox.Location = new System.Drawing.Point(513, 50);
            this.passengerSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passengerSearchTextBox.Name = "passengerSearchTextBox";
            this.passengerSearchTextBox.Size = new System.Drawing.Size(150, 23);
            this.passengerSearchTextBox.TabIndex = 32;
            this.passengerSearchTextBox.Text = " ";
            // 
            // passengerComboBox
            // 
            this.passengerComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerComboBox.FormattingEnabled = true;
            this.passengerComboBox.Items.AddRange(new object[] {
            "Flight",
            "Airplane",
            "Airport",
            "Booked Flight"});
            this.passengerComboBox.Location = new System.Drawing.Point(384, 50);
            this.passengerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.passengerComboBox.Name = "passengerComboBox";
            this.passengerComboBox.Size = new System.Drawing.Size(103, 22);
            this.passengerComboBox.TabIndex = 31;
            this.passengerComboBox.Text = "Select Item";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(207, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(653, 380);
            this.dataGridView2.TabIndex = 30;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(35, 476);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(95, 27);
            this.logoutBtn.TabIndex = 29;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.button11_Click);
            // 
            // loadBookedFilghts
            // 
            this.loadBookedFilghts.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBookedFilghts.Location = new System.Drawing.Point(35, 170);
            this.loadBookedFilghts.Name = "loadBookedFilghts";
            this.loadBookedFilghts.Size = new System.Drawing.Size(95, 51);
            this.loadBookedFilghts.TabIndex = 28;
            this.loadBookedFilghts.Text = "Load Booked Flight";
            this.loadBookedFilghts.UseVisualStyleBackColor = true;
            this.loadBookedFilghts.Click += new System.EventHandler(this.loadBookedFilghts_Click);
            // 
            // loadFlightsBtn
            // 
            this.loadFlightsBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFlightsBtn.Location = new System.Drawing.Point(35, 114);
            this.loadFlightsBtn.Name = "loadFlightsBtn";
            this.loadFlightsBtn.Size = new System.Drawing.Size(95, 36);
            this.loadFlightsBtn.TabIndex = 27;
            this.loadFlightsBtn.Text = "Load Flights";
            this.loadFlightsBtn.UseVisualStyleBackColor = true;
            this.loadFlightsBtn.Click += new System.EventHandler(this.loadFlightsBtn_Click);
            // 
            // bookTicketBtn
            // 
            this.bookTicketBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTicketBtn.Location = new System.Drawing.Point(35, 56);
            this.bookTicketBtn.Name = "bookTicketBtn";
            this.bookTicketBtn.Size = new System.Drawing.Size(95, 36);
            this.bookTicketBtn.TabIndex = 26;
            this.bookTicketBtn.Text = "Book Ticket";
            this.bookTicketBtn.UseVisualStyleBackColor = true;
            this.bookTicketBtn.Click += new System.EventHandler(this.bookTicketBtn_Click_2);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(35, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 49);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cancel Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(894, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewAirplaneBtn);
            this.Controls.Add(this.viewAirports);
            this.Controls.Add(this.passengerSearchBtn);
            this.Controls.Add(this.passengerSearchTextBox);
            this.Controls.Add(this.passengerComboBox);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.loadBookedFilghts);
            this.Controls.Add(this.loadFlightsBtn);
            this.Controls.Add(this.bookTicketBtn);
            this.Name = "PassengerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengerForm";
            this.Load += new System.EventHandler(this.PassengerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewAirplaneBtn;
        private System.Windows.Forms.Button viewAirports;
        private System.Windows.Forms.Button passengerSearchBtn;
        private System.Windows.Forms.TextBox passengerSearchTextBox;
        private System.Windows.Forms.ComboBox passengerComboBox;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button loadBookedFilghts;
        private System.Windows.Forms.Button loadFlightsBtn;
        private System.Windows.Forms.Button bookTicketBtn;
        private System.Windows.Forms.Button button1;
    }
}