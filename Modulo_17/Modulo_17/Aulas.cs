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
    public partial class Aulas : Form
    {
        public Aulas()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void Aulas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.DataTable5' table. You can move, or remove it, as needed.
            this.dataTable5TableAdapter.Fill(this.escola_NatacaoDataSet.DataTable5);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Insert' table. You can move, or remove it, as needed.
            //this.insertTableAdapter.Fill(this.escola_NatacaoDataSet.Insert);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inserir_Aulas frm = new Inserir_Aulas();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicial nf = new Inicial();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }
=======
>>>>>>> cd08b6074d381193eaeda0e14d67d91a7dfb89d0
    }
}
