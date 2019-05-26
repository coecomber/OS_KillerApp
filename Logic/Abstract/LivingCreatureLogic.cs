using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Abstract
{
    public abstract class LivingCreatureLogic
    {
        public string Name { get; set; }
        public int Health { get; set; }
        //Location <enum> implementeren soon
        public int MagicDefence { get; set; }
        public int MeleeDefence { get; set; }
        public int RangedDefence { get; set; }
        public string Weakness { get; set; }
        public string AttackStyle { get; set; }
        public float AttackSpeed { get; set; }
        public int AttackBonus { get; set; }

        public int CalculateDamage()
        {
            int damage = 1;

            return damage;
        }

        public void Attack()
        {
            
        }

        public void Die()
        {

        }
    }
}
