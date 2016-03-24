using Nancy;

namespace IAmBacon.Demos.Nancy
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = parameters =>
            {
                return View["index"];
            };

            Get["/pinch"] = parameters => View["pinch"];

            Get["/toaster"] = parameters => View["toaster"];

            Get["/semantic-grid-helper"] = parameters => View["semanticGridHelper"];

            Get["/css-corner-flag"] = parameters => View["cssFlag"];
        }
    }
}