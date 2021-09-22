using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegexDemo058
{
    public class Addition
    {
        public int Sum(int first,int second)
        {
            int res = Multi(first);
            return first + res;
        }
        public int Multi(int first)
        {
            return first * first;
        }
    }
}
