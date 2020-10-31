using System;
using System.Linq;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            return orig.Aggregate("", (repeatText, ch) => repeatText += new String(ch, n));
        }
    }
}
