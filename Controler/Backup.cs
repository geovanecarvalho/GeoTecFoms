using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Controler
{
    public class Backup
    {
       
        private string Path;
       

        public string Verificar()

        {
            StreamReader ler = new StreamReader(@"C:\\FileSystem\\Path.txt");
            this.Path = ler.ReadLine();
            ler.Close();
            return this.Path;
        }


        public string Imprime()
        {
            return this.Path;
        }
       

    }
}
