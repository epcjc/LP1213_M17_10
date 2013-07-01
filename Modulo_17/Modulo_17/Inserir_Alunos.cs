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
    public partial class Inserir_Alunos : Form
    {
        public Inserir_Alunos()
        {
            InitializeComponent();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.escola_NatacaoDataSet);

        }

        private void Inserir_Alunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.escola_NatacaoDataSet.Turmas);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.escola_NatacaoDataSet.Alunos);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.alunosTableAdapter.Insert(this.textBox1.Text, Convert.ToInt16(comboBox1.SelectedValue));
            try
            {

                this.alunosTableAdapter.Insert(this.textBox1.Text, Convert.ToInt16(comboBox1.SelectedValue));
                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "Preencher Nome");
                }
                else
                {
                    errorProvider1.Dispose(); MessageBox.Show("Inserido com Sucesso");
                    this.Close();
                }
                //MessageBox.Show("Inserido com Sucesso");
                
                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
