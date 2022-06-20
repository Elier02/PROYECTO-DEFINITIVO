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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }
        string usuarioA,contraA;
        
        private void btnRegresarA_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void btnUsuarioA_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioA = txtUsuarioA.Text;
                contraA = txtContraseñaA.Text;

                StreamReader read;
                read = File.OpenText("Administrador.txt");
                string cadena;
                string[] arreglo = new string[2];
                char[] guion = { '-' };
                bool check = false;
                cadena = read.ReadLine();
                while (cadena != null && check == false)
                {
                    arreglo = cadena.Split(guion);
                    if (arreglo[0].Trim().Equals(usuarioA) && arreglo[1].Trim().Equals(contraA))
                    {
                        MessageBox.Show("Usuario y contraseña AUTORIZADA", "Login aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        check = true;
                        MenuAdmin m = new MenuAdmin();
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
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Login no aceptado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuarioA.Text = "";
                    txtContraseñaA.Text = "";
                    txtUsuarioA.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
