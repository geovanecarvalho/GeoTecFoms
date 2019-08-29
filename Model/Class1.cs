using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MdlLogin
    {
        private string login;
        private string senha;

        public string getLogin()
        {
            return this.login;
        }

        public void setLogin(string log)
        {
            this.login = log;
        }
       
      
        public string getSenha()
        {
            return this.senha;
        }
        
        public void setSenha(string sen)
        {
            this.senha = sen;
        }
           
    }
}
