namespace Modulo_17
{
    partial class Inserir_Aulas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label professorLabel;
            System.Windows.Forms.Label diaLabel;
            System.Windows.Forms.Label hora_inicioLabel;
            this.escola_NatacaoDataSet = new Modulo_17.Escola_NatacaoDataSet();
            this.aulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aulasTableAdapter = new Modulo_17.Escola_NatacaoDataSetTableAdapters.AulasTableAdapter();
            this.tableAdapterManager = new Modulo_17.Escola_NatacaoDataSetTableAdapters.TableAdapterManager();
            this.professoresTableAdapter = new Modulo_17.Escola_NatacaoDataSetTableAdapters.ProfessoresTableAdapter();
            this.temposTableAdapter = new Modulo_17.Escola_NatacaoDataSetTableAdapters.TemposTableAdapter();
            this.turmasTableAdapter = new Modulo_17.Escola_NatacaoDataSetTableAdapters.TurmasTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.turmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.professoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.temposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.inserir_aulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inserir_aulasTableAdapter = new Modulo_17.Escola_NatacaoDataSetTableAdapters.inserir_aulasTableAdapter();
            descricaoLabel = new System.Windows.Forms.Label();
            professorLabel = new System.Windows.Forms.Label();
            diaLabel = new System.Windows.Forms.Label();
            hora_inicioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.escola_NatacaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inserir_aulasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(43, 90);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(40, 13);
            descricaoLabel.TabIndex = 0;
            descricaoLabel.Text = "Turma:";
            // 
            // professorLabel
            // 
            professorLabel.AutoSize = true;
            professorLabel.Location = new System.Drawing.Point(43, 116);
            professorLabel.Name = "professorLabel";
            professorLabel.Size = new System.Drawing.Size(53, 13);
            professorLabel.TabIndex = 2;
            professorLabel.Text = "professor:";
            // 
            // diaLabel
            // 
            diaLabel.AutoSize = true;
            diaLabel.Location = new System.Drawing.Point(43, 147);
            diaLabel.Name = "diaLabel";
            diaLabel.Size = new System.Drawing.Size(24, 13);
            diaLabel.TabIndex = 4;
            diaLabel.Text = "dia:";
            // 
            // hora_inicioLabel
            // 
            hora_inicioLabel.AutoSize = true;
            hora_inicioLabel.Location = new System.Drawing.Point(43, 173);
            hora_inicioLabel.Name = "hora_inicioLabel";
            hora_inicioLabel.Size = new System.Drawing.Size(58, 13);
            hora_inicioLabel.TabIndex = 6;
            hora_inicioLabel.Text = "hora inicio:";
            // 
            // escola_NatacaoDataSet
            // 
            this.escola_NatacaoDataSet.DataSetName = "Escola_NatacaoDataSet";
            this.escola_NatacaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aulasBindingSource
            // 
            this.aulasBindingSource.DataMember = "Aulas";
            this.aulasBindingSource.DataSource = this.escola_NatacaoDataSet;
            // 
            // aulasTableAdapter
            // 
            this.aulasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HorariosTurmaTableAdapter = null;
            this.tableAdapterManager.inserir_aulasTableAdapter = null;
            this.tableAdapterManager.ProfessoresTableAdapter = this.professoresTableAdapter;
            this.tableAdapterManager.TecnicasTableAdapter = null;
            this.tableAdapterManager.TemposTableAdapter = this.temposTableAdapter;
            this.tableAdapterManager.TurmasTableAdapter = this.turmasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Modulo_17.Escola_NatacaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UtilizadoresTableAdapter = null;
            // 
            // professoresTableAdapter
            // 
            this.professoresTableAdapter.ClearBeforeFill = true;
            // 
            // temposTableAdapter
            // 
            this.temposTableAdapter.ClearBeforeFill = true;
            // 
            // turmasTableAdapter
            // 
            this.turmasTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.turmasBindingSource;
            this.comboBox1.DisplayMember = "descricao";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "id_turma";
            // 
            // turmasBindingSource
            // 
            this.turmasBindingSource.DataMember = "Turmas";
            this.turmasBindingSource.DataSource = this.escola_NatacaoDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.professoresBindingSource;
            this.comboBox2.DisplayMember = "professor";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(107, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.ValueMember = "id_professor";
            // 
            // professoresBindingSource
            // 
            this.professoresBindingSource.DataMember = "Professores";
            this.professoresBindingSource.DataSource = this.escola_NatacaoDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.temposBindingSource;
            this.comboBox3.DisplayMember = "hora_inicio";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(107, 170);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.ValueMember = "id_tempo";
            // 
            // temposBindingSource
            // 
            this.temposBindingSource.DataMember = "Tempos";
            this.temposBindingSource.DataSource = this.escola_NatacaoDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inserir_aulasBindingSource
            // 
            this.inserir_aulasBindingSource.DataMember = "inserir_aulas";
            this.inserir_aulasBindingSource.DataSource = this.escola_NatacaoDataSet;
            // 
            // inserir_aulasTableAdapter
            // 
            this.inserir_aulasTableAdapter.ClearBeforeFill = true;
            // 
            // Inserir_Aulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(professorLabel);
            this.Controls.Add(diaLabel);
            this.Controls.Add(hora_inicioLabel);
            this.Name = "Inserir_Aulas";
            this.Text = "Inserir_Aulas";
            this.Load += new System.EventHandler(this.Inserir_Aulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.escola_NatacaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inserir_aulasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Escola_NatacaoDataSet escola_NatacaoDataSet;
        private System.Windows.Forms.BindingSource aulasBindingSource;
        private Escola_NatacaoDataSetTableAdapters.AulasTableAdapter aulasTableAdapter;
        private Escola_NatacaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Escola_NatacaoDataSetTableAdapters.TurmasTableAdapter turmasTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource turmasBindingSource;
        private Escola_NatacaoDataSetTableAdapters.ProfessoresTableAdapter professoresTableAdapter;
        private System.Windows.Forms.BindingSource professoresBindingSource;
        private Escola_NatacaoDataSetTableAdapters.TemposTableAdapter temposTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource temposBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource inserir_aulasBindingSource;
        private Escola_NatacaoDataSetTableAdapters.inserir_aulasTableAdapter inserir_aulasTableAdapter;
    }
}