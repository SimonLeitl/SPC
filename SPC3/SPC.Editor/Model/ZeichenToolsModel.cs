using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SPC3.SPC.Editor.Model
{
    public abstract class ZeichenToolsModel
    {
        private String _ZeichenToolsName;
        private Int16 _ZeichenToolsID;
        private Image _ZeichenToolsImage;

        public String ZeichenToolsName
        {
            get => _ZeichenToolsName;
            set => _ZeichenToolsName = value;
        }

        public short ZeichenToolsID
        {
            get => _ZeichenToolsID;
            set => _ZeichenToolsID = value;
        }

        public Image ZeichenToolsmage
        {
            get => _ZeichenToolsImage;
            set => _ZeichenToolsImage = value;
        }


    }
}
