//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Media;
//using System.Text;
//using System.Threading.Tasks;

//namespace QonquestOfVikings
//{
//    class Sound
//    {
//        public void Victory()
//        {
//            SoundPlayer snd = new SoundPlayer(Properties.Sounds.WinSound);
//            snd.Play();
//        }
//        public void Defeat()
//        {
//            SoundPlayer snd = new SoundPlayer(Properties.Sounds.DefeatSound);
//            snd.Play();
//        }
//        public void BattleBackground()
//        {
//            SoundPlayer snd = new SoundPlayer(Properties.Sounds.BackgroundBattleSound);
//            snd.PlayLooping();
//        }
//        public void StoryBackground()
//        {
//            SoundPlayer snd = new SoundPlayer(Properties.Sounds.BackgroundStorySound);
//            snd.PlayLooping();
//        }
//        public void Hit()
//        {
//            SoundPlayer snd = new SoundPlayer(Properties.Sounds.AttackSound);
//            snd.PlaySync();
//        }
//        public void Heal()
//        {
//            SoundPlayer snd = new SoundPlayer(Properties.Sounds.HealSound);
//            snd.PlaySync();
//        }
//    }
//}
