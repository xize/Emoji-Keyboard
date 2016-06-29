using emoji_keyboard.src.smillies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emoji_keyboard.src
{
    class SmilleyType
    {

        private static Dictionary<string, SmilleyType> smillies = new Dictionary<string, SmilleyType>();

        public static SmilleyType HAPPY = new SmilleyType("happy", new Happy());
        public static SmilleyType GRINIC_FACE = new SmilleyType("grinic_face", new GrinicFace());
        public static SmilleyType JOY_FACE = new SmilleyType("joy_face", new JoyFace());
        public static SmilleyType HAPPY_2 = new SmilleyType("happy_2", new Happy2());
        public static SmilleyType HAPPY_3 = new SmilleyType("happy_3", new Happy3());
        public static SmilleyType HAPPY_TEAR = new SmilleyType("happy_tear", new HappyTear());
        public static SmilleyType XD = new SmilleyType("xd", new XD());
        public static SmilleyType WINK = new SmilleyType("wink", new Wink());
        public static SmilleyType SHY_SMILE = new SmilleyType("shy_smile", new ShySmile());
        public static SmilleyType SHY_SMILE_2 = new SmilleyType("shy_smile_2", new ShySmile2());
        public static SmilleyType TONGUE = new SmilleyType("tongue", new Tongue());
        public static SmilleyType COOL_GUY = new SmilleyType("cool_guy", new CoolGuy());
        public static SmilleyType LOVE_EYES = new SmilleyType("love_eyes", new LoveEyes());
        public static SmilleyType KISS_FACE = new SmilleyType("kiss_face", new KissFace());
        public static SmilleyType KISSING_FACE = new SmilleyType("kissing_face", new KissingFace());
        public static SmilleyType KISSING_FACE_WITH_SMILE = new SmilleyType("kissing_face_with_smile", new KissingFaceWithSmile());
        public static SmilleyType KISSING_FACE_SHY = new SmilleyType("kissing_face_shy", new KissingFaceShy());
        public static SmilleyType HAPPY_SMILE = new SmilleyType("happy_smile", new HappySmile());
        public static SmilleyType HUG_SMILE = new SmilleyType("hug_smile", new HugSmile());
        public static SmilleyType ANGEL_SMILE = new SmilleyType("angel_smile", new AngelSmile());
        public static SmilleyType SMART_GUY = new SmilleyType("smart_guy", new SmartGuy());
        public static SmilleyType THINK_FACE = new SmilleyType("think_face", new ThinkFace());
        public static SmilleyType SHOCKED_FACE = new SmilleyType("shocked_face", new Shocked());
        public static SmilleyType EMOTIONLESS_FACE = new SmilleyType("emotionless_face", new Emotionless());
        public static SmilleyType SCARED_EYES = new SmilleyType("scared_eyes", new ScaredEyes());
        public static SmilleyType ROLLING_EYES = new SmilleyType("rolling_eyes", new RollEyes());
        public static SmilleyType COOL_SHY = new SmilleyType("cool_shy", new CoolShy());
        
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
