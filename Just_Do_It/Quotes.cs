using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just_Do_It
{
    public static class Quotes
    {
        private static List<string> _quotes = new List<string>
        {
            "You can DO IT!",
            "I Believe in you!",
            "Easy Peasy",
            "Just a few more tries!",
            "Winners never quit, and quitters never win",
        };
        private static int index = 0;

        public static string GetQuote()
        {
            if(index > _quotes.Count - 1) { index = 0; }
            index++;
            return _quotes[index];
        }
    }
}
