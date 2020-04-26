using GraphQL.Types;
using PBZN_SSU.MyAirport.EF;
using System.Linq;

namespace MyAirport.GraphQL
{
    public class AirportQuery : ObjectGraphType
    {
        public AirportQuery(MyAirportContext db)
        {
            Field<ListGraphType<BagageType>>(
                "bagages",
                resolve: context => db.Bagages.ToList());
            /*Field<BagageType>(
                "bagage",
                arguments : new QueryArguments( new QueryArgument<IntGraphType> { Name = "BagageId" }),
                resolve: context => db.Bagages.First(b => b.BagageId == context));
                */
        }
    }
}
