using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SPC3.SPC.Editor.Model
{
    abstract class LeitungenToolsModel
    {
        private String _LeitungenName;
        public String LeitungenName{
            get => _LeitungenName;
            set => _LeitungenName = value;
        }

        private Int16 _LeitungenID;
        public short LeitungenID
        {
            get => _LeitungenID;
            set => _LeitungenID = value;
        }

        private String _LeitungenGroesse;
        public String LeitungenGroesse
        {
            get => _LeitungenGroesse;
            set => _LeitungenGroesse = value;
        }

        private Image _LeitungenImage;
        public Image LeitungenImage
        {
            get => _LeitungenImage;
            set => _LeitungenImage = value;
        }

        private double _LeitungenXPosition;
        public double LeitungenXPosition
        {
            get => _LeitungenXPosition;
            set => _LeitungenXPosition = value;
        }

        private double _LeitungenYPosition;
        public double LeitungenYPosition
        {
            get => _LeitungenYPosition;
            set => _LeitungenYPosition = value;
        }
    }
}
