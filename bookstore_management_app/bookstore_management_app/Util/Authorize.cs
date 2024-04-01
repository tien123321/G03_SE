using System;
using System.Collections.Generic;

namespace bookstore_management_app.Util
{
    internal class Authorize
    {
        private static Authorize instance;
        private string role;
        private string username;
        private int iMaNV;
        private int status= (int)ACCOUNT_STATUS.ACTIVATE;

        private Authorize() {}
        public string Role
        {
            set
            {
                this.role = value;
            }
        }

        public string Username
        {
            get 
            { 
                return this.username; 
            }
            set 
            {
                this.username = value;
            }
        }

        public int MaNV
        {
            get
            {
                return this.iMaNV;
            }
            set
            {
                this.iMaNV = value;
            }
        }


        public int Status
        {
            set { this.status = value; }
            get { return this.status; }
        }

        public void clearSession()
        {
            instance = null;
            this.role = null;
            this.username = null;
            this.iMaNV = 0;
            this.status = (int)ACCOUNT_STATUS.ACTIVATE;
        }

        public static Authorize Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Authorize();
                }
                return instance;
            }
            set { instance = value; }
        }

        public bool isCheckRole(List<String> roles)
        {
            if (roles.Contains(this.role))
            {
                return true;
            }
            return false;
        }

        public void saveSession(string username, string role, int status, int iMaNV)
        {
            this.username = username;
            this.role = role;
            this.status = status;
            this.iMaNV= iMaNV;
        }
    }
}
