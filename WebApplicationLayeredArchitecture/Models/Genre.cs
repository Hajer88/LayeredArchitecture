namespace WebApplicationLayeredArchitecture.Models;

public class Genre
{
    public int Id{  get; set; }
     
    public string genre { get; set; }

    public virtual List<Movie>? movies{ get; set; }
}