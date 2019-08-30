using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Controler
{
    public class Leitura
    {
        private string Name;
        private string Date;
        private string Description;

        public string LerName()
        {
            return this.Name;
        }
        public string LerDate()
        {
            return this.Date;
        }
        public string LerDescription()
        {
            return this.Description;
        }

        public void lerArquivo()
        {
            StreamReader lerName = new StreamReader(@"c:\FileSystem\Name.txt");
            this.Name = lerName.ReadLine();
            lerName.Close();

            StreamReader lerDate = new StreamReader(@"c:\FileSystem\Date.txt");
            this.Date = lerDate.ReadLine();
            lerDate.Close();

            StreamReader lerDescription = new StreamReader(@"c:\FileSystem\Description.txt");
            this.Description = lerDescription.ReadLine();
            lerDescription.Close();
        }
       
        
    }
}
