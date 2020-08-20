namespace HotelDatabase
{
    partial class Room
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
            this.reservationInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RUpdateButton = new System.Windows.Forms.Button();
            this.RDeleteButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.reservation_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RID_textBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            reservation_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reservation_IDLabel
            // 
            reservation_IDLabel.AutoSize = true;
            reservation_IDLabel.Location = new System.Drawing.Point(508, 26);
            reservation_IDLabel.Name = "reservation_IDLabel";
            reservation_IDLabel.Size = new System.Drawing.Size(81, 13);
            reservation_IDLabel.TabIndex = 6;
            reservation_IDLabel.Text = "Reservation ID:";
            // 
            // RUpdateButton
            // 
            this.RUpdateButton.Location = new System.Drawing.Point(261, 174);
            this.RUpdateButton.Name = "RUpdateButton";
            this.RUpdateButton.Size = new System.Drawing.Size(83, 24);
            this.RUpdateButton.TabIndex = 2;
            this.RUpdateButton.Text = "Update";
            this.RUpdateButton.UseVisualStyleBackColor = true;
            this.RUpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // RDeleteButton
            // 
            this.RDeleteButton.Location = new System.Drawing.Point(399, 22);
            this.RDeleteButton.Name = "RDeleteButton";
            this.RDeleteButton.Size = new System.Drawing.Size(83, 24);
            this.RDeleteButton.TabIndex = 4;
            this.RDeleteButton.Text = "Delete";
            this.RDeleteButton.UseVisualStyleBackColor = true;
            this.RDeleteButton.Click += new System.EventHandler(this.RDeleteButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 20);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 34);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Main";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Room # :";
            // 
            // RID_textBox
            // 
            this.RID_textBox.Location = new System.Drawing.Point(199, 25);
            this.RID_textBox.Name = "RID_textBox";
            this.RID_textBox.Size = new System.Drawing.Size(100, 20);
            this.RID_textBox.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(586, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Room # :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(81, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Floor :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(270, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bed Type:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(242, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Smoking";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(466, 129);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(330, 69);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Room Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Description:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 24);
            this.button1.TabIndex = 23;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 24);
            this.button2.TabIndex = 24;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(692, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 24);
            this.button3.TabIndex = 25;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 264);
            this.dataGridView1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Start Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(586, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(586, 80);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "End Date:";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 485);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.RID_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(reservation_IDLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RDeleteButton);
            this.Controls.Add(this.RUpdateButton);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

//        private Hotel_DatabaseDataSet1 hotel_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource reservationInfoBindingSource;
//        private Hotel_DatabaseDataSet1TableAdapters.Reservation_InfoTableAdapter reservation_InfoTableAdapter;
        private System.Windows.Forms.Button RUpdateButton;
        private System.Windows.Forms.Button RDeleteButton;
        private System.Windows.Forms.Button BackButton;
//        private Hotel_DatabaseDataSet3 hotel_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource reservation_InfoBindingSource;
//        private Hotel_DatabaseDataSet3TableAdapters.Reservation_InfoTableAdapter reservation_InfoTableAdapter1;
//        private Hotel_DatabaseDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
//        private System.Windows.Forms.TextBox reservation_IDTextBox;
        private System.Windows.Forms.BindingSource roomInfoBindingSource;
//        private Hotel_DatabaseDataSet3TableAdapters.Room_InfoTableAdapter room_InfoTableAdapter;
//        private System.Windows.Forms.DataGridView room_InfoDataGridView;
 //       private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
 //       private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
//        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
//        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
//        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
/**        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBox1;**/
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RID_textBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
    }
}