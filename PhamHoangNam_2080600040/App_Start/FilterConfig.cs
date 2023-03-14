using System.Web;
using System.Web.Mvc;

namespace PhamHoangNam_2080600040
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
