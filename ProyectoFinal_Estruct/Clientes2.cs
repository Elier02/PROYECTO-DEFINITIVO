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
    public partial class Clientes2 : Form
    {
        public Clientes2()
        {
            InitializeComponent();
        }
        private void Clientes2_Load(object sender, EventArgs e)
        {

        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            CartaDelivery c = new CartaDelivery();
            this.Hide();
            c.Show();
        }

        private void btnRestaurante_Click(object sender, EventArgs e)
        {
            CartaRestaurante cr = new CartaRestaurante();
            this.Hide();
            cr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes v = new Clientes();
            this.Hide();
            v.Show();
        }
    }
}
