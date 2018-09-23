using System;
using System.Windows.Forms;
using System.IO;

namespace Login
{
    public partial class Form1 : Form
    {
        public static string Arquivo { get; set; }
        public Form1()
        {
            InitializeComponent();
            Arquivo = "C:\\Users\\Allan\\Desktop\\Trabalho_IHM\\login.login";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LerArquivo();
        }

        private void LerArquivo()
        {
            string[] dados;
            bool logou = false;

            if (this.txtUsuario.Text.Equals("admin") && this.txtSenha.Text.Equals("admin"))
            {
                MessageBox.Show("Bem Vindo Administrador!");
            }
            else
            {
                if (File.Exists(Arquivo))
                {
                    using (StreamReader r = new StreamReader(Arquivo))
                    {
                        while (!r.EndOfStream)
                        {
                            dados = r.ReadLine().Split(';');
                            if (dados[4].Equals(this.txtUsuario.Text) && dados[5].Equals(this.txtSenha.Text))
                            {
                                MessageBox.Show("Bem Vindo " + dados[0] + " " + dados[1] + "! \nNascido em: " + dados[3] + "\nCPF: " + dados[2]);
                                logou = true;
                            }

                        }

                        if (!logou)
                        {
                            MessageBox.Show("Cadastro não encontrado!");
                            txtUsuario.Focus();
                        }
                    }
                }else
                {
                    AbreCad();
                }
            }
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            AbreCad();
        }

        private void AbreCad()
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
