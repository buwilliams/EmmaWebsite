using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Friend
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Likes { get; set; }
}