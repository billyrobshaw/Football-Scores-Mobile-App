using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football_App.Models;
using Newtonsoft.Json;

namespace Football_App.Services
{
    public static class LiveScoreAPI
    {

        public static async Task<Root> LiveScoresAPI()
        {
            var httpClient = new HttpClient();
            //get request
            var response = await httpClient.GetStringAsync(string.Format
                ("https://livescore-api.com/api-client/matches/live.json?key=sabgxItKNG3zcHxd&secret=FOENjzTfS6OyPEDiPOzmw27kJaUVSs9y"));
            //API URl for weather in a city
            return JsonConvert.DeserializeObject<Root>(response);
        }

    }
}
