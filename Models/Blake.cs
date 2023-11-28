namespace blakeslist.Models;

public class Blake
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Name { get; set; }
    public string FavoriteMovie { get; set; }
    public int? Age { get; set; }
    public int? Year { get; set; }
    public bool? IsBlake { get; set; }
    public bool? IsFlexible { get; set; }

}