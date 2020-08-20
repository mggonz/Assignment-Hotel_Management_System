namespace HotelDatabase
{
    partial class Reservation
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
            System.Windows.Forms.Label reservation_IDLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservationInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_DatabaseDataSet_All = new HotelDatabase.Hotel_DatabaseDataSet_All();
            this.reservationInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RUpdateButton = new System.Windows.Forms.Button();
            this.RDeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.labelReservationNum = new System.Windows.Forms.Label();
            this.reservation_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.res_IDTextBox = new System.Windows.Forms.TextBox();
            this.EAddButton = new System.Windows.Forms.Button();
            this.reservation_InfoTableAdapter2 = new HotelDatabase.Hotel_DatabaseDataSet_AllTableAdapters.Reservation_InfoTableAdapter();
            this.RID_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoomNum_textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CMInit_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CFName_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            reservation_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_DatabaseDataSet_All)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_InfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reservation_IDLabel
            // 
            reservation_IDLabel.AutoSize = true;
            reservation_IDLabel.Location = new System.Drawing.Point(228, 31);
            reservation_IDLabel.Name = "reservation_IDLabel";
            reservation_IDLabel.Size = new System.Drawing.Size(81, 13);
            reservation_IDLabel.TabIndex = 6;
            reservation_IDLabel.Text = "Reservation ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reservation ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 258);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reservationInfoBindingSource1
            // 
            this.reservationInfoBindingSource1.DataMember = "Reservation_Info";
            this.reservationInfoBindingSource1.DataSource = this.hotel_DatabaseDataSet_All;
            // 
            // hotel_DatabaseDataSet_All
            // 
            this.hotel_DatabaseDataSet_All.DataSetName = "Hotel_DatabaseDataSet_All";
            this.hotel_DatabaseDataSet_All.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationInfoBindingSource
            // 
            this.reservationInfoBindingSource.DataMember = "Reservation_Info";
            // 
            // RUpdateButton
            // 
            this.RUpdateButton.Location = new System.Drawing.Point(600, 25);
            this.RUpdateButton.Name = "RUpdateButton";
            this.RUpdateButton.Size = new System.Drawing.Size(89, 24);
            this.RUpdateButton.TabIndex = 2;
            this.RUpdateButton.Text = "Update";
            this.RUpdateButton.UseVisualStyleBackColor = true;
            this.RUpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RDeleteButton
            // 
            this.RDeleteButton.Location = new System.Drawing.Point(505, 25);
            this.RDeleteButton.Name = "RDeleteButton";
            this.RDeleteButton.Size = new System.Drawing.Size(89, 24);
            this.RDeleteButton.TabIndex = 4;
            this.RDeleteButton.Text = "Delete";
            this.RDeleteButton.UseVisualStyleBackColor = true;
            this.RDeleteButton.Click += new System.EventHandler(this.RDeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 15);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 34);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Main";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // labelReservationNum
            // 
            this.labelReservationNum.AutoSize = true;
            this.labelReservationNum.Location = new System.Drawing.Point(198, 36);
            this.labelReservationNum.Name = "labelReservationNum";
            this.labelReservationNum.Size = new System.Drawing.Size(0, 13);
            this.labelReservationNum.TabIndex = 6;
            this.labelReservationNum.Click += new System.EventHandler(this.label1_Click);
            // 
            // reservation_InfoBindingSource
            // 
            this.reservation_InfoBindingSource.DataMember = "Reservation_Info";
            // 
            // res_IDTextBox
            // 
            this.res_IDTextBox.Location = new System.Drawing.Point(315, 28);
            this.res_IDTextBox.Name = "res_IDTextBox";
            this.res_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.res_IDTextBox.TabIndex = 7;
            // 
            // EAddButton
            // 
            this.EAddButton.Location = new System.Drawing.Point(665, 131);
            this.EAddButton.Name = "EAddButton";
            this.EAddButton.Size = new System.Drawing.Size(106, 24);
            this.EAddButton.TabIndex = 8;
            this.EAddButton.Text = "New";
            this.EAddButton.UseVisualStyleBackColor = true;
            this.EAddButton.Click += new System.EventHandler(this.EAddButton_Click);
            // 
            // reservation_InfoTableAdapter2
            // 
            this.reservation_InfoTableAdapter2.ClearBeforeFill = true;
            // 
            // RID_textBox1
            // 
            this.RID_textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.reservationInfoBindingSource1, "Reservation_ID", true));
            this.RID_textBox1.Location = new System.Drawing.Point(114, 99);
            this.RID_textBox1.Name = "RID_textBox1";
            this.RID_textBox1.Size = new System.Drawing.Size(100, 20);
            this.RID_textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reservation Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Client Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Room #:";
            // 
            // RoomNum_textBox2
            // 
            this.RoomNum_textBox2.Location = new System.Drawing.Point(114, 125);
            this.RoomNum_textBox2.Name = "RoomNum_textBox2";
            this.RoomNum_textBox2.Size = new System.Drawing.Size(100, 20);
            this.RoomNum_textBox2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Middle Initial:";
            // 
            // CMInit_textBox
            // 
            this.CMInit_textBox.Location = new System.Drawing.Point(481, 128);
            this.CMInit_textBox.MaxLength = 2;
            this.CMInit_textBox.Name = "CMInit_textBox";
            this.CMInit_textBox.Size = new System.Drawing.Size(40, 20);
            this.CMInit_textBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "First Name:";
            // 
            // CFName_textBox
            // 
            this.CFName_textBox.Location = new System.Drawing.Point(481, 102);
            this.CFName_textBox.Name = "CFName_textBox";
            this.CFName_textBox.Size = new System.Drawing.Size(100, 20);
            this.CFName_textBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Phone #:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(481, 181);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Last Name:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(481, 155);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(114, 184);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "End Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Start Date:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 24);
            this.button1.TabIndex = 30;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CMInit_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CFName_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RoomNum_textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RID_textBox1);
            this.Controls.Add(this.EAddButton);
            this.Controls.Add(reservation_IDLabel);
            this.Controls.Add(this.res_IDTextBox);
            this.Controls.Add(this.labelReservationNum);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RDeleteButton);
            this.Controls.Add(this.RUpdateButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_DatabaseDataSet_All)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_InfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
//        private Hotel_DatabaseDataSet1 hotel_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource reservationInfoBindingSource;
 //       private Hotel_DatabaseDataSet1TableAdapters.Reservation_InfoTableAdapter reservation_InfoTableAdapter;
 /**       private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMInitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhoneDataGridViewTextBoxColumn;**/
        private System.Windows.Forms.Button RUpdateButton;
//        private System.Windows.Forms.Button RAddButton;
        private System.Windows.Forms.Button RDeleteButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label labelReservationNum;
//        private Hotel_DatabaseDataSet3 hotel_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource reservation_InfoBindingSource;
//        private Hotel_DatabaseDataSet3TableAdapters.Reservation_InfoTableAdapter reservation_InfoTableAdapter1;
//        private Hotel_DatabaseDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox res_IDTextBox;
        private System.Windows.Forms.Button EAddButton;
        private HotelDatabase.Hotel_DatabaseDataSet_All hotel_DatabaseDataSet_All;
        private System.Windows.Forms.BindingSource reservationInfoBindingSource1;
        private HotelDatabase.Hotel_DatabaseDataSet_AllTableAdapters.Reservation_InfoTableAdapter reservation_InfoTableAdapter2;
        private System.Windows.Forms.TextBox RID_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RoomNum_textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CMInit_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CFName_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}