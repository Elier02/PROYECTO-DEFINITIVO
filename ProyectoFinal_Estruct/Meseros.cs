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
    public partial class Meseros : Form
    {
        public Meseros()
        {
            InitializeComponent();
        }
        string usuario, contra;

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();  
            this.Hide();
            l.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = txtUsuario.Text;
                contra = txtContraseña.Text;

                StreamReader read;
                read = File.OpenText("Meseros.txt");
                string cadena;
                string[] arreglo = new string[2];
                char[] guion = { '-' };
                bool check = false;
                cadena = read.ReadLine();
                while (cadena != null && check == false)
                {
                    arreglo = cadena.Split(guion);
                    if (arreglo[0].Trim().Equals(usuario) && arreglo[1].Trim().Equals(contra))
                    {
                        MessageBox.Show("Usuario y contraseña AUTORIZADA","Login aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        check = true;  
                        MenuMeseros m = new MenuMeseros();
                        this.Hide();
                        m.Show();
                    }
                    else
                    {
                        cadena = read.ReadLine();
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos","Login no aceptado",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
