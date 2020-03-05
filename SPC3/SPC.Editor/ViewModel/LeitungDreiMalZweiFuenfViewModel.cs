using SPC3.SPC.Editor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC3.SPC.Editor.ViewModel
{
    class LeitungDreiMalZweiFuenfViewModel : LeitungenToolsViewModel
    {
        LeitungDreiMalZweiFuenfModel LeitungenDreiMalZweiFuenfModel = new LeitungDreiMalZweiFuenfModel();

        public LeitungDreiMalZweiFuenfViewModel()
        {
            Name = LeitungenDreiMalZweiFuenfModel.LeitungenName;
        }
    }
}
