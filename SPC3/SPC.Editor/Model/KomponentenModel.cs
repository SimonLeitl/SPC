using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SPC3.SPC.Editor.Model
{
     abstract class KomponentenModel
    {

        public KomponentenModel()
        {
        }

        public String komponentenName;
        private String komponentenBeschreibung;
        private Image komponentenImage;

        public String KomponentenName
        {
            get => komponentenName;
            set => komponentenBeschreibung = value;
        }


        public String KomponentenBeschreibung
        {
            get => komponentenBeschreibung;
            set => komponentenBeschreibung = value;
        }

        public Image Image
        {
            get => komponentenImage;
            set => komponentenImage = value;
        }
    }
}
