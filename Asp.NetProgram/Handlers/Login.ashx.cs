using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.NetProgram.Handlers
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {
        private DAL.AdminService objAdminService = new DAL.AdminService();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string uname = context.Request.Params["uname"];//获取传入的用户名
            string upwd = context.Request.Params["upwd"];//获取传入的密码
            if (objAdminService.AdminLogin(uname, upwd))
            {
                context.Response.Write("登陆成功");
            }
            else
            {
                context.Response.Write("登陆失败");
            }
            context.Response.Write("Hello World");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}