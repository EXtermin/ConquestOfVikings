﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QonquestOfVikings.Utils
{
    class ConsoleControl
    {
        public ConsoleControl()
        {

        }

        public void AttackUse(string line, string attackName, bool isHeal, int damage = 0)
        {
            if(isHeal)
                Console.WriteLine(line, attackName);
            else
                Console.WriteLine(line, attackName, damage);
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
