using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Mdlbackup
    {
        private string PathBackup;

        public string getPath()
        {
            return this.PathBackup;
        }
        public void setPath(string path)
        {
            this.PathBackup = path;
        }
    }
}
