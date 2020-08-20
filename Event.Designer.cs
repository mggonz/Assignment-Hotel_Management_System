namespace HotelDatabase
{
    partial class Event
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
            System.Windows.Forms.Label enumLabel;
            System.Windows.Forms.Label room_numLabel;
            System.Windows.Forms.Label eNameLabel;
            System.Windows.Forms.Label eDateLabel;
            System.Windows.Forms.Label start_TimeLabel;
            System.Windows.Forms.Label end_TimeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label mInitLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label eContactPhoneLabel;
            System.Windows.Forms.Label emp_IDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.reservationInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RUpdateButton = new System.Windows.Forms.Button();
            this.EAddButton = new System.Windows.Forms.Button();
            this.RDeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.reservation_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.event_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.event_InfoDataGridView = new System.Windows.Forms.DataGridView();
            this.enumTextBox = new System.Windows.Forms.TextBox();
            this.room_numTextBox = new System.Windows.Forms.TextBox();
            this.eNameTextBox = new System.Windows.Forms.TextBox();
            this.eDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.start_TimeTextBox = new System.Windows.Forms.TextBox();
            this.end_TimeTextBox = new System.Windows.Forms.TextBox();
            this.eContactFNameTextBox = new System.Windows.Forms.TextBox();
            this.eContactMInitTextBox = new System.Windows.Forms.TextBox();
            this.eContactLNameTextBox = new System.Windows.Forms.TextBox();
            this.eContactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.emp_IDTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            enumLabel = new System.Windows.Forms.Label();
            room_numLabel = new System.Windows.Forms.Label();
            eNameLabel = new System.Windows.Forms.Label();
            eDateLabel = new System.Windows.Forms.Label();
            start_TimeLabel = new System.Windows.Forms.Label();
            end_TimeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            mInitLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            eContactPhoneLabel = new System.Windows.Forms.Label();
            emp_IDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_InfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // enumLabel
            // 
            enumLabel.AutoSize = true;
            enumLabel.Location = new System.Drawing.Point(52, 99);
            enumLabel.Name = "enumLabel";
            enumLabel.Size = new System.Drawing.Size(48, 13);
            enumLabel.TabIndex = 7;
            enumLabel.Text = "Event #:";
            // 
            // room_numLabel
            // 
            room_numLabel.AutoSize = true;
            room_numLabel.Location = new System.Drawing.Point(39, 125);
            room_numLabel.Name = "room_numLabel";
            room_numLabel.Size = new System.Drawing.Size(61, 13);
            room_numLabel.TabIndex = 9;
            room_numLabel.Text = "Room num:";
            // 
            // eNameLabel
            // 
            eNameLabel.AutoSize = true;
            eNameLabel.Location = new System.Drawing.Point(55, 151);
            eNameLabel.Name = "eNameLabel";
            eNameLabel.Size = new System.Drawing.Size(38, 13);
            eNameLabel.TabIndex = 11;
            eNameLabel.Text = "Name:";
            // 
            // eDateLabel
            // 
            eDateLabel.AutoSize = true;
            eDateLabel.Location = new System.Drawing.Point(60, 178);
            eDateLabel.Name = "eDateLabel";
            eDateLabel.Size = new System.Drawing.Size(33, 13);
            eDateLabel.TabIndex = 13;
            eDateLabel.Text = "Date:";
            // 
            // start_TimeLabel
            // 
            start_TimeLabel.AutoSize = true;
            start_TimeLabel.Location = new System.Drawing.Point(42, 201);
            start_TimeLabel.Name = "start_TimeLabel";
            start_TimeLabel.Size = new System.Drawing.Size(58, 13);
            start_TimeLabel.TabIndex = 15;
            start_TimeLabel.Text = "Start Time:";
            // 
            // end_TimeLabel
            // 
            end_TimeLabel.AutoSize = true;
            end_TimeLabel.Location = new System.Drawing.Point(45, 225);
            end_TimeLabel.Name = "end_TimeLabel";
            end_TimeLabel.Size = new System.Drawing.Size(55, 13);
            end_TimeLabel.TabIndex = 17;
            end_TimeLabel.Text = "End Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(9, 255);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 16);
            label1.TabIndex = 25;
            label1.Text = "Contact Information";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(29, 330);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(61, 13);
            lNameLabel.TabIndex = 28;
            lNameLabel.Text = "Last Name:";
            // 
            // mInitLabel
            // 
            mInitLabel.AutoSize = true;
            mInitLabel.Location = new System.Drawing.Point(22, 304);
            mInitLabel.Name = "mInitLabel";
            mInitLabel.Size = new System.Drawing.Size(68, 13);
            mInitLabel.TabIndex = 27;
            mInitLabel.Text = "Middle Initial:";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(30, 278);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(60, 13);
            fNameLabel.TabIndex = 26;
            fNameLabel.Text = "First Name:";
            // 
            // eContactPhoneLabel
            // 
            eContactPhoneLabel.AutoSize = true;
            eContactPhoneLabel.Location = new System.Drawing.Point(46, 364);
            eContactPhoneLabel.Name = "eContactPhoneLabel";
            eContactPhoneLabel.Size = new System.Drawing.Size(44, 13);
            eContactPhoneLabel.TabIndex = 28;
            eContactPhoneLabel.Text = " Phone:";
            // 
            // emp_IDLabel
            // 
            emp_IDLabel.AutoSize = true;
            emp_IDLabel.Location = new System.Drawing.Point(47, 397);
            emp_IDLabel.Name = "emp_IDLabel";
            emp_IDLabel.Size = new System.Drawing.Size(45, 13);
            emp_IDLabel.TabIndex = 29;
            emp_IDLabel.Text = "Emp ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(304, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 13);
            label2.TabIndex = 31;
            label2.Text = "Event #:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(8, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(152, 20);
            label3.TabIndex = 34;
            label3.Text = "Event Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 450);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 13);
            label4.TabIndex = 36;
            label4.Text = "Description:";
            // 
            // RUpdateButton
            // 
            this.RUpdateButton.Location = new System.Drawing.Point(570, 12);
            this.RUpdateButton.Name = "RUpdateButton";
            this.RUpdateButton.Size = new System.Drawing.Size(104, 24);
            this.RUpdateButton.TabIndex = 2;
            this.RUpdateButton.Text = "Update";
            this.RUpdateButton.UseVisualStyleBackColor = true;
            this.RUpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EAddButton
            // 
            this.EAddButton.Location = new System.Drawing.Point(75, 529);
            this.EAddButton.Name = "EAddButton";
            this.EAddButton.Size = new System.Drawing.Size(131, 34);
            this.EAddButton.TabIndex = 3;
            this.EAddButton.Text = "Add New Event";
            this.EAddButton.UseVisualStyleBackColor = true;
            this.EAddButton.Click += new System.EventHandler(this.EAddButton_Click);
            // 
            // RDeleteButton
            // 
            this.RDeleteButton.Location = new System.Drawing.Point(680, 12);
            this.RDeleteButton.Name = "RDeleteButton";
            this.RDeleteButton.Size = new System.Drawing.Size(104, 24);
            this.RDeleteButton.TabIndex = 4;
            this.RDeleteButton.Text = "Delete";
            this.RDeleteButton.UseVisualStyleBackColor = true;
            this.RDeleteButton.Click += new System.EventHandler(this.RDeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(9, 19);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 34);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Main";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // event_InfoDataGridView
            // 
            this.event_InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.event_InfoDataGridView.Location = new System.Drawing.Point(314, 82);
            this.event_InfoDataGridView.Name = "event_InfoDataGridView";
            this.event_InfoDataGridView.Size = new System.Drawing.Size(527, 507);
            this.event_InfoDataGridView.TabIndex = 7;
            // 
            // enumTextBox
            // 
            this.enumTextBox.Location = new System.Drawing.Point(106, 96);
            this.enumTextBox.Name = "enumTextBox";
            this.enumTextBox.Size = new System.Drawing.Size(100, 20);
            this.enumTextBox.TabIndex = 8;
            // 
            // room_numTextBox
            // 
            this.room_numTextBox.Location = new System.Drawing.Point(106, 122);
            this.room_numTextBox.Name = "room_numTextBox";
            this.room_numTextBox.Size = new System.Drawing.Size(100, 20);
            this.room_numTextBox.TabIndex = 10;
            // 
            // eNameTextBox
            // 
            this.eNameTextBox.Location = new System.Drawing.Point(106, 148);
            this.eNameTextBox.Name = "eNameTextBox";
            this.eNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.eNameTextBox.TabIndex = 12;
            // 
            // eDateDateTimePicker
            // 
            this.eDateDateTimePicker.Location = new System.Drawing.Point(106, 174);
            this.eDateDateTimePicker.Name = "eDateDateTimePicker";
            this.eDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eDateDateTimePicker.TabIndex = 14;
            // 
            // start_TimeTextBox
            // 
            this.start_TimeTextBox.Location = new System.Drawing.Point(106, 198);
            this.start_TimeTextBox.Name = "start_TimeTextBox";
            this.start_TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.start_TimeTextBox.TabIndex = 16;
            // 
            // end_TimeTextBox
            // 
            this.end_TimeTextBox.Location = new System.Drawing.Point(106, 222);
            this.end_TimeTextBox.Name = "end_TimeTextBox";
            this.end_TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.end_TimeTextBox.TabIndex = 18;
            // 
            // eContactFNameTextBox
            // 
            this.eContactFNameTextBox.Location = new System.Drawing.Point(106, 276);
            this.eContactFNameTextBox.Name = "eContactFNameTextBox";
            this.eContactFNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.eContactFNameTextBox.TabIndex = 20;
            // 
            // eContactMInitTextBox
            // 
            this.eContactMInitTextBox.Location = new System.Drawing.Point(106, 301);
            this.eContactMInitTextBox.Name = "eContactMInitTextBox";
            this.eContactMInitTextBox.Size = new System.Drawing.Size(100, 20);
            this.eContactMInitTextBox.TabIndex = 22;
            // 
            // eContactLNameTextBox
            // 
            this.eContactLNameTextBox.Location = new System.Drawing.Point(106, 332);
            this.eContactLNameTextBox.Name = "eContactLNameTextBox";
            this.eContactLNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.eContactLNameTextBox.TabIndex = 24;
            // 
            // eContactPhoneTextBox
            // 
            this.eContactPhoneTextBox.Location = new System.Drawing.Point(106, 361);
            this.eContactPhoneTextBox.Name = "eContactPhoneTextBox";
            this.eContactPhoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.eContactPhoneTextBox.TabIndex = 29;
            // 
            // emp_IDTextBox
            // 
            this.emp_IDTextBox.Location = new System.Drawing.Point(106, 394);
            this.emp_IDTextBox.Name = "emp_IDTextBox";
            this.emp_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.emp_IDTextBox.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(75, 420);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(210, 85);
            this.richTextBox1.TabIndex = 35;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(307, 44);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 13);
            label5.TabIndex = 37;
            label5.Text = "Emp ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(358, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 24);
            this.button2.TabIndex = 39;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 587);
            this.Controls.Add(this.button2);
            this.Controls.Add(label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(emp_IDLabel);
            this.Controls.Add(this.emp_IDTextBox);
            this.Controls.Add(eContactPhoneLabel);
            this.Controls.Add(this.eContactPhoneTextBox);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(mInitLabel);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(label1);
            this.Controls.Add(this.eContactLNameTextBox);
            this.Controls.Add(this.eContactMInitTextBox);
            this.Controls.Add(this.eContactFNameTextBox);
            this.Controls.Add(end_TimeLabel);
            this.Controls.Add(this.end_TimeTextBox);
            this.Controls.Add(start_TimeLabel);
            this.Controls.Add(this.start_TimeTextBox);
            this.Controls.Add(eDateLabel);
            this.Controls.Add(this.eDateDateTimePicker);
            this.Controls.Add(eNameLabel);
            this.Controls.Add(this.eNameTextBox);
            this.Controls.Add(room_numLabel);
            this.Controls.Add(this.room_numTextBox);
            this.Controls.Add(enumLabel);
            this.Controls.Add(this.enumTextBox);
            this.Controls.Add(this.event_InfoDataGridView);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RDeleteButton);
            this.Controls.Add(this.EAddButton);
            this.Controls.Add(this.RUpdateButton);
            this.Name = "Event";
            this.Text = "Aqua Room Manager - Event";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_InfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

