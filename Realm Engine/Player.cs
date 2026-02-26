using System;
using System.Collections.Generic;
using System.Text;

namespace Realm_Engine
{
    public class Player
    {
        private string _name;
        private int _hp;

        public string Name{ get; set; }

        public int Hp { get; set; }

        public Player(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }

    }
}
