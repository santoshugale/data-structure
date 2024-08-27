using System;

namespace Leetcode.Recursion
{
    public class TowersOfHanoi
    {
        //The pattern here is :
        //Shift 'n-1' disks from 'A' to 'B'.
        //Shift last disk from 'A' to 'C'.
        //Shift 'n-1' disks from 'B' to 'C'.
        public static void TowerOfHanoi(int n, char from_rod, char to_rod, char aux_rod)
        {
            if (n == 1)
            {
                Console.WriteLine($"Move disk {n} from rod {from_rod} to rod {to_rod}");
                return;
            }

            TowerOfHanoi(n - 1, from_rod, aux_rod, to_rod);
            Console.WriteLine($"Move disk {n} from rod {from_rod} to rod {to_rod}");
            TowerOfHanoi(n - 1, aux_rod, to_rod, from_rod);
        }
    }
}
