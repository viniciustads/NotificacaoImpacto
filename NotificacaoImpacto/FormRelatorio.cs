using System;
using System.Windows.Forms;

namespace NotificacaoImpacto
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        { 
           BuscaDiretorios b = new BuscaDiretorios();
           elementosBindingSource.DataSource = b.GetElementos();
            
           this.reportViewer1.RefreshReport();
        }
    }
}
