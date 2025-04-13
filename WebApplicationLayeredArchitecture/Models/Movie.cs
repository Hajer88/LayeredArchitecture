namespace WebApplicationLayeredArchitecture.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }

    public virtual Genre? genre { get; set; }
}