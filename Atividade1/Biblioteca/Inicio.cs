using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Inicio : Form
    {
        //1 - read, 2 - edit.
        int estadoEntidade = 1;
        Livro livro = null;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTitulo.ReadOnly = true;
            txtNroPaginas.ReadOnly = true;
            txtNroExemplares.ReadOnly = true;
            txtGenero.ReadOnly = true;
            txtAutor.ReadOnly = true;

            btnEnviar.Enabled = false;


            rdEmprestimoLivre.Enabled = false;
            rdLocal.Enabled = false;
            if (livro == null)
            {
                btnExcluir.Enabled = false;
                btnEditar.Text = "Novo";
            }
            else
            {
                btnExcluir.Enabled = true;
                btnEditar.Text = "Editar";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (estadoEntidade == 1 && livro == null)
            {
                TornarEntidadeEdicao();

                livro = new Livro();
            }
            else if (estadoEntidade == 2 && livro != null)
            {
                var houveErro = false;
                errorProvider.Clear();
                errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;


                foreach (var item in Controls.OfType<TextBox>())
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        errorProvider.SetError(item, $"Campo obrigatório.");
                        houveErro = true;
                    }
                }
                if (houveErro)
                {
                    return;
                }

                SalvarInformacoesEntidade();
                estadoEntidade = 1;
                Form1_Load(sender, e);
            }
            else if (estadoEntidade == 1 && livro != null)
            {
                TornarEntidadeEdicao();
            }

        }

        private void SalvarInformacoesEntidade()
        {
            livro.Autor = txtAutor.Text;
            livro.Capa = pbCapa.Image;
            livro.Disponibilidade = (rdLocal.Checked ? 1 : 2);
            livro.Genero = txtGenero.Text;
            livro.NumeroExemplares = Convert.ToInt32(txtNroExemplares.Text);
            livro.NumeroPaginas = Convert.ToInt32(txtNroPaginas.Text);
            livro.Titulo = txtTitulo.Text;
        }

        private void TornarEntidadeEdicao()
        {
            btnEditar.Text = "Salvar";

            txtTitulo.ReadOnly = false;
            txtNroPaginas.ReadOnly = false;
            txtNroExemplares.ReadOnly = false;
            txtGenero.ReadOnly = false;
            txtAutor.ReadOnly = false;

            btnEnviar.Enabled = true;
            btnExcluir.Enabled = true;

            rdEmprestimoLivre.Enabled = true;
            rdLocal.Enabled = true;
            estadoEntidade = 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LimparRegistro();
            errorProvider.Clear();
            Form1_Load(sender, e);
        }

        private void LimparRegistro()
        {
            livro = null;
            estadoEntidade = 1;
            pbCapa.Image = null;
            txtTitulo.Text = "";
            txtNroPaginas.Text = "";
            txtNroExemplares.Text = "";
            txtGenero.Text = "";
            txtAutor.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbCapa.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
