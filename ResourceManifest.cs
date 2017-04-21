using Orchard.UI.Resources;

namespace Orchard.Bootstrap {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineStyle("Bootstrap.Style").SetUrl("bs.min.css", "bs.css");
            manifest.DefineScript("Bootstrap.Script").SetUrl("bs.min.js", "bs.js").SetDependencies(new[] { "jQuery" });
        }
    }
}
