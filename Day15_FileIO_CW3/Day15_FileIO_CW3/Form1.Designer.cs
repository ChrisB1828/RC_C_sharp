namespace Day15_FileIO_CW3
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
            this.BoxForText = new System.Windows.Forms.RichTextBox();
            this.BtnText1 = new System.Windows.Forms.Button();
            this.BtnText2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxForText
            // 
            this.BoxForText.Location = new System.Drawing.Point(12, 12);
            this.BoxForText.Name = "BoxForText";
            this.BoxForText.Size = new System.Drawing.Size(180, 426);
            this.BoxForText.TabIndex = 0;
            this.BoxForText.Text = "";
            // 
            // BtnText1
            // 
            this.BtnText1.Location = new System.Drawing.Point(198, 28);
            this.BtnText1.Name = "BtnText1";
            this.BtnText1.Size = new System.Drawing.Size(75, 23);
            this.BtnText1.TabIndex = 1;
            this.BtnText1.Text = "Add Text 1";
            this.BtnText1.UseVisualStyleBackColor = true;
            this.BtnText1.Click += new System.EventHandler(this.BtnText1_Click);
            // 
            // BtnText2
            // 
            this.BtnText2.Location = new System.Drawing.Point(199, 58);
            this.BtnText2.Name = "BtnText2";
            this.BtnText2.Size = new System.Drawing.Size(75, 23);
            this.BtnText2.TabIndex = 2;
            this.BtnText2.Text = "Add Text 2";
            this.BtnText2.UseVisualStyleBackColor = true;
            this.BtnText2.Click += new System.EventHandler(this.BtnText2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnText2);
            this.Controls.Add(this.BtnText1);
            this.Controls.Add(this.BoxForText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox BoxForText;
        private System.Windows.Forms.Button BtnText1;
        private System.Windows.Forms.Button BtnText2;
    }
}

