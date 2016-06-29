﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src.smillies
{
    class SadFace2 : Smilley
    {
        public override string getCharacter()
        {
            return "☹";
        }

        public override Image getSmilleyImage()
        {
            return Properties.Resources.sad2;
        }

        public override SmilleyType getType()
        {
            return SmilleyType.SAD_FACE2;
        }
    }
}
