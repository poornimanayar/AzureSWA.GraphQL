using Api.Models;
using HotChocolate.Types;

namespace Api.GraphQLTypes
{
    public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            descriptor
                .Field(f => f.Id)
                .Name("id")
                .Type<IntType>()
                .Description("The id of the author");

            descriptor
               .Field(f => f.Name)
               .Name("name")
               .Type<StringType>()
               .Description("The name of the author");
        }
    }
}