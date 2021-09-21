using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Xceed.Wpf.Toolkit;

namespace matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color empty = Color.Empty;

        private List<Color> generate_colorList(int width, int height, Color color)
        {
            List<Color> colors = new List<Color>();
            for (int i = 0; i < width * height; i++)
            {
                colors.Add(color);
            }
            return colors;
        }

        private void createMatrix(int width, int height, List<Color> colors = null)
        {
            if (colors == null)
            {
                colors = generate_colorList(width, height, Color.White);
            }

            Point point = new Point(10, 10);

            foreach (Control item in Controls.OfType<Field>().ToList())
            {
                Controls.Remove(item);
            }

            for (int i = 0; i < height; i++, point.Y += 30, point.X = 10)
            {
                for (int j = 0; j < width; j++)
                {
                    Field label = new Field();
                    //MouseEventArgs me = new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 0, mou);
                    label.Click += (sender2, e2) => field_Click(label);
                    label.Name = i + "_" + j;
                    label.Text = "";
                    label.Size = new Size(30, 30);
                    label.BackColor = colors[(i * width) + j];
                    label.Location = point;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(label);

                    point.X += 30;
                }
            }
        }

        private void translateMatrix(string text)
        {
            //[[[0,0][255,0,0]].[[0,0][255,0,0]]] [[[0,0][0,255,0]][[0,1][255,0,0]][[0,2][0,0,255]]]
            //string rx = @"\d*";
            //string text = "[[[1, 0][255, 0, 0]][[2,0][255,0,0]][[3, 0][255, 0, 0]]]";

            string rx = @"\d{1,}";

            Regex regex = new Regex(rx);
            MatchCollection b;

            b = regex.Matches(text);

            int size = b.Count / 5;

            int[,] nos = new int[size, 5];

            int row = -1;
            for (int i = 0; i < b.Count; i++)
            {
                int rest = i % 5;
                if (rest == 0)
                    row++;

                nos[row, rest] = Convert.ToInt32(b[i].Value);
            }

            int height = 1, width = 1;
            for (int i = 0; i < size; i++)
            {
                int val = nos[i, 1], val2 = nos[i, 0];
                if (val > height)
                    height = val;

                if (val2 > width)
                    width = val2;
            }

            for (int j = 0; j < size; j++)
            {
                int no_rows = 0, val = nos[j, 0]; ;
                if (val > no_rows)
                    width = val;
            }

            List<Color> colors = new List<Color>();
            for (int i = 0; i < size; i++)
            {
                int[] ay = new int[3];
                for (int j = 2; j < 5; j++)
                {
                    ay[j - 2] = nos[i, j];
                }

                colors.Add(Color.FromArgb(ay[0], ay[1], ay[2]));
            }

            createMatrix(width + 1, height + 1, colors);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Nevron.Nov.WinFormControls.NHsbColorPickerControl nHsbColorPickerControl = new Nevron.Nov.WinFormControls.NHsbColorPickerControl();
            nHsbColorPickerControl.
        }

        private void field_Click(Field field)
        {
            //if (me.Button == MouseButtons.Left)
            System.Windows.Forms.MessageBox.Show(field.Name);
            string[] arr = txtColor.Text.Split(new char[] { ',' }, 3);
            field.BackColor = Color.FromArgb(int.Parse(arr[0]), int.Parse(arr[1]), int.Parse(arr[2]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtxt.Text))
            {
                string[] arrSize = txtSize.Text.Split(new char[] { ',' }, 2);
                string[] arrColor = txtColor.Text.Split(new char[] { ',' }, 3);
                createMatrix(int.Parse(arrSize[0]), int.Parse(arrSize[1]), generate_colorList(int.Parse(arrSize[0]), int.Parse(arrSize[1]), String.IsNullOrEmpty(txtColor.Text) ? Color.White : Color.FromArgb(int.Parse(arrColor[0]), int.Parse(arrColor[1]), int.Parse(arrColor[2]))));
            }
            else
                translateMatrix(rtxt.Text);
            /*
            Point point = new Point(10, 10);
            
            string[] arr = textBox1.Text.Split(new char[] {','}, 3);

            foreach (Control item in Controls.OfType<Field>().ToList())
            {
                Controls.Remove(item);
            }

            for (int i = 0; i < 10; i++, point.Y += 30, point.X = 10)
            {
                for (int j = 0; j < 10; j++)
                {
                    Field label = new Field();
                    //MouseEventArgs me = new MouseEventArgs(System.Windows.Forms.MouseButtons.Left, 0, mou);
                    label.Click += (sender2, e2) => field_Click(label);
                    label.Name = i + "_" + j;
                    label.Text = "";
                    label.Size = new Size(30, 30);
                    label.BackColor = Color.FromArgb(int.Parse(arr[0]), int.Parse(arr[1]), int.Parse(arr[2]));
                    label.Location = point;
                    label.BorderStyle = BorderStyle.FixedSingle;
                    this.Controls.Add(label);

                    point.X += 30;
                }
            }*/
        }
    }
}
