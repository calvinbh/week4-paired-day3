using System.Web;
using System.Web.Mvc;

namespace week4_csharp_paired_day3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
