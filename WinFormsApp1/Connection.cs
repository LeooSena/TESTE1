using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace CrudConsole
{
    class Connection
    {

        //static string conexaoString = "DATA SOURCE=DESKTOP-K8V6CFC; INITIAL CATALOG=CURSO; Trusted_Connection=True";
        static string conexaoString = "DATA SOURCE=.; INITIAL CATALOG=CURSO; Trusted_Connection=True";

        static SqlConnection conn;

        public SqlConnection conectar()
        {

            conn = new SqlConnection(conexaoString);

            try
            {
                conn.Open();
                //Console.WriteLine("Conexão realizada com sucesso!");

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao conectar no banco..." + e.Message);
            }

            return conn;
        }

        public void insertCurso(int idcurso, string descurso, int periodo, double valor)
        {
            string query = "INSERT INTO CURSO values(@IDCURSO, @DESCURSO, @PERIODOCURSO, @VALORCURDO)";

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
        public void alterarCurso(string descurso, int periodo, double valor, int idcurso)
        {
            string query = "UPDATE " +
                "              SET DESCRICAO = @DESCURSO," +
                "                  PERIODO = @PERIODOCURSO," +
                "                  VALOR= @VALORCURSO " +
                "            WHERE IDCURSO = @IDCURSO";

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                cmd.Parameters.Add(new SqlParameter("@DESCURSO", descurso));
                cmd.Parameters.Add(new SqlParameter("@PERIODOCURSO", periodo));
                cmd.Parameters.Add(new SqlParameter("@VALORCURSO", valor));
                cmd.Parameters.Add(new SqlParameter("@IDCURSO", idcurso));
                cmd.ExecuteNonQuery();
                Console.WriteLine("Curso alterado com sucesso!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro no banco de dados... " + e.Message);

            }

        }

        public void deleteCurso(int idcurso)
        {

            string query = "DELETE FROM CURSO WHERE IDCURSO = '" + idcurso + "'";

            SqlCommand cmd = new SqlCommand(query, conn);

            int ret = cmd.ExecuteNonQuery();

            if (ret <= 0)
            {
                Console.WriteLine("Produto não encontrado!");
            }
            else
            {
                Console.WriteLine("Produto excluído com sucesso!");
            }
        }

        public Curso pesquisaCurso(int codigo, Curso curso)
        {

            string query = "SELECT * FROM PRODUTO WHERE IDPROD = '" + codigo + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader;

            try
            {
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    //curso.idcurso;
                    //curso.setDescricao(reader[1].ToString());
                    //curso.setEstoque(int.Parse(reader[2].ToString()));
                    //curso.setValor(double.Parse(reader[3].ToString()));
                }

                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(" *** Erro ao pesquisar o produto *** " + e.Message);
            }

            return curso;
        }


    }
}
