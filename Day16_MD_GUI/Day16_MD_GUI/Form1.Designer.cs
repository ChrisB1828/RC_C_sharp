namespace Day16_MD_GUI
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnTextXhange = new System.Windows.Forms.Button();
            this.TxtChange = new System.Windows.Forms.TextBox();
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtCours = new System.Windows.Forms.TextBox();
            this.LstStudent = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(197, 63);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(100, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(197, 93);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnTextXhange
            // 
            this.BtnTextXhange.Location = new System.Drawing.Point(197, 122);
            this.BtnTextXhange.Name = "BtnTextXhange";
            this.BtnTextXhange.Size = new System.Drawing.Size(101, 23);
            this.BtnTextXhange.TabIndex = 3;
            this.BtnTextXhange.Text = "Text Change";
            this.BtnTextXhange.UseVisualStyleBackColor = true;
            // 
            // TxtChange
            // 
            this.TxtChange.Location = new System.Drawing.Point(304, 122);
            this.TxtChange.Name = "TxtChange";
            this.TxtChange.Size = new System.Drawing.Size(100, 20);
            this.TxtChange.TabIndex = 4;
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Location = new System.Drawing.Point(197, 151);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(100, 23);
            this.BtnReadFile.TabIndex = 5;
            this.BtnReadFile.Text = "Read File";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            this.BtnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(304, 63);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 6;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(410, 62);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(100, 20);
            this.TxtSurname.TabIndex = 7;
            // 
            // TxtCours
            // 
            this.TxtCours.Location = new System.Drawing.Point(516, 62);
            this.TxtCours.Name = "TxtCours";
            this.TxtCours.Size = new System.Drawing.Size(100, 20);
            this.TxtCours.TabIndex = 8;
            // 
            // LstStudent
            // 
            this.LstStudent.HideSelection = false;
            this.LstStudent.Location = new System.Drawing.Point(13, 13);
            this.LstStudent.Name = "LstStudent";
            this.LstStudent.Size = new System.Drawing.Size(178, 425);
            this.LstStudent.TabIndex = 9;
            this.LstStudent.UseCompatibleStateImageBehavior = false;
            this.LstStudent.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LstStudent);
            this.Controls.Add(this.TxtCours);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnReadFile);
            this.Controls.Add(this.TxtChange);
            this.Controls.Add(this.BtnTextXhange);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnTextXhange;
        private System.Windows.Forms.TextBox TxtChange;
        private System.Windows.Forms.Button BtnReadFile;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtCours;
        private System.Windows.Forms.ListView LstStudent;
    }
}

