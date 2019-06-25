using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningBitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] preload = new bool[3] { true, false, true };


            BitArray enemyGrid = new BitArray(preload);
            //BitArray is not a generic because by design it stores only bits.
            //ie, t/f only
            //these are rare but handy when you only need t/f tables.


            //enemyGrid[0] = false;
            //enemyGrid[1] = true;
            //enemyGrid.Set(2, false);
            //these lines are two other ways of creating a bit array.
            //a third way in the "bool[] preload" line above.

            foreach (var item in enemyGrid)
            {
                Console.WriteLine(item);
            }

        }
    }
}
