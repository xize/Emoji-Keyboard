using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src.smillies
{
    class XDEye : Smilley
    {
        public override string getCharacter()
        {
            return "😝";
        }

        public override Image getSmilleyImage()
        {
            return Properties.Resources.one_eye_xd;
        }

        public override SmilleyType getType()
        {
            return SmilleyType.XD_ONE_EYE;
        }
    }
}
