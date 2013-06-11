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
    public partial class Alunos : Form
    {
        public Alunos()
        {
            InitializeComponent();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola_NatacaoDataSet);

        }

        private void Alunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.escola_NatacaoDataSet.DataTable1);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.escola_NatacaoDataSet.Alunos);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.escola_NatacaoDataSet.Alunos);

        }

        private void alunosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola_NatacaoDataSet);

        }
    }
}
