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

        public string getKomponentenName()
        {
            return komponentenName;
        }
    }
}
