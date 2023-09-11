using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginC_.DAL
{
    internal class LoginDaoComandos
    {
        public bool tem;
        public String mensagem;
        public bool verificarLogin(String login, String senha)
        {
            //método com os comandos SQL para verificar se tem no banco
            return tem;
        }
        public string cadastrar(String email, String senha, String confSenha)
        {
            //comandos para inserir no banco retornando uma string de cadastrado ou erro
            return mensagem;
        }
    }
}
