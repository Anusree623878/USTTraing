using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodExample
{
    public static class GetWordCount
    {
        public static int GetWordCountstr(this string word)
        {
            if(!string.IsNullOrEmpty(word))
            {
                string[]strArray = word.Split(' ');
                return strArray.Count();
            }
            return 0;
        }
    }
}
