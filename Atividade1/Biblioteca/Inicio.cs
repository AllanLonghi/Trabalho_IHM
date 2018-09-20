using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.txtTitulo.ReadOnly = true;
            this.txtNroPaginas.ReadOnly = true;
            this.txtNroExemplares.ReadOnly = true;
            this.txtGenero.ReadOnly = true;
            this.txtAutor.ReadOnly = true;

            this.btnEnviar.Enabled = false;
            this.btnExcluir.Enabled = false;

            this.rdEmprestimoLivre.Enabled = false;
            this.rdLocal.Enabled = false;
            if (this.livro == null)
            {
                this.btnEditar.Text = "Novo";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (this.estadoEntidade == 1 && this.livro == null)
            {
                this.btnEditar.Text = "Salvar";

                this.txtTitulo.ReadOnly = false;
                this.txtNroPaginas.ReadOnly = false;
                this.txtNroExemplares.ReadOnly = false;
                this.txtGenero.ReadOnly = false;
                this.txtAutor.ReadOnly = false;

                this.btnEnviar.Enabled = true;
                this.btnExcluir.Enabled = true;

                this.rdEmprestimoLivre.Enabled = true;
                this.rdLocal.Enabled = true;

                this.livro = new Livro();
                this.estadoEntidade = 2;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.livro = null;
            this.estadoEntidade = 1;
            this.pbCapa.Image = null;
            this.txtTitulo.Text = "";
            this.txtNroPaginas.Text = "";
            this.txtNroExemplares.Text = "";
            this.txtGenero.Text = "";
            this.txtAutor.Text = "";
            this.Form1_Load(sender, e);
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
