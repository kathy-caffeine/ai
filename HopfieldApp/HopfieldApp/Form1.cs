using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopfieldApp
{
    public partial class Form1 : Form
    {
        static Color backColor = Color.Black;
        static Color fontColor = Color.White;
        public List<Rectangle> rect = new List<Rectangle>();
        int step = 50;
        int recognised;
        Hopfield hopfield = new Hopfield();
        SolidBrush brush = new SolidBrush(fontColor);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            //bool crunch = false;
            coordinates.X = (coordinates.X / step) * step;
            coordinates.Y = (coordinates.Y / step) * step;
            int j = coordinates.X / 50 + coordinates.Y / 50 * 3;
            if (hopfield.input[j] == -1)
            {
                rect.RemoveAll(r =>
                (r.X == coordinates.X && r.Y == coordinates.Y));
                hopfield.input[j] = 1;
            }
            else
            {
                hopfield.input[j] = -1;
                rect.Add(new Rectangle(coordinates.X, coordinates.Y, step, step));
            }
            Graphics g = pictureBoxInput.CreateGraphics();
            g.Clear(backColor);
            for(int i = 0; i<rect.Count; i++)
            {
                g.FillRectangle(brush, rect[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxInput.BackColor = backColor;
            pictureBoxRes.BackColor = backColor;
            known1.Image = new Bitmap("../../1.png");
            known2.Image = new Bitmap("../../2.png");
            known3.Image = new Bitmap("../../3.png");
            known4.Image = new Bitmap("../../4.png");
        }

        private void recognise_Click(object sender, EventArgs e)
        {
            recognised = -1;
            Graphics g = pictureBoxRes.CreateGraphics();
            g.Clear(backColor);
            recognised = hopfield.recognition();
            if (recognised != -1)
            {
                List<Rectangle> rect = new List<Rectangle>();
                for(int i = 0; i<hopfield.getPower(); i++)
                {
                    if(hopfield.known[recognised, i] == -1)
                    {
                        Rectangle r = new Rectangle(i % 3 * step, i / 3 * step, step, step);
                        rect.Add(r);
                        g.FillRectangle(brush, r);
                    }
                }
            }
            else
            {
                g.Clear(Color.Red);
            }
        }
    }
}
