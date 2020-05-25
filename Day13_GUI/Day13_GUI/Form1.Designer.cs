namespace Day13_GUI
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblCourss = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.nameError = new System.Windows.Forms.Label();
            this.surnameError = new System.Windows.Forms.Label();
            this.courseError = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblPrintName = new System.Windows.Forms.Label();
            this.lblPrintSurname = new System.Windows.Forms.Label();
            this.lblPrintCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 21);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(197, 13);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Lūdzu aizpildiet informāciju par studentu:";
            this.lblOutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Vārds";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 96);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(46, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Uzvārds";
            // 
            // lblCourss
            // 
            this.lblCourss.AutoSize = true;
            this.lblCourss.Location = new System.Drawing.Point(12, 146);
            this.lblCourss.Name = "lblCourss";
            this.lblCourss.Size = new System.Drawing.Size(67, 13);
            this.lblCourss.TabIndex = 3;
            this.lblCourss.Text = "Studiju kurss";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(15, 68);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 4;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(15, 113);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 20);
            this.surnameBox.TabIndex = 5;
            this.surnameBox.TextChanged += new System.EventHandler(this.surnameBox_TextChanged);
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(15, 163);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(100, 20);
            this.courseBox.TabIndex = 6;
            this.courseBox.TextChanged += new System.EventHandler(this.courseBox_TextChanged);
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameError.ForeColor = System.Drawing.Color.Crimson;
            this.nameError.Location = new System.Drawing.Point(121, 68);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(14, 18);
            this.nameError.TabIndex = 8;
            this.nameError.Text = "*";
            // 
            // surnameError
            // 
            this.surnameError.AutoSize = true;
            this.surnameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameError.ForeColor = System.Drawing.Color.Crimson;
            this.surnameError.Location = new System.Drawing.Point(121, 113);
            this.surnameError.Name = "surnameError";
            this.surnameError.Size = new System.Drawing.Size(14, 18);
            this.surnameError.TabIndex = 9;
            this.surnameError.Text = "*";
            // 
            // courseError
            // 
            this.courseError.AutoSize = true;
            this.courseError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseError.ForeColor = System.Drawing.Color.Crimson;
            this.courseError.Location = new System.Drawing.Point(121, 163);
            this.courseError.Name = "courseError";
            this.courseError.Size = new System.Drawing.Size(14, 18);
            this.courseError.TabIndex = 10;
            this.courseError.Text = "*";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(15, 202);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblPrintName
            // 
            this.lblPrintName.AutoSize = true;
            this.lblPrintName.Location = new System.Drawing.Point(15, 247);
            this.lblPrintName.Name = "lblPrintName";
            this.lblPrintName.Size = new System.Drawing.Size(37, 13);
            this.lblPrintName.TabIndex = 12;
            this.lblPrintName.Text = "Vārds:";
            // 
            // lblPrintSurname
            // 
            this.lblPrintSurname.AutoSize = true;
            this.lblPrintSurname.Location = new System.Drawing.Point(15, 273);
            this.lblPrintSurname.Name = "lblPrintSurname";
            this.lblPrintSurname.Size = new System.Drawing.Size(49, 13);
            this.lblPrintSurname.TabIndex = 13;
            this.lblPrintSurname.Text = "Uzvārds:";
            // 
            // lblPrintCourse
            // 
            this.lblPrintCourse.AutoSize = true;
            this.lblPrintCourse.Location = new System.Drawing.Point(15, 296);
            this.lblPrintCourse.Name = "lblPrintCourse";
            this.lblPrintCourse.Size = new System.Drawing.Size(67, 13);
            this.lblPrintCourse.TabIndex = 14;
            this.lblPrintCourse.Text = "Studiju kurss";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrintCourse);
            this.Controls.Add(this.lblPrintSurname);
            this.Controls.Add(this.lblPrintName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.courseError);
            this.Controls.Add(this.surnameError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.lblCourss);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblCourss;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label surnameError;
        private System.Windows.Forms.Label courseError;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblPrintName;
        private System.Windows.Forms.Label lblPrintSurname;
        private System.Windows.Forms.Label lblPrintCourse;
    }
}

