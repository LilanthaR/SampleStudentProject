using System.Web;
using System.Web.Mvc;

namespace AbcCo.StdMng.Deployable.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
