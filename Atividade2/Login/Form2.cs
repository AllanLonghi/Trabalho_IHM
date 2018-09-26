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
            bool valido = true;
            errProv.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtNascimento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            errProv.Clear();
            foreach (Control c in this.Controls)
            {
                if ((c is TextBox && ((TextBox)c).Text.Equals("")) || (c is MaskedTextBox && ((MaskedTextBox)c).Text.Equals("")))
                {
                    errProv.SetError(c, "Obrigatório.");
                    valido = false;
                }
            }
            txtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtNascimento.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            return valido;
        }

        private void Salva()
        {
            if (ValidaUsuario()){
                using (StreamWriter w = new StreamWriter(Form1.Arquivo, true))
                {
                    if (ValidaDados())
                    {
                        w.WriteLine(txtNome.Text + ";" + txtSNome.Text + ";" + txtCPF.Text.Replace(",", ".") + ";" + txtNascimento.Text + ";" + txtUsuario.Text + ";" + txtSenha.Text);
                        this.Close();
                    }
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

        private bool ValidaUsuario()
        {
            string[] dados;
            using (StreamReader r = new StreamReader(Form1.Arquivo))
            {
                while (!r.EndOfStream)
                {
                    dados = r.ReadLine().Split(';');
                    if (dados[4].Equals(this.txtUsuario.Text))
                    {
                        MessageBox.Show("Usuário já cadastrado.");
                        txtUsuario.Focus();
                        return false;   
                    }

                }
            }
            return true;
        }
    }
}
