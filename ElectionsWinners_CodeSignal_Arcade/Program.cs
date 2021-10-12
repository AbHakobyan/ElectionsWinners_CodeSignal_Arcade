
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionsWinners_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 5, 2 };
            int k = 3;
            int c = electionsWinners(array, k);
            Console.WriteLine(c);
        }

        static int electionsWinners(int[] votes, int k)
        {
            int count = 0;
            int max = int.MinValue;
            int count1 = 0;
            int maxcount = 0;
            for (int i = 0; i < votes.Length; i++)
            {
                if (max < votes[i])
                {
                    max = votes[i];
                }
                else if (k == 0 && max == votes[i])
                {
                    maxcount++;
                }
            }
            for (int i = 0; i < votes.Length; i++)
            {
                if (k != 0)
                {
                    if (k + votes[i] > max)
                    {
                        count++;
                    }
                }
                else if (k == 0 && max == votes[i] && maxcount<1)
                {
                    count1++;
                }
            }
            if (count < count1)
            {
                return count1;
            }
            return count;
        }
    }
}
