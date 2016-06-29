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
            emoticons.Add("😗", Properties.Resources.kissingface);
            emoticons.Add("😙", Properties.Resources.kissingface_with_smile_eyes);
            emoticons.Add("😚", Properties.Resources.kissingface_shy);
            emoticons.Add("☺️", Properties.Resources.shysmile);
            emoticons.Add("🙂", Properties.Resources.happy_smile);
            emoticons.Add("🤗", Properties.Resources.hug_smile);
            emoticons.Add("😇", Properties.Resources.angel_smile);
            emoticons.Add("🤓", Properties.Resources.smartguy);
            emoticons.Add("🤔", Properties.Resources.thinkface);
            emoticons.Add("😐", Properties.Resources.shocked_smilley);
            emoticons.Add("😑", Properties.Resources.emotionless_smilley);
            emoticons.Add("😶", Properties.Resources.scared_eyes);
            emoticons.Add("🙄", Properties.Resources.rolleyes);
            emoticons.Add("😏", Properties.Resources.coolshy);
            emoticons.Add("😣", Properties.Resources.sad_xd);
            emoticons.Add("😥", Properties.Resources.sad_sigh);
            emoticons.Add("😮", Properties.Resources.wow_1);
            emoticons.Add("🤐", Properties.Resources.zipped_emoticon);
            emoticons.Add("😯", Properties.Resources.wow_2);
            emoticons.Add("😪", Properties.Resources.sleepy_face);
            emoticons.Add("😫", Properties.Resources.tired_face);
            emoticons.Add("😴", Properties.Resources.sleepface);
            emoticons.Add("😌", Properties.Resources.feelinggood); /* <- evil emoticon, yet feeling good, Microsoft?.... */
            emoticons.Add("😛", Properties.Resources.stickytounge);
            emoticons.Add("😜", Properties.Resources.stick_tongue_one_eye);
            emoticons.Add("😝", Properties.Resources.one_eye_xd);
            emoticons.Add("😒", Properties.Resources.sigh_notear);
            emoticons.Add("😓", Properties.Resources.sigh);
            emoticons.Add("😔", Properties.Resources.sad);
            emoticons.Add("😕", Properties.Resources.confused);
            emoticons.Add("🙃", Properties.Resources.upside_down);
            emoticons.Add("🤑", Properties.Resources.money_emoticon);
            emoticons.Add("😲", Properties.Resources.astonished_face);
            emoticons.Add("😷", Properties.Resources.sick_1);
            emoticons.Add("🤒", Properties.Resources.sick_2);
            emoticons.Add("🤕", Properties.Resources.sick_3);
            emoticons.Add("☹", Properties.Resources.sad2);
            emoticons.Add("🙁", Properties.Resources.sad3);
            emoticons.Add("😖", Properties.Resources.confounded_face);
            emoticons.Add("😞", Properties.Resources.disappointed_face);
            emoticons.Add("😟", Properties.Resources.worried_face);
            emoticons.Add("😤", Properties.Resources.mad_steam);
            emoticons.Add("😢", Properties.Resources.crying_face);
            emoticons.Add("😭", Properties.Resources.loudly_crying);
            emoticons.Add("😦", Properties.Resources.frowning_face);
            emoticons.Add("😧", Properties.Resources.aguised_face);
            emoticons.Add("😨", Properties.Resources.aguised_tear);
            emoticons.Add("😩", Properties.Resources.wear_face);
            emoticons.Add("😬", Properties.Resources.teeth_close);
            emoticons.Add("😰", Properties.Resources.cry_tear_cold);
            emoticons.Add("😱", Properties.Resources.screaming_fear);
            emoticons.Add("😳", Properties.Resources.love_eyes2);
            emoticons.Add("😵", Properties.Resources.dizzy_face);
            emoticons.Add("😡", Properties.Resources.pouting_face);
            emoticons.Add("😠", Properties.Resources.angry_face);
            emoticons.Add("😈", Properties.Resources.smiling_with_horns);
            emoticons.Add("👿", Properties.Resources.imp);
            emoticons.Add("🤖", Properties.Resources.robot);
            emoticons.Add("💩", Properties.Resources.poop);
            emoticons.Add("💀", Properties.Resources.skull);
            emoticons.Add("☠", Properties.Resources.skull2);
            emoticons.Add("👻", Properties.Resources.ghost);
            emoticons.Add("👽", Properties.Resources.alien);
            emoticons.Add("👾", Properties.Resources.android);
        }

        public void convertTextToSmilleys(RichTextBox box)
        {
            foreach(KeyValuePair<String, Image> data in emoticons)
            {
                while(box.Text.Contains(data.Key))
                {
                    //TODO: add Label with a image when the text has been set ;-)
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
