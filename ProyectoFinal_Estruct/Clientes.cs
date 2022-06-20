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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        string usuarioC, contraC;

        

        private void btnRegresarC_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            this.Hide();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes2 c2 = new Clientes2();
            this.Hide();
            c2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(); 
            this.Hide();
            registro.Show();
        }

        private void btnUsuarioC_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioC = txtUsuarioC.Text;
                contraC = txtContraseñaC.Text;

                StreamReader read;
                read = File.OpenText("Clientes.txt");
                string cadena;
                string[] arreglo = new string[2];
                char[] guion = { '-' };
                bool check = false;
                cadena = read.ReadLine();
                while (cadena != null && check == false)
                {
                    arreglo = cadena.Split(guion);
                    if (arreglo[0].Trim().Equals(usuarioC) && arreglo[1].Trim().Equals(contraC))
                    {
                        MessageBox.Show("Usuario y contraseña AUTORIZADA", "Login aceptado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        check = true;
                        read.Close();
                        Clientes2 c2 = new Clientes2();
                        this.Hide();
                        c2.Show();
                    }
                    else
                    {
                        cadena = read.ReadLine();
                    }
                }
                if (check == false)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Login no aceptado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseñaC.Text = "";
                    txtUsuarioC.Text = "";
                    txtUsuarioC.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
