using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Person : LivingEntity
    {
        public decimal Age;
        public const decimal MinAge = 15;
        public const decimal MaxAge = 80;

        public Person()
        {
            Age = MinAge;
        }
    }
}
