using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_2_
{
    public partial class Form1 : Form
    {
        bool click;
        bool isCanvasEmpty;
        bool isSaved;
        private Color selectedColor = Color.Black;
        private float penWidth;
        Random rnd = new Random();
        Pen PenRed = new Pen(Color.Red);
        SolidBrush SolidBlue = new SolidBrush(Color.Blue);
        private int clicksCount; public static int q = 0;
        private int mx1; private int mx2; private int Gmx;
        private int my1; private int my2; private int Gmy;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void Start()
        {
            isSaved = true;
            isCanvasEmpty = true;

            label3.Text = isSaved.ToString();
        }

        private void рисунок1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSaved = false;
            label3.Text = isSaved.ToString();
            isCanvasEmpty = false;
            checkBox1.Checked = true;
            pictureBox1.Refresh();
            Bitmap row = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = Graphics.FromImage(row);
            graph.DrawLine(PenRed, 2, 400, 500, 200);
            graph.FillEllipse(SolidBlue, 20, 20, 50, 50);
        }

        private void паинтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCanvasEmpty = true;
            checkBox1.Checked = false;
            pictureBox1.Refresh();
            Bitmap row = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graph = pictureBox1.CreateGraphics();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                selectedColor = colorDialog1.Color;
                button29.BackColor = colorDialog1.Color;
            }
        }

        private void бриллиантToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCanvasEmpty = false;
            checkBox1.Checked = true;
            pictureBox1.Refresh();
            Graphics graph = pictureBox1.CreateGraphics();
            Pen PenAqua = new Pen(Color.Aqua, 2);
            graph.DrawLine(PenAqua, 366, 353, 503, 205);
            graph.DrawLine(PenAqua, 363, 355, 223, 219);
            graph.DrawLine(PenAqua, 501, 207, 214, 202);
            graph.DrawLine(PenAqua, 213, 204, 226, 222);
            graph.DrawLine(PenAqua, 213, 202, 259, 154);
            graph.DrawLine(PenAqua, 259, 154, 456, 147);
            graph.DrawLine(PenAqua, 456, 147, 500, 205);
            graph.DrawLine(PenAqua, 362, 355, 295, 206);
            graph.DrawLine(PenAqua, 409, 203, 363, 352);
            graph.DrawLine(PenAqua, 385, 151, 404, 206);
            graph.DrawLine(PenAqua, 317, 151, 296, 206);
        }

        private void эллипсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCanvasEmpty = false;
            checkBox1.Checked = true;

            Graphics graph = pictureBox1.CreateGraphics();
            Pen PenAqua = new Pen(Color.Violet, 3);

            Form FormName = new Form2();
            FormName.ShowDialog();
            int alpha = 255;

            if (Form2.ClearCanvas) { pictureBox1.Refresh(); }

            for (int i = 0; i < q; i++)
            {
                int rsx = rnd.Next(5, 300);
                int rsy = rnd.Next(5, 300);
                int rx = rnd.Next(1, 757 - rsx);
                int ry = rnd.Next(1, 457 - rsy);
                if (Form2.isRandomColor)
                {
                    Color randomColor = Color.FromArgb(alpha, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    SolidBrush Square = new SolidBrush(randomColor);
                    graph.FillEllipse(Square, rx, ry, rsx, rsy);
                }
                else
                {
                    SolidBrush Square = new SolidBrush(selectedColor);
                    graph.FillEllipse(Square, rx, ry, rsx, rsy);
                }
                if (alpha > 150) { alpha = alpha - (255 / (2 * q)); } else { alpha = 150; }
            }
            Form2.ClearCanvas = false;
            Form2.isRandomColor = false;
        }

        private void окружностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCanvasEmpty = false;
            checkBox1.Checked = true;

            Graphics graph = pictureBox1.CreateGraphics();

            Form FormName = new Form2();
            FormName.ShowDialog();
            int alpha = 255;

            if (Form2.ClearCanvas) { pictureBox1.Refresh(); }

            for (int i = 0; i < q; i++)
            {
                int rs = rnd.Next(5, 300);
                int rx = rnd.Next(1, 757 - rs);
                int ry = rnd.Next(1, 457 - rs);
                if (Form2.isRandomColor)
                {
                    Color randomColor = Color.FromArgb(alpha, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    SolidBrush Square = new SolidBrush(randomColor);
                    graph.FillEllipse(Square, rx, ry, rs, rs);
                }
                else
                {
                    SolidBrush Square = new SolidBrush(selectedColor);
                    graph.FillEllipse(Square, rx, ry, rs, rs);
                }
                if (alpha > 150) { alpha = alpha - (255 / (2 * q)); } else { alpha = 150; }
            }
            Form2.ClearCanvas = false;
            Form2.isRandomColor = false;
        }

        private void прямоугольникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCanvasEmpty = false;
            checkBox1.Checked = true;

            Graphics graph = pictureBox1.CreateGraphics();
            Pen PenAqua = new Pen(Color.Violet, 3);
            Form FormName = new Form2();
            FormName.ShowDialog();
            int alpha = 255;

            if (Form2.ClearCanvas) { pictureBox1.Refresh(); }

            for (int i = 0; i < q; i++)
            {
                int rsx = rnd.Next(5, 300);
                int rsy = rnd.Next(5, 300);
                int rx = rnd.Next(1, 757 - rsx);
                int ry = rnd.Next(1, 457 - rsy);
                if (Form2.isRandomColor)
                {
                    Color randomColor = Color.FromArgb(alpha, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    SolidBrush Square = new SolidBrush(randomColor);
                    graph.FillRectangle(Square, rx, ry, rsx, rsy);
                }
                else
                {
                    SolidBrush Square = new SolidBrush(selectedColor);
                    graph.FillRectangle(Square, rx, ry, rsx, rsy);
                }
                if (alpha > 150) { alpha = alpha - (255 / (2 * q)); } else { alpha = 150; }
            }
            Form2.ClearCanvas = false;
            Form2.isRandomColor = false;
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCanvasEmpty = false;
            checkBox1.Checked = true;

            Graphics graph = pictureBox1.CreateGraphics();
            Pen PenAqua = new Pen(Color.Violet, 3);
            Form FormName = new Form2();
            FormName.ShowDialog();
            int alpha = 255;

            if (Form2.ClearCanvas) { pictureBox1.Refresh(); }

            for (int i = 0; i < q; i++)
            {
                int rs = rnd.Next(5, 300);
                int rx = rnd.Next(1, 757 - rs);
                int ry = rnd.Next(1, 457 - rs);
                if (Form2.isRandomColor)
                {
                    Color randomColor = Color.FromArgb(alpha, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    SolidBrush Square = new SolidBrush(randomColor);
                    graph.FillRectangle(Square, rx, ry, rs, rs);
                }
                else
                {
                    SolidBrush Square = new SolidBrush(selectedColor);
                    graph.FillRectangle(Square, rx, ry, rs, rs);
                }
                if (alpha > 150) { alpha = alpha - (255 / (2 * q)); } else { alpha = 150; }
            }
            Form2.ClearCanvas = false;
            Form2.isRandomColor = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graph = pictureBox1.CreateGraphics();
            penWidth = (float)trackBar1.Value;
            SolidBrush CustomColor = new SolidBrush(selectedColor);
            Pen CustomPen = new Pen(selectedColor, penWidth);
            if (click)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    clicksCount++;
                    if (clicksCount > 2)
                    {
                        clicksCount = 1;
                    }

                    switch (clicksCount)
                    {
                        case 1:
                            mx1 = Gmx;
                            my1 = Gmy;
                            break;
                        case 2:
                            mx2 = Gmx;
                            my2 = Gmy;
                            graph.DrawLine(CustomPen, mx1, my1, mx2, my2);
                            Console.WriteLine("graph.DrawLine(" + CustomPen.Color.Name + "," + mx1 + "," + my1 + "," + mx2 + "," + my2 + ");");
                            label3.Text = ("graph.DrawLine(" + CustomPen.Color.Name + "," + mx1 + "," + my1 + "," + mx2 + "," + my2 + ");");
                            mx1 = 0; mx2 = 0; my1 = 0; my2 = 0;
                            break;
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    clicksCount++;
                    if (clicksCount > 2)
                    {
                        clicksCount = 1;
                    }

                    switch (clicksCount)
                    {
                        case 1:
                            mx1 = Gmx;
                            my1 = Gmy;
                            break;
                        case 2:
                            mx2 = Gmx;
                            my2 = Gmy;
                            if (mx2 < mx1)
                            {
                                int buff = mx1;
                                mx1 = mx2;
                                mx2 = buff;
                                buff = 0;
                            }
                            if (my2 < my1)
                            {
                                int buff = my1;
                                my1 = my2;
                                my2 = buff;
                                buff = 0;
                            }
                            SolidBrush Square = new SolidBrush(selectedColor);
                            graph.FillRectangle(Square, mx1, my1, mx2 - mx1, my2 - my1);
                            Console.WriteLine("graph.Rectangle(" + CustomPen.Color.Name + "," + mx1 + "," + my1 + "," + mx2 + "," + my2 + ");");
                            label3.Text = ("graph.FillRectangle(" + CustomPen.Color.Name + "," + mx1 + "," + my1 + "," + mx2 + "," + my2 + ");");
                            mx1 = 0; mx2 = 0; my1 = 0; my2 = 0;
                            break;
                    }
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    clicksCount++;
                    if (clicksCount > 2)
                    {
                        clicksCount = 1;

                    }
                    switch (clicksCount)
                    {
                        case 1:
                            mx1 = Gmx;
                            my1 = Gmy;

                            break;
                        case 2:
                            mx2 = Gmx;
                            my2 = Gmy;
                            if (mx2 < mx1)
                            {
                                int buff = mx1;
                                mx1 = mx2;
                                mx2 = buff;
                                buff = 0;
                            }
                            if (my2 < my1)
                            {
                                int buff = my1;
                                my1 = my2;
                                my2 = buff;
                                buff = 0;
                            }
                            SolidBrush Square = new SolidBrush(selectedColor);
                            graph.FillEllipse(Square, mx1, my1, mx2 - mx1, my2 - my1);
                            Console.WriteLine("graph.FillEllipse(" + CustomPen.Color.Name + "," + mx1 + "," + my1 + "," + mx2 + "," + my2 + ");");
                            label3.Text = ("graph.FillRectangle(" + CustomPen.Color.Name + "," + mx1 + "," + my1 + "," + mx2 + "," + my2 + ");");
                            mx1 = 0; mx2 = 0; my1 = 0; my2 = 0;
                            break;
                    }
                }
                if (comboBox1.SelectedIndex == 4)
                {
                            SolidBrush Square = new SolidBrush(selectedColor);
                            graph.FillRectangle(Square, 0, 0, 757, 451);
                            Console.WriteLine("graph.FillRectangle(Square, 0, 0, 757, 451);");
                            label3.Text = ("graph.FillRectangle(Square, 0, 0, 757, 451);");
                }
            }
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null | isCanvasEmpty == false)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        isSaved = true;
                        label3.Text = isSaved.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Похоже, что ваш холст пуст =(", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image.Save(openFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            openFileDialog1.Filter = "PNG Изображение (*.png)|*.txt|Все файлы (*.*)|*.*";
            string filename = openFileDialog1.FileName;
            pictureBox1.Image = (Image.FromFile(filename));
            MessageBox.Show("Файл открыт");

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image img = Image.FromFile(pic);
                pictureBox1.Image = img;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.ForeColor = Color.PaleGreen;
            if (!checkBox1.Checked)
                checkBox1.ForeColor = Color.LightCoral;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (isCanvasEmpty == false | isSaved == false)
            {
                DialogResult msg = MessageBox.Show("Сохранить?", "Внимание", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (msg == DialogResult.No)
                {
                    Application.ExitThread();
                    Application.Exit();
                }
                else if (msg == DialogResult.Yes)
                {
                    сохранитьToolStripMenuItem_Click(sender, e);
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (isSaved)
            {
                Application.ExitThread();
                Application.Exit();
            }
        }

        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Gmx = Control.MousePosition.X - this.Location.X - 23;
            Gmy = Control.MousePosition.Y - this.Location.Y - 75;
            label1.Text = ("MousePos:  " + Gmx + ";  " + Gmy);
            Graphics graph = pictureBox1.CreateGraphics();
            penWidth = (float)trackBar1.Value;
            SolidBrush CustomColor = new SolidBrush(selectedColor);
            Pen CustomPen = new Pen(selectedColor, penWidth);
            if (click & comboBox1.SelectedIndex == 0)
            {
                mx1 = Gmx;
                my1 = Gmy;
                graph.DrawLine(CustomPen, mx1 + 2, my1 + 2, mx1, my1);
                label3.Text = ("graph.DrawLine(" + CustomPen.Color.Name + "," + mx1 + "," + my1 + "," + mx2 + "," + my2 + ");");
                mx1 = 0; mx2 = 0; my1 = 0; my2 = 0;
            }
        }

        private void домToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCanvasEmpty = false;
            checkBox1.Checked = true;
            pictureBox1.Refresh();
            Graphics graph = pictureBox1.CreateGraphics();
            Pen PenLime = new Pen(Color.Lime, 5);
            Pen PenYellow = new Pen(Color.Yellow, 5);
            Pen PenGreen = new Pen(Color.Green, 5);
            Pen PenBrown = new Pen(Color.SaddleBrown, 5);
            SolidBrush BrushBlue = new SolidBrush(Color.CornflowerBlue);
            SolidBrush BrushYellow = new SolidBrush(Color.Yellow);
            SolidBrush BrushGray = new SolidBrush(Color.Gray);
            SolidBrush Square = new SolidBrush(selectedColor);
            graph.DrawLine(PenLime, 185, 265, 2, 334);
            graph.DrawLine(PenLime, 184, 265, 348, 250);
            graph.DrawLine(PenLime, 348, 250, 545, 272);
            graph.DrawLine(PenLime, 545, 272, 756, 359);
            graph.DrawLine(PenBrown, 89, 365, 113, 132);
            graph.DrawLine(PenBrown, 127, 133, 140, 357);
            graph.DrawLine(PenGreen, 100, 240, 33, 201);
            graph.DrawLine(PenGreen, 33, 201, 25, 111);
            graph.DrawLine(PenGreen, 70, 40, 23, 112);
            graph.DrawLine(PenGreen, 68, 41, 144, 34);
            graph.DrawLine(PenGreen, 144, 35, 201, 96);
            graph.DrawLine(PenGreen, 201, 96, 199, 200);
            graph.DrawLine(PenGreen, 199, 200, 132, 240);
            graph.FillRectangle(BrushGray, 440, 79, 231, 285);
            graph.FillRectangle(BrushBlue, 451, 94, 63, 65);
            graph.FillRectangle(BrushBlue, 532, 95, 53, 65);
            graph.FillRectangle(BrushBlue, 601, 96, 53, 65);
            graph.FillRectangle(BrushBlue, 453, 169, 54, 54);
            graph.FillRectangle(BrushBlue, 533, 169, 54, 54);
            graph.FillRectangle(BrushBlue, 608, 168, 54, 54);
            graph.FillRectangle(BrushBlue, 454, 240, 54, 54);
            graph.FillRectangle(BrushBlue, 453, 316, 54, 37);
            graph.FillRectangle(BrushBlue, 531, 240, 54, 37);
            graph.FillRectangle(BrushBlue, 609, 239, 40, 37);
            graph.FillRectangle(BrushBlue, 609, 313, 40, 37);
            graph.FillRectangle(Square, 544, 317, 30, 34);
            graph.FillEllipse(BrushYellow, 260, 14, 74, 74);
            graph.DrawLine(PenYellow, 242, 23, 198, 6);
            graph.DrawLine(PenYellow, 229, 50, 178, 47);
            graph.DrawLine(PenYellow, 243, 78, 210, 104);
            graph.DrawLine(PenYellow, 264, 97, 199, 246);
            graph.DrawLine(PenYellow, 289, 105, 284, 237);
            graph.DrawLine(PenYellow, 314, 101, 381, 236);
            graph.DrawLine(PenYellow, 339, 86, 429, 206);
            graph.DrawLine(PenYellow, 356, 64, 428, 87);
            graph.DrawLine(PenYellow, 361, 37, 730, 33);
            graph.DrawLine(PenYellow, 352, 13, 390, 3);
            graph.DrawLine(PenYellow, 261, 4, 249, 1);
        }
    }
}
