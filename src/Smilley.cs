using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emoji_keyboard.src
{
    abstract class Smilley
    {

        private Label smilley;

       public string getName()
        {
            return getType().getName();
        }

        public abstract SmilleyType getType();

        public abstract Image getSmilleyImage();

        public abstract string getCharacter();

        public Image getSmallSmilley()
        {
            return new Bitmap(getSmilleyImage(), 23, 23);
        }
        
        public Label getFormSmilley()
        {
            if(smilley == null)
            {
                this.smilley = new Label();
                smilley.Height = 23;
                smilley.Width = 23;
                smilley.Image = getSmallSmilley();
            }
            return smilley;
        }

    }
}
