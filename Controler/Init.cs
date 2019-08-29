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
        public void CriarArquivo(string nome)
        {
            // CRIANDO ARQUIVO HIDDEN
            try
            {
                FileInfo arquivo = new FileInfo(@"C:\\fileSystem\\" + nome + ".txt");
                arquivo.CreateText();
                arquivo.Attributes = FileAttributes.Hidden;
            }
            catch
            {

            }
        }
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
