using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniRPG
{
    public class Hero
    {
        private int _health;
        private int _attack;

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public int Attack
        {
            get => _attack;
            set => _attack = value;
        }
    }

}
