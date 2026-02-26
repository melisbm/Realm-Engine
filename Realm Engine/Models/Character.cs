using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Realm_Engine.Models
{
    public abstract class Character
    {
        private string _name;
        private int _hp;
        private int _level = 0;

        public int Level{
            get { return _level; }
            set { }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name must not be empty or whitespace.", nameof(value));
                }
                else if (value.Length > 100)
                {
                    throw new ArgumentException("Name must be lower than 100 characters", nameof(value));
                }
                else
                {
                    _name = value;
                }
            }
        }

        public int Hp
        {
            get { return _hp; }
            set
            {
                if(value > 1000)
                {
                    _hp = 1000;
                }
                else if(value < 0)
                {
                    throw new ArgumentException("hp cannot be negative", nameof(value));
                }
                else
                {
                    _hp = value;
                }
            }
        }

        public abstract void Attack(Player player);

    }
}
