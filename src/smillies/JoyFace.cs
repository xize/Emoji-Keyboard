﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src.smillies
{
    class JoyFace : Smilley
    {
        public override string getCharacter()
        {
            return "😂";
        }

        public override string getName()
        {
            return getType().getName();
        }

        public override Image getSmilleyImage()
        {
            return Properties.Resources.face_of_joy;
        }

        public override SmilleyType getType()
        {
            return SmilleyType.JOY_FACE;
        }
    }
}
