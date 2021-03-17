using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Clan
{
    interface IProfile
    {
        bool Choose(int Avatar);
        bool Update_name(string name,int ID);
        bool Update_Avatar(int Avatar,int ID);
        DataTable selectall();
        DataTable search(string friends_search);


    }
}
