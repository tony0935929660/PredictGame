using System.ComponentModel.DataAnnotations;
using Backend.Models;
using Backend.Enums;

namespace Backend.Models;

public class Prediction
{
    public int Id { get; set; }

    public int UserId { get; set; }
    public required User User { get; set; }

    public int GameId { get; set; }
    public required Game Game { get; set; }

    public WinType PredictedResult { get; set; }

    public bool IsPredictionCorrect { get; set; }

    public int Profit { get; set; }
}
