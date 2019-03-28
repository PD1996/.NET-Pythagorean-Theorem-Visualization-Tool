using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythagVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        Line a = new Line();
        Line b = new Line();
        Line c = new Line();

        //Add 1 to side A
        private void button1_Click(object sender, EventArgs e)
        {
            if (a.getLength() > 9)
                a.setLength(10); 
            else
                a.setLength(a.getLength() + 1);

            c.setLength(Math.Sqrt(a.getLengthSquared() + b.getLengthSquared()));

            this.label2.Text = a.getLength().ToString(); 
            
            if (a.getLengthSquared() > 0 && b.getLengthSquared() > 0)
            {
                this.label6.Text = Math.Round(c.getLength(), 3).ToString();
                this.label10.Text = a.getLengthSquared().ToString();
                this.label11.Text = b.getLengthSquared().ToString();
                this.label12.Text = c.getLengthSquared().ToString();
            }
            else
            { 
                this.label6.Text = "0";
                this.label10.Text = "0";
                this.label11.Text = "0";
                this.label12.Text = "0";
            }
            pictureBox2.Invalidate();
            pictureBox3.Invalidate();
            pictureBox4.Invalidate();
        }
        
        //Subtract 1 from side A
        private void button2_Click(object sender, EventArgs e)
        {
            if (a.getLength() < 1)
                a.setLength(0); 
            else
                a.setLength(a.getLength() - 1);

            c.setLength(Math.Sqrt(a.getLengthSquared() + b.getLengthSquared()));

            this.label2.Text = a.getLength().ToString();

            if (a.getLengthSquared() > 0 && b.getLengthSquared() > 0)
            {
                this.label6.Text = Math.Round(c.getLength(), 3).ToString();
                this.label10.Text = a.getLengthSquared().ToString();
                this.label11.Text = b.getLengthSquared().ToString();
                this.label12.Text = c.getLengthSquared().ToString();
            }
            else
            {
                this.label6.Text = "0";
                this.label10.Text = "0";
                this.label11.Text = "0";
                this.label12.Text = "0";
            }
            pictureBox2.Invalidate();
            pictureBox3.Invalidate();
            pictureBox4.Invalidate();
        }
        
        //Add 1 to side B
        private void button3_Click(object sender, EventArgs e)
        {
            if (b.getLength() > 9)
                b.setLength(10);
            else
                b.setLength(b.getLength() + 1);

            c.setLength(Math.Sqrt(a.getLengthSquared() + b.getLengthSquared()));

            this.label4.Text = b.getLength().ToString();

            if (a.getLengthSquared() > 0 && b.getLengthSquared() > 0)
            {
                this.label6.Text = Math.Round(c.getLength(), 3).ToString();
                this.label10.Text = a.getLengthSquared().ToString();
                this.label11.Text = b.getLengthSquared().ToString();
                this.label12.Text = c.getLengthSquared().ToString();
            }
            else
            {
                this.label6.Text = "0";
                this.label10.Text = "0";
                this.label11.Text = "0";
                this.label12.Text = "0";
            }
            pictureBox2.Invalidate();
            pictureBox3.Invalidate();
            pictureBox4.Invalidate();
        }
        
        //Subtract 1 from side B
        private void button4_Click(object sender, EventArgs e)
        {
            if (b.getLength() < 1)
                b.setLength(0);
            else
                b.setLength(b.getLength() - 1);

            c.setLength(Math.Sqrt(a.getLengthSquared() + b.getLengthSquared()));

            this.label4.Text = b.getLength().ToString();

            if (a.getLengthSquared() > 0 && b.getLengthSquared() > 0)
            {
                this.label6.Text = Math.Round(c.getLength(), 3).ToString();
                this.label10.Text = a.getLengthSquared().ToString();
                this.label11.Text = b.getLengthSquared().ToString();
                this.label12.Text = c.getLengthSquared().ToString();
            }
            else
            {
                this.label6.Text = "0";
                this.label10.Text = "0";
                this.label11.Text = "0";
                this.label12.Text = "0";
            }
            pictureBox2.Invalidate();
            pictureBox3.Invalidate();
            pictureBox4.Invalidate();
        }
        
        //Reset
        private void button6_Click(object sender, EventArgs e)
        {
            a.setLength(0);
            b.setLength(0);
            c.setLength(0);

            this.label2.Text = "0";
            this.label4.Text = "0";
            this.label6.Text = "0";
            this.label10.Text = "0";
            this.label11.Text = "0";
            this.label12.Text = "0";

            pictureBox2.Invalidate();
            pictureBox3.Invalidate();
            pictureBox4.Invalidate();
        }
        
        //Draw grid
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.LightGray, 1);
            
            Point[] verticles = new Point[66];
            int v = 0;
            
            for (int i = 0; i <= 640; i += 20)
            {
                verticles[v] = new Point(i, 0); 
                verticles[v + 1] = new Point(i, 640); 
                e.Graphics.DrawLine(pen, verticles[v], verticles[v + 1]);
                v += 2;
            }
            
            Point[] horizontals = new Point[66];
            int h = 0;
            
            for (int i = 0; i <= 640; i += 20)
            {
                horizontals[h] = new Point(0, i); 
                horizontals[h + 1] = new Point(640, i); 
                e.Graphics.DrawLine(pen, horizontals[h], horizontals[h + 1]); 
                h += 2;
            }
        }

        //Draw triangle lines
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Pen green = new Pen(Color.Green, 3);
            Pen blue = new Pen(Color.Blue, 3);
            Pen red = new Pen(Color.Red, 3);

            Point start = new Point(220, 420); 

            Point[] possibleDrawingLengthsA = new Point[11]; 
            int indexA = 0; 
            
            for (int i = 420; i >= 220; i -= 20)
            {
                possibleDrawingLengthsA[indexA] = new Point(220, i);
                indexA++;
            }
            
            for (int i = 0; i <= 10; i++)
            {
                if (a.getLength() == i)
                {
                    e.Graphics.DrawLine(green, start, possibleDrawingLengthsA[(int)a.getLength()]);
                    a.setDistanceFromTop(420 - i * 20);
                    a.setDistanceFromLeft(220 - i * 20);
                }
            }
           
            Point[] possibleDrawingLengthsB = new Point[11]; 
            int indexB = 0; 
            
            for (int i = 220; i <= 420; i += 20)
            {
                possibleDrawingLengthsB[indexB] = new Point(i, 420);
                indexB++;
            }
            
            for (int i = 0; i <= 10; i++)
            {
                if (b.getLength() == i)
                {
                    e.Graphics.DrawLine(blue, start, possibleDrawingLengthsB[(int)b.getLength()]);
                    b.setDistanceFromBottom(220 + i * 20);
                }
            }
            
            if (a.getLength() > 0 && b.getLength() > 0)
                e.Graphics.DrawLine(red, possibleDrawingLengthsA[(int)a.getLength()], possibleDrawingLengthsB[(int)b.getLength()]); 
        }

        //Draw 90 degree angle square
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            Pen thin = new Pen(Color.Black, 1);
            Pen medium = new Pen(Color.Black, 2);

            Rectangle smallRect90 = new Rectangle(220, 415, 5, 5);
            Rectangle midRect90 = new Rectangle(220, 410, 10, 10);
            Rectangle largeRect90 = new Rectangle(220, 400, 20, 20);

            if (a.getLength() > 0 && b.getLength() > 0)
            {
                if (a.getLength() < 3 && b.getLength() < 3)
                    e.Graphics.DrawRectangle(thin, smallRect90);
                else if (a.getLength() < 5 && b.getLength() < 5)
                    e.Graphics.DrawRectangle(thin, midRect90);
                else if (a.getLength() > 1 && b.getLength() > 1)
                    e.Graphics.DrawRectangle(medium, largeRect90);
                else
                    e.Graphics.DrawRectangle(thin, midRect90);
            }
        }

        //Draw squares for each line
        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            Pen red = new Pen(Color.Red, 2);
            Pen green = new Pen(Color.Green, 2);
            Pen blue = new Pen(Color.Blue, 2);

            Rectangle rectA = new Rectangle(a.getDistanceFromLeft(), a.getDistanceFromTop(), (int)a.getLength() * 20, (int)a.getLength() * 20);

            if (a.getLength() > 0 && b.getLength() > 0)
                e.Graphics.DrawRectangle(green, rectA);

            Rectangle rectB = new Rectangle(220, 420, (int)b.getLength() * 20, (int)b.getLength() * 20);

            if (a.getLength() > 0 && b.getLength() > 0)
                e.Graphics.DrawRectangle(blue, rectB);

            Point[] squareC = new Point[4];

            squareC[0] = new Point(b.getDistanceFromBottom(), 420);
            squareC[1] = new Point(220, a.getDistanceFromTop());
            squareC[2] = new Point(220 + (int)a.getLength() * 20, a.getDistanceFromTop() - (int)b.getLength() * 20);
            squareC[3] = new Point(b.getDistanceFromBottom() + (int)a.getLength() * 20, 420 - (int)b.getLength() * 20);

            if (a.getLength() > 0 && b.getLength() > 0)
            {
                e.Graphics.DrawPolygon(red, squareC);
            }
        }

        //Open "about" form
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.Show();
        }

        //Align all picture boxes
        private void pictureBox3_ParentChanged(object sender, EventArgs e)
        {
            pictureBox3.Parent = pictureBox1;
            pictureBox3.Location = new System.Drawing.Point(0, 0);
        }

        private void pictureBox2_ParentChanged(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox3;
            pictureBox2.Location = new System.Drawing.Point(0, 0);
        }

        private void pictureBox4_ParentChanged(object sender, EventArgs e)
        {
            pictureBox4.Parent = pictureBox2;
            pictureBox4.Location = new System.Drawing.Point(0, 0);
        }
    }
}
