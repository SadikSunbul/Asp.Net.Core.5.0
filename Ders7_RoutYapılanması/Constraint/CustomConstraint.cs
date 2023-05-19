using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Ders7_RoutYapılanması.Constraint
{
    public class CustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext,
            IRouter route, 
            string routeKey, 
            RouteValueDictionary values,
            RouteDirection routeDirection)
        {
            var value= values[routeKey];
            return true;
        }
    }
}
