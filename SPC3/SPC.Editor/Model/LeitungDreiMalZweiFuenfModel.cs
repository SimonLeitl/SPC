using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC3.SPC.Editor.Model
{
    class LeitungDreiMalZweiFuenfModel : LeitungenToolsModel
    {
        private readonly new String LeitungenName = "3x 2.5";
        private readonly new int LeitungenID = 1;

        public String GetLeitungenNameZweiFuenf()
        {
            return LeitungenName;
        }
    }
}
