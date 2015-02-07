using System.Web;
using System.Web.Mvc;

namespace aspnetmvc_mvaintro
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
