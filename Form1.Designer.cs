namespace projeto_reajuste
{
    partial class frm_Reajuste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reajuste));
            this.rdb_DesenvolvedorWeb = new System.Windows.Forms.RadioButton();
            this.rdb_Programador = new System.Windows.Forms.RadioButton();
            this.rdb_Designer = new System.Windows.Forms.RadioButton();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.lbl_Reajuste = new System.Windows.Forms.Label();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.txt_Reajuste = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.pcb_Imagens = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Imagens)).BeginInit();
            this.SuspendLayout();
            // 
            // rdb_DesenvolvedorWeb
            // 
            this.rdb_DesenvolvedorWeb.AutoSize = true;
            this.rdb_DesenvolvedorWeb.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_DesenvolvedorWeb.Location = new System.Drawing.Point(22, 120);
            this.rdb_DesenvolvedorWeb.Name = "rdb_DesenvolvedorWeb";
            this.rdb_DesenvolvedorWeb.Size = new System.Drawing.Size(178, 23);
            this.rdb_DesenvolvedorWeb.TabIndex = 2;
            this.rdb_DesenvolvedorWeb.TabStop = true;
            this.rdb_DesenvolvedorWeb.Text = "Desenvolvedor Web";
            this.rdb_DesenvolvedorWeb.UseVisualStyleBackColor = true;
            this.rdb_DesenvolvedorWeb.CheckedChanged += new System.EventHandler(this.rdb_DesenvolvedorWeb_CheckedChanged);
            // 
            // rdb_Programador
            // 
            this.rdb_Programador.AutoSize = true;
            this.rdb_Programador.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Programador.Location = new System.Drawing.Point(22, 154);
            this.rdb_Programador.Name = "rdb_Programador";
            this.rdb_Programador.Size = new System.Drawing.Size(127, 23);
            this.rdb_Programador.TabIndex = 3;
            this.rdb_Programador.TabStop = true;
            this.rdb_Programador.Text = "Programador";
            this.rdb_Programador.UseVisualStyleBackColor = true;
            this.rdb_Programador.CheckedChanged += new System.EventHandler(this.rdb_Programador_CheckedChanged);
            // 
            // rdb_Designer
            // 
            this.rdb_Designer.AutoSize = true;
            this.rdb_Designer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Designer.Location = new System.Drawing.Point(22, 188);
            this.rdb_Designer.Name = "rdb_Designer";
            this.rdb_Designer.Size = new System.Drawing.Size(94, 23);
            this.rdb_Designer.TabIndex = 4;
            this.rdb_Designer.TabStop = true;
            this.rdb_Designer.Text = "Designer";
            this.rdb_Designer.UseVisualStyleBackColor = true;
            this.rdb_Designer.CheckedChanged += new System.EventHandler(this.rdb_Designer_CheckedChanged);
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salario.Location = new System.Drawing.Point(19, 78);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(61, 17);
            this.lbl_Salario.TabIndex = 3;
            this.lbl_Salario.Text = "Salário:";
            // 
            // lbl_Reajuste
            // 
            this.lbl_Reajuste.AutoSize = true;
            this.lbl_Reajuste.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reajuste.Location = new System.Drawing.Point(225, 220);
            this.lbl_Reajuste.Name = "lbl_Reajuste";
            this.lbl_Reajuste.Size = new System.Drawing.Size(76, 19);
            this.lbl_Reajuste.TabIndex = 4;
            this.lbl_Reajuste.Text = "Reajuste:";
            // 
            // txt_Salario
            // 
            this.txt_Salario.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Salario.ForeColor = System.Drawing.Color.Black;
            this.txt_Salario.Location = new System.Drawing.Point(78, 76);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(95, 23);
            this.txt_Salario.TabIndex = 1;
            this.txt_Salario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Salario_KeyPress);
            // 
            // txt_Reajuste
            // 
            this.txt_Reajuste.Enabled = false;
            this.txt_Reajuste.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reajuste.Location = new System.Drawing.Point(229, 242);
            this.txt_Reajuste.Name = "txt_Reajuste";
            this.txt_Reajuste.Size = new System.Drawing.Size(133, 25);
            this.txt_Reajuste.TabIndex = 6;
            this.txt_Reajuste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.Peru;
            this.btn_Calcular.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.ForeColor = System.Drawing.Color.White;
            this.btn_Calcular.Location = new System.Drawing.Point(33, 235);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(140, 36);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(27, 9);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(339, 19);
            this.lbl_Texto.TabIndex = 9;
            this.lbl_Texto.Text = "Bem-vindo a calculadora de reajuste salarial!";
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Peru;
            this.btn_Sair.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(251, 283);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(94, 31);
            this.btn_Sair.TabIndex = 7;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(19, 45);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(54, 17);
            this.lbl_Nome.TabIndex = 10;
            this.lbl_Nome.Text = "Nome:";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.ForeColor = System.Drawing.Color.Black;
            this.txt_Nome.Location = new System.Drawing.Point(78, 42);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(284, 25);
            this.txt_Nome.TabIndex = 0;
            this.txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nome_KeyPress);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.Peru;
            this.btn_Limpar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(49, 283);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(94, 31);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // pcb_Imagens
            // 
            this.pcb_Imagens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcb_Imagens.Location = new System.Drawing.Point(229, 92);
            this.pcb_Imagens.Name = "pcb_Imagens";
            this.pcb_Imagens.Size = new System.Drawing.Size(133, 120);
            this.pcb_Imagens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_Imagens.TabIndex = 8;
            this.pcb_Imagens.TabStop = false;
            // 
            // frm_Reajuste
            // 
            this.AcceptButton = this.btn_Calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 326);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.pcb_Imagens);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Reajuste);
            this.Controls.Add(this.txt_Salario);
            this.Controls.Add(this.lbl_Reajuste);
            this.Controls.Add(this.lbl_Salario);
            this.Controls.Add(this.rdb_Designer);
            this.Controls.Add(this.rdb_Programador);
            this.Controls.Add(this.rdb_DesenvolvedorWeb);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Peru;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Reajuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reajuste";
            this.Load += new System.EventHandler(this.frm_Reajuste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Imagens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_DesenvolvedorWeb;
        private System.Windows.Forms.RadioButton rdb_Programador;
        private System.Windows.Forms.RadioButton rdb_Designer;
        private System.Windows.Forms.Label lbl_Salario;
        private System.Windows.Forms.Label lbl_Reajuste;
        private System.Windows.Forms.TextBox txt_Salario;
        private System.Windows.Forms.TextBox txt_Reajuste;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.PictureBox pcb_Imagens;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

