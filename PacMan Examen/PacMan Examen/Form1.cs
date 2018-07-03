using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan_Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            this.Hide();
            pacman pacman = new pacman();
            pacman.Show();
        }
    }
}
