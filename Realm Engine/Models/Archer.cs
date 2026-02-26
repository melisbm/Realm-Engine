using System;
using System.Collections.Generic;
using System.Text;

namespace Realm_Engine.Models
{
    class Archer : Character
    {
        public Archer(string name)
        {
            Name = name;
        }
        public override void Attack(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
