using System.Web.Mvc;

namespace _190410_BlogV1.Areas.AdminPaneli
{
    public class AdminPaneliAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AdminPaneli";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AdminPaneli_default",
                "AdminPaneli/{controller}/{action}/{id}",
                new {controller = "Default", action="Index" ,id = UrlParameter.Optional },
                namespaces: new[] {"_190410_BlogV1.Controllers"}
            );
        }
    }
}