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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Repetido()
        {
            string usuarioRg = txtUsuarioRe.Text;
            StreamReader read;
            read = File.OpenText("Clientes.txt");
            string cadena;
            string[] arreglos = new string[1];
            char[] guion = { '-' };
            bool check = false;
            cadena = read.ReadLine();
            while (cadena != null && check == false)
            {
                arreglos = cadena.Split(guion);
                if (arreglos[0].Trim().Equals(usuarioRg))
                {
                    MessageBox.Show("USUARIO YA REGISTRADO, INGRESE OTRO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    check = true;
                    txtUsuarioRe.Text = "";
                    txtContraseñaRe.Text = "";
                    txtRepetir.Text = "";
                    txtUsuarioRe.Focus();
                }
                else
                {
                    cadena = read.ReadLine();
                }
            }
            if (check == false)
            {
                read.Close();
                Registrar();
            }
        }

        public void Registrar()
        {
            string usuarioRg = txtUsuarioRe.Text;
            string contraRg = txtContraseñaRe.Text;
            StreamWriter generar = new StreamWriter("Clientes.txt", true);
            generar.Write(usuarioRg + "-" + contraRg + "\n");
            generar.Close();
            MessageBox.Show("USUARIO REGISTRADO CON ÉXITO", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clientes c = new Clientes();
            this.Hide();
            c.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarioRe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtContraseñaRe.Text == txtRepetir.Text)
            {
                Repetido();
            }
            else
            {
                MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN.\nINGRESE NUEVAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseñaRe.Text = "";
                txtRepetir.Text = "";
                txtContraseñaRe.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes();
            this.Hide();
            c.Show();
        }
    }
}
