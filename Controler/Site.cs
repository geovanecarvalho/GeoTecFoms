using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controler
{

    

    public class Site
    {
        private string siteGeoTec = "https://geotecinformatica.herokuapp.com/";
        private string whatsAppWeb = "https://wa.me/5561995488068?text=Olá%20Geovane%20Carvalho!";

        public string webGeotec()
        {
            return this.siteGeoTec;
        }
        public string webWhatsApp()
        {
            
         return this.whatsAppWeb;
            
        }
    }
}
