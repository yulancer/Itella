// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Default.aspx.cs" company="">
//   
// </copyright>
// <summary>
//   The _ default.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.ModelBinding;
using System.Web.UI;

using Itella.Database;
using Itella.Database.Entities;

/// <summary>
/// The _ default.
/// </summary>
public partial class _Default : Page
{
    /// <summary>
    /// The page_ load.
    /// </summary>
    /// <param name="sender">
    /// The sender.
    /// </param>
    /// <param name="e">
    /// The e.
    /// </param>
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// The select book.
    /// </summary>
    /// <param name="nameFilter">
    /// The name filter.
    /// </param>
    /// <returns>
    /// The <see cref="IQueryable"/>.
    /// </returns>
    public IQueryable<Book> SelectBook([Control] string nameFilter)
    {
        LibraryContext context = new LibraryContext();
        IQueryable<Book> query = context.Books;
        if (!string.IsNullOrEmpty(nameFilter))
        {
            query = query.Where(b => b.Name.Contains(nameFilter)).AsQueryable();
        }

        return query;
    }

    /// <summary>
    /// The update.
    /// </summary>
    /// <param name="id">
    /// The id.
    /// </param>
    public void Update(int id)
    {
        using (LibraryContext context = new LibraryContext())
        {
            Book book = context.Books.Find(id);
            if (book == null)
            {
                this.ModelState.AddModelError(string.Empty, $"Item with id {id} was not found");
                return;
            }

            this.TryUpdateModel(book);
            if (this.ModelState.IsValid)
            {
                context.SaveChanges();
            }
        }
    }

    /// <summary>
    /// The delete.
    /// </summary>
    /// <param name="id">
    /// The id.
    /// </param>
    public void Delete(int id)
    {
        using (LibraryContext context = new LibraryContext())
        {
            Book book = new Book { Id = id };
            context.Entry(book).State = EntityState.Deleted;
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                this.ModelState.AddModelError(string.Empty, $"Книга {id} не найдена в базе.");
            }
        }
    }
}