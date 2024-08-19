using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_App.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Away
    {
        public int id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public string stadium { get; set; }
    }

    public class Competition
    {
        public bool is_cup { get; set; }
        public bool active { get; set; }
        public bool has_groups { get; set; }
        public bool national_teams_only { get; set; }
        public int tier { get; set; }
        public string name { get; set; }
        public bool is_league { get; set; }
        public int id { get; set; }
    }

    public class Country
    {
        public string name { get; set; }
        public int id { get; set; }
        public string uefa_code { get; set; }
        public string fifa_code { get; set; }
        public bool is_real { get; set; }
    }

    public class Data
    {
        public List<Match> match { get; set; }
    }

    public class Federation
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Home
    {
        public int id { get; set; }
        public string name { get; set; }
        public int country_id { get; set; }
        public string stadium { get; set; }
    }

    public class Live
    {
        [JsonProperty("1")]
        public object _1 { get; set; }

        [JsonProperty("2")]
        public object _2 { get; set; }
        public object X { get; set; }
    }

    public class Match
    {
        public string location { get; set; }
        public string scheduled { get; set; }
        public Country country { get; set; }
        public string last_changed { get; set; }
        public string status { get; set; }
        public int fixture_id { get; set; }
        public Home home { get; set; }
        public Away away { get; set; }
        public int id { get; set; }
        public Federation federation { get; set; }
        public Odds odds { get; set; }
        public string time { get; set; }
        public string added { get; set; }
        public Competition competition { get; set; }
        public Outcomes outcomes { get; set; }
        public Scores scores { get; set; }
        public Urls urls { get; set; }
    }

    public class Odds
    {
        public Live live { get; set; }
        public Pre pre { get; set; }
    }

    public class Outcomes
    {
        public string half_time { get; set; }
        public string full_time { get; set; }
        public object extra_time { get; set; }
        public object penalty_shootout { get; set; }
    }

    public class Pre
    {
        [JsonProperty("1")]
        public double? _1 { get; set; }

        [JsonProperty("2")]
        public double? _2 { get; set; }
        public double? X { get; set; }
    }

    public class Root
    {
        public bool success { get; set; }
        public Data data { get; set; }
    }

    public class Scores
    {
        public string score { get; set; }
        public string ht_score { get; set; }
        public string ft_score { get; set; }
        public string et_score { get; set; }
        public string ps_score { get; set; }
    }

    public class Urls
    {
        public string events { get; set; }
        public string statistics { get; set; }
        public string lineups { get; set; }
        public string head2head { get; set; }
    }



}
