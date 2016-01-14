using System.Web;
using System.Web.Mvc;

namespace Berlitz.Cosmos.Web.Html5
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}