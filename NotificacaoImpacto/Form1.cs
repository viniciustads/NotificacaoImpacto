using NotificacaoImpacto.Properties;
using System;
using System.Drawing;

using System.Windows.Forms;

namespace NotificacaoImpacto
{
    public partial class Form_NotificaoImpacto : Form
    {

        Image adicionar = Resources.file_add;
        Image editar = Resources.file_edit;
        Image remover = Resources.file_delete;

        public Form_NotificaoImpacto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBoxAdiconar.Image = adicionar;
            pictureBoxEditar.Image = editar;
            pictureBoxRemover.Image = remover;



        }

        private void pictureBoxAdiconar_Click(object sender, EventArgs e)
        {
            if(textBoxColunaTabela.Text != "")
            {
                listBoxColunaTabela.Items.Add(textBoxColunaTabela.Text);                
                textBoxColunaTabela.Clear();
            }
            else
            {
                MessageBox.Show("Adicione algum valor de pesquisa", "Valor não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxColunaTabela.Focus();
            }
                        
        }

        private void pictureBoxEditar_Click(object sender, EventArgs e)
        {
                       

            if (listBoxColunaTabela.SelectedItems.Count > 0)
            {
                textBoxColunaTabela.Text = listBoxColunaTabela.SelectedItem.ToString();                                
                listBoxColunaTabela.Items.Remove(listBoxColunaTabela.SelectedItems[0]);                
            }
            else
            {
                MessageBox.Show("Adicione algum valor de pesquisa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void pictureBoxRemover_Click(object sender, EventArgs e)
        {

            if (listBoxColunaTabela.SelectedItems.Count > 0)
            {                
                while (listBoxColunaTabela.SelectedItems.Count > 0)
                {
                    listBoxColunaTabela.Items.Remove(listBoxColunaTabela.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("Adicione algum valor de pesquisa", "Valor não removido", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        }

      

        

        private void buttonEmitir_Click(object sender, EventArgs e)
        {
            BuscaDiretorios b = new BuscaDiretorios();
                      

            if (textBox_Diretorio.Text!="")
            {
                if(listBoxColunaTabela.Items.Count>0)
                { 
            
                   b.buscar_Diretorios(textBox_Diretorio.Text, listBoxColunaTabela.Items);
                
                 
                    
                   FormRelatorio fr = new FormRelatorio();

                   fr.Show();
                }
                else
                {
                    MessageBox.Show("Selecione uma tabela/coluna na lista: ", "Elemento não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxColunaTabela.Focus();
                }

            }
            else
            {
                MessageBox.Show("Selecione um diretório: ", "Diretório não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }      
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            textBox_Diretorio.Text = fbd.SelectedPath;
        }
    }
}
