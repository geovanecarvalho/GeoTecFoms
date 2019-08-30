using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Controler
{
    public class Init
    {
        public void CriarPasta()
        {

            try
            {
                //CRIANDO DIRETÓRIO HIDDEN
                DirectoryInfo diretorio = Directory.CreateDirectory(@"c:\\FileSystem");
                diretorio.Attributes = FileAttributes.Hidden;
            }
            catch
            {

            }
        }
    }
}
