using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore_management_app.Util
{
    internal class ROLES
    {
        public static string ADMIN = "ADMIN";
        public static string MANAGER = "MANAGER";
        public static string WAREHOUSE_WORKER = "WAREHOUSE_WORKER";
        public static string SALSEPERSON = "SALSEPERSON";
    }
    enum ACCOUNT_STATUS
    {
        ACTIVATE = 1,
        DEACTIVATE = 0 
    };
}
