using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings
{
    class FollowUpStoryline
    {
        Player player1;
        Battle battle;
        public FollowUpStoryline(Player player)
        {
            this.player1 = player;
            this.battle = new Battle(player1);
           
        }
        public void FollowUpBegin()
        {
            
        }
         public void FollowUpMiddle()
        {
            
        }
         public void FollowUpEnd()
        {
            
        }
        public void Battle()
        {
            //Deze kan verandert worden ivm andere vijanden
            battle.battle();
        }
    }
}
