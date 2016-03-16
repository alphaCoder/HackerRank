using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Strings
{
    // O(n log n) - Manber and Myers algorithm
    public class SuffixArray
    {
        private string text;
        private int textLen = 0;
        private int[] sa;
        public SuffixArray(string txt)
        {
            text = txt;
            textLen = text.Length;
            sa = new int[textLen];
        }
        public string[] SuffixSort()
        {
            for(int i=0; i<textLen; i++)
            {
                sa[i] = i;
            }
            
            return null;
        }

        private bool SmallerFirstChar(int a, int b)
        {
            return text[a] < text[b];
        }
    }
}
