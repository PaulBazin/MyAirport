using GraphQL;
using GraphQL.Types;

namespace MyAirport.GraphQL
{
    public class AirportSchema : Schema
    {
        public AirportSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AirportQuery>();
        }
    }
}
