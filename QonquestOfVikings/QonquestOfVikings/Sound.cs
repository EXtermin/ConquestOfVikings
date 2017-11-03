using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class Sound
    {
        public void Victory()
        {
            SoundPlayer snd = new SoundPlayer(@"Sound/WinSound.wav");
            snd.Play();
        }
        public void Defeat()
        {
            SoundPlayer snd = new SoundPlayer(@"Sound/DefeatSound.wav");
            snd.Play();
        }
        public void BattleBackground()
        {
            SoundPlayer snd = new SoundPlayer(@"Sound/BackgroundBattleSound.wav");
            snd.PlayLooping();
        }
        public void StoryBackground()
        {
            SoundPlayer snd = new SoundPlayer(@"Sound/BackgroundStorySound.wav");
            snd.PlayLooping();
        }
        public void Hit()
        {
            SoundPlayer snd = new SoundPlayer(@"Sound/AttackSound.wav");
            snd.PlaySync();
        }
        public void Heal()
        {
            SoundPlayer snd = new SoundPlayer(@"Sound/HealSound.wav");
            snd.PlaySync();
        }
    }
}
