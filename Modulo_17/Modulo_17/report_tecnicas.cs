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
    public partial class report_tecnicas : Form
    {
        public report_tecnicas()
        {
            InitializeComponent();
        }

        private void report_tecnicas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Escola_NatacaoDataSet.Tecnicas' table. You can move, or remove it, as needed.
            this.TecnicasTableAdapter.Fill(this.Escola_NatacaoDataSet.Tecnicas);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
