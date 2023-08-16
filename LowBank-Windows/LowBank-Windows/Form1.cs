namespace LowBank_Windows
{
    public partial class Form1 : Form
    {
        private bool FazendoDrag;

        private string dbPath = "C:\\Users\\Daniel\\Downloads\\LowBankBancoDeDados.csv";

        private Cliente usuarioLogado;
        public Form1()
        {
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
            //acessa arquivo
            string[] conteudoArquivo = File.ReadAllLines(dbPath);

            //quebrar informa��es por virgula
            string[] informacoes = conteudoArquivo[1].Split(',');

            string cpf = informacoes[0];
            string conta = informacoes[1];
            string nome = informacoes[2];
            string saldo = informacoes[3];
            decimal saldoDecimal = decimal.Parse(saldo);

            usuarioLogado = new Cliente(nome, cpf, conta, saldoDecimal);

            // atribuir label no formulario
            textoBemVindo.Text = "Bem vindo, " + nome + "!";

            //atribuir saldo
            saldoTexto.Text = "R$ " + saldoDecimal.ToString("n2");
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