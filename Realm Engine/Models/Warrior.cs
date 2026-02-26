using System;
using System.Collections.Generic;
using System.Text;

namespace Realm_Engine.Models
{
    public class Warrior : Character
    {
        public Warrior(string name)
        {
            Name = name;
        }
        public override void Attack(Player player)
        {
            player.Hp -= 10;
        }
    }
}
