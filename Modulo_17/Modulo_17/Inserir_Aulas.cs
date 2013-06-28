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
            // TODO: This line of code loads data into the 'escola_NatacaoDataSet.Tempos' table. You can move, or remove it, as needed.
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
            this.inserir_aulasTableAdapter.Insert(Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue), Convert.ToInt16(this.comboBox3.SelectedValue), this.textBox1.Text);
        }
    }
}
