using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Controler
{
    public class Login
    {
        private bool acesso = false;

        public void Verificar(string login, string senha)
        {
            if(login == "GeoTecInfo" && senha == "gti@info")
            {
                this.acesso = true;
            }
        }

        public  bool Acesso()
        {
            return this.acesso;
        }
    }
}
