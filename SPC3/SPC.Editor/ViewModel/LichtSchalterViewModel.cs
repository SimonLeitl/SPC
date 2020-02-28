using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPC3.SPC.Editor.Model;

namespace SPC3.SPC.Editor.ViewModel
{
    public class LichtSchalterViewModel : KomponentenViewModel
    {
        LichtSchalterModel lichtSchalterModel = new LichtSchalterModel();
        public LichtSchalterViewModel()
        {
            Name = lichtSchalterModel.GetKomponentenName();
        }
    }
}
