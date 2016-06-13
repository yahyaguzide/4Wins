using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Gewinnt
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

        private void DrawImage(PaintEventArgs p)
        {
            Image Left = Image.FromFile("4Gewinnt\\Resource\\4Wins-LeftPart");

            Graphics myGraphics = p.Graphics;
            myGraphics.DrawImage(Left, 10, 10);
        }
    }
}
