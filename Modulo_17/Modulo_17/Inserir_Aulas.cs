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
    public partial class Inserir_Aulas : Form
    {
        public Inserir_Aulas()
        {
            InitializeComponent();
        }

        private void Inserir_Aulas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.inserir_aulas' table. You can move, or remove it, as needed.
            this.inserir_aulasTableAdapter.Fill(this.escola_NatacaoDataSet.inserir_aulas);
<<<<<<< HEAD
            //TODO: This line of code loads data into the 'escola_NatacaoDataSet.Tempos' table. You can move, or remove it, as needed.
=======
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Tempos' table. You can move, or remove it, as needed.
>>>>>>> cd08b6074d381193eaeda0e14d67d91a7dfb89d0
            this.temposTableAdapter.Fill(this.escola_NatacaoDataSet.Tempos);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.escola_NatacaoDataSet.Professores);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.escola_NatacaoDataSet.Turmas);
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Aulas' table. You can move, or remove it, as needed.
            this.aulasTableAdapter.Fill(this.escola_NatacaoDataSet.Aulas);

        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

            try
            {

                this.inserir_aulasTableAdapter.Insert(Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue), Convert.ToInt16(this.comboBox3.SelectedValue), this.textBox1.Text);
                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "Preencher Dia");
                }
                else
                {
                    errorProvider1.Dispose(); 
                    MessageBox.Show("Inserido com Sucesso");
                    this.Close();

                }
                //MessageBox.Show("Inserido com Sucesso");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
=======
            this.inserir_aulasTableAdapter.Insert(Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue), Convert.ToInt16(this.comboBox3.SelectedValue), this.textBox1.Text);
>>>>>>> cd08b6074d381193eaeda0e14d67d91a7dfb89d0
        }
    }
}
