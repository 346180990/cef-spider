using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;

namespace AutoSingIn
{
    class GetCookie : CefSharp.ICookieVisitor
    {
        public event Action<CefSharp.Cookie> SendCookie;
        public void Dispose()
        {
           
        }

        public bool Visit(Cookie cookie, int count, int total, ref bool deleteCookie)
        {
            deleteCookie = false;
            if (SendCookie != null)
            {
                SendCookie(cookie);
            }
            return true;
        }
        private void visitor_SendCookie(CefSharp.Cookie obj)
        {

            //this.SendCookie += obj.Domain.TrimStart('.') + "^" + obj.Name + "^" + obj.Value + "$";
        }  

    }
}
