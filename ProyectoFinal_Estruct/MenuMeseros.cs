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
    public partial class MenuMeseros : Form
    {
        public MenuMeseros()
        {
            InitializeComponent();
        }
        Queue<string> colaD = new Queue<string>();
        Queue<string> colaR = new Queue<string>();

        public void MostrarD()
        {
            StreamReader read;
            read = File.OpenText("OrdenesD.txt");
            string cadena;
            string[] arreglos = new string[8];
            char[] guion = { '-' };
            cadena = read.ReadLine();
            while (cadena != null)
            {
                arreglos = cadena.Split(guion);

                colaD.Enqueue("ENTRADA:"+arreglos[0] +" -"+" PLATO DE FONDO:" + arreglos[1] +" -"+" BEBIDA:" + arreglos[2] + " -"+" NOMBRE:" + arreglos[3] + " -"+" DISTRITO:" + arreglos[4] + " -"+" DIRECCIÓN:" + arreglos[5] + " -"+" METODO PAGO:" + arreglos[6] + " -"+" TOTAL A PAGAR:S/" + arreglos[7] + "\r\n");

                cadena = read.ReadLine();

            }
            foreach (var item in colaD)
            {
                rtbDelivery.Text += item;
            }

            read.Close();
        }

        public void MostrarR()
        {
            StreamReader read;
            read = File.OpenText("OrdenesR.txt");
            string cadena;
            string[] arreglos = new string[5];
            char[] guion = { '-' };
            cadena = read.ReadLine();
            while (cadena != null)
            {
                arreglos = cadena.Split(guion);

                colaR.Enqueue("ENTRADA:" + arreglos[0] + " -" + " PLATO DE FONDO:" + arreglos[1] + " -" + " BEBIDA:" + arreglos[2] +" -"+" N° DE MESA:"+arreglos[3]+" -"+" TOTAL A PAGAR:S/" + arreglos[4] + "\r\n");

                cadena = read.ReadLine();

            }
            foreach (var item in colaR)
            {
                rtbRestaurante.Text += item;
            }

            read.Close();
        }
        private void MenuMeseros_Load(object sender, EventArgs e)
        {
            MostrarD();
            MostrarR();
            CartaDelivery c = new CartaDelivery();
        }

        private void btnAtenderD_Click(object sender, EventArgs e)
        {
            if (rtbDelivery.Text == "")
            {
                MessageBox.Show("NO HAY MAS ORDENES PARA ENVIAR", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                colaD.Dequeue();
                rtbDelivery.Clear();
                foreach (var item in colaD)
                {
                    rtbDelivery.Text += item;
                }
            }
        }

        private void btnAtenderR_Click(object sender, EventArgs e)
        {
            if (rtbRestaurante.Text == "")
            {
                MessageBox.Show("NO HAY MAS ORDENES PARA ATENDER", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                colaR.Dequeue();
                rtbRestaurante.Clear();
                foreach (var item in colaR)
                {
                    rtbRestaurante.Text += item;
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Meseros m = new Meseros();
            this.Hide();
            m.Show();
        }
    }
}
