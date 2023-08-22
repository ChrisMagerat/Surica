namespace Surica;

public class Authors
{
   public Guid AuthorID { get; set; }
    public string? AuthorName { get; set; }
    public DateTime ActiveFrom { get; set; }

    public DateTime ActiveTo { get; set; }

    public Guid UserId{ get; set; }
}
