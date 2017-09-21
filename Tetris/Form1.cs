using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//using Tetris.Klocek;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private int poziom = 0;
        private int punkty = 0;
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 1);
        PointF Srodek = new PointF(200, 200);
        PointF P2,P3, P4, P1 = new PointF(0, 0);
        Klocek ZaczepTablicyKlocka;
        private int[][] TablicaMiejsc;
        private int[][] TablicaZmian;
        private System.Timers.Timer T0;
//        private KeyEventHandler myKey;

        public event KeyPressEventHandler KeyPress;

        Button Left = new Button();
        Button Right = new Button();
        Button Down = new Button();
        Button Up = new Button();

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void RysujTablice(Klocek K = null)
        {
            g.Clear(Color.White);
            for (float i = 12.5f; i >= 250 ;i += 25)
            {
                for (float j = 12.5f; j >= 500 ; j += 25)
                {
                    RysujKwadrat(i,j);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TablicaMiejsc = new int[10][];
//            MessageBox.Show("Enter key pressed");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tetris.Autor a = new Autor();
            a.Show();
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            l_punkty.Text = "0";
            n_poziom.Text = "0";
            T0 = new System.Timers.Timer();
            T0.Interval = 2000;
            T0.Start();
            T0.Elapsed += OnTimedEvent;
            T0.AutoReset = true;
            T0.Enabled = true;
            g.Clear(Color.White);


        }

        private void RysujKwadrat(Klocek K, int X = 0, int Y = 0)
        {
            PointF[] currentPoints =
            {
                this.P1,
                this.P2,
                this.P3,
                this.P4
            };
            this.P1 = new PointF(X + 12.5f, Y + 12.5f);
            this.P2 = new PointF(X + 12.5f, Y - 12.5f);
            this.P3 = new PointF(X - 12.5f, Y - 12.5f);
            this.P4 = new PointF(X - 12.5f, Y + 12.5f);

            switch (K.Ksztalt)
            {
                case 1:
                    pen1.Color = Color.FromArgb(26, 236, 15);
                    break;
                case 2:
                    pen1.Color = Color.FromArgb(255, 80, 80);
                    break;
                case 3:
                    pen1.Color = Color.FromArgb(255, 171, 56);
                    break;
                case 4:
                    pen1.Color = Color.FromArgb(111, 111, 111);
                    break;
                case 5:
                    pen1.Color = Color.FromArgb(241, 255, 73);
                    break;
                case 6:
                    pen1.Color = Color.FromArgb(81, 175, 255);
                    break;
                case 7:
                    pen1.Color = Color.FromArgb(156, 65, 164);
                    break;


            }
            g.DrawPolygon(pen1, currentPoints);
        }

        private void RysujKwadrat(float X = 0f, float Y = 0f)
        {
            PointF[] currentPoints =
            {
                this.P1,
                this.P2,
                this.P3,
                this.P4
            };
            this.P1 = new PointF(X + 12.5f, Y + 12.5f);
            this.P2 = new PointF(X + 12.5f, Y - 12.5f);
            this.P3 = new PointF(X - 12.5f, Y - 12.5f);
            this.P4 = new PointF(X - 12.5f, Y + 12.5f);
            pen1.Color = Color.White;

            g.DrawPolygon(pen1, currentPoints );
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            czyTablicaPrzekroczona();
            czyMoznaObnizyc();
            czyNowyKlocek();
            SprawdzLinie();



        }

        private void SprawdzLinie()
        {
            //throw new NotImplementedException();
        }
        private void SkazujLinie()
        {
            //throw new NotImplementedException();
        }

        private void czyNowyKlocek()
        {
            if (ZaczepTablicyKlocka == null )
            {
                this.ZaczepTablicyKlocka = new Klocek();
                
            }
        }

        

        private void polaczTabliceKlocka()
        {
            
        }

        private void czyMoznaObnizyc()
        {
            
        }

        private void czyTablicaPrzekroczona()
        {
            
        }

        private void obnizKlocek()
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyCode == Keys.Right)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyCode == Keys.Up)
            {
                MessageBox.Show("Enter key pressed");
            }
            if (e.KeyCode == Keys.Down)
            {
                MessageBox.Show("Enter key pressed");
            }
        }
    }
}
