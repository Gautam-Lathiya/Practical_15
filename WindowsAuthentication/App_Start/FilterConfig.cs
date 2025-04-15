using System.Web;
using System.Web.Mvc;
using WindowsAuthentication.Filters;

namespace WindowsAuthentication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuditLogFilter());
        }
    }
}
