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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Turmas nf = new Turmas();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alunos nf = new Alunos();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Professores nf = new Professores();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 nf = new Form1();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutBox1 frm = new AboutBox1();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Turmas nf = new Turmas();//Object of the form that you want to open
            this.Hide();//Hide cirrent form.
            nf.Show();//Display the next form window
        }
    }
}
