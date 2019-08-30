using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Controler
{
    public class Cadastro
    {
        public void Inserir(string date, string name, string description)
        {   
          
            StreamWriter writeDate = new StreamWriter(@"c:\FileSystem\Date.txt");
            writeDate.Write(date);
            writeDate.Close();

            StreamWriter writeName = new StreamWriter(@"c:\FileSystem\Name.txt");
            writeName.Write(name);
            writeName.Close();

            StreamWriter writeDescription = new StreamWriter(@"c:\FileSystem\Description.txt");
            writeDescription.Write(description);
            writeDescription.Close();
        }

    }
}
