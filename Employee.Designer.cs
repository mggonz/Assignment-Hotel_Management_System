namespace HotelDatabase
{
    partial class Employee
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
            System.Windows.Forms.Label emp_IDLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label mInitLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label occupationLabel;
            System.Windows.Forms.Label dnumLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.reservationInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BackButton = new System.Windows.Forms.Button();
            this.labelReservationNum = new System.Windows.Forms.Label();
            this.reservation_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RDeleteButton = new System.Windows.Forms.Button();
            this.EAddButton = new System.Windows.Forms.Button();
            this.RUpdateButton = new System.Windows.Forms.Button();
            this.event_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_InfoDataGridView = new System.Windows.Forms.DataGridView();
            this.emp_IDTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.mInitTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.occupationTextBox = new System.Windows.Forms.TextBox();
            this.dnumTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            emp_IDLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            mInitLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            occupationLabel = new System.Windows.Forms.Label();
            dnumLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_InfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // emp_IDLabel
            // 
            emp_IDLabel.AutoSize = true;
            emp_IDLabel.Location = new System.Drawing.Point(50, 263);
            emp_IDLabel.Name = "emp_IDLabel";
            emp_IDLabel.Size = new System.Drawing.Size(70, 13);
            emp_IDLabel.TabIndex = 10;
            emp_IDLabel.Text = "Employee ID:";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(60, 289);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(60, 13);
            fNameLabel.TabIndex = 11;
            fNameLabel.Text = "First Name:";
            // 
            // mInitLabel
            // 
            mInitLabel.AutoSize = true;
            mInitLabel.Location = new System.Drawing.Point(52, 315);
            mInitLabel.Name = "mInitLabel";
            mInitLabel.Size = new System.Drawing.Size(68, 13);
            mInitLabel.TabIndex = 12;
            mInitLabel.Text = "Middle Initial:";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(59, 341);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(61, 13);
            lNameLabel.TabIndex = 13;
            lNameLabel.Text = "Last Name:";
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Location = new System.Drawing.Point(55, 367);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new System.Drawing.Size(65, 13);
            occupationLabel.TabIndex = 14;
            occupationLabel.Text = "Occupation:";
            // 
            // dnumLabel
            // 
            dnumLabel.AutoSize = true;
            dnumLabel.Location = new System.Drawing.Point(45, 393);
            dnumLabel.Name = "dnumLabel";
            dnumLabel.Size = new System.Drawing.Size(75, 13);
            dnumLabel.TabIndex = 16;
            dnumLabel.Text = "Department #:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(30, 232);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(184, 20);
            label1.TabIndex = 18;
            label1.Text = "Employee Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(38, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 13);
            label2.TabIndex = 19;
            label2.Text = "Employee ID:";
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
            // 
            // RDeleteButton
            // 
            this.RDeleteButton.Location = new System.Drawing.Point(96, 160);
            this.RDeleteButton.Name = "RDeleteButton";
            this.RDeleteButton.Size = new System.Drawing.Size(88, 24);
            this.RDeleteButton.TabIndex = 10;
            this.RDeleteButton.Text = "Delete";
            this.RDeleteButton.UseVisualStyleBackColor = true;
            this.RDeleteButton.Click += new System.EventHandler(this.RDeleteButton_Click_1);
            // 
            // EAddButton
            // 
            this.EAddButton.Location = new System.Drawing.Point(83, 429);
            this.EAddButton.Name = "EAddButton";
            this.EAddButton.Size = new System.Drawing.Size(131, 34);
            this.EAddButton.TabIndex = 9;
            this.EAddButton.Text = "Add";
            this.EAddButton.UseVisualStyleBackColor = true;
            this.EAddButton.Click += new System.EventHandler(this.EAddButton_Click);
            // 
            // RUpdateButton
            // 
            this.RUpdateButton.Location = new System.Drawing.Point(96, 130);
            this.RUpdateButton.Name = "RUpdateButton";
            this.RUpdateButton.Size = new System.Drawing.Size(88, 24);
            this.RUpdateButton.TabIndex = 8;
            this.RUpdateButton.Text = "Update";
            this.RUpdateButton.UseVisualStyleBackColor = true;
            this.RUpdateButton.Click += new System.EventHandler(this.RUpdateButton_Click);
            // 
            // employee_InfoDataGridView
            // 
            this.employee_InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_InfoDataGridView.Location = new System.Drawing.Point(304, 15);
            this.employee_InfoDataGridView.Name = "employee_InfoDataGridView";
            this.employee_InfoDataGridView.Size = new System.Drawing.Size(528, 486);
            this.employee_InfoDataGridView.TabIndex = 10;
            // 
            // emp_IDTextBox
            // 
            this.emp_IDTextBox.Location = new System.Drawing.Point(126, 260);
            this.emp_IDTextBox.Name = "emp_IDTextBox";
            this.emp_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.emp_IDTextBox.TabIndex = 11;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.Location = new System.Drawing.Point(127, 286);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fNameTextBox.TabIndex = 12;
            // 
            // mInitTextBox
            // 
            this.mInitTextBox.Location = new System.Drawing.Point(127, 312);
            this.mInitTextBox.Name = "mInitTextBox";
            this.mInitTextBox.Size = new System.Drawing.Size(100, 20);
            this.mInitTextBox.TabIndex = 13;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.Location = new System.Drawing.Point(126, 338);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lNameTextBox.TabIndex = 14;
            // 
            // occupationTextBox
            // 
            this.occupationTextBox.Location = new System.Drawing.Point(126, 364);
            this.occupationTextBox.Name = "occupationTextBox";
            this.occupationTextBox.Size = new System.Drawing.Size(100, 20);
            this.occupationTextBox.TabIndex = 15;
            // 
            // dnumTextBox
            // 
            this.dnumTextBox.Location = new System.Drawing.Point(126, 390);
            this.dnumTextBox.Name = "dnumTextBox";
            this.dnumTextBox.Size = new System.Drawing.Size(100, 20);
            this.dnumTextBox.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 21;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label1);
            this.Controls.Add(dnumLabel);
            this.Controls.Add(this.dnumTextBox);
            this.Controls.Add(occupationLabel);
            this.Controls.Add(this.occupationTextBox);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(mInitLabel);
            this.Controls.Add(this.mInitTextBox);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(emp_IDLabel);
            this.Controls.Add(this.emp_IDTextBox);
            this.Controls.Add(this.employee_InfoDataGridView);
            this.Controls.Add(this.RDeleteButton);
            this.Controls.Add(this.EAddButton);
            this.Controls.Add(this.RUpdateButton);
            this.Controls.Add(this.labelReservationNum);
            this.Controls.Add(this.BackButton);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservation_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_InfoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

