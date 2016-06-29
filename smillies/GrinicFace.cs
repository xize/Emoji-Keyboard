using emoji_keyboard.src.smillies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace emoji_keyboard.smillies
{
    class GrinicFace : Smilley
    {
        public override string getCharacter()
        {
            return "😁";
        }

        public override string getName()
        {
            return getType().getName();
        }

        public override Image getSmilleyImage()
        {
            return Properties.Resources.grinic_face_with_smiling_eyes;
        }

        public override SmilleyType getType()
        {
            return SmilleyType.GRINIC_FACE;
        }
    }
}
