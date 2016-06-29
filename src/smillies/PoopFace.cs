using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src.smillies
{
    class PoopFace : Smilley
    {
        public override string getCharacter()
        {
            return "💩";
        }

        public override Image getSmilleyImage()
        {
            return Properties.Resources.poop;
        }

        public override SmilleyType getType()
        {
            throw new NotImplementedException();
        }
    }
}
