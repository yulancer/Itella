// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LibraryContext.cs" company="">
//   
// </copyright>
// <summary>
//   The library context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Itella.Database
{
    using System.Data.Entity;

    using Itella.Database.Entities;

    /// <summary>
    /// The library context.
    /// </summary>
    public class LibraryContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryContext"/> class.
        /// </summary>
        public LibraryContext()
            : base("DefaultConnection")
        {
        }

        /// <summary>
        /// Gets or sets the books.
        /// </summary>
        public DbSet<Book> Books { get; set; }

        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasMany(a => a.Books).WithMany(b => b.Authors);
        }
    }
}