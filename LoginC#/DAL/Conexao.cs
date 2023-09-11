using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginC_.DAL
{
    public class Conexao
    {

        SqlConnection con = new SqlConnection();
        public Conexao() { 
        
            con.ConnectionString = @"";
        }  
        
        public SqlConnection conectar()
        {
            //verificar se o banco já não está conectado ou seja 
            //se a conexão está fechada
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            //verificar se o banco está conectado ou seja 
            //se a conexão está aberta
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