//      private Hotel_DatabaseDataSet1 hotel_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource reservationInfoBindingSource;
//        private Hotel_DatabaseDataSet1TableAdapters.Reservation_InfoTableAdapter reservation_InfoTableAdapter;
//        private System.Windows.Forms.Button RAddButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label labelReservationNum;
 //       private Hotel_DatabaseDataSet3 hotel_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource reservation_InfoBindingSource;
//        private Hotel_DatabaseDataSet3TableAdapters.Reservation_InfoTableAdapter reservation_InfoTableAdapter1;
//        private Hotel_DatabaseDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button RDeleteButton;
        private System.Windows.Forms.Button EAddButton;
        private System.Windows.Forms.Button RUpdateButton;
        private System.Windows.Forms.BindingSource event_InfoBindingSource;
 //       private Hotel_DatabaseDataSet3TableAdapters.Event_InfoTableAdapter event_InfoTableAdapter;
        private System.Windows.Forms.BindingSource employee_InfoBindingSource;
 //       private Hotel_DatabaseDataSet3TableAdapters.Employee_InfoTableAdapter employee_InfoTableAdapter;
        private System.Windows.Forms.DataGridView employee_InfoDataGridView;
/**        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;**/
        private System.Windows.Forms.TextBox emp_IDTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox mInitTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox occupationTextBox;
        private System.Windows.Forms.TextBox dnumTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}