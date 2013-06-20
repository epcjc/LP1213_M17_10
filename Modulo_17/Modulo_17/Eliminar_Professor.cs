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
    public partial class Eliminar_Professor : Form
    {
        public Eliminar_Professor()
        {
            InitializeComponent();
        }

        private void professoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola_NatacaoDataSet);

        }

        private void Eliminar_Professor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escola_NatacaoDataSet.Professores);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicial nf = new Inicial();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }
    }
}
