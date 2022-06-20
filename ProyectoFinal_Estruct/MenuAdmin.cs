using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Estruct
{
    public partial class MenuAdmin : Form
    {
        
        public MenuAdmin()
        {
            InitializeComponent();
        }
        Queue<string> colaE = new Queue<string>();
        Queue<string> colaP = new Queue<string>();
        Queue<string> colaB = new Queue<string>();

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            MostrarE();
            MostrarP();
            MostrarB();
        }

        private void btnVerificar1_Click(object sender, EventArgs e)
        {
            if (rtbEntradas.Text == "")
            {
                MessageBox.Show("NO HAY MAS ENTRADAS PARA VERIFICAR", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                colaE.Dequeue();
                rtbEntradas.Clear();
                foreach (var item in colaE)
                {
                    rtbEntradas.Text += item;
                }
            } 
        }

        public void MostrarE()
        {
            StreamReader read;
            read = File.OpenText("Entradas.txt");
            string cadena;
            string[] arreglos = new string[2];
            char[] guion = { '-' };
            cadena = read.ReadLine();
            while (cadena != null)
            {
                arreglos = cadena.Split(guion);

                colaE.Enqueue(arreglos[0] + "-" + arreglos[1] + "\r\n");
                //MessageBox.Show();

                cadena = read.ReadLine();

            }
            foreach (var item in colaE)
            {
                rtbEntradas.Text += item;
            }

            read.Close();
        }

        public void MostrarP()
        {
            StreamReader read;
            read = File.OpenText("Platos.txt");
            string cadena;
            string[] arreglos = new string[2];
            char[] guion = { '-' };
            cadena = read.ReadLine();
            while (cadena != null)
            {
                arreglos = cadena.Split(guion);

                colaP.Enqueue(arreglos[0] + "-" + arreglos[1] + "\r\n");
                //MessageBox.Show();

                cadena = read.ReadLine();

            }
            foreach (var item in colaP)
            {
                rtbPlatos.Text += item;
            }

            read.Close();
        }

        public void MostrarB()
        {
            StreamReader read;
            read = File.OpenText("Bebidas.txt");
            string cadena;
            string[] arreglos = new string[2];
            char[] guion = { '-' };
            cadena = read.ReadLine();
            while (cadena != null)
            {
                arreglos = cadena.Split(guion);

                colaB.Enqueue(arreglos[0] + "-" + arreglos[1] + "\r\n");
                //MessageBox.Show();

                cadena = read.ReadLine();

            }
            foreach (var item in colaB)
            {
                rtbBebidas.Text += item;
            }

            read.Close();
        }

        private void btnVerificar2_Click(object sender, EventArgs e)
        {
            if (rtbPlatos.Text == "")
            {
                MessageBox.Show("NO HAY MAS PLATOS PARA VERIFICAR", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                colaP.Dequeue();
                rtbPlatos.Clear();
                foreach (var item in colaP)
                {
                    rtbPlatos.Text += item;
                }
            }
        }

        private void btnVerificar3_Click(object sender, EventArgs e)
        {
            if (rtbBebidas.Text == "")
            {
                MessageBox.Show("NO HAY MAS BEBIDAS PARA VERIFICAR", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                colaB.Dequeue();
                rtbBebidas.Clear();
                foreach (var item in colaB)
                {
                    rtbBebidas.Text += item;
                }
            }
        }
    }
}
