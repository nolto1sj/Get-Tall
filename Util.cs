using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTall
{
    public class Util
    {
        public static Random Random = new Random();

        public static int d20()
        {
            var roll = Random.Next(1, 20);
            return roll;
        }
    }
}
