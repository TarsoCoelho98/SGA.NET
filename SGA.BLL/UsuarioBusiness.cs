using SGA.DAL.Entity;
using SGA.DAL.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA.BLL
{
    public class UsuarioBusiness
    {
        public static bool UserExits(string racf, string password)
        {
            return UsuarioFacade.UserExits(racf, password);
        }

        public static Usuario UserData(string racf)
        {
            return UsuarioFacade.UserData(racf);
        }

        public static bool IsDeveloperAcess(string racf, string password)
        {
            return UsuarioFacade.IsDeveloperAcess(racf, password);
        }

        public static bool UserAlreadyExists(string racf)
        {
            return UsuarioFacade.UserAlreadyExists(racf);
        }

        public static void Insert(string nome, string email, string racf, string senha, string rua, string bairro, string numero, string cpf, string rg, string senhaEmail)
        {
            UsuarioFacade.Insert(nome, email, racf, senha, rua, bairro, numero, cpf, rg, senhaEmail);
        }

        public static void Update(string racfReferencia, string email, string nome, string senha, string rua, string bairro, string numero, string cpf, string rg, string emailSenha)
        {
            UsuarioFacade.Update(racfReferencia, email, nome, senha, rua, bairro, numero, cpf, rg, emailSenha);
        }

        public KeyValuePair<string, string> UserEmailCredentials(string racf)
        {
            return UsuarioFacade.UserEmailCredentials(racf);
        }
    }
}
