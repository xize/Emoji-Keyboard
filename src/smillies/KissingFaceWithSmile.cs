using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src.smillies
{
    class KissingFaceWithSmile : Smilley
    {
        public override string getCharacter()
        {
            return "😙";
        }

        public override Image getSmilleyImage()
        {
            return Properties.Resources.kissingface_with_smile_eyes;
        }

        public override SmilleyType getType()
        {
            return SmilleyType.KISSING_FACE_WITH_SMILE;
        }
    }
}
