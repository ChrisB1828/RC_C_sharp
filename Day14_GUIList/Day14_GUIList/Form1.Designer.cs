namespace Day14_GUIList
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
            this.LstTest = new System.Windows.Forms.ListView();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.FieldInput = new System.Windows.Forms.TextBox();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstTest
            // 
            this.LstTest.HideSelection = false;
            this.LstTest.Location = new System.Drawing.Point(12, 12);
            this.LstTest.Name = "LstTest";
            this.LstTest.Size = new System.Drawing.Size(208, 339);
            this.LstTest.TabIndex = 0;
            this.LstTest.UseCompatibleStateImageBehavior = false;
            this.LstTest.View = System.Windows.Forms.View.List;
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(250, 108);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 1;
            this.BtnTest.Text = "ADD";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(250, 137);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(250, 167);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(75, 23);
            this.BtnChange.TabIndex = 4;
            this.BtnChange.Text = "Change Text";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // FieldInput
            // 
            this.FieldInput.Location = new System.Drawing.Point(250, 82);
            this.FieldInput.Name = "FieldInput";
            this.FieldInput.Size = new System.Drawing.Size(100, 20);
            this.FieldInput.TabIndex = 5;
            // 
            // BtnUndo
            // 
            this.BtnUndo.Location = new System.Drawing.Point(250, 197);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(75, 23);
            this.BtnUndo.TabIndex = 6;
            this.BtnUndo.Text = "Undo";
            this.BtnUndo.UseVisualStyleBackColor = true;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.FieldInput);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.LstTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstTest;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.TextBox FieldInput;
        private System.Windows.Forms.Button BtnUndo;
    }
}

