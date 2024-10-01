namespace StudentRegistrationForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label_StudentR = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TextBox_LastN = new TextBox();
            TextBox_FirstN = new TextBox();
            TextBox_MiddleN = new TextBox();
            RadioButton_Male = new RadioButton();
            RadioButton_Female = new RadioButton();
            Combobox_Day = new ComboBox();
            ComboBox_Month = new ComboBox();
            ComboBox_Year = new ComboBox();
            ComboBox_SelectP = new ComboBox();
            Button_Register = new Button();
            Button_Browse = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Label_StudentR
            // 
            Label_StudentR.AutoSize = true;
            Label_StudentR.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Label_StudentR.Location = new Point(8, 9);
            Label_StudentR.Name = "Label_StudentR";
            Label_StudentR.Size = new Size(243, 25);
            Label_StudentR.TabIndex = 0;
            Label_StudentR.Text = "Student Registration Form";
            Label_StudentR.Click += Label_StudentR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Last name *";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 101);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "First name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 151);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 4;
            label4.Text = "Middle name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 202);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 5;
            label5.Text = "Gender *";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 226);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 6;
            label6.Text = "Date of birth *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 275);
            label7.Name = "label7";
            label7.Size = new Size(146, 20);
            label7.TabIndex = 7;
            label7.Text = "Program to apply * ";
            label7.Click += label1_Click_1;
            // 
            // TextBox_LastN
            // 
            TextBox_LastN.Location = new Point(14, 72);
            TextBox_LastN.Name = "TextBox_LastN";
            TextBox_LastN.Size = new Size(246, 23);
            TextBox_LastN.TabIndex = 8;
            // 
            // TextBox_FirstN
            // 
            TextBox_FirstN.Location = new Point(12, 125);
            TextBox_FirstN.Name = "TextBox_FirstN";
            TextBox_FirstN.Size = new Size(246, 23);
            TextBox_FirstN.TabIndex = 9;
            // 
            // TextBox_MiddleN
            // 
            TextBox_MiddleN.Location = new Point(12, 175);
            TextBox_MiddleN.Name = "TextBox_MiddleN";
            TextBox_MiddleN.Size = new Size(246, 23);
            TextBox_MiddleN.TabIndex = 10;
            // 
            // RadioButton_Male
            // 
            RadioButton_Male.AutoSize = true;
            RadioButton_Male.Location = new Point(89, 204);
            RadioButton_Male.Name = "RadioButton_Male";
            RadioButton_Male.Size = new Size(51, 19);
            RadioButton_Male.TabIndex = 11;
            RadioButton_Male.TabStop = true;
            RadioButton_Male.Text = "Male";
            RadioButton_Male.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Female
            // 
            RadioButton_Female.AutoSize = true;
            RadioButton_Female.Location = new Point(146, 204);
            RadioButton_Female.Name = "RadioButton_Female";
            RadioButton_Female.Size = new Size(63, 19);
            RadioButton_Female.TabIndex = 12;
            RadioButton_Female.TabStop = true;
            RadioButton_Female.Text = "Female";
            RadioButton_Female.UseVisualStyleBackColor = true;
            // 
            // Combobox_Day
            // 
            Combobox_Day.FormattingEnabled = true;
            Combobox_Day.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            Combobox_Day.Location = new Point(12, 249);
            Combobox_Day.Name = "Combobox_Day";
            Combobox_Day.Size = new Size(65, 23);
            Combobox_Day.TabIndex = 13;
            Combobox_Day.Text = "-Day-";
            // 
            // ComboBox_Month
            // 
            ComboBox_Month.FormattingEnabled = true;
            ComboBox_Month.Items.AddRange(new object[] { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            ComboBox_Month.Location = new Point(83, 249);
            ComboBox_Month.Name = "ComboBox_Month";
            ComboBox_Month.Size = new Size(91, 23);
            ComboBox_Month.TabIndex = 14;
            ComboBox_Month.Text = "-Month-";
            // 
            // ComboBox_Year
            // 
            ComboBox_Year.FormattingEnabled = true;
            ComboBox_Year.Location = new Point(180, 249);
            ComboBox_Year.Name = "ComboBox_Year";
            ComboBox_Year.Size = new Size(78, 23);
            ComboBox_Year.TabIndex = 15;
            ComboBox_Year.Text = "-Year-";
            // 
            // ComboBox_SelectP
            // 
            ComboBox_SelectP.FormattingEnabled = true;
            ComboBox_SelectP.Items.AddRange(new object[] { "BS in Information Technology (BSIT)", "BS in Computer Science (BSCS)", "BS in Information Systems (BSIS)", "BS in Business Administration (BSBA)", "BS in Accountancy (BSA)", "BS in Accounting Information System (BSAIS)", "BS in Management Accounting (BSMA)", "BS in Retail Technology and Consumer Science (BSRTCS)", "BS in Hospitality Management (BSHM)", "BS in Culinary Management (BSCM)", "BA in Communication (BACOMM)", "Bachelor of Multimedia Arts (BMMA)", "Bachelor of Arts in PsychologyBS in Tourism Management (BSTM)" });
            ComboBox_SelectP.Location = new Point(12, 298);
            ComboBox_SelectP.Name = "ComboBox_SelectP";
            ComboBox_SelectP.Size = new Size(248, 23);
            ComboBox_SelectP.TabIndex = 16;
            ComboBox_SelectP.Text = "-Select program-";
            // 
            // Button_Register
            // 
            Button_Register.BackColor = Color.Red;
            Button_Register.FlatStyle = FlatStyle.Flat;
            Button_Register.ForeColor = Color.White;
            Button_Register.Location = new Point(12, 327);
            Button_Register.Name = "Button_Register";
            Button_Register.Size = new Size(162, 35);
            Button_Register.TabIndex = 17;
            Button_Register.Text = "Register Student";
            Button_Register.UseVisualStyleBackColor = false;
            Button_Register.Click += Button_Register_Click;
            // 
            // Button_Browse
            // 
            Button_Browse.Location = new Point(418, 278);
            Button_Browse.Name = "Button_Browse";
            Button_Browse.Size = new Size(134, 31);
            Button_Browse.TabIndex = 18;
            Button_Browse.Text = "Browse";
            Button_Browse.UseVisualStyleBackColor = true;
            Button_Browse.Click += Button_Browse_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(332, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 260);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(705, 432);
            Controls.Add(pictureBox1);
            Controls.Add(Button_Browse);
            Controls.Add(Button_Register);
            Controls.Add(ComboBox_SelectP);
            Controls.Add(ComboBox_Year);
            Controls.Add(ComboBox_Month);
            Controls.Add(Combobox_Day);
            Controls.Add(RadioButton_Female);
            Controls.Add(RadioButton_Male);
            Controls.Add(TextBox_MiddleN);
            Controls.Add(TextBox_FirstN);
            Controls.Add(TextBox_LastN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label_StudentR);
            Name = "Form1";
            Text = "Student Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_StudentR;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TextBox_LastN;
        private TextBox TextBox_FirstN;
        private TextBox TextBox_MiddleN;
        private RadioButton RadioButton_Male;
        private RadioButton RadioButton_Female;
        private ComboBox Combobox_Day;
        private ComboBox ComboBox_Month;
        private ComboBox ComboBox_Year;
        private ComboBox ComboBox_SelectP;
        private Button Button_Register;
        private Button Button_Browse;
        private PictureBox pictureBox1;
    }
}
