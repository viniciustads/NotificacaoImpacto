using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
