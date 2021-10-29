using Api.Models;
using HotChocolate.Types;

namespace Api.GraphQLTypes
{
   public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            descriptor
                .Field(f => f.Id)
                .Name("id")
                .Type<IntType>()
                .Description("The id of the book");

            descriptor
               .Field(f => f.Title)
               .Name("title")
               .Type<StringType>()
               .Description("The title of the book");

            descriptor
                .Field(f => f.BookAuthor)
                .Name("author")
                .Type<AuthorType>()
                .Description("The author of the book");
        }
    }
}
