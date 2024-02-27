using Microsoft.AspNetCore.Mvc.Routing;

namespace BigWebApp
{
    public class CustomRouteValueTransformer : DynamicRouteValueTransformer
    {
        public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
        {
            return new ValueTask<RouteValueDictionary>(values);
        }
    }
}
