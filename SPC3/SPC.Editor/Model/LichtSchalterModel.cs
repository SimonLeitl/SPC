using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC3.SPC.Editor.Model
{
    class LichtSchalterModel : KomponentenModel
    {
        private string komponentenName = "Lichtschalter";
        private string symbolPfad = @"C:\Users\simonleitl\source\repos\SPC\SPC3\SPC.Editor\KomponentenPictures\lichtschalter.png";

        public string getKomponentenName()
        {
            return komponentenName;
        }

        public string getSymbolPfad()
        {
            return symbolPfad;
        }
    }
}
