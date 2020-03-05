using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC3.SPC.Editor.Model
{
    class ZeichenToolGrundrissModel : ZeichenToolsModel
    {

        private readonly String GrundrissName = "Grundriss";
        //private String LinienVolumenAnzahl = "1";
        //private String LinienVolumen = "StrokeThickness=";

        public String GetZeichenToolGrundrissName()
        {
            return GrundrissName;
        }
    }
}
