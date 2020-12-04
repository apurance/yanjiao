using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yanjiao
{
    class Yanjiao
    {
        static public int IntPow(int x, int pow)
        {
            int ret = 1;
            while (pow != 0)
            {
                if ((pow & 1) == 1)
                    ret *= x;
                x *= x;
                pow >>= 1;
            }
            return ret;
        }

        static public (List<int>,List<int>) Violent(int[] deck)
        {
            
            int distribution = IntPow(3, deck.Length);

            int sum = 0;

            foreach(int d in deck)
            {
                sum += d;
            }

            int max = 0;
            int bestdis = 0;

            for(int j = 0; j < distribution; j++)
            {
                int a = 0, b = 0, c = 0;

                int _j = j;

                for(int k = 0; k < deck.Length; k++)
                {
                    if (_j % 3 == 1)
                    {
                        a += deck[k];
                        c++;
                    }
                    else if (_j % 3 == 2){
                        b += deck[k];
                        c++;
                    }
                    _j /= 3;
                }
                if (a == b)
                {
                    if (c > max)
                    {
                        max = c;
                        bestdis = j;
                    }
                    if (max == deck.Length - sum % 2)
                    {
                        break;
                    }
                }
            }
            List<int> al = new List<int>();
            List<int> bl = new List<int>();
            for (int k = 0; k < deck.Length; k++)
            {
                if (bestdis % 3 == 1)
                {
                    al.Add(deck[k]);
                }
                else if (bestdis % 3 == 2)
                {
                    bl.Add(deck[k]);
                }
                bestdis /= 3;
            }

            return (al,bl);
        }
    }
}
