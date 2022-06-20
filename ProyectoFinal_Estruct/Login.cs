namespace ProyectoFinal_Estruct
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Meseros m = new Meseros();
            this.Hide();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Administrador a=new Administrador();    
            this.Hide();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClienteL_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes(); 
            this.Hide();
            c.Show();
        }
    }
}