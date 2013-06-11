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
    public partial class Inserir_Turmas : Form
    {
        public Inserir_Turmas()
        {
            InitializeComponent();
        }

        private void turmasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.turmasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola_NatacaoDataSet);

        }

        private void Inserir_Turmas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escola_NatacaoDataSet.Professores);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escola_NatacaoDataSet.Professores);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escola_NatacaoDataSet.Professores);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escola_NatacaoDataSet.Professores);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Tecnicas' table. You can move, or remove it, as needed.
            this.tecnicasTableAdapter.Fill(this.escola_NatacaoDataSet.Tecnicas);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escola_NatacaoDataSet.Professores);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.escola_NatacaoDataSet.Turmas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.turmasTableAdapter.Insert(this.textBox1.Text, Convert.ToInt16(comboBox1.SelectedValue), Convert.ToInt16(comboBox2.SelectedValue));

            try
            {

                this.turmasTableAdapter.Insert(this.textBox1.Text, Convert.ToInt16(comboBox1.SelectedValue), Convert.ToInt16(comboBox2.SelectedValue));
                MessageBox.Show("Inserido com Sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
