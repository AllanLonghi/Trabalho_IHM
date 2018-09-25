using System;
using System.IO;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            ValidaArquivo();
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (File.Exists(Form1.Arquivo))
            {
                Salva();
            }
            else
            {
                File.Create(Form1.Arquivo);
                Salva();
            }


        }

        private bool ValidaDados()
        {
            foreach(Control c in this.Controls)
            {
                if ((c is TextBox && ((TextBox)c).Text.Equals("")) || (c is MaskedTextBox && ((MaskedTextBox)c).Text.Equals("")))
                {
                    MessageBox.Show("Todos os dados devem ser preenchidos!");
                    c.Focus();
                    return false;
                }
            }

            return true;
        }

        private void Salva()
        {
            using (StreamWriter w = new StreamWriter(Form1.Arquivo, true))
            {
                if (ValidaDados())
                {
                    w.WriteLine(txtNome.Text + ";" + txtSNome.Text + ";" + txtCPF.Text + ";" + txtNascimento.Text + ";" + txtUsuario.Text + ";" + txtSenha.Text);
                    this.Close();
                }
            }

        }

        private void ValidaArquivo()
        {
            if (!File.Exists(Form1.Arquivo))
            {
                var fileStream = File.Create(Form1.Arquivo);
                fileStream.Close();
            }
        }
    }
}
