// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Book.cs" company="">
//   
// </copyright>
// <summary>
//   The book.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Itella.Database.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel;

    /// <summary>
    /// The book.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [ReadOnly(true)]
        [DisplayName(" ")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DisplayName("Наименование")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the page count.
        /// </summary>
        [DisplayName("Количество страниц")]
        public int PageCount { get; set; }

        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        public ICollection<Author> Authors { get; set; }
    }
}