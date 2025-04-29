using System.ComponentModel.DataAnnotations;

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

public enum Team
{
    ATL = 1,  // Atlanta Hawks
    BOS = 2,  // Boston Celtics
    BKN = 3,  // Brooklyn Nets
    CHA = 4,  // Charlotte Hornets
    CHI = 5,  // Chicago Bulls
    CLE = 6,  // Cleveland Cavaliers
    DAL = 7,  // Dallas Mavericks
    DEN = 8,  // Denver Nuggets
    DET = 9,  // Detroit Pistons
    GSW = 10, // Golden State Warriors
    HOU = 11, // Houston Rockets
    IND = 12, // Indiana Pacers
    LAC = 13, // Los Angeles Clippers
    LAL = 14, // Los Angeles Lakers
    MEM = 15, // Memphis Grizzlies
    MIA = 16, // Miami Heat
    MIL = 17, // Milwaukee Bucks
    MIN = 18, // Minnesota Timberwolves
    NOP = 19, // New Orleans Pelicans
    NYK = 20, // New York Knicks
    OKC = 21, // Oklahoma City Thunder
    ORL = 22, // Orlando Magic
    PHI = 23, // Philadelphia 76ers
    PHX = 24, // Phoenix Suns
    POR = 25, // Portland Trail Blazers
    SAC = 26, // Sacramento Kings
    SAS = 27, // San Antonio Spurs
    TOR = 28, // Toronto Raptors
    UTA = 29, // Utah Jazz
    WAS = 30  // Washington Wizards
}

public enum WinType
{
    Home = 1,
    Away = 2
}
