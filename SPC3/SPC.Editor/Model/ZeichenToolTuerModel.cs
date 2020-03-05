using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC3.SPC.Editor.Model
{
    class ZeichenToolTuerModel : ZeichenToolsModel
    {
        private readonly String TuerName = "Tür";

        public String GetZeichenToolTuer()
        {
            return TuerName;
        }
    }
}
