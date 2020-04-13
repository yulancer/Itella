using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Itella.Database;
using Itella.Database.Entities;

public partial class AddBook : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Insert()
    {
        var item = new Book();

        this.TryUpdateModel(item);
        if (ModelState.IsValid)
        {
            using (LibraryContext db = new LibraryContext())
            {
                db.Books.Add(item);
                db.SaveChanges();
            }
        }
    }

    protected void OnCancelClick(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void addBookForm_OnItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}