using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SPC3.SPC.Editor.Model
{
    class SteckdoseModel : KomponentenModel

    {
        public String komponentenName = "Steckdose";
        public String komponentenBeschreibung;
        public String symbolPfad = @"C:\Users\simonleitl\source\repos\SPC\SPC3\SPC.Editor\KomponentenPictures\steckdose.png";
        

        public SteckdoseModel()
        {

        }

        public string getName()
        {
            return komponentenName;

        }


    }
    
}
