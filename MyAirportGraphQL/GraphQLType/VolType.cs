using GraphQL.Types;
using MyAirport.EF;

namespace MyAirport.GraphQL
{
    public class VolType : ObjectGraphType<Vol>
    {
        public VolType()
        {
            Field(x => x.Cie);
            Field(x => x.Des);
            Field(x => x.Dhc);
            Field(x => x.Imm);
            Field(x => x.Lig);
            Field(x => x.Pax);
            Field(x => x.Pkg);
            Field(x => x.VolId);
        }
    }
}
