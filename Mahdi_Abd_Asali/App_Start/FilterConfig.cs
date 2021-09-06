using System.Web;
using System.Web.Mvc;

namespace Mahdi_Abd_Asali
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
