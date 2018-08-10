using ExercicioMVC01.DataBase;
using ExercicioMVC01.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ExercicioMVC01.Repository
{
    public class AlunoRepository
    {
        public List<Aluno> ObterTodos()
        {
            List<Aluno> alunos = new List<Aluno>();
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "SELECT id, nome, codigo_matricula, nota_1, nota_2, nota_3, frequencia, format(((nota_1 + nota_2 + nota_3) / 3), '#.00') FROM escolaalunos";

            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            foreach(DataRow line in table.Rows)
            {
                Aluno aluno = new Aluno()
                {
                    Id = Convert.ToInt32(line[0].ToString()),
                    Nome = line[1].ToString(),
                    CodigoMatricula = line[2].ToString(),
                    Nota1 = Convert.ToSingle(line[3].ToString()),
                    Nota2 = Convert.ToSingle(line[4].ToString()),
                    Nota3 = Convert.ToSingle(line[5].ToString()),
                    Frequencia = Convert.ToByte(line[6].ToString()),
                    Media = Convert.ToSingle(line[7].ToString().Replace(".", ","))
                };
                alunos.Add(aluno);
            }
            return alunos;
        }

        public int Cadastrar(Aluno aluno)
        {
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "INSERT INTO escolaalunos (nome, codigo_matricula, nota_1, nota_2, nota_3, frequencia) OUTPUT INSERTED.ID VALUES (@NOME, @CODIGO_MATRICULA, @NOTA_1, @NOTA_2, @NOTA_3, @FREQUENCIA)";
            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.CodigoMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            int id = Convert.ToInt32(command.ExecuteScalar().ToString());
            return id;
        }

        public bool Excluir(int id)
        {
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "DELETE FROM escolaalunos WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);
            return command.ExecuteNonQuery() == 1;
        }

        public Aluno ObterPeloId(int id)
        {
            Aluno aluno = null;
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "SELECT nome, codigo_matricula, nota_1, nota_2, nota_3, frequencia FROM escolaalunos WHERE id = @ID";
            command.Parameters.AddWithValue("@ID", id);
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            if (table.Rows.Count == 1)
            {
                aluno = new Aluno();
                aluno.Id = id;
                aluno.Nome = table.Rows[0][0].ToString();
                aluno.CodigoMatricula = table.Rows[0][1].ToString();
                aluno.Nota1 = Convert.ToSingle(table.Rows[0][2].ToString());
                aluno.Nota2 = Convert.ToSingle(table.Rows[0][3].ToString());
                aluno.Nota3 = Convert.ToSingle(table.Rows[0][4].ToString());
                aluno.Frequencia = Convert.ToByte(table.Rows[0][5].ToString());                
            }
            return aluno;
        }

        public bool Alterar(Aluno aluno)
        {
            SqlCommand command = new BancoDados().ObterConexao();
            command.CommandText = "UPDATE escolaalunos SET nome = @NOME, codigo_matricula = @CODIGO_MATRICULA, nota_1 = @NOTA_1, nota_2 = @NOTA_2, nota_3 = @NOTA_3, frequencia = @FREQUENCIA";
            command.Parameters.AddWithValue("@NOME", aluno.Nome);
            command.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.CodigoMatricula);
            command.Parameters.AddWithValue("@NOTA_1", aluno.Nota1);
            command.Parameters.AddWithValue("@NOTA_2", aluno.Nota2);
            command.Parameters.AddWithValue("@NOTA_3", aluno.Nota3);
            command.Parameters.AddWithValue("@FREQUENCIA", aluno.Frequencia);
            return command.ExecuteNonQuery() == 1;
        }

    }
}