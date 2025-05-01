using System.ComponentModel.DataAnnotations;
using Backend.Enums;

namespace Backend.Models;

public class Game
{
    public int Id { get; set; }

    [Required]
    public int Round { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public Team HomeTeam { get; set; }

    [Required]
    public Team AwayTeam { get; set; }

    public WinType? WinType { get; set; }

    public ICollection<Prediction>? Predictions { get; set; }
}