//        private Hotel_DatabaseDataSet1 hotel_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource reservationInfoBindingSource;
//        private Hotel_DatabaseDataSet1TableAdapters.Reservation_InfoTableAdapter reservation_InfoTableAdapter;
        private System.Windows.Forms.Button RUpdateButton;
        private System.Windows.Forms.Button EAddButton;
        private System.Windows.Forms.Button RDeleteButton;
        private System.Windows.Forms.Button BackButton;
//        private System.Windows.Forms.Label labelReservationNum;
//        private Hotel_DatabaseDataSet3 hotel_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource reservation_InfoBindingSource;
//        private Hotel_DatabaseDataSet3TableAdapters.Reservation_InfoTableAdapter reservation_InfoTableAdapter1;
//        private Hotel_DatabaseDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource event_InfoBindingSource;
//        private Hotel_DatabaseDataSet3TableAdapters.Event_InfoTableAdapter event_InfoTableAdapter;
        private System.Windows.Forms.DataGridView event_InfoDataGridView;
 /**       private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;**/
        private System.Windows.Forms.TextBox enumTextBox;
        private System.Windows.Forms.TextBox room_numTextBox;
        private System.Windows.Forms.TextBox eNameTextBox;
        private System.Windows.Forms.DateTimePicker eDateDateTimePicker;
        private System.Windows.Forms.TextBox start_TimeTextBox;
        private System.Windows.Forms.TextBox end_TimeTextBox;
        private System.Windows.Forms.TextBox eContactFNameTextBox;
        private System.Windows.Forms.TextBox eContactMInitTextBox;
        private System.Windows.Forms.TextBox eContactLNameTextBox;
        private System.Windows.Forms.TextBox eContactPhoneTextBox;
        private System.Windows.Forms.TextBox emp_IDTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
    }
}