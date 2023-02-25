namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btmName = new System.Windows.Forms.Button();
            this.btmEx = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmName
            // 
            this.btmName.Location = new System.Drawing.Point(76, 165);
            this.btmName.MaximumSize = new System.Drawing.Size(200, 25);
            this.btmName.Name = "btmName";
            this.btmName.Size = new System.Drawing.Size(182, 20);
            this.btmName.TabIndex = 0;
            this.btmName.Text = "Привет!";
            this.btmName.UseVisualStyleBackColor = true;
            this.btmName.Click += new System.EventHandler(this.btmName_Click);
            // 
            // btmEx
            // 
            this.btmEx.Location = new System.Drawing.Point(76, 226);
            this.btmEx.MaximumSize = new System.Drawing.Size(200, 25);
            this.btmEx.Name = "btmEx";
            this.btmEx.Size = new System.Drawing.Size(182, 23);
            this.btmEx.TabIndex = 1;
            this.btmEx.Text = "Выход";
            this.btmEx.UseVisualStyleBackColor = true;
            this.btmEx.Click += new System.EventHandler(this.btmEx_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(173, 92);
            this.tbName.MaximumSize = new System.Drawing.Size(150, 20);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 95);
            this.label1.MaximumSize = new System.Drawing.Size(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите своё имя!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btmEx);
            this.Controls.Add(this.btmName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmName;
        private System.Windows.Forms.Button btmEx;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
    }
}

