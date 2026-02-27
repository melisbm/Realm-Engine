using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Serialization;

namespace Realm_Engine
{
    public class Player
    {
        private string _name;
        private int _hp;

        private bool _isDead = false;
        public bool IsDead { get; set; }
        public string Name{ get; set; }

        public int Hp
        {
            get => _hp;
            set
            {
                if (IsDead)
                {
                    throw new ArgumentException("Cannot decrease hp of dead a player");
                }
                else
                {
                    if (value < 0)
                    {
                        IsDead = true;
                        _hp = 0;
                    }
                    else
                    {
                        _hp = value;
                    }
                }
            }
        }

        public Player(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }
    }
}
