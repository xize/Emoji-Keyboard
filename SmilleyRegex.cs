using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace emoji_keyboard
{
    class SmilleyRegex
    {

        private static SmilleyRegex regex;

        private Dictionary<string, Image> emoticons = new Dictionary<string, Image>();

        public SmilleyRegex()
        {
            emoticons.Add("😀", Properties.Resources.happy);
            emoticons.Add("😁", Properties.Resources.grinic_face_with_smiling_eyes);
            emoticons.Add("😂", Properties.Resources.face_of_joy);
            emoticons.Add("😃", Properties.Resources.happy2);
            emoticons.Add("😄", Properties.Resources.happy3);
            emoticons.Add("😅", Properties.Resources.happy_tear);
            emoticons.Add("😆", Properties.Resources.XD);
            emoticons.Add("😉", Properties.Resources.wink);
            emoticons.Add("😊", Properties.Resources.shy_smile);
            emoticons.Add("😋", Properties.Resources.tongue);
            emoticons.Add("😎", Properties.Resources.coolguy);
            emoticons.Add("😍", Properties.Resources.love_eyes);
            emoticons.Add("😘", Properties.Resources.kissface);
        }

        public void convertTextToSmilleys(RichTextBox box)
        {
            foreach(KeyValuePair<String, Image> data in emoticons)
            {
                while(box.Text.Contains(data.Key))
                {
                    Image img = new Bitmap(data.Value, 23, 23);
                    int id = box.Text.IndexOf(data.Key);
                    box.Select(id, data.Key.Length);
                    Clipboard.SetDataObject(img);
                    box.Paste();
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
