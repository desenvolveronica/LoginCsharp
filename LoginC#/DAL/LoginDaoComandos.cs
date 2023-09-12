using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LoginC_.DAL
{
    internal class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = ""; //se a variável estiver vazia é pq está tudo OK
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool verificarLogin(String login, String senha)
        {
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try{
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) //verifica se foi encontrado alguma linha correspondente no BD
                {
                    tem = true; 
                }
                con.desconectar();
                dr.Close();

            }
            catch (SqlException){

                this.mensagem = "Erro com Banco de dados";
            }

            //método com os comandos SQL para verificar se tem no banco
            return tem;
        }
        public string cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir no banco retornando uma string de cadastrado ou erro
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into logins values (@e, @s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();  
                    con.desconectar();
                    this.mensagem = "Cadastro finalizado com sucesso!";
                }
                catch (SqlException)
                {

                    this.mensagem = "Erro com o Banco de Dados";
                }
            }
            else
            {
                this.mensagem = "Senhas não correspondem :(";
            }
            return mensagem;
        }
    }
}
