using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorChanger
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorButton1.Click += new EventHandler(this.colorButton1_Click);
            this.Controls.Add(colorButton1);
        }

        private void colorButton1_Click(object sender, EventArgs e)
        {
             int red = random.Next(0,256);
             int green = random.Next(0,256);
             int blue = random.Next(0,256);

            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
