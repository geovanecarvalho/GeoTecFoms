using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MdlCadastro
    {
        private string data;
        private string name;
        private string description;

        public string getData()
        {
            return this.data;
        }
        public void setData(string data)
        {
            this.data = data;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public string getDescription()
        {
            return this.description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }
    }
}
