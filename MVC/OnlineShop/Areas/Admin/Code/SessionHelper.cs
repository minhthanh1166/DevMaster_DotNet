using System.Web;

namespace OnlineShop.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSesstion(UserSession session)
        {
            HttpContext.Current.Session["LoginSesstion"] = session;
        }

        public static UserSession GetSession()
        {
            var session = HttpContext.Current.Session["LoginSesstion"];
            if (session == null)
                return null;
            else
                return session as UserSession;
        }
    }
}