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

namespace ProyectoFinal_Estruct
{
    public partial class CartaDelivery : Form
    {
        public CartaDelivery()
        {
            InitializeComponent();
        }
        public double Pentradas, Pplatos, Pbebidas;
        public string eleccion2E,eleccion2P,eleccion2B;
        public string ne, np, nb;
              

        private void dgvEntradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Carta_Load(object sender, EventArgs e)
        {
            MostrarCartaE();
            MostrarCartaP();
            MostrarCartaB();

        }

        private void RegresarCarta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes2 c = new Clientes2();
            c.Show();
            
        }

        public void MostrarCartaE()
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
                string a = arreglos[0];
                string b = arreglos[1];
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvEntradas);
                fila.Cells[0].Value = a;
                fila.Cells[1].Value = b;
                dgvEntradas.Rows.Add(fila);
                cadena = read.ReadLine();

            }
            read.Close();
        }
        public void MostrarCartaP()
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
                string a = arreglos[0];
                string b = arreglos[1];
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvPlatos);
                fila.Cells[0].Value = a;
                fila.Cells[1].Value = b;
                dgvPlatos.Rows.Add(fila);
                cadena = read.ReadLine();

            }
            read.Close();
        }
        public void MostrarCartaB()
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
                string a = arreglos[0];
                string b = arreglos[1];
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvBebidas);
                fila.Cells[0].Value = a;
                fila.Cells[1].Value = b;
                dgvBebidas.Rows.Add(fila);
                cadena = read.ReadLine();

            }
            read.Close();
        }
        //Método de Entradas
        public double ObtenerE(string a)
        {
            StreamReader read;
            read = File.OpenText("Entradas.txt");
            string cadena;
            string[] arreglos = new string[2];
            char[] guion = { '-' };
            bool check = false;
            cadena = read.ReadLine();
            while (cadena != null)
            {
                arreglos = cadena.Split(guion);
                if (arreglos[0].Trim().Equals(a))
                {
                    double costoE =double.Parse(arreglos[1]);
                    return costoE*int.Parse(cbEntradas.Text);
                    read.Close();
                    break;
                }
                else
                {
                    cadena = read.ReadLine();
                }
            }return 0;
        }
        //Método de Platos fuertes
        public double ObtenerP(string a)
        {
            StreamReader read;
            read = File.OpenText("Platos.txt");
            string cadena;
            string[] arreglos = new string[2];
            char[] guion = { '-' };
            bool check = false;
            cadena = read.ReadLine();
            while (cadena != null)
            {
                arreglos = cadena.Split(guion);
                if (arreglos[0].Trim().Equals(a))
                {
                    double costoP = double.Parse(arreglos[1]);
                    return costoP*int.Parse(cbPlatos.Text);
                    read.Close();
                    break;
                }
                else
                {
                    cadena = read.ReadLine();
                }
            }
            return 0;
        }
        //Método de Bebidas
        public double ObtenerB(string a)
        {
            StreamReader read;
            read = File.OpenText("Bebidas.txt");
            string cadena;
            string[] arreglos = new string[2];
            char[] guion = { '-' };
            bool check = false;
            cadena = read.ReadLine();
            while (cadena != null)
            {
                arreglos = cadena.Split(guion);
                if (arreglos[0].Trim().Equals(a))
                {
                    double costoB = double.Parse(arreglos[1]);
                    return costoB*int.Parse(cbBebidas.Text);
                    read.Close();
                    break;
                }
                else
                {
                    cadena = read.ReadLine();
                }
            }
            return 0;
        }

        private void cbEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Entradas
            if (rbSopa.Checked == true)
            {
                string Eleccion = "Sopa";
                eleccion2E = "Sopa";
                Pentradas = ObtenerE(Eleccion);
                txtPentradas.Text = Pentradas.ToString();
            }
            if (rbEnsalada.Checked == true)
            {
                string Eleccion = "Ensalada";
                eleccion2E = "Ensalada";
                Pentradas = ObtenerE(Eleccion);
                txtPentradas.Text = Pentradas.ToString();
            }
            if (rbWantan.Checked == true)
            {
                string Eleccion = "Wantan";
                eleccion2E = "Wantan";
                Pentradas = ObtenerE(Eleccion);
                txtPentradas.Text = Pentradas.ToString();
            }
            if (rbPapa.Checked == true)
            {
                string Eleccion = "Papa a la huancaina";
                eleccion2E = "Papa a la huancaína";
                Pentradas = ObtenerE(Eleccion);
                txtPentradas.Text = Pentradas.ToString();
            }
        }

        private void txtPplatos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbPlatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Platos Fuertes
            if (rbChaufa.Checked == true)
            {
                string Eleccion = "Arroz chaufa";
                eleccion2P = "Arroz chaufa";
                Pplatos = ObtenerP(Eleccion);
                txtPplatos.Text = Pplatos.ToString();
            }
            if (rbCebiche.Checked == true)
            {
                string Eleccion = "Cebiche";
                eleccion2P = "Cebiche";
                Pplatos = ObtenerP(Eleccion);
                txtPplatos.Text = Pplatos.ToString();
            }
            if (rbPato.Checked == true)
            {
                string Eleccion = "Arroz con Pato";
                eleccion2P = "Arroz con Pato";
                Pplatos = ObtenerP(Eleccion);
                txtPplatos.Text = Pplatos.ToString();
            }
            if (rbPollo.Checked == true)
            {
                string Eleccion = "Pollo a la Brasa";
                eleccion2P = "Pollo a la Brasa";
                Pplatos = ObtenerP(Eleccion);
                txtPplatos.Text = Pplatos.ToString();
            }
        }

        private void cbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bebidas
            if (rbGaseosa.Checked == true)
            {
                string Eleccion = "Gaseosa";
                eleccion2B = "Gaseosa";
                Pbebidas = ObtenerB(Eleccion);
                txtPbebidas.Text = Pbebidas.ToString();
            }
            if (rbLimonada.Checked == true)
            {
                string Eleccion = "Limonada";
                eleccion2B = "Limonada";
                Pbebidas = ObtenerB(Eleccion);
                txtPbebidas.Text = Pbebidas.ToString();
            }
            if (rbAgua.Checked == true)
            {
                string Eleccion = "Agua";
                eleccion2B = "Agua";
                Pbebidas = ObtenerB(Eleccion);//18196134
                txtPbebidas.Text = Pbebidas.ToString();
            }
        }

        public void btnContinuar_Click(object sender, EventArgs e)
        {

            DeliveryC dc = new DeliveryC(Pentradas,Pplatos,Pbebidas);
            ne = cbEntradas.Text;
            np = cbPlatos.Text;
            nb = cbBebidas.Text;
            Registrar();
            this.Hide();
            dc.Show();
        }

        private void rdPapa_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void Registrar()
        {
            StreamWriter generar = new StreamWriter("OrdenesD.txt", true);
            generar.Write(ne+" "+eleccion2E + "-" + np + " "+eleccion2P+ "-" + nb + " "+eleccion2B+ "-");
            generar.Close();
        }
    }
}
