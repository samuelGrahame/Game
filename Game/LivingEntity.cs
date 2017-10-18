using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class LivingEntity : Entity
    {
        public string Name;
        public long Health;

        public decimal BaseDamage;
        public decimal BaseArmor;

        public float X;
        public float Y;
        public float Z;

        public float Height;
        public float Width;
        public float Depth;
    }
}
