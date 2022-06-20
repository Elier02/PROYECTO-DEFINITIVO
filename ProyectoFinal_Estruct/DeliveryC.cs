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
    public partial class DeliveryC : Form
    {
        public DeliveryC(double a,double b, double c)
        {
            InitializeComponent();
            this.a = a;
            this.b = b; 
            this.c = c;
        }

        double a,b,c;
        string metodo, nombre, direccion, distrito, precioT;
        private void DeliveryC_Load(object sender, EventArgs e)
        {
            CartaDelivery ca = new CartaDelivery();
            double Total = a + b + c;
            txtTotalD.Text = Total.ToString();
        }

        private void txtEstimacion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboxDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Distrito = cboxDistrito.Text;
            switch (Distrito)
            {
                case "Lince":
                case "Cercado de Lima":
                case "Breña": txtEstimacion.Text = "20 minutos"; break;
                case "Barranco":
                case "Chorrillos": txtEstimacion.Text = "50 minutos";break;
                case "San Juan de Lurigancho":
                case "Comas": txtEstimacion.Text = "40 minutos";break;
                case "Miraflores": txtEstimacion.Text = "10 minutos";break;
                case "Rimac":txtEstimacion.Text = "25 minutos";break;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CartaDelivery d = new CartaDelivery();
            this.Hide();
            d.Show();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked)
            {
                metodo = "Efectivo";
            }
            if (rbTarjeta.Checked)
            {
                metodo = "Tarjeta";
            }
            nombre = txtNombre.Text;
            distrito=cboxDistrito.Text;
            direccion=txtDireccion.Text;
            precioT=txtTotalD.Text;
            StreamWriter generar = new StreamWriter("OrdenesD.txt", true);
            generar.Write(nombre + "-" + distrito + "-" + direccion +"-"+metodo+"-"+precioT+"\n");
            generar.Close();
            MessageBox.Show("Orden Registrada, el motorizado irá a su dirección en el tiempo estimado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalD_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
