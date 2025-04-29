using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class User
{
    public int Id { get; set; }

    [Required]
    public required string Name { get; set; }

    public string? LineId { get; set; }

    [Required]
    public required string Password { get; set; }

    public bool IsAdmin { get; set; }

    // Navigation
    public ICollection<Prediction>? Predictions { get; set; }
}
