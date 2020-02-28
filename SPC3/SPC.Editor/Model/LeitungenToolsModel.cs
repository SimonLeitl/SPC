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
        private Int16 _LeitungenID;
        private String _LeitungenGroesse;
        private Image _LeitungenImage;
        private double _LeitungenXPosition;
        private double _LeitungenYPosition;

        public String LeitungenName
        {
            get => _LeitungenName;
            set => _LeitungenName = value;
        }

        public short LeitungenID
        {
            get => _LeitungenID;
            set => _LeitungenID = value;
        }

        public String LeitungenGroesse
        {
            get => _LeitungenGroesse;
            set => _LeitungenGroesse = value;
        }

        public Image LeitungenImage
        {
            get => _LeitungenImage;
            set => _LeitungenImage = value;
        }

        public double LeitungenXPosition
        {
            get => _LeitungenXPosition;
            set => _LeitungenXPosition = value;
        }

        public double LeitungenYPosition
        {
            get => _LeitungenYPosition;
            set => _LeitungenYPosition = value;
        }
    }
}
