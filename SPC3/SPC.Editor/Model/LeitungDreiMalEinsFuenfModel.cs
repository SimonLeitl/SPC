using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC3.SPC.Editor.Model
{
    class LeitungDreiMalEinsFuenfModel : LeitungenToolsModel
    {
        private readonly new String LeitungenName = "3x 1.5";
        private readonly new int LeitungenID = 2;

        public String GetLeitungenNameEinsFuenf()
        {
            return LeitungenName;
        }
    }
}
