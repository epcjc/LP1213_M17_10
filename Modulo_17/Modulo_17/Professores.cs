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
    public partial class Professores : Form
    {
        public Professores()
        {
            InitializeComponent();
        }

        private void professoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola_NatacaoDataSet);

        }

        private void Professores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escola_NatacaoDataSet.Professores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicial nf = new Inicial();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inserir_Professores frm = new Inserir_Professores();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar_Professor frm = new Eliminar_Professor();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            report_professores frm = new report_professores();
            frm.ShowDialog();
        }
    }
}
