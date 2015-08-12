using System.Web.Optimization;

namespace SimpleBlog.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundels(BundleCollection bundels)
        {
            bundels.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/bootstrap.css")
                .Include("~/content/styles/admin.css"));

            bundels.Add(new StyleBundle("~/Styles")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/Styles/Site.css"));

            bundels.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/scripts/jquery-2.1.4.js")
                .Include("~/Scripts/jquery.validate.min.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.min.js")
                .Include("~/Scripts/bootstrap.js"));

            bundels.Add(new ScriptBundle("~/scripts")
                .Include("~/scripts/jquery-2.1.4.js")
                .Include("~/Scripts/jquery.validate.min.js")
                .Include("~/Scripts/jquery.validate.unobtrusive.min.js")
                .Include("~/Scripts/bootstrap.js"));
        }
    }
}