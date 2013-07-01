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
    public partial class Inserir_Professores : Form
    {
        public Inserir_Professores()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Preencher Nome");
            }
            else
            {
                this.professoresTableAdapter.Insert(this.textBox1.Text);
                errorProvider1.Dispose(); MessageBox.Show("Inserido com Sucesso");
                this.Close();
            }
            //MessageBox.Show("Inserido com Sucesso");
        }

        private void professoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola_NatacaoDataSet);

        }

        private void Inserir_Professores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escola_NatacaoDataSet.Professores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
