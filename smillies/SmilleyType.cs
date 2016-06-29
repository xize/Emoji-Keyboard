﻿using emoji_keyboard.smillies;
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
