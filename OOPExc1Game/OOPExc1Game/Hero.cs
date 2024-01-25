using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    abstract class Hero
    {
        protected static Random randomDamageGenerator = new Random();
        public string Name { get; set; }
        public double Health { get; set; } 
        public double Armor { get; set; }  
        public double Damage { get; set; }
        
        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }

        public virtual int Attack()
        {
            double multiplier = randomDamageGenerator.Next(80, 121);
            return (int)(Damage * (multiplier / 100));
        }

        public virtual int Defend(int attackDamage)
        {
            double multiplier = randomDamageGenerator.Next(80, 121);
            double defendPower = Armor * (multiplier / 100);

            int realDamage = attackDamage - (int) defendPower;
            if (realDamage <= 0)
            {
                return 0;
            }
            Health -= realDamage;
            return realDamage;
        }
    }
}
