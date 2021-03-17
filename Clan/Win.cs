using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan
{
    
    class Win : IWin
    {

        public bool CheckWin(string part1, string part2, string part3, string part4, string part5, string part6, string part7, string part8, string part9)
        {

            if (part1 == part2 && part2 == part3 && part3!="")
            {
                return true;
            }
            
            if (part7 == part8 && part8 == part9 && part9 != "")
            {
                return true;
            }
            if (part1 == part5 && part5 == part9 && part9 != "")
            {
                return true;
            }

            if (part3 == part5 && part5 == part7 && part7 != "")
            {
                return true;
            }
            if (part1 == part4 && part4 == part7 && part7 != "")
            {
                return true;
            }
            if (part2 == part5 && part5 == part8 && part8 != "")
            {
                return true;
            }
            if (part3 == part6 && part6 == part9 && part9 != "")
            {
                return true;
            }
            if (part4 == part5 && part5 == part6 && part6 != "")
            {
                return true;
            }



            return false;


        }
    }
}