using Backend.Models;

namespace Backend.Helpers;

public static class TeamHelper
{
    public static string GetTeamFullName(Team team)
    {
        return team switch
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
    }

    public static string GetTeamLogoPath(Team team)
    {
        // 這裡假設你的 Logo 檔案路徑都是用簡寫，小寫存放在 /assets/logos/
        return $"/assets/logos/{team.ToString().ToLower()}.png";
    }
}
