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
    public partial class Eliminar_Turma : Form
    {
        public Eliminar_Turma()
        {
            InitializeComponent();
        }

        private void turmasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.turmasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola_NatacaoDataSet);

        }

        private void Eliminar_Turma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.escola_NatacaoDataSet.Turmas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicial nf = new Inicial();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }
    }
}
