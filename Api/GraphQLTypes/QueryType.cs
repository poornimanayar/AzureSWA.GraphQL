using HotChocolate.Types;


namespace Api.GraphQLTypes
{
   public class QueryType : ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            descriptor
                .Field(f => f.GetBooks())
                .Name("GetBooks")
                .Type<ListType<BookType>>();

            descriptor
               .Field(f => f.GetBook(default))
               .Name("GetBook")
               .Argument("id", a => a.Type<NonNullType<IntType>>())
               .Type<BookType>();
        }
    }
}
