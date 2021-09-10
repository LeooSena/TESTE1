using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FPrincipal: Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cURSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CADASTROCURSO CADASTRO = new CADASTROCURSO();
            CADASTRO.ShowDialog();
        }

        private void aLUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALUNOCAD CADALUNO = new ALUNOCAD();
            CADALUNO.ShowDialog();
        }
    }
}
