using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Fractals_5_1
{
    public partial class Fractals : Form
    {
        public class State
        {
            public Point point1;
            public Point point2;
            public int degree;
            public Pen pen;

            public State(Point point1,Point point2,int degree, Pen pen)
            {
                this.point1 = point1;
                this.point2 = point2;
                this.degree = degree;
                this.pen = pen;
            }
        }

        public Fractals()
        {
            InitializeComponent();
            start_position.X = -1;
            textBoxN.Text = "1";
        }

        string atom;
        int angle_degree;
        string direction;
        string[] rules;
        int n;
        Point start_position;
        Stack<State> points = new Stack<State>();
        int LineLength = 25;
        int degree_change = 0;
        static Bitmap bmp = new Bitmap(920, 780);
        public Graphics g = Graphics.FromImage(bmp);

        void Setup()
        {
            rules = Regex.Split(textBoxDescription.Text, "\r\n|\r|\n");
            string[] config = rules[0].Split();
            atom = config[0];
            angle_degree = int.Parse(config[1]);
            direction = config[2];
            n = int.Parse(textBoxN.Text);
            pictureBox1.Image = bmp;
            
        }

        void ComputeResultString()
        {
            for (int i = 0; i < n; i++)
            {
                for (var pos = 0; pos < atom.Length; pos++)
                {
                    for (int rule_num = 1; rule_num < rules.Length; rule_num++)
                    {
                        var curr_rule = rules[rule_num].Split('>');
                        if (atom[pos].ToString() == curr_rule[0])
                        {
                            atom = atom.Remove(pos, 1).Insert(pos, curr_rule[1]);
                            pos += curr_rule[1].Length - 1;
                            break;
                        }
                    }
                }

                //for (int j = 1; j < rules.Length; j++)
                //{
                //    var curr_rule = rules[j].Split('>');
                //    atom = atom.Replace(curr_rule[0], curr_rule[1]);
                //}
                //MessageBox.Show(atom);
            }

            for (int j = 2; j < rules.Length; j++)
            {
                var curr_rule = rules[j].Split('>');
                atom = atom.Replace(curr_rule[0], "");
            }
            //MessageBox.Show(atom);
        }

        void Fill_Points()
        {
            
            degree_change = 0;
            //points.Push(start_position);
            double x1 = start_position.X;
            double y1 = start_position.Y;
            double x2 = start_position.X;
            double y2 = start_position.Y;
            if (direction == "right")
                x2 += LineLength;
            else
                if (direction == "left")
                x2 -= LineLength;
            else
                if (direction == "up")
                y2 += LineLength;
            else
                if (direction == "down")
                y2 -= LineLength;
            else
            {
                MessageBox.Show("Invalid direction!");
                //Fill_Points();
                return;
            }

            //MessageBox.Show(points.Peek().X + " " + points.Peek().Y);
            double x1_reserve = x1;
            double y1_reserve = y1;

            double x2_reserve = x2;
            double y2_reserve = y2;

            Stack<State> states = new Stack<State>();
            int degree_change_reserve = degree_change;
            

            Random rnd = new Random();

            Pen pen;
            Color color = Color.Black;
            if (checkBoxColor.Checked)
                color = Color.Brown;
            if (!checkBoxThickness.Checked)
                pen = new Pen(color, 1f);
            else
                pen = new Pen(color, 10f);
            Pen pen_reserve = pen;

            foreach (var atm in atom)
            {
                
                switch (atm)
                {
                    case 'F':
                        double angle = degree_change * Math.PI / 180.0;
                        var xx = x2;
                        x2 = (x1 + (x2 - x1) * Math.Cos(angle) - (y2 - y1) * Math.Sin(angle));
                        y2 = (y1 + (xx - x1) * Math.Sin(angle) + (y2 - y1) * Math.Cos(angle));
                        y2 = y1 + y1 - y2;

                        points.Push(new State(new Point((int)x1, (int)y1), new Point((int)x2, (int)y2), degree_change,(Pen)pen.Clone()));
                        pen.Width--;
                        if (checkBoxColor.Checked)
                        {
                            color = pen.Color;
                            color = Color.FromArgb(Math.Max(color.R - 20, 0), Math.Min(color.G + 20, 255), Math.Max(color.B - 20, 0));
                            pen.Color = color;
                        }
                        //MessageBox.Show(points.Peek().X + " "+ points.Peek().Y);
                        x1 = x2;
                        y1 = y2;
                        if (direction == "right")
                            x2 += LineLength;
                        else
                            if (direction == "left")
                            x2 -= LineLength;
                        else
                            if (direction == "up")
                            y2 += LineLength;
                        else
                            if (direction == "down")
                            y2 -= LineLength;

                        if (x2 >= pictureBox1.Width - 5 || y2 >= pictureBox1.Height - 5 || x2 <= 5 || y2 <= 5)
                        {
                            //while (x2 > pictureBox1.Width || y2 > pictureBox1.Height || x2 < 0 || y2 < 0)
                            LineLength -= 1;
                            //MessageBox.Show(LineLength + "");
                            if (checkBox2.Checked)
                            {
                                g.Clear(Color.White);
                                pictureBox1.Image = bmp;
                            }
                            Setup();
                            ComputeResultString();
                            while (points.Count() > 0)
                                points.Pop();
                            Fill_Points();

                            return;
                        }
                        break;
                    case '+':
                        if (!checkBox1.Checked)
                            degree_change += angle_degree;
                        else
                        {
                            int num = rnd.Next(angle_degree/2,angle_degree+angle_degree/2);
                            degree_change += num;
                        }
                        break;
                    case '-':
                        if (!checkBox1.Checked)
                            degree_change -= angle_degree;
                        else
                        {
                            int num = rnd.Next(angle_degree/2, angle_degree + angle_degree/2);
                            degree_change -= num;
                        }
                        break;
                    case '[':

                        x1_reserve = x1;
                        y1_reserve = y1;

                        x2_reserve = x2;
                        y2_reserve = y2;

                        degree_change_reserve = degree_change;

                        pen_reserve = pen;

                        states.Push(new State(new Point((int)x1_reserve, (int)y1_reserve), new Point((int)x2_reserve, (int)y2_reserve), degree_change_reserve, (Pen)pen_reserve.Clone()));
                        break;
                    case ']':
                        State curr_line = states.Pop();
                        x1 = curr_line.point1.X;
                        y1 = curr_line.point1.Y;

                        x2 = curr_line.point2.X;
                        y2 = curr_line.point2.Y;

                        degree_change = curr_line.degree;
                        pen = curr_line.pen;
                        break;
                }
            }
        }

        void Draw_Points()
        {
            while (points.Count > 0)
            {
                State line = points.Pop();
                g.DrawLine(line.pen, line.point1.X, line.point1.Y, line.point2.X, line.point2.Y) ;
                //Line_Bres(first.X, first.Y, second.X, second.Y);
            }
            pictureBox1.Image = bmp;
        }

        void Line_Bres(int x0, int y0, int x1, int y1)
        {
            int xtemp0 = x0;
            int xtemp1 = x1;
            int ytemp0 = y0;
            int ytemp1 = y1;
            if (Math.Abs(x1 - x0) < Math.Abs(y1 - y0))
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }
            int deltax = Math.Abs(x1 - x0);
            int deltay = Math.Abs(y1 - y0);
            int error = 0;
            int deltaerr = (deltay + 1);
            int y = y0;
            int diry = y1 - y0;
            if (diry > 0)
                diry = 1;
            if (diry < 0)
                diry = -1;
            for (int x = x0; x <= x1; x++)
            {
                bmp.SetPixel(Math.Abs(ytemp1 - ytemp0) > Math.Abs(xtemp1 - xtemp0) ? y : x, Math.Abs(ytemp1 - ytemp0) > Math.Abs(xtemp1 - xtemp0) ? x : y, Color.Black);
                error = error + deltaerr;
                if (error >= deltax + 1)
                {
                    y += diry;
                    error = error - (deltax + 1);
                }
            }
            pictureBox1.Image = bmp;
        }
        static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                g.Clear(Color.White);
                pictureBox1.Image = bmp;
            }
            
            Setup();
            if(start_position.X != -1)
            {
                ComputeResultString();
                LineLength = 25;
                Fill_Points();
                Draw_Points();
            }
            else
                MessageBox.Show("Определите начальное положение");
            

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            start_position.X = e.X;
            start_position.Y = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
        }

        private void buttonThickness_Click(object sender, EventArgs e)
        {

        }
    }
}
