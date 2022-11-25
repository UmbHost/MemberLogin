using Umbraco.Cms.Core.Manifest;

namespace Our.Umbraco.MemberLogin.ManifestFilters;

internal class MemberLoginManifestFilter : IManifestFilter
{
    public void Filter(List<PackageManifest> manifests)
    {
        manifests.Add(new PackageManifest
        {
            PackageName = "MemberLogin",
            Scripts = new[]
            {
                "/App_Plugins/MemberLogin/js/memberlogin.controller.js"
            },
            Stylesheets = new[]
            {
                "/App_Plugins/MemberLogin/css/memberlogin.css"
            }
        });
    }
}