using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src.smillies
{
    class MoneyFace : Smilley
    {
        public override string getCharacter()
        {
            return "🤑";
        }

        public override Image getSmilleyImage()
        {
            return Properties.Resources.money_emoticon;
        }

        public override SmilleyType getType()
        {
            return SmilleyType.MONEY_FACE;
        }
    }
}
