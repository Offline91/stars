using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace stars
{
    public partial class Form1 : Form
    {
        private float x;
        private float y;

        public Form1()
        {
            InitializeComponent();
          
        }
        private void button1_Click(object sender, EventArgs e)

        {
            Random randNum = new Random();
            int y;
            int x;

            int red, green, blue;
            red = randNum.Next(1, 256);
            green = randNum.Next(1, 256);
            blue = randNum.Next(1, 256);

            x = randNum.Next(1, this.Width);
            y = randNum.Next(1, this.Width);

            SolidBrush drawbrush = new SolidBrush(Color.FromArgb(red, green, blue, 0));
       

        }

        public void starfield(int length)
        {
            starfield(100);
            for (length = 100; length<=200; length++ )
            {
                Random randNum = new Random();

                x = randNum.Next(1, this.Width);
                y = randNum.Next(1, this.Height);

                int red, green, blue;
                red = randNum.Next(1, 256);
                green = randNum.Next(1, 256);
                blue = randNum.Next(1, 256);
                Graphics formgraphics = this.CreateGraphics();
                SolidBrush drawbrush = new SolidBrush(Color.FromArgb(red, green, blue, 0));
                formgraphics.FillEllipse(drawbrush, x, y, 25, 25);

                Thread.Sleep(50);
            }
        }
    }
}
