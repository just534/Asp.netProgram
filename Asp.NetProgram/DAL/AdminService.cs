using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.NetProgram.DAL
{
    public class AdminService
    {
        public bool AdminLogin(string name,string pwd)
        {
            if (name == "xiaowang" && pwd == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}