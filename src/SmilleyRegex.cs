using emoji_keyboard.src;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace emoji_keyboard.src
{
    class SmilleyRegex
    {

        private static SmilleyRegex regex;

        public void convertTextToSmilleys(RichTextBox box)
        {
            foreach(KeyValuePair<String, SmilleyType> data in SmilleyType.values())
            {
                Smilley smilley = data.Value.getSmilley();
                Match match = Regex.Match(box.Text, smilley.getCharacter());
                while(match.Success)
                {
                    int id = match.Index;
                    Label s = smilley.getFormSmilley();
                    
                    //box.Controls.Add(s);
                    
                    Clipboard.SetImage(smilley.getSmallSmilley());
                    box.Paste();
                    match = match.NextMatch();
                }
            }
        }

        public static SmilleyRegex getFactory()
        {
            if(regex == null)
            {
                regex = new SmilleyRegex();
            }
            return regex;
        }

    }
}
