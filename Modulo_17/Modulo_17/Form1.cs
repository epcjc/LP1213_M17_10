﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Modulo_17
{
    public partial class Login : Form
    {
        SqlConnection sqlConn;
        private string strConn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Escola_Natacao.mdf;Integrated Security=True;User Instance=True";
        private string _Sql = string.Empty;

        public bool logado = false;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public bool logar()
        {
            sqlConn = new SqlConnection(strConn);
            string usu, pwd;

            try
            {
                usu = textlogin.Text;
                pwd = textpassword.Text;

                _Sql = "SELECT COUNT(id_utilizador) FROM Utilizadores WHERE login = @Nome AND password = @Senha";

                SqlCommand cmd = new SqlCommand(_Sql, sqlConn);

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = pwd;

                sqlConn.Open();

                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    logado = true;
                }
                else
                {
                    logado = false;
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro.Message);
            }

            return logado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (logar())
            {
                Inicial nf = new Inicial();//Object of the form that you want to open
                this.Hide();//Hide cirrent form.
                nf.Show();//Display the next form window
            }
            else
            {
                MessageBox.Show("Acesso não permitido");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        }
    }

