
namespace Test_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNmae = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.radioButtonTeacher = new System.Windows.Forms.RadioButton();
            this.radioButtonStodent = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.radiobuttenCourse = new System.Windows.Forms.GroupBox();
            this.btnR = new System.Windows.Forms.RadioButton();
            this.btnF = new System.Windows.Forms.RadioButton();
            this.btnJ = new System.Windows.Forms.RadioButton();
            this.btnC = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateOfRegister = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.radiobuttenCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNmae
            // 
            this.txtNmae.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNmae.Location = new System.Drawing.Point(204, 20);
            this.txtNmae.Name = "txtNmae";
            this.txtNmae.Size = new System.Drawing.Size(210, 26);
            this.txtNmae.TabIndex = 0;
            this.txtNmae.TextChanged += new System.EventHandler(this.Nmae1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPassword.Location = new System.Drawing.Point(204, 181);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEmail.Location = new System.Drawing.Point(204, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 26);
            this.txtEmail.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLastName.Location = new System.Drawing.Point(204, 62);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(210, 26);
            this.txtLastName.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name.Image = ((System.Drawing.Image)(resources.GetObject("Name.Image")));
            this.Name.Location = new System.Drawing.Point(87, 20);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(88, 29);
            this.Name.TabIndex = 6;
            this.Name.Text = "Name:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastName.Image = ((System.Drawing.Image)(resources.GetObject("lastName.Image")));
            this.lastName.Location = new System.Drawing.Point(32, 59);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(143, 29);
            this.lastName.TabIndex = 7;
            this.lastName.Text = "Last Name:";
            this.lastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Email.Image = ((System.Drawing.Image)(resources.GetObject("Email.Image")));
            this.Email.Location = new System.Drawing.Point(90, 96);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(85, 29);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Password.Image = ((System.Drawing.Image)(resources.GetObject("Password.Image")));
            this.Password.Location = new System.Drawing.Point(44, 176);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(131, 29);
            this.Password.TabIndex = 9;
            this.Password.Text = "Password:";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // radioButtonTeacher
            // 
            this.radioButtonTeacher.AutoSize = true;
            this.radioButtonTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonTeacher.Location = new System.Drawing.Point(6, 53);
            this.radioButtonTeacher.Name = "radioButtonTeacher";
            this.radioButtonTeacher.Size = new System.Drawing.Size(91, 24);
            this.radioButtonTeacher.TabIndex = 10;
            this.radioButtonTeacher.Text = "Teacher";
            this.radioButtonTeacher.UseVisualStyleBackColor = true;
            this.radioButtonTeacher.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonStodent
            // 
            this.radioButtonStodent.AutoSize = true;
            this.radioButtonStodent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonStodent.Location = new System.Drawing.Point(6, 23);
            this.radioButtonStodent.Name = "radioButtonStodent";
            this.radioButtonStodent.Size = new System.Drawing.Size(87, 24);
            this.radioButtonStodent.TabIndex = 11;
            this.radioButtonStodent.Text = "Student";
            this.radioButtonStodent.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(30, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "My profession";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(310, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.radioButtonStodent);
            this.groupBox1.Controls.Add(this.radioButtonTeacher);
            this.groupBox1.Location = new System.Drawing.Point(37, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chose:";
            // 
            // btnForm2
            // 
            this.btnForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnForm2.Location = new System.Drawing.Point(777, 472);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(163, 75);
            this.btnForm2.TabIndex = 23;
            this.btnForm2.Text = "Show";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(131, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtID.Location = new System.Drawing.Point(204, 142);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(210, 26);
            this.txtID.TabIndex = 24;
            // 
            // radiobuttenCourse
            // 
            this.radiobuttenCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radiobuttenCourse.BackgroundImage")));
            this.radiobuttenCourse.Controls.Add(this.btnR);
            this.radiobuttenCourse.Controls.Add(this.btnF);
            this.radiobuttenCourse.Controls.Add(this.btnJ);
            this.radiobuttenCourse.Controls.Add(this.btnC);
            this.radiobuttenCourse.Location = new System.Drawing.Point(37, 384);
            this.radiobuttenCourse.Name = "radiobuttenCourse";
            this.radiobuttenCourse.Size = new System.Drawing.Size(224, 163);
            this.radiobuttenCourse.TabIndex = 26;
            this.radiobuttenCourse.TabStop = false;
            this.radiobuttenCourse.Text = "course:";
            // 
            // btnR
            // 
            this.btnR.AutoSize = true;
            this.btnR.Location = new System.Drawing.Point(7, 117);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(66, 21);
            this.btnR.TabIndex = 3;
            this.btnR.TabStop = true;
            this.btnR.Text = "React";
            this.btnR.UseVisualStyleBackColor = true;
            // 
            // btnF
            // 
            this.btnF.AutoSize = true;
            this.btnF.Location = new System.Drawing.Point(7, 89);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(90, 21);
            this.btnF.TabIndex = 2;
            this.btnF.TabStop = true;
            this.btnF.Text = "Full Stack";
            this.btnF.UseVisualStyleBackColor = true;
            // 
            // btnJ
            // 
            this.btnJ.AutoSize = true;
            this.btnJ.Location = new System.Drawing.Point(7, 61);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(95, 21);
            this.btnJ.TabIndex = 1;
            this.btnJ.TabStop = true;
            this.btnJ.Text = "JavaScript";
            this.btnJ.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.Location = new System.Drawing.Point(7, 33);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(46, 21);
            this.btnC.TabIndex = 0;
            this.btnC.TabStop = true;
            this.btnC.Text = "C#";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(626, 157);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 48);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(621, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Enter ID to Update or Delete";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(626, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(813, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 48);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dateOfRegister
            // 
            this.dateOfRegister.Location = new System.Drawing.Point(750, 27);
            this.dateOfRegister.Name = "dateOfRegister";
            this.dateOfRegister.Size = new System.Drawing.Size(200, 22);
            this.dateOfRegister.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 573);
            this.Controls.Add(this.dateOfRegister);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.radiobuttenCourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNmae);
            
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.radiobuttenCourse.ResumeLayout(false);
            this.radiobuttenCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNmae;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.RadioButton radioButtonTeacher;
        private System.Windows.Forms.RadioButton radioButtonStodent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox radiobuttenCourse;
        private System.Windows.Forms.RadioButton btnR;
        private System.Windows.Forms.RadioButton btnF;
        private System.Windows.Forms.RadioButton btnJ;
        private System.Windows.Forms.RadioButton btnC;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dateOfRegister;
    }
}

