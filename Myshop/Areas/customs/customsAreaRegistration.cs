using System.Web.Mvc;

namespace MyShop.Areas.customs
{
    public class customsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "customs";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "customs_default",
                "customs/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}