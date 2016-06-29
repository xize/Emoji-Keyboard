using emoji_keyboard.src.smillies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src.smillies
{
    class SmilleyType
    {

        private static Dictionary<string, SmilleyType> smillies = new Dictionary<string, SmilleyType>();

        public static SmilleyType HAPPY = new SmilleyType("happy", new Happy());
        public static SmilleyType GRINIC_FACE = new SmilleyType("grinic_face", new GrinicFace());
        public static SmilleyType JOY_FACE = new SmilleyType("joy_face", new JoyFace());
        public static SmilleyType HAPPY_2 = new SmilleyType("happy_2", new Happy2());
        
        private string name;
        private Smilley smilley;

        private SmilleyType(string name, Smilley smilley)
        {
            this.name = name;
            this.smilley = smilley;
            if(!smillies.ContainsKey(smilley.getCharacter()))
            {
                smillies.Add(smilley.getCharacter(), this);
            }
        }

        public string getName()
        {
            return name;
        }

        public static KeyValuePair<string, SmilleyType>[] values()
        {
            return smillies.ToArray();
        }

        public static SmilleyType valueOf(string name)
        {
            SmilleyType[] types = smillies.Values.ToArray();
            foreach(SmilleyType type in types)
            {
                if(name.ToLower().StartsWith(type.getName()))
                {
                    return type;
                }
            }
            return null;
        }
    }
}
