namespace NotificacaoImpacto
{
    partial class Form_NotificaoImpacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NotificaoImpacto));
            this.lb_diretorio = new System.Windows.Forms.Label();
            this.textBox_Diretorio = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lb_coluna_tabela = new System.Windows.Forms.Label();
            this.textBoxColunaTabela = new System.Windows.Forms.TextBox();
            this.pictureBoxAdiconar = new System.Windows.Forms.PictureBox();
            this.pictureBoxEditar = new System.Windows.Forms.PictureBox();
            this.pictureBoxRemover = new System.Windows.Forms.PictureBox();
            this.listBoxColunaTabela = new System.Windows.Forms.ListBox();
            this.buttonEmitir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdiconar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemover)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_diretorio
            // 
            this.lb_diretorio.AutoSize = true;
            this.lb_diretorio.Location = new System.Drawing.Point(50, 30);
            this.lb_diretorio.Name = "lb_diretorio";
            this.lb_diretorio.Size = new System.Drawing.Size(49, 13);
            this.lb_diretorio.TabIndex = 0;
            this.lb_diretorio.Text = "Diretório:";
            // 
            // textBox_Diretorio
            // 
            this.textBox_Diretorio.Location = new System.Drawing.Point(105, 30);
            this.textBox_Diretorio.Name = "textBox_Diretorio";
            this.textBox_Diretorio.Size = new System.Drawing.Size(247, 20);
            this.textBox_Diretorio.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.Location = new System.Drawing.Point(358, 28);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(36, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = ".....";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lb_coluna_tabela
            // 
            this.lb_coluna_tabela.AutoSize = true;
            this.lb_coluna_tabela.Location = new System.Drawing.Point(18, 74);
            this.lb_coluna_tabela.Name = "lb_coluna_tabela";
            this.lb_coluna_tabela.Size = new System.Drawing.Size(81, 13);
            this.lb_coluna_tabela.TabIndex = 3;
            this.lb_coluna_tabela.Text = "Coluna/Tabela:";
            // 
            // textBoxColunaTabela
            // 
            this.textBoxColunaTabela.Location = new System.Drawing.Point(105, 71);
            this.textBoxColunaTabela.Name = "textBoxColunaTabela";
            this.textBoxColunaTabela.Size = new System.Drawing.Size(216, 20);
            this.textBoxColunaTabela.TabIndex = 4;
            // 
            // pictureBoxAdiconar
            // 
            this.pictureBoxAdiconar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdiconar.Location = new System.Drawing.Point(334, 70);
            this.pictureBoxAdiconar.Name = "pictureBoxAdiconar";
            this.pictureBoxAdiconar.Size = new System.Drawing.Size(33, 21);
            this.pictureBoxAdiconar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdiconar.TabIndex = 5;
            this.pictureBoxAdiconar.TabStop = false;
            this.pictureBoxAdiconar.Click += new System.EventHandler(this.pictureBoxAdiconar_Click);
            // 
            // pictureBoxEditar
            // 
            this.pictureBoxEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEditar.Location = new System.Drawing.Point(373, 70);
            this.pictureBoxEditar.Name = "pictureBoxEditar";
            this.pictureBoxEditar.Size = new System.Drawing.Size(33, 21);
            this.pictureBoxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEditar.TabIndex = 6;
            this.pictureBoxEditar.TabStop = false;
            this.pictureBoxEditar.Click += new System.EventHandler(this.pictureBoxEditar_Click);
            // 
            // pictureBoxRemover
            // 
            this.pictureBoxRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRemover.Location = new System.Drawing.Point(412, 70);
            this.pictureBoxRemover.Name = "pictureBoxRemover";
            this.pictureBoxRemover.Size = new System.Drawing.Size(33, 21);
            this.pictureBoxRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRemover.TabIndex = 7;
            this.pictureBoxRemover.TabStop = false;
            this.pictureBoxRemover.Click += new System.EventHandler(this.pictureBoxRemover_Click);
            // 
            // listBoxColunaTabela
            // 
            this.listBoxColunaTabela.FormattingEnabled = true;
            this.listBoxColunaTabela.Location = new System.Drawing.Point(105, 106);
            this.listBoxColunaTabela.Name = "listBoxColunaTabela";
            this.listBoxColunaTabela.ScrollAlwaysVisible = true;
            this.listBoxColunaTabela.Size = new System.Drawing.Size(216, 95);
            this.listBoxColunaTabela.TabIndex = 8;
            // 
            // buttonEmitir
            // 
            this.buttonEmitir.Location = new System.Drawing.Point(370, 178);
            this.buttonEmitir.Name = "buttonEmitir";
            this.buttonEmitir.Size = new System.Drawing.Size(75, 23);
            this.buttonEmitir.TabIndex = 12;
            this.buttonEmitir.Text = "Emitir";
            this.buttonEmitir.UseVisualStyleBackColor = true;
            this.buttonEmitir.Click += new System.EventHandler(this.buttonEmitir_Click);
            // 
            // Form_NotificaoImpacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 230);
            this.Controls.Add(this.buttonEmitir);
            this.Controls.Add(this.listBoxColunaTabela);
            this.Controls.Add(this.pictureBoxRemover);
            this.Controls.Add(this.pictureBoxEditar);
            this.Controls.Add(this.pictureBoxAdiconar);
            this.Controls.Add(this.textBoxColunaTabela);
            this.Controls.Add(this.lb_coluna_tabela);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.textBox_Diretorio);
            this.Controls.Add(this.lb_diretorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_NotificaoImpacto";
            this.Text = "Notificação de Impacto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdiconar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_diretorio;
        private System.Windows.Forms.TextBox textBox_Diretorio;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lb_coluna_tabela;
        private System.Windows.Forms.TextBox textBoxColunaTabela;
        private System.Windows.Forms.PictureBox pictureBoxAdiconar;
        private System.Windows.Forms.PictureBox pictureBoxEditar;
        private System.Windows.Forms.PictureBox pictureBoxRemover;
        private System.Windows.Forms.ListBox listBoxColunaTabela;
        private System.Windows.Forms.Button buttonEmitir;
    }
}

