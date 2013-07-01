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
    public partial class report_professores : Form
    {
        public report_professores()
        {
            InitializeComponent();
        }

        private void report_professores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Escola_NatacaoDataSet.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.Escola_NatacaoDataSet.DataTable3);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
