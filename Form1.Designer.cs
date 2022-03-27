namespace Lab1_2_
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисункиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунок1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окружностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эллипсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бриллиантToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.домToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паинтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button29 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 454);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисункиToolStripMenuItem,
            this.паинтToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // рисункиToolStripMenuItem
            // 
            this.рисункиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисунок1ToolStripMenuItem,
            this.бриллиантToolStripMenuItem,
            this.домToolStripMenuItem});
            this.рисункиToolStripMenuItem.Name = "рисункиToolStripMenuItem";
            this.рисункиToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисункиToolStripMenuItem.Text = "Рисунки";
            // 
            // рисунок1ToolStripMenuItem
            // 
            this.рисунок1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадратToolStripMenuItem,
            this.прямоугольникиToolStripMenuItem,
            this.окружностиToolStripMenuItem,
            this.эллипсыToolStripMenuItem});
            this.рисунок1ToolStripMenuItem.Name = "рисунок1ToolStripMenuItem";
            this.рисунок1ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.рисунок1ToolStripMenuItem.Text = "Геометрические фигуры";
            this.рисунок1ToolStripMenuItem.Click += new System.EventHandler(this.рисунок1ToolStripMenuItem_Click);
            // 
            // квадратToolStripMenuItem
            // 
            this.квадратToolStripMenuItem.Name = "квадратToolStripMenuItem";
            this.квадратToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.квадратToolStripMenuItem.Text = "Квадраты";
            this.квадратToolStripMenuItem.Click += new System.EventHandler(this.квадратToolStripMenuItem_Click);
            // 
            // прямоугольникиToolStripMenuItem
            // 
            this.прямоугольникиToolStripMenuItem.Name = "прямоугольникиToolStripMenuItem";
            this.прямоугольникиToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.прямоугольникиToolStripMenuItem.Text = "Прямоугольники";
            this.прямоугольникиToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникиToolStripMenuItem_Click);
            // 
            // окружностиToolStripMenuItem
            // 
            this.окружностиToolStripMenuItem.Name = "окружностиToolStripMenuItem";
            this.окружностиToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.окружностиToolStripMenuItem.Text = "Окружности";
            this.окружностиToolStripMenuItem.Click += new System.EventHandler(this.окружностиToolStripMenuItem_Click);
            // 
            // эллипсыToolStripMenuItem
            // 
            this.эллипсыToolStripMenuItem.Name = "эллипсыToolStripMenuItem";
            this.эллипсыToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.эллипсыToolStripMenuItem.Text = "Эллипсы";
            this.эллипсыToolStripMenuItem.Click += new System.EventHandler(this.эллипсыToolStripMenuItem_Click);
            // 
            // бриллиантToolStripMenuItem
            // 
            this.бриллиантToolStripMenuItem.Name = "бриллиантToolStripMenuItem";
            this.бриллиантToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.бриллиантToolStripMenuItem.Text = "Бриллиант";
            this.бриллиантToolStripMenuItem.Click += new System.EventHandler(this.бриллиантToolStripMenuItem_Click);
            // 
            // домToolStripMenuItem
            // 
            this.домToolStripMenuItem.Name = "домToolStripMenuItem";
            this.домToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.домToolStripMenuItem.Text = "Дом";
            this.домToolStripMenuItem.Click += new System.EventHandler(this.домToolStripMenuItem_Click);
            // 
            // паинтToolStripMenuItem
            // 
            this.паинтToolStripMenuItem.Name = "паинтToolStripMenuItem";
            this.паинтToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.паинтToolStripMenuItem.Text = "Паинт";
            this.паинтToolStripMenuItem.Click += new System.EventHandler(this.паинтToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(580, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Debug";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(209, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ширина:";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.ShowHelp = true;
            // 
            // button29
            // 
            this.button29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button29.Location = new System.Drawing.Point(12, 507);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(121, 23);
            this.button29.TabIndex = 33;
            this.button29.Text = "Цвет";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBar1.Location = new System.Drawing.Point(287, 507);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(116, 45);
            this.trackBar1.TabIndex = 34;
            this.trackBar1.Value = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gray;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DisplayMember = "01";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Точки",
            "Линия",
            "Прямоугольник",
            "Эллипс",
            "Заливка"});
            this.comboBox1.Location = new System.Drawing.Point(12, 534);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.ValueMember = "01";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.ForeColor = System.Drawing.Color.PaleGreen;
            this.checkBox1.Location = new System.Drawing.Point(722, 501);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "Lock";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(173, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Debug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(804, 604);
            this.MinimumSize = new System.Drawing.Size(804, 604);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cursed Paint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рисункиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунок1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паинтToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.ToolStripMenuItem бриллиантToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окружностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эллипсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem домToolStripMenuItem;
    }
}

