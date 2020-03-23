using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GetAllTheMortys.Attack;

namespace GetAllTheMortys.Mortys
{
    class WerewolfMorty : IMorty
    {
        public int Health { get; set; } = 25;
        public void Scream()
        {
            Console.WriteLine("RAWWWOOOOOoooOOOoooowwww");
        }
        public void Hurt(Attack attack)
        {
            if (attack.Type == DamageType.Piercing || attack.Type == DamageType.Shocking)
            {
                attack.Damage = (int) Math.Floor(attack.Damage * 1.5);
            } else if (attack.Type == DamageType.Bludgeoning || attack.Type == DamageType.Psych)
            {
                attack.Damage = (int) Math.Ceiling(attack.Damage * 0.5);
            }
            Health -= attack.Damage;
        }
        public Attack Attack()
        {
            return new Attack(5, 10, DamageType.Slashing);
        }
    }
}
