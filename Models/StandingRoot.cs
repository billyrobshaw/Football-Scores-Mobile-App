using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Competition
{
    public int id { get; set; }
    public string name { get; set; }
    public bool is_league { get; set; }
    public bool is_cup { get; set; }
    public int tier { get; set; }
    public bool has_groups { get; set; }
    public bool active { get; set; }
    public bool national_teams_only { get; set; }
}

public class Data
{
    public Competition competition { get; set; }
    public Season season { get; set; }
    public List<Stage> stages { get; set; }
}

public class Group
{
    public int id { get; set; }
    public string name { get; set; }
    public List<Standing> standings { get; set; }
}

public class Roots
{
    public bool success { get; set; }
    public Data data { get; set; }
}

public class Season
{
    public int id { get; set; }
    public string name { get; set; }
    public string start { get; set; }
    public string end { get; set; }
}

public class Stage
{
    public Stage stage { get; set; }
    public List<Group> groups { get; set; }
}

public class Stage2
{
    public int id { get; set; }
    public string name { get; set; }
}

public class Standing
{
    public int rank { get; set; }
    public int points { get; set; }
    public int matches { get; set; }
    public int goal_diff { get; set; }
    public int goals_scored { get; set; }
    public int goals_conceded { get; set; }
    public int lost { get; set; }
    public int drawn { get; set; }
    public int won { get; set; }
    public Team team { get; set; }
}

public class Team
{
    public int id { get; set; }
    public string name { get; set; }
    public string stadium { get; set; }
    public int country_id { get; set; }
}


