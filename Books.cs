namespace Surica;

public class Books
{
   public Guid BookId { get; set; }
    public string? BookName { get; set; }
    public string? Publisher { get; set; }

    public DateTime DatePublished { get; set; }
    public int CopiesSold { get; set; }

    public Guid AuthorID{ get; set; }

    public Guid UserId{ get; set; }
    
}
