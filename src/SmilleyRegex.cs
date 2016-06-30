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
                    if(id == 0)
                    {
                        s.Location = new Point(0, s.Location.Y);
                        box.Select(id, smilley.getCharacter().Length);
                    } else
                    {
                        s.Location = new Point(s.Location.X + 23 + id, s.Location.Y);
                        box.Select(id, smilley.getCharacter().Length);
                    }

                    box.Controls.Add(smilley.getFormSmilley());
                    
                    //Clipboard.SetImage(smilley.getSmallSmilley());
                    //box.Paste();
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
