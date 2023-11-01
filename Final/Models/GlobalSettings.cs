using Final.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Models
{
    public static class GlobalSettings
    {
        public static FinalDataBaseEntities DB = new FinalDataBaseEntities();
        public static User contextUser;
    }
}
