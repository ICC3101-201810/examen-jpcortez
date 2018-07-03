using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PacMan_Examen
{
    public partial class pacman : Form
    {
        public pacman()
        {
            this.CenterToScreen();
            InitializeComponent();
            label1.Text = "Puntaje: 0" ;
        }

        public enum Direccion : int
        {
            arriba = 1,
            abajo = 2,
            izquierda = 3,
            derecha = 4,
            quieto = 5
        }
        int puntaje = 0;
        Direccion direccion;
        private void pacman_KeyDown(object sender, KeyEventArgs e)
        {
            #region ApretarTecla

            if (e.KeyCode == Keys.Up)
            {
                direccion = Direccion.arriba;
            }
            if (e.KeyCode == Keys.Down)
            {
                direccion = Direccion.abajo;
            }
            if (e.KeyCode == Keys.Left)
            {
                direccion = Direccion.izquierda;
            }
            else if (e.KeyCode == Keys.Right)
            {
                direccion = Direccion.derecha;
            }
            #endregion
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {

            label1.Text = "Puntaje: " + puntaje.ToString(); ;
            switch (direccion)
            {
                #region MoverPacman

                case Direccion.arriba:
                    pictureBox1.Image = Image.FromFile("pacman-up.png");
                    if (pictureBox1.Location.Y > pictureBox1.Height - 15)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 2);
                    }
                    else
                    {
                        direccion = Direccion.quieto;
                        pictureBox1.Location = new Point(pictureBox1.Location.X, 25);
                    }
                    break;
                case Direccion.abajo:
                    pictureBox1.Image = Image.FromFile("pacman-down.png");

                    if (pictureBox1.Location.Y < this.Height - 3 * 43)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 2);
                    }
                    else
                    {
                        direccion = Direccion.quieto;
                        pictureBox1.Location = new Point(pictureBox1.Location.X, 360-43);
                    }
                    break;
                case Direccion.derecha:
                    pictureBox1.Image = Image.FromFile("pacman-right.png");
                    if (pictureBox1.Location.X < this.Width - 55)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y);
                    }
                    else
                    {
                        direccion = Direccion.quieto;
                        pictureBox1.Location = new Point(this.Width - 55, pictureBox1.Location.Y);
                    }
                    break;
                case Direccion.izquierda:
                    pictureBox1.Image = Image.FromFile("pacman-left.png");
                    if (pictureBox1.Location.X > pictureBox1.Width - 43)
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X - 2, pictureBox1.Location.Y);
                    }
                    else
                    {
                        direccion = Direccion.quieto;
                        pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
                    }
                    break;
                case Direccion.quieto:
                    break;
                default:
                    break;
                    #endregion
            }
            if (Math.Abs(guinda.Location.X - pictureBox1.Location.X) < 20 && Math.Abs(guinda.Location.Y - pictureBox1.Location.Y) < 20)
            {
                if (guinda.Enabled)
                {
                    guinda.Hide();
                    guinda.Enabled = false;
                    puntaje += 10;
                }
            }
            if (Math.Abs(uva.Location.X - pictureBox1.Location.X) < 20 && Math.Abs(uva.Location.Y - pictureBox1.Location.Y) < 20)
            {
                if (uva.Enabled)
                {
                    uva.Hide();
                    uva.Enabled = false;
                    puntaje += 15;
                }
            }
            if (Math.Abs(rojo.Location.X - pictureBox1.Location.X) < 20 && Math.Abs(rojo.Location.Y - pictureBox1.Location.Y) < 20)
            {
                Salir salir = new Salir();
                this.Hide();
                salir.Show();
            }
            if (Math.Abs(rosado.Location.X - pictureBox1.Location.X) < 20 && Math.Abs(rosado.Location.Y - pictureBox1.Location.Y) < 20)
            {
                Salir salir = new Salir();
                this.Hide();
                salir.Show();
            }

        }


        private void pacman_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            #region MoverRojo
            if (rojo.Location.X < pictureBox1.Location.X)
            {
                rojo.Location = new Point(rojo.Location.X + 1, rojo.Location.Y);
            }
            else if ((rojo.Location.X > pictureBox1.Location.X))
            {
                rojo.Location = new Point(rojo.Location.X - 1, rojo.Location.Y);
            }
            else if (rojo.Location.Y < pictureBox1.Location.Y )
            {
                rojo.Location = new Point(rojo.Location.X, rojo.Location.Y + 1);
            }
            else if (rojo.Location.Y > pictureBox1.Location.Y)
            {
                rojo.Location = new Point(rojo.Location.X, rojo.Location.Y - 1);
            }
            #endregion
            #region MoverRosado
            if (rosado.Location.X < pictureBox1.Location.X)
            {
                rosado.Location = new Point(rosado.Location.X + 1, rosado.Location.Y);
            }
            else if ((rosado.Location.X > pictureBox1.Location.X))
            {
                rosado.Location = new Point(rosado.Location.X - 1, rosado.Location.Y);
            }
            else if (rosado.Location.Y < pictureBox1.Location.Y)
            {
                rosado.Location = new Point(rosado.Location.X, rosado.Location.Y + 1);
            }
            else if (rosado.Location.Y > pictureBox1.Location.Y)
            {
                rosado.Location = new Point(rosado.Location.X, rosado.Location.Y - 1);
            }
#endregion
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            Salir salir = new Salir();
            this.Hide();
            salir.Show();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }

        private void pacman_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            guinda.Enabled = true;
            uva.Enabled = true;
            Random random = new Random();
            int rxg = random.Next(0, 405);
            int ryg = random.Next(15, 360);
            int rxu = random.Next(0, 405);
            int ryu = random.Next(15, 360);
            uva.Location = new Point(rxu, ryu);
            guinda.Location = new Point(rxg, ryg);
            uva.Show();
            guinda.Show();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            uva.Hide();
            guinda.Hide();
            uva.Enabled = false;
            guinda.Enabled = false;
        }
    }
}
