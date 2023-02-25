namespace simplepaint
{
    partial class Form2
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHeigh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ok1 = new System.Windows.Forms.Button();
            this.Cance1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(149, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(149, 86);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(100, 20);
            this.tbWidth.TabIndex = 1;
            // 
            // tbHeigh
            // 
            this.tbHeigh.Location = new System.Drawing.Point(149, 130);
            this.tbHeigh.Name = "tbHeigh";
            this.tbHeigh.Size = new System.Drawing.Size(100, 20);
            this.tbHeigh.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя файла";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Высота";
            // 
            // Ok1
            // 
            this.Ok1.Location = new System.Drawing.Point(36, 187);
            this.Ok1.Name = "Ok1";
            this.Ok1.Size = new System.Drawing.Size(75, 23);
            this.Ok1.TabIndex = 6;
            this.Ok1.Text = "Ok";
            this.Ok1.UseVisualStyleBackColor = true;
            this.Ok1.Click += new System.EventHandler(this.Ok1_Click);
            // 
            // Cance1
            // 
            this.Cance1.Location = new System.Drawing.Point(192, 186);
            this.Cance1.Name = "Cance1";
            this.Cance1.Size = new System.Drawing.Size(75, 23);
            this.Cance1.TabIndex = 7;
            this.Cance1.Text = "Exit";
            this.Cance1.UseVisualStyleBackColor = true;
            this.Cance1.Click += new System.EventHandler(this.Cance1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.Cance1);
            this.Controls.Add(this.Ok1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHeigh);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.tbName);
            this.MaximumSize = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.Name = "Form2";
            this.Text = "Создать";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ok1;
        private System.Windows.Forms.Button Cance1;
    }
}