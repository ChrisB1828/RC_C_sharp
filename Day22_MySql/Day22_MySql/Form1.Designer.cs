namespace Day22_MySql
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
            this.LstOfEmployee = new System.Windows.Forms.ListView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.TxtBoxLastName = new System.Windows.Forms.TextBox();
            this.TxtBoxDepId = new System.Windows.Forms.TextBox();
            this.TxtBoxJobId = new System.Windows.Forms.TextBox();
            this.TxtBoxSalary = new System.Windows.Forms.TextBox();
            this.BtnShowEmployees = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LstOfEmployee
            // 
            this.LstOfEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Name,
            this.LastName,
            this.Department,
            this.Salary,
            this.Position});
            this.LstOfEmployee.HideSelection = false;
            this.LstOfEmployee.Location = new System.Drawing.Point(13, 13);
            this.LstOfEmployee.Name = "LstOfEmployee";
            this.LstOfEmployee.Size = new System.Drawing.Size(479, 425);
            this.LstOfEmployee.TabIndex = 0;
            this.LstOfEmployee.UseCompatibleStateImageBehavior = false;
            this.LstOfEmployee.View = System.Windows.Forms.View.Details;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(701, 102);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(688, 131);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxName.TabIndex = 2;
            // 
            // TxtBoxLastName
            // 
            this.TxtBoxLastName.Location = new System.Drawing.Point(688, 157);
            this.TxtBoxLastName.Name = "TxtBoxLastName";
            this.TxtBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxLastName.TabIndex = 3;
            // 
            // TxtBoxDepId
            // 
            this.TxtBoxDepId.Location = new System.Drawing.Point(748, 183);
            this.TxtBoxDepId.Name = "TxtBoxDepId";
            this.TxtBoxDepId.Size = new System.Drawing.Size(40, 20);
            this.TxtBoxDepId.TabIndex = 4;
            // 
            // TxtBoxJobId
            // 
            this.TxtBoxJobId.Location = new System.Drawing.Point(748, 209);
            this.TxtBoxJobId.Name = "TxtBoxJobId";
            this.TxtBoxJobId.Size = new System.Drawing.Size(40, 20);
            this.TxtBoxJobId.TabIndex = 5;
            // 
            // TxtBoxSalary
            // 
            this.TxtBoxSalary.Location = new System.Drawing.Point(721, 235);
            this.TxtBoxSalary.Name = "TxtBoxSalary";
            this.TxtBoxSalary.Size = new System.Drawing.Size(67, 20);
            this.TxtBoxSalary.TabIndex = 6;
            // 
            // BtnShowEmployees
            // 
            this.BtnShowEmployees.Location = new System.Drawing.Point(679, 73);
            this.BtnShowEmployees.Name = "BtnShowEmployees";
            this.BtnShowEmployees.Size = new System.Drawing.Size(109, 23);
            this.BtnShowEmployees.TabIndex = 7;
            this.BtnShowEmployees.Text = "Show all employees";
            this.BtnShowEmployees.UseVisualStyleBackColor = true;
            this.BtnShowEmployees.Click += new System.EventHandler(this.BtnShowEmployees_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 36;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 91;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 92;
            // 
            // Department
            // 
            this.Department.Text = "Department";
            this.Department.Width = 120;
            // 
            // Salary
            // 
            this.Salary.Text = "Salary";
            this.Salary.Width = 67;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            this.Position.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnShowEmployees);
            this.Controls.Add(this.TxtBoxSalary);
            this.Controls.Add(this.TxtBoxJobId);
            this.Controls.Add(this.TxtBoxDepId);
            this.Controls.Add(this.TxtBoxLastName);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LstOfEmployee);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstOfEmployee;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.TextBox TxtBoxLastName;
        private System.Windows.Forms.TextBox TxtBoxDepId;
        private System.Windows.Forms.TextBox TxtBoxJobId;
        private System.Windows.Forms.TextBox TxtBoxSalary;
        private System.Windows.Forms.Button BtnShowEmployees;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader Salary;
        private System.Windows.Forms.ColumnHeader Position;
    }
}

