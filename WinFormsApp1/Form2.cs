using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ALUNOCAD : Form
    {
        public ALUNOCAD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            void insertAluno(int matricula, string nome, string cpf, string email, string telefone, string cidade, string uf, int idcurso)
            {

                string conexaoString = "DATA SOURCE=DESKTOP-K8V6CFC; INITIAL CATALOG=BancoAluno; Trusted_Connection=True;";
                string query = "INSERT INTO ALUNO values(@MATRICALUNO, @NOME, @CPF, @EMAIL, @FONE, @CIDADE, @CIDADE, @UF, @IDCURSO)";
                using var conn = new SqlConnection(conexaoString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    cmd.Parameters.Add(new SqlParameter("@MATRICALUNO", txtMatricula));
                    cmd.Parameters.Add(new SqlParameter("@NOME", txtNome));
                    cmd.Parameters.Add(new SqlParameter("@CPF", txtCPF));
                    cmd.Parameters.Add(new SqlParameter("@EMAIL", txtEmail));
                    cmd.Parameters.Add(new SqlParameter("@FONE", txtTelefone));
                    cmd.Parameters.Add(new SqlParameter("@CIDADE", TxtCidade));
                    cmd.Parameters.Add(new SqlParameter("@UF", txtUf));
                    cmd.Parameters.Add(new SqlParameter("@IDCURSO", txtIdcurso));
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Aluno inserido com sucesso!!");
                }

                catch (Exception e)
                {
                    Console.WriteLine("Erro no banco de dados... " + e.Message);

                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
