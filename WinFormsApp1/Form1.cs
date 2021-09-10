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
    public partial class CADASTROCURSO : Form
    {
        public CADASTROCURSO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nome = idcurso.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idcurso = int.Parse(this.idcurso.Text);
            string descurso = descricao.Text;
            int periodo = int.Parse(periodocurso.Text);
            double valor = double.Parse(valorcurso.Text);

            insertCurso(idcurso, descurso, periodo, valor);


        }
        public void insertCurso(int idcurso, string descurso, int periodo, double valor)
        {

            string conexaoString = "DATA SOURCE=DESKTOP-K8V6CFC; INITIAL CATALOG=BancoAluno; Trusted_Connection=True;";
            string query = "INSERT INTO CURSO values(@IDCURSO, @DESCURSO, @PERIODOCURSO, @VALORCURSO)";
            using var conn = new SqlConnection(conexaoString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.Parameters.Add(new SqlParameter("@IDCURSO", idcurso));
                cmd.Parameters.Add(new SqlParameter("@DESCURSO", descurso));
                cmd.Parameters.Add(new SqlParameter("@PERIODOCURSO", periodo));
                cmd.Parameters.Add(new SqlParameter("@VALORCURSO", valor));
                cmd.ExecuteNonQuery();
                Console.WriteLine("Curso inserido com sucesso!!");
            }

            catch (Exception e)
            {
                Console.WriteLine("Erro no banco de dados... " + e.Message);

            }
        }

        private void descurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void periodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void ALTERAR_Click(object sender, EventArgs e)
        {
            int idcurso = int.Parse(this.idcurso.Text);
            string descurso = descricao.Text;
            int periodo = int.Parse(periodocurso.Text);
            double valor = double.Parse(valorcurso.Text);

            AlterarCurso(idcurso, descurso, periodo, valor);
        }
        public void AlterarCurso(int idcurso, string descurso, int periodo, double valor)
        {
            string conexaoString = "DATA SOURCE=DESKTOP-K8V6CFC; INITIAL CATALOG=BancoAluno; Trusted_Connection=True;";
            string query = "UPDATE CURSO " +
                "SET DESCURSO = @DESCURSO, VALORCURSO = @VALORCURSO, PERIODOCURSO = @PERIODOCURSO WHERE IDCURSO = @IDCURSO";
            using var conn = new SqlConnection(conexaoString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            
            try
            {
                cmd.Parameters.Add(new SqlParameter("@IDCURSO", idcurso));
                cmd.Parameters.Add(new SqlParameter("@DESCURSO", descurso));
                cmd.Parameters.Add(new SqlParameter("@PERIODOCURSO", periodo));
                cmd.Parameters.Add(new SqlParameter("@VALORCURSO", valor));
                cmd.ExecuteNonQuery();
                Console.WriteLine("Curso ALTERADO com sucesso!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro no banco de dados... " + e.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idcurso = int.Parse(this.idcurso.Text);
            deletarCurso(idcurso);
        }
        private void deletarCurso(int idcurso) 
        {
            string conexaoString = "DATA SOURCE=DESKTOP-K8V6CFC; INITIAL CATALOG=BancoAluno; Trusted_Connection=True;";
            string query = "DELETE FROM CURSO WHERE IDCURSO = @IDCURSO ";
            using var conn = new SqlConnection(conexaoString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@IDCURSO", idcurso));
            cmd.ExecuteNonQuery();
        }

    }
}
