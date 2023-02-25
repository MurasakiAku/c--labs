namespace simplepaint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.snowflake = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TrackBar1 = new System.Windows.Forms.TrackBar();
            this.squadBrush = new System.Windows.Forms.Button();
            this.Lastik = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.snowflake);
            this.panel1.Controls.Add(this.Circle);
            this.panel1.Controls.Add(this.rectangle);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.squadBrush);
            this.panel1.Controls.Add(this.Lastik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MaximumSize = new System.Drawing.Size(165, 433);
            this.panel1.MinimumSize = new System.Drawing.Size(165, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 433);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // snowflake
            // 
            this.snowflake.Location = new System.Drawing.Point(100, 207);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(57, 40);
            this.snowflake.TabIndex = 4;
            this.snowflake.Text = "цветок";
            this.snowflake.UseVisualStyleBackColor = true;
            this.snowflake.UseWaitCursor = true;
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(3, 207);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(57, 40);
            this.Circle.TabIndex = 2;
            this.Circle.Text = "круг";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.UseWaitCursor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(100, 152);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(57, 40);
            this.rectangle.TabIndex = 3;
            this.rectangle.Text = "Прямоу";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.UseWaitCursor = true;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TrackBar1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор кисти";
            this.groupBox1.UseWaitCursor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 43);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 25);
            this.button7.TabIndex = 5;
            this.button7.Text = "Другие цвета";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.UseWaitCursor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Location = new System.Drawing.Point(61, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 30);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.Location = new System.Drawing.Point(117, 74);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 30);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(3, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 30);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkViolet;
            this.button3.Location = new System.Drawing.Point(3, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 30);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(61, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(117, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button4_Click);
            // 
            // TrackBar1
            // 
            this.TrackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TrackBar1.Location = new System.Drawing.Point(3, 16);
            this.TrackBar1.Maximum = 40;
            this.TrackBar1.Minimum = 3;
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(159, 45);
            this.TrackBar1.TabIndex = 0;
            this.TrackBar1.UseWaitCursor = true;
            this.TrackBar1.Value = 3;
            this.TrackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            this.TrackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // squadBrush
            // 
            this.squadBrush.Location = new System.Drawing.Point(3, 152);
            this.squadBrush.Name = "squadBrush";
            this.squadBrush.Size = new System.Drawing.Size(57, 40);
            this.squadBrush.TabIndex = 1;
            this.squadBrush.Text = "квадрат";
            this.squadBrush.UseVisualStyleBackColor = true;
            this.squadBrush.UseWaitCursor = true;
            this.squadBrush.Click += new System.EventHandler(this.squadBrush_Click);
            // 
            // Lastik
            // 
            this.Lastik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lastik.Location = new System.Drawing.Point(3, 264);
            this.Lastik.Name = "Lastik";
            this.Lastik.Size = new System.Drawing.Size(154, 30);
            this.Lastik.TabIndex = 1;
            this.Lastik.Text = "Ластик";
            this.Lastik.UseVisualStyleBackColor = false;
            this.Lastik.UseWaitCursor = true;
            this.Lastik.Click += new System.EventHandler(this.Lastik_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(165, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 437);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.cохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // cохранитьToolStripMenuItem
            // 
            this.cохранитьToolStripMenuItem.Name = "cохранитьToolStripMenuItem";
            this.cохранитьToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.cохранитьToolStripMenuItem.Text = "Cохранить";
            this.cохранитьToolStripMenuItem.Click += new System.EventHandler(this.cохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1500, 800);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "Form1";
            this.Text = "Simpl Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button snowflake;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button squadBrush;
        private System.Windows.Forms.TrackBar TrackBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button Lastik;
        private System.Windows.Forms.ToolStripMenuItem cохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button7;
    }
}

