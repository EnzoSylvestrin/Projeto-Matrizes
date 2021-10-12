using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace matrix
{
    public partial class Form1 : Form
    {
        #region audio
        //static CultureInfo ci = new CultureInfo("pt-BR");
        //static readonly CultureInfo ci = new CultureInfo("en-US");
        //static readonly SpeechRecognitionEngine sre =
          //new SpeechRecognitionEngine(ci);

        public Form1()
        {
            InitializeComponent();
            //sre.SetInputToDefaultAudioDevice();
            //sre.SpeechRecognized += sre_SpeechRecognized;
            //Grammar g_GetCell = GetCell();
            //sre.LoadGrammarAsync(g_GetCell);
            //sre.RecognizeAsync(RecognizeMode.Multiple);
        }

        static Grammar GetCell()
        {
            Choices ch_Numbers = new Choices();
            ch_Numbers.Add(new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen" });
            GrammarBuilder gb_result = new GrammarBuilder();
            Choices ch_Colors = new Choices();
            ch_Colors.Add(new string[] { "red", "green", "blue", "yellow", "gray", "white", "black", "orange", "brown", "purple", "pink", "turquoise", "lime" });
            gb_result.Append(ch_Numbers);
            gb_result.Append(ch_Numbers);
            gb_result.Append(ch_Colors);
            Grammar g_result = new Grammar(gb_result);
            return g_result;
        }

        void sre_SpeechRecognized(object sender,
          SpeechRecognizedEventArgs e)
        {
            string txt = e.Result.Text;
            float conf = e.Result.Confidence;
            if (conf < 0.65) return;
            this.Invoke(new MethodInvoker(() =>
            {
                translateCellSpeechToNumbers(txt);
            })); // WinForm specific
            if (txt.IndexOf("text") >= 0 && txt.IndexOf("box") >=
              0 && txt.IndexOf("1") >= 0)
            {
                string[] words = txt.Split(' ');
                this.Invoke(new MethodInvoker(() =>
                { rtxt.Text = words[4]; })); // WinForm specific
            }
        }
        #endregion

        private string checkNumber(string txt)
        {
            switch (txt)
            {
                case "one":
                    return "1";
                case "two":
                    return "2";
                case "three":
                    return "3";
                case "four":
                    return "4";
                case "five":
                    return "5";
                case "six":
                    return "6";
                case "seven":
                    return "7";
                case "eight":
                    return "8";
                case "nine":
                    return "9";
                case "ten":
                    return "10";
                case "eleven":
                    return "11";
                case "twelve":
                    return "12";
                case "thirteen":
                    return "13";
                case "fourteen":
                    return "14";
                case "fifteen":
                    return "15";
                case "sixteen":
                    return "16";
            }

            return null;
        }

        private void translateCellSpeechToNumbers(string text)
        {
            string[] txt = text.Split(new char[] { ' ' }, 3);
            string cell = "";
            Color color = Color.Empty;

            cell += checkNumber(txt[0]);
            cell += "_";
            cell += checkNumber(txt[1]);


            switch (txt[2])
            {
                case "red":
                    color = Color.FromArgb(255, 0, 0);
                    break;
                case "green":
                    color = Color.FromArgb(0, 255, 0);
                    break;
                case "blue":
                    color = Color.FromArgb(0, 0, 255);
                    break;
                case "yellow":
                    color = Color.FromArgb(255, 255, 0);
                    break;
                case "gray":
                    color = Color.FromArgb(128, 128, 128);
                    break;
                case "white":
                    color = Color.FromArgb(255, 255, 255);
                    break;
                case "black":
                    color = Color.FromArgb(0, 0, 0);
                    break;
                case "orange":
                    color = Color.FromArgb(255, 150, 3);
                    break;
                case "brown":
                    color = Color.FromArgb(120, 82, 30);
                    break;
                case "purple":
                    color = Color.FromArgb(157, 0, 255);
                    break;
                case "pink":
                    color = Color.FromArgb(255, 150, 250);
                    break;
                case "turquoise":
                    color = Color.FromArgb(48, 213, 199);
                    break;
                case "lime":
                    color = Color.FromArgb(196, 240, 53);
                    break;
            }

            PaintCell(cell, color);
        }

        private void PaintCell(string cell, Color color)
        {
            foreach (Control item in Controls.OfType<Field>().ToList())
            {
                if (item.Name == cell)
                {
                    item.BackColor = color;
                }
            }
        }

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
                    label.Name = (i + 1) + "_" + (j + 1);
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

        }



        private void field_Click(Field field)
        {
            //if (me.Button == MouseButtons.Left)
            //System.Windows.Forms.MessageBox.Show(field.Name);
            string[] arr = txtColor.Text.Split(new char[] { ',' }, 3);
            field.BackColor = Color.FromArgb(int.Parse(arr[0]), int.Parse(arr[1]), int.Parse(arr[2]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtxt.Text))
            {
                string[] arrSize = txtSize.Text.Split(new char[] { ',' }, 2);
                string[] arrColor = txtColor.Text.Split(new char[] { ',' }, 3);
                createMatrix(int.Parse(arrSize[0]), int.Parse(arrSize[1]), generate_colorList(int.Parse(arrSize[0]), int.Parse(arrSize[1]), String.IsNullOrEmpty(txtSize.Text) ? Color.White : Color.FromArgb(int.Parse(arrColor[0]), int.Parse(arrColor[1]), int.Parse(arrColor[2]))));
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
