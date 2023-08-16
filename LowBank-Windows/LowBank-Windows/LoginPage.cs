using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowBank_Windows
{
    public partial class LoginPage : Form
    {
        private string dbPath = "C:\\Users\\Daniel\\Downloads\\LowBankBancoDeDados.csv";

        public LoginPage()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void customButton1_Click(object sender, EventArgs e)
        {
            if(cpfTextBox.Visible!= true)
            {
                this.avatarImage.Visible = false;
                this.CadastroButtom.Visible = false;
                LoginButton.Location = new Point(183, LoginButton.Location.Y);
                cpfTextBox.Visible = true;
                senhaTextBox.Visible = true;
            }

            else
            {

                // recuperar cpf
                string cpfDaTela = cpfTextBox.Text;

                //acessa arquivo
                string[] conteudoArquivo = File.ReadAllLines(dbPath);

                foreach(var linha in conteudoArquivo)
                {
                    string[] informacoesLinha = linha.Split(',');
                    string cpfLinha = informacoesLinha[0];
                    // 41:02
                }

                //quebrar informações por virgula
                string[] informacoes = conteudoArquivo[1].Split(',');

                string cpf = informacoes[0];
                string conta = informacoes[1];
                string nome = informacoes[2];
                string saldo = informacoes[3];
                decimal saldoDecimal = decimal.Parse(saldo);

                Cliente usuarioLogado = new Cliente(nome, cpf, conta, saldoDecimal);

                // ir para o home page

                Form1 homepage = new Form1(usuarioLogado);
                homepage.Show();
                this.Hide();
            }

        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
