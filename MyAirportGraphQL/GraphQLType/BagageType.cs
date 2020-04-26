using GraphQL.Types;
using PBZN_SSU.MyAirport.EF;

namespace MyAirport.GraphQL
{
    public class BagageType : ObjectGraphType<Bagage>
    {
        public BagageType()
        {
            Field(x => x.BagageId);
            Field(x => x.Classe);
            Field(x => x.CodeIata);
            Field(x => x.DateCreation);
            Field(x => x.Destination);
            Field(x => x.Escale);
            //Field(x => x.Prioritaire);
            Field(x => x.Sta);
            Field(x => x.Ssur);
            //Field(x => x.VolId);
        }
       
    }
}
