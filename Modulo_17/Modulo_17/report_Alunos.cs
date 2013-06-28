using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Modulo_17
{
    public partial class report_Alunos : Form
    {
        public report_Alunos()
        {
            InitializeComponent();
        }

        private void report_Alunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Escola_NatacaoDataSet.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.Escola_NatacaoDataSet.DataTable2);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
