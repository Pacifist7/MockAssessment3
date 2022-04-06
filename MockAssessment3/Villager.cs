using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    abstract class Villager
    {
        public int Hunger;

        public int Farm()
        {
            return 1;
        }

        public class Farmer:Villager
        {
            int Hunger = 1;
        }

        public override int Farm()
        {
            return 2;
        }

        public class Slacker: Villager
        {
            public Slacker()
            {
                Hunger = 3;
            }

            public override int Farm()
            {
                return 0;

            }
        }

    }
}
