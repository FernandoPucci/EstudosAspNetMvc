using System.Web;
using System.Web.Mvc;

namespace ExercicioVendasMasterDetail
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
