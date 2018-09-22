namespace Biblioteca
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroPaginas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroExemplares = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rdEmprestimoLivre = new System.Windows.Forms.RadioButton();
            this.rdLocal = new System.Windows.Forms.RadioButton();
            this.pbCapa = new System.Windows.Forms.PictureBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(491, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capa";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(464, 22);
            this.txtTitulo.TabIndex = 3;
            this.txtTitulo.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulo";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(12, 74);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(464, 22);
            this.txtAutor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(12, 119);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(146, 22);
            this.txtGenero.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gênero";
            // 
            // txtNroPaginas
            // 
            this.txtNroPaginas.Location = new System.Drawing.Point(164, 119);
            this.txtNroPaginas.Name = "txtNroPaginas";
            this.txtNroPaginas.Size = new System.Drawing.Size(147, 22);
            this.txtNroPaginas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número de Páginas";
            // 
            // txtNroExemplares
            // 
            this.txtNroExemplares.Location = new System.Drawing.Point(317, 119);
            this.txtNroExemplares.Name = "txtNroExemplares";
            this.txtNroExemplares.Size = new System.Drawing.Size(159, 22);
            this.txtNroExemplares.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Número de exemplares";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rdEmprestimoLivre);
            this.panel1.Controls.Add(this.rdLocal);
            this.panel1.Location = new System.Drawing.Point(12, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 49);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Disponibilidade";
            // 
            // rdEmprestimoLivre
            // 
            this.rdEmprestimoLivre.AutoSize = true;
            this.rdEmprestimoLivre.Location = new System.Drawing.Point(119, 25);
            this.rdEmprestimoLivre.Name = "rdEmprestimoLivre";
            this.rdEmprestimoLivre.Size = new System.Drawing.Size(133, 21);
            this.rdEmprestimoLivre.TabIndex = 1;
            this.rdEmprestimoLivre.TabStop = true;
            this.rdEmprestimoLivre.Text = "Empréstimo livre";
            this.rdEmprestimoLivre.UseVisualStyleBackColor = true;
            // 
            // rdLocal
            // 
            this.rdLocal.AutoSize = true;
            this.rdLocal.Location = new System.Drawing.Point(3, 25);
            this.rdLocal.Name = "rdLocal";
            this.rdLocal.Size = new System.Drawing.Size(63, 21);
            this.rdLocal.TabIndex = 0;
            this.rdLocal.TabStop = true;
            this.rdLocal.Text = "Local";
            this.rdLocal.UseVisualStyleBackColor = true;
            // 
            // pbCapa
            // 
            this.pbCapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCapa.Location = new System.Drawing.Point(494, 29);
            this.pbCapa.Name = "pbCapa";
            this.pbCapa.Size = new System.Drawing.Size(314, 229);
            this.pbCapa.TabIndex = 13;
            this.pbCapa.TabStop = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(494, 264);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 32);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(401, 264);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 32);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(320, 264);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 32);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.Button4_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 314);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.pbCapa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNroExemplares);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNroPaginas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Início";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroPaginas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNroExemplares;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdEmprestimoLivre;
        private System.Windows.Forms.RadioButton rdLocal;
        private System.Windows.Forms.PictureBox pbCapa;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

