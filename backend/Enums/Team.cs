namespace Backend.Enums;

public enum Team
{
    ATL = 1,
    BOS = 2,
    BKN = 3,
    CHA = 4,
    CHI = 5,
    CLE = 6,
    DAL = 7,
    DEN = 8,
    DET = 9,
    GSW = 10,
    HOU = 11,
    IND = 12,
    LAC = 13,
    LAL = 14,
    MEM = 15,
    MIA = 16,
    MIL = 17,
    MIN = 18,
    NOP = 19,
    NYK = 20,
    OKC = 21,
    ORL = 22,
    PHI = 23,
    PHX = 24,
    POR = 25,
    SAC = 26,
    SAS = 27,
    TOR = 28,
    UTA = 29,
    WAS = 30
}

public static class TeamExtensions
{
    public static string GetFullName(this Team team) => team switch
    {
        Team.ATL => "Atlanta Hawks",
        Team.BOS => "Boston Celtics",
        Team.BKN => "Brooklyn Nets",
        Team.CHA => "Charlotte Hornets",
        Team.CHI => "Chicago Bulls",
        Team.CLE => "Cleveland Cavaliers",
        Team.DAL => "Dallas Mavericks",
        Team.DEN => "Denver Nuggets",
        Team.DET => "Detroit Pistons",
        Team.GSW => "Golden State Warriors",
        Team.HOU => "Houston Rockets",
        Team.IND => "Indiana Pacers",
        Team.LAC => "Los Angeles Clippers",
        Team.LAL => "Los Angeles Lakers",
        Team.MEM => "Memphis Grizzlies",
        Team.MIA => "Miami Heat",
        Team.MIL => "Milwaukee Bucks",
        Team.MIN => "Minnesota Timberwolves",
        Team.NOP => "New Orleans Pelicans",
        Team.NYK => "New York Knicks",
        Team.OKC => "Oklahoma City Thunder",
        Team.ORL => "Orlando Magic",
        Team.PHI => "Philadelphia 76ers",
        Team.PHX => "Phoenix Suns",
        Team.POR => "Portland Trail Blazers",
        Team.SAC => "Sacramento Kings",
        Team.SAS => "San Antonio Spurs",
        Team.TOR => "Toronto Raptors",
        Team.UTA => "Utah Jazz",
        Team.WAS => "Washington Wizards",
        _ => "Unknown"
    };

    public static string GetLogoPath(this Team team) =>
        $"/assets/logos/{team.ToString().ToLower()}.png";
}
