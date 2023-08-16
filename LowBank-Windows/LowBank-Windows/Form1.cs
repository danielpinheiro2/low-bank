namespace LowBank_Windows
{
    public partial class Form1 : Form
    {
        private bool FazendoDrag;


        private Cliente usuarioLogado;
        public Form1(Cliente cliente)
        {

            usuarioLogado = cliente;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PainelFundo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (FazendoDrag)
            {
                this.Location = new Point(Location.X + e.X, Location.Y + e.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            FazendoDrag = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            FazendoDrag = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // atribuir label no formulario
            textoBemVindo.Text = "Bem vindo, " + usuarioLogado.Nome + "!";

            //atribuir saldo
            saldoTexto.Text = "R$ " + usuarioLogado.Saldo.ToString("n2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioLogado.Saldo += 100;
            saldoTexto.Text = "R$ " + usuarioLogado.Saldo.ToString("n2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            usuarioLogado.Saldo -= 100;
            saldoTexto.Text = "R$ " + usuarioLogado.Saldo.ToString("n2");
        }
    }
}