﻿using emoji_keyboard.src.smillies;
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
        public static SmilleyType SAD_XD = new SmilleyType("sad_xd", new SadXD());
        public static SmilleyType SAD_SIGH = new SmilleyType("sad_sigh", new SadSigh());
        public static SmilleyType WOW = new SmilleyType("wow", new Wow());
        public static SmilleyType ZIPPED_FACE = new SmilleyType("zipped_face", new ZippedFace());
        public static SmilleyType WOW_2 = new SmilleyType("wow_2", new Wow2());
        public static SmilleyType SLEEP_FACE = new SmilleyType("sleepy_face", new SleepFace());
        public static SmilleyType TIRED_FACE = new SmilleyType("tired_face", new TiredFace());
        public static SmilleyType SLEEP_FACE_2 = new SmilleyType("sleep_face_2", new SleepFace2());
        public static SmilleyType FEELING_GOOD_FACE = new SmilleyType("feeling_good_face", new FeelingGoodFace());
        public static SmilleyType STICKY_TONGUE = new SmilleyType("sticky_tongue", new StickyTongue());
        public static SmilleyType STICKY_TONGUE_ONE_EYE = new SmilleyType("sticky_tongue_one_eye", new StickyTongueEye());
        public static SmilleyType XD_ONE_EYE = new SmilleyType("xd_one_eye", new XDEye());
        public static SmilleyType SIGH_NO_TEAR = new SmilleyType("sigh_no_tear", new SighNoTear());
        public static SmilleyType SIGH_FACE = new SmilleyType("sigh_face", new SighFace());
        public static SmilleyType SAD_FACE = new SmilleyType("sad_face", new SadFace());
        public static SmilleyType CONFUSED_FACE = new SmilleyType("confused_face", new ConfusedFace());
        public static SmilleyType UPSIDE_DOWN_FACE = new SmilleyType("upside_down_face", new UpsideDownFace());
        public static SmilleyType MONEY_FACE = new SmilleyType("money_face", new MoneyFace());
        public static SmilleyType ASTONISHED_FACE = new SmilleyType("astonished_face", new AstonishedFace());
        public static SmilleyType SICK_FACE = new SmilleyType("sick_face", new SickFace());
        public static SmilleyType SICK_FACE2 = new SmilleyType("sick_face2", new SickFace2());
        public static SmilleyType SICK_FACE3 = new SmilleyType("sick_face3", new SickFace3());
        public static SmilleyType SAD_FACE2 = new SmilleyType("sad_face2", new SadFace2());
        public static SmilleyType SAD_FACE3 = new SmilleyType("sad_face3", new SadFace3());
        public static SmilleyType CONFOUNDED_FACE = new SmilleyType("confounded_face", new ConfoundedFace());
        public static SmilleyType DISAPPOINTED_FACE = new SmilleyType("disappointed_face", new DisappointedFace());
        public static SmilleyType WORRIED_FACE = new SmilleyType("worried_face", new WorriedFace());
        public static SmilleyType MAD_STEAM_FACE = new SmilleyType("mad_steam_face", new MadSteamFace());
        public static SmilleyType CRY_FACE = new SmilleyType("cry_face", new CryingFace());
        public static SmilleyType LOUDCRY_FACE = new SmilleyType("loudcry_face", new LoudCryFace());
        public static SmilleyType FROWNING_FACE = new SmilleyType("frowning_face", new FrowningFace());
        public static SmilleyType AGUISHED_FACE = new SmilleyType("aguished_face", new AguishedFace());
        public static SmilleyType AGUISHED_TEAR_FACE = new SmilleyType("aguished_tear_face", new AguishedTear());
        public static SmilleyType WEAR_FACE = new SmilleyType("wear_face", new WearFace());
        public static SmilleyType TEETH_CLOSE = new SmilleyType("teeth_close", new TeethClose());
        public static SmilleyType CRY_TEAR_COLD = new SmilleyType("cry_tear_cold", new CryTearColdFace());
        public static SmilleyType SCREAMING_FEAR_FACE = new SmilleyType("screaming_fear_face", new ScreamingFearFace());
        public static SmilleyType LOVE_EYES_2 = new SmilleyType("love_eyes_2", new LoveEyes2());
        public static SmilleyType DIZZY_FACE = new SmilleyType("dizzy_face", new DizzyFace());
        public static SmilleyType POUTING_FACE = new SmilleyType("pouting_face", new PoutingFace());
        public static SmilleyType ANGRY_FACE = new SmilleyType("angry_face", new AngryFace());
        public static SmilleyType SMILING_WITH_HORNS = new SmilleyType("smiling_with_horns", new SmileWithHornsFace());
        public static SmilleyType IMP = new SmilleyType("imp", new IMP());
        public static SmilleyType ROBOT_FACE = new SmilleyType("robot_face", new RobotFace());
        public static SmilleyType POOP_FACE = new SmilleyType("poop_face", new PoopFace());
        public static SmilleyType SKULL_FACE = new SmilleyType("skull_face", new SkullFace());
        public static SmilleyType SKULL_FACE2 = new SmilleyType("skull_face2", new SkullFace2());
        public static SmilleyType GHOST_FACE = new SmilleyType("ghost_face", new GhostFace());
        public static SmilleyType ALIEN_FACE = new SmilleyType("alien_face", new AlienFace());

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
