using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src.smillies
{
    class Shocked : Smilley
    {
        public override string getCharacter()
        {
            return "😐";
        }

        public override Image getSmilleyImage()
        {
            return Properties.Resources.shocked_smilley;
        }

        public override SmilleyType getType()
        {
            return SmilleyType.SHOCKED_FACE;
        }
    }
}
