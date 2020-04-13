// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Author.cs" company="">
//   
// </copyright>
// <summary>
//   The author.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Itella.Database.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The author.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the books.
        /// </summary>
        public ICollection<Book> Books { get; set; }
    }
}