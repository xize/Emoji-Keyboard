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
        private Image smallimage;
        private Button btn;

       public string getName()
        {
            return getType().getName();
        }

        public abstract SmilleyType getType();

        public abstract Image getSmilleyImage();

        public abstract string getCharacter();

        public String getUnicodeCharacter()
        {
            byte[] utf8 = Encoding.UTF8.GetBytes(getCharacter());
            string utf = Encoding.UTF8.GetString(utf8);
            return utf;
        }

        public Button getButton()
        {
            if(btn == null)
            {
                this.btn = new Button();
                btn.Height = 72;
                btn.Width = 72;
                btn.BackgroundImage = getSmilleyImage();
            }
            return btn;
        }

        public Image getSmallSmilley()
        {
            if(smallimage == null)
            {
                this.smallimage = new Bitmap(getSmilleyImage(), 23, 23);
            }
            return smallimage;
        }
        
        public Label getFormSmilley()
        {
            if(this.smilley == null)
            {
                this.smilley = new Label();
                smilley.Margin = new Padding(25, 0, 0, 0);
                smilley.Height = 23;
                smilley.Width = 23;
                smilley.Image = getSmallSmilley();
            }
            return smilley;
        }

    }
}
