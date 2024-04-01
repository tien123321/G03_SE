using bookstore_management_app.Model;
using bookstore_management_app.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore_management_app.Controller
{
    internal class AuthenController
    {
        private AuthenModel authenModel;
        public AuthenController(){
            this.authenModel = new AuthenModel();
        }
        
        public bool login(string username, string password)
        {
             return this.authenModel.isCheckAccount(username, password);
        }

        public bool changePassword(String oldPassword,String newPassword)
        {
            return this.authenModel.changePassword(Authorize.Instance.Username, oldPassword,newPassword);
        }
    
    }
}
