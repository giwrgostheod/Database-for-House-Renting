﻿namespace _6miniaia
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Advertisements",
            "BusinessOwners",
            "ClientPhones",
            "Clients",
            "Contracts",
            "Employees",
            "Newspapers",
            "OwnerPhones",
            "Owners",
            "PrivateOwners",
            "Properties",
            "PropertyTypes",
            "Visits"});
            this.comboBox1.Location = new System.Drawing.Point(47, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Advertisements",
            "BusinessOwners",
            "ClientPhones",
            "Clients",
            "Contracts",
            "Employees",
            "Newspapers",
            "OwnerPhones",
            "Owners",
            "PrivateOwners",
            "Properties",
            "PropertyTypes",
            "Visits"});
            this.comboBox2.Location = new System.Drawing.Point(47, 199);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Advertisements",
            "BusinessOwners",
            "ClientPhones",
            "Clients",
            "Contracts",
            "Employees",
            "Newspapers",
            "OwnerPhones",
            "Owners",
            "PrivateOwners",
            "Properties",
            "PropertyTypes",
            "Visits"});
            this.comboBox3.Location = new System.Drawing.Point(47, 300);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Choose all the attributes from tables Employees and Properties with Rent>= the nu" +
                "mber you enter",
            "See the advertisments in Newspaper Kathimerinh",
            "See the minimum,maximum and average Rents that are signed in Contracts",
            "See the number of contracts each emplyoee has signed",
            "See the number of Properties have the owners from a choosen number of Properties " +
                "and above",
            "See the summary of cost in Advertisements of Properties equal or above the number" +
                " you choose",
            "See Employees AFM and Salary with Salary greater than a choosen Employee",
            "See all the Visits except the ones that the Client you chose made",
            "Find a Client by his Last Name",
            "Select all the Business Owners and show their AFMs and Properties"});
            this.comboBox4.Location = new System.Drawing.Point(453, 153);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(481, 21);
            this.comboBox4.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(940, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 31);
            this.button4.TabIndex = 7;
            this.button4.Text = "Queries";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(654, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(310, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to Idaniko Spiti";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose a table to make your change:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(676, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose another action:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(393, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ask us:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(940, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 31);
            this.button5.TabIndex = 13;
            this.button5.Text = "Views";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "View1_Updatable",
            "View2_Not_Updatable"});
            this.comboBox5.Location = new System.Drawing.Point(664, 225);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(194, 21);
            this.comboBox5.TabIndex = 14;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 478);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "n";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}

