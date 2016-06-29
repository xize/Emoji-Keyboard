using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src.smillies
{
    class CryingFace : Smilley
    {
        public override string getCharacter()
        {
            return "😢";
        }

        public override Image getSmilleyImage()
        {
            return Properties.Resources.crying_face;
        }

        public override SmilleyType getType()
        {
            return SmilleyType.CRY_FACE;
        }
    }
}
