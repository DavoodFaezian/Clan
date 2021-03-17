using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan
{
    interface IComputerBattle
    {
        DataTable Selectall();
        bool Money(int ID,int money,int currentmoney);
        bool Cup(int ID,int cup,int currentcup, int money, int currentmoney);
        }
}
