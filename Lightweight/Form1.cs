using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightweight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        Graphics g;
        Cloudlet[] c = new Cloudlet[100];

        Param[] p = { new ParamCloudlet1(), new ParamCloudlet2(), new ParamCloudlet3(), new ParamCloudlet4() };
        int count = 0;
        int random;
        Random r = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled) timer2.Stop();
            else timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                if (c[i].x >= Width) continue;

                Rectangle rect = new Rectangle(c[i].x, c[i].y, c[i].p.h, 30);
                g.FillRectangle(new SolidBrush(Color.LightSkyBlue), rect);
                g.DrawRectangle(new Pen(Color.LightSkyBlue), rect);

                c[i].x += c[i].p.s;
                g.DrawImage(c[i].p.pic, new Rectangle(c[i].x, c[i].y, c[i].p.h, 30));
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            random = r.Next(0, 4);
            c[count] = new Cloudlet(e.X, e.Y, p[random]);

            g.DrawImage(c[count].p.pic, new Rectangle(c[count].x, c[count].y, c[count].p.h, 30));
            count++;
        }
    }
}
