// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LibraryInitializer.cs" company="">
//   
// </copyright>
// <summary>
//   The library initializer.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Itella.Database
{
    using System.Collections.Generic;

    using Itella.Database.Entities;

    /// <summary>
    /// The library initializer.
    /// </summary>
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        /// <inheritdoc />
        protected override void Seed(LibraryContext context)
        {
            var authors = new List<Author>(new[]
                                               {
                                                   new Author { Id = 1, Name = "Иванов" },
                                                   new Author { Id = 2, Name = "Петров" },
                                                   new Author { Id = 3, Name = "Сидоров" },
                                                   new Author { Id = 4, Name = "Соавтор" },
                                               });
            authors.ForEach(au => context.Authors.Add(au));
            context.SaveChanges();

            int booksCount = 100;
            for (int i = 0; i < booksCount; i++)
            {
                Author author = authors[i % 3];
                Book book = new Book
                                {
                                    Id = i + 1,
                                    Name = $"Книга {i}",
                                    PageCount = i * 10,
                                    Authors = new List<Author>(new[] { author })
                                };

                // каждой 10-й книге добавляем соавтора, если это не Петров - его найдём запросом
                if (i % 10 == 0 && author.Id != 2)
                {
                    book.Authors.Add(authors[3]);
                }

                context.Books.Add(book);
            }

            context.SaveChanges();
        }
    }
}