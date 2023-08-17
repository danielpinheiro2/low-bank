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
            if (cpfTextBox.Visible != true)
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

                var clienteResultado = conteudoArquivo
                    .Skip(1)
                    .Select(linha => Cliente.Parse(linha))
                    .FirstOrDefault(c => c.CPF == cpfDaTela);
                if (clienteResultado == null)
                {
                    MessageBox.Show("Usuário não cadastrado");
                }
                else
                {
                    if (clienteResultado.Senha == senhaTextBox.Text)
                    {
                        var homePage = new Form1(clienteResultado);
                        homePage.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("senha inválida");
                    }
                    // ir para o home page
                    Form1 homepage = new Form1(clienteResultado);
                    homepage.Show();
                    this.Hide();
                }
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

        private void senhaTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
