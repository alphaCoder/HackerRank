using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Net.Strings;
using System.Net.Mail;
using System.Net;

namespace HackerRank.Net
{
    class Program
    {
        static void Main(string[] args)
        {

            var expected = "aaaaabccigicgjihidfiejfijgidgbhhehgfhjgiibggjddjjd";
            var input = "djjcddjggbiigjhfghehhbgdigjicafgjcehhfgifadihiajgciagicdahcbajjbhifjiaajigdgdfhdiijjgaiejgegbbiigida";

            //Act
            var actual = ReverseShuffleMerge.GetSubstring(input);

            Console.ReadLine();



        }
    }
}
