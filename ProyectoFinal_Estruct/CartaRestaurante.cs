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
    public partial class CartaRestaurante : Form
    {
        public CartaRestaurante()
        {
            InitializeComponent();
        }
        string eleccion2E, eleccion2P, eleccion2B;
        string ne, np, nb, nm;
        double PrecioT;

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
                fila.CreateCells(dgvEntradasR);
                fila.Cells[0].Value = a;
                fila.Cells[1].Value = b;
                dgvEntradasR.Rows.Add(fila);
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
                fila.CreateCells(dgvPlatosR);
                fila.Cells[0].Value = a;
                fila.Cells[1].Value = b;
                dgvPlatosR.Rows.Add(fila);
                cadena = read.ReadLine();

            }
            read.Close();
        }

        private void CartaRestaurante_Load(object sender, EventArgs e)
        {
            MostrarCartaE();
            MostrarCartaP();
            MostrarCartaB();
        }

        private void btnRegresarR_Click(object sender, EventArgs e)
        {
            Clientes2 c2 = new Clientes2();
            this.Hide();
            c2.Show();
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
                fila.CreateCells(dgvBebidasR);
                fila.Cells[0].Value = a;
                fila.Cells[1].Value = b;
                dgvBebidasR.Rows.Add(fila);
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
                    double costoE = double.Parse(arreglos[1]);
                    return costoE * int.Parse(cbEntradasR.Text);
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
                    return costoP * int.Parse(cbPlatosR.Text);
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

        private void cbEntradasR_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Pentradas;
            //Entradas
            if (rbSopaR.Checked == true)
            {
                string Eleccion = "Sopa";
                eleccion2E = "Sopa";
                Pentradas = ObtenerE(Eleccion);
                txtPentradasR.Text = Pentradas.ToString();
            }
            if (rbEnsaladaR.Checked == true)
            {
                string Eleccion = "Ensalada";
                eleccion2E = "Ensalada";
                Pentradas = ObtenerE(Eleccion);
                txtPentradasR.Text = Pentradas.ToString();
            }
            if (rbWantanR.Checked == true)
            {
                string Eleccion = "Wantan";
                eleccion2E = "Wantan";
                Pentradas = ObtenerE(Eleccion);
                txtPentradasR.Text = Pentradas.ToString();
            }
            if (rbPapaR.Checked == true)
            {
                string Eleccion = "Papa a la huancaina";
                eleccion2E = "Papa a la huancaína";
                Pentradas = ObtenerE(Eleccion);
                txtPentradasR.Text = Pentradas.ToString();
            }
        }

        private void txtPentradasR_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPlatosR_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Pplatos;
            //Platos Fuertes
            if (rbChaufaR.Checked == true)
            {
                string Eleccion = "Arroz chaufa";
                eleccion2P = "Arroz chaufa";
                Pplatos = ObtenerP(Eleccion);
                txtPplatosR.Text = Pplatos.ToString();
            }
            if (rbCebicheR.Checked == true)
            {
                string Eleccion = "Cebiche";
                eleccion2P = "Cebiche";
                Pplatos = ObtenerP(Eleccion);
                txtPplatosR.Text = Pplatos.ToString();
            }
            if (rbPatoR.Checked == true)
            {
                string Eleccion = "Arroz con Pato";
                eleccion2P = "Arroz con Pato";
                Pplatos = ObtenerP(Eleccion);
                txtPplatosR.Text = Pplatos.ToString();
            }
            if (rbPolloR.Checked == true)
            {
                string Eleccion = "Pollo a la Brasa";
                eleccion2P = "Pollo a la Brasa";
                Pplatos = ObtenerP(Eleccion);
                txtPplatosR.Text = Pplatos.ToString();
            }
        }

        private void cbBebidasR_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Pbebidas;
            //Bebidas
            if (rbGaseosaR.Checked == true)
            {
                string Eleccion = "Gaseosa";
                eleccion2B = "Gaseosa";
                Pbebidas = ObtenerB(Eleccion);
                txtPbebidasR.Text = Pbebidas.ToString();
            }
            if (rbLimonadaR.Checked == true)
            {
                string Eleccion = "Limonada";
                eleccion2B = "Limonada";
                Pbebidas = ObtenerB(Eleccion);
                txtPbebidasR.Text = Pbebidas.ToString();
            }
            if (rbAguaR.Checked == true)
            {
                string Eleccion = "Agua";
                eleccion2B = "Agua";
                Pbebidas = ObtenerB(Eleccion);//18196134
                txtPbebidasR.Text = Pbebidas.ToString();
            }
        }

        private void cbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnContinuarR.Enabled = true;
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
                    return costoB * int.Parse(cbBebidasR.Text);
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

        private void btnContinuarR_Click(object sender, EventArgs e)
        {
            ne=cbEntradasR.Text;
            np=cbPlatosR.Text;
            nb = cbBebidasR.Text;
            nm = cbMesa.Text;
            PrecioT = double.Parse(txtPentradasR.Text) + double.Parse(txtPplatosR.Text) + double.Parse(txtPbebidasR.Text); 
            Registrar();
            MessageBox.Show("Orden Registrada, en un momento un mesero le traerá su pedido", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Login l = new Login();
            l.Show();

        }

        public void Registrar()
        {
            StreamWriter generar = new StreamWriter("OrdenesR.txt", true);
            generar.Write(ne + " " + eleccion2E + "-" + np + " " + eleccion2P + "-" + nb + " " + eleccion2B + "-"+ nm+"-"+PrecioT+"\n");
            generar.Close();
        }
    }
}
