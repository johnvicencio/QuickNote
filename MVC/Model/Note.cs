using System;
namespace QuickNote.MVC.Model;

public class Note
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public DateTime DateModified { get; set; }
}

