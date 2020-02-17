using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace VikingsInterface
{
    class Sound
    {
        public void Victory()
        {
            SoundPlayer snd = new SoundPlayer(Properties.GameSounds.WinSound);
            snd.Play();
        }
        public void Defeat()
        {
            SoundPlayer snd = new SoundPlayer(Properties.GameSounds.DefeatSound);
            snd.Play();
        }
        public void BattleBackground()
        {
            SoundPlayer snd = new SoundPlayer(Properties.GameSounds.BackgroundBattleSound);
            snd.PlayLooping();
        }
        public void StoryBackground()
        {
            SoundPlayer snd = new SoundPlayer(Properties.GameSounds.BackgroundStorySound);
            snd.PlayLooping();
        }
        public void Hit()
        {
            SoundPlayer snd = new SoundPlayer(Properties.GameSounds.AttackSound);
            snd.PlaySync();
        }
        public void Heal()
        {
            SoundPlayer snd = new SoundPlayer(Properties.GameSounds.HealSound);
            snd.PlaySync();
        }
        public void DeadChicken()
        {
            SoundPlayer snd = new SoundPlayer(Properties.GameSounds.DeadChicken);
            snd.Play();
        }
    }
}
