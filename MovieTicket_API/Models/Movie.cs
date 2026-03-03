namespace MovieTicket.API.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; } = "";
    public string? Genre { get; set; } = "";
    public double Duration { get; set; }   
    public double Rating { get; set; }
    public int Price {get; set;}
    
}
