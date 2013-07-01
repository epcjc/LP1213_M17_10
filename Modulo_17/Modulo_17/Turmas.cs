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
    public partial class Turmas : Form
    {
        public Turmas()
        {
            InitializeComponent();
        }

        private void turmasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.turmasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola_NatacaoDataSet);

        }

        private void Turmas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.DataTable4' table. You can move, or remove it, as needed.
            this.dataTable4TableAdapter.Fill(this.escola_NatacaoDataSet.DataTable4);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.escola_NatacaoDataSet.Turmas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inserir_Turmas frm = new Inserir_Turmas();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicial nf = new Inicial();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar_Turma frm = new Eliminar_Turma();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            report_tecnicas frm = new report_tecnicas();
            frm.ShowDialog();
        }
    }
}
