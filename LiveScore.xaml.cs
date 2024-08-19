using Football_App.Models;
using Football_App.Services;


namespace Football_App
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {

            var results = await LiveScoreAPI.LiveScoresAPI();

            try
            {
                //Live scores grid 1
                LiveTeamA.Text = results.data.match[0].home.name;
                LiveTeamB.Text = results.data.match[0].away.name;
                ScoreG1.Text = results.data.match[0].scores.score;
                TimeG1.Text = results.data.match[0].time;
            }
            catch
            {
                //Catching Null Errors
                LiveTeamA.Text = null;
                LiveTeamB.Text = null;
                ScoreG1.Text = "No Live scores";
                TimeG1.Text = null;
            }

            try
            {
                //Live scores grid 2
                TeamAGrid2.Text = results.data.match[1].home.name;
                TeamBGrid2.Text = results.data.match[1].away.name;
                ScoreG2.Text = results.data.match[1].scores.score;
                TimeG2.Text = results.data.match[1].time;
            }
            catch
            {
                //Catching Null Errors
                TeamAGrid2.Text = null;
                TeamBGrid2.Text = null;
                ScoreG2.Text = "No Live scores";
                TimeG2.Text = null;
            }

            try
            {
                //Live scores grid 3
                TeamAGrid3.Text = results.data.match[2].home.name;
                TeamBGrid3.Text = results.data.match[2].away.name;
                ScoreG3.Text = results.data.match[2].scores.score;
                TimeG3.Text = results.data.match[2].time;
            }
            catch
            {
                //Catching Null Errors
                TeamAGrid3.Text = null;
                TeamBGrid3.Text = null;
                ScoreG3.Text = "No Live scores";
                TimeG3.Text = null;
            }

            try
            {
                //Live scores grid 4
                TeamAGrid4.Text = results.data.match[3].home.name;
                TeamBGrid4.Text = results.data.match[3].away.name;
                ScoreG4.Text = results.data.match[3].scores.score;
                TimeG4.Text = results.data.match[3].time;
            }
            catch
            {
                //Catching Null Errors
                TeamAGrid4.Text = null;
                TeamBGrid4.Text = null;
                ScoreG4.Text = "No Live scores";
                TimeG4.Text = null;
            }

            try
            {
                //Live scores grid 5
                TeamAGrid5.Text = results.data.match[4].home.name;
                TeamBGrid5.Text = results.data.match[4].away.name;
                ScoreG5.Text = results.data.match[4].scores.score;
                TimeG5.Text = results.data.match[4].time;
            }
            catch
            {
                //Catching Null Errors
                TeamAGrid5.Text = null;
                TeamBGrid5.Text = null;
                ScoreG5.Text = "No Live scores";
                TimeG5.Text = null;
            }

            //Calling the PL table Standings to appear on Application Launch
            PLStandings();
        }

        public async void PLStandings()
        {
            //Accessing Data from Roots throught the API
            var standings = await StandingsAPI.LiveStandings();

           

            try
            {
                //Standing Team 1 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos1Team.Text = standings.data.stages[0].groups[0].standings[0].team.name;
                pos1Draw.Text = standings.data.stages[0].groups[0].standings[0].drawn + "D";
                pos1Won.Text = standings.data.stages[0].groups[0].standings[0].won + "W";
                pos1Loss.Text = standings.data.stages[0].groups[0].standings[0].lost + "L";
                pos1GoalDiff.Text = standings.data.stages[0].groups[0].standings[0].goal_diff + "GD";
                pos1Matches.Text = standings.data.stages[0].groups[0].standings[0].matches + "PL";
                pos1Point.Text = standings.data.stages[0].groups[0].standings[0].points + "PT";
            }
            catch
            {
                //Standing Team 1 - Catch Null errors
                pos1Team.Text = null;
                pos1Draw.Text = null;
                pos1Won.Text = null;
                pos1Loss.Text = null;
                pos1GoalDiff.Text = null;
                pos1Matches.Text = null;
                pos1Point.Text = null;

            }
            try
            {
                //Standing Team 2 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos2Team.Text = standings.data.stages[0].groups[0].standings[1].team.name;
                pos2Draw.Text = standings.data.stages[0].groups[0].standings[1].drawn + "D";
                pos2Won.Text = standings.data.stages[0].groups[0].standings[1].won + "W";
                pos2Loss.Text = standings.data.stages[0].groups[0].standings[1].lost + "L";
                pos2GoalDiff.Text = standings.data.stages[0].groups[0].standings[1].goal_diff + "GD";
                pos2Matches.Text = standings.data.stages[0].groups[0].standings[1].matches + "PL";
                pos2Point.Text = standings.data.stages[0].groups[0].standings[1].points + "PT";
            }
            catch
            {
                //Standing Team 2 - Catch Null errors
                pos2Team.Text = null;
                pos2Draw.Text = null;
                pos2Won.Text = null;
                pos2Loss.Text = null;
                pos2GoalDiff.Text = null;
                pos2Matches.Text = null;
                pos2Point.Text = null;

            }
            try
            {
                //Standing Team 3 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos3Team.Text = standings.data.stages[0].groups[0].standings[2].team.name;
                pos3Draw.Text = standings.data.stages[0].groups[0].standings[2].drawn + "D";
                pos3Won.Text = standings.data.stages[0].groups[0].standings[2].won + "W";
                pos3Loss.Text = standings.data.stages[0].groups[0].standings[2].lost + "L";
                pos3GoalDiff.Text = standings.data.stages[0].groups[0].standings[2].goal_diff + "GD";
                pos3Matches.Text = standings.data.stages[0].groups[0].standings[2].matches + "PL";
                pos3Point.Text = standings.data.stages[0].groups[0].standings[2].points + "PT";
            }
            catch
            {
                //Standing Team 3 - Catch Null errors
                pos3Team.Text = null;
                pos3Draw.Text = null;
                pos3Won.Text = null;
                pos3Loss.Text = null;
                pos3GoalDiff.Text = null;
                pos3Matches.Text = null;
                pos3Point.Text = null;

            }
            try
            {
                //Standing Team 4 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos4Team.Text = standings.data.stages[0].groups[0].standings[3].team.name;
                pos4Draw.Text = standings.data.stages[0].groups[0].standings[3].drawn + "D";
                pos4Won.Text = standings.data.stages[0].groups[0].standings[3].won + "W";
                pos4Loss.Text = standings.data.stages[0].groups[0].standings[3].lost + "L";
                pos4GoalDiff.Text = standings.data.stages[0].groups[0].standings[3].goal_diff + "GD";
                pos4Matches.Text = standings.data.stages[0].groups[0].standings[3].matches + "PL";
                pos4Point.Text = standings.data.stages[0].groups[0].standings[3].points + "PT";
            }
            catch
            {
                //Standing Team 4 - Catch Null errors
                pos4Team.Text = null;
                pos4Draw.Text = null;
                pos4Won.Text = null;
                pos4Loss.Text = null;
                pos4GoalDiff.Text = null;
                pos4Matches.Text = null;
                pos4Point.Text = null;

            }
            try
            {
                //Standing Team 5 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos5Team.Text = standings.data.stages[0].groups[0].standings[4].team.name;
                pos5Draw.Text = standings.data.stages[0].groups[0].standings[4].drawn + "D";
                pos5Won.Text = standings.data.stages[0].groups[0].standings[4].won + "W";
                pos5Loss.Text = standings.data.stages[0].groups[0].standings[4].lost + "L";
                pos5GoalDiff.Text = standings.data.stages[0].groups[0].standings[4].goal_diff + "GD";
                pos5Matches.Text = standings.data.stages[0].groups[0].standings[4].matches + "PL";
                pos5Point.Text = standings.data.stages[0].groups[0].standings[4].points + "PT";
            }
            catch
            {
                //Standing Team 5 - Catch Null errors
                pos5Team.Text = null;
                pos5Draw.Text = null;
                pos5Won.Text = null;
                pos5Loss.Text = null;
                pos5GoalDiff.Text = null;
                pos5Matches.Text = null;
                pos5Point.Text = null;

            }
            try
            {
                //Standing Team 6 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos6Team.Text = standings.data.stages[0].groups[0].standings[5].team.name;
                pos6Draw.Text = standings.data.stages[0].groups[0].standings[5].drawn + "D";
                pos6Won.Text = standings.data.stages[0].groups[0].standings[5].won + "W";
                pos6Loss.Text = standings.data.stages[0].groups[0].standings[5].lost + "L";
                pos6GoalDiff.Text = standings.data.stages[0].groups[0].standings[5].goal_diff + "GD";
                pos6Matches.Text = standings.data.stages[0].groups[0].standings[5].matches + "PL";
                pos6Point.Text = standings.data.stages[0].groups[0].standings[5].points + "PT";
            }
            catch
            {
                //Standing Team 6 - Catch Null errors
                pos6Team.Text = null;
                pos6Draw.Text = null;
                pos6Won.Text = null;
                pos6Loss.Text = null;
                pos6GoalDiff.Text = null;
                pos6Matches.Text = null;
                pos6Point.Text = null;

            }
            try
            {
                //Standing Team 7 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos7Team.Text = standings.data.stages[0].groups[0].standings[6].team.name;
                pos7Draw.Text = standings.data.stages[0].groups[0].standings[6].drawn + "D";
                pos7Won.Text = standings.data.stages[0].groups[0].standings[6].won + "W";
                pos7Loss.Text = standings.data.stages[0].groups[0].standings[6].lost + "L";
                pos7GoalDiff.Text = standings.data.stages[0].groups[0].standings[6].goal_diff + "GD";
                pos7Matches.Text = standings.data.stages[0].groups[0].standings[6].matches + "PL";
                pos7Point.Text = standings.data.stages[0].groups[0].standings[6].points + "PT";
            }
            catch
            {
                //Standing Team 7 - Catch Null errors
                pos7Team.Text = null;
                pos7Draw.Text = null;
                pos7Won.Text = null;
                pos7Loss.Text = null;
                pos7GoalDiff.Text = null;
                pos7Matches.Text = null;
                pos7Point.Text = null;

            }
            try
            {
                //Standing Team 8 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos8Team.Text = standings.data.stages[0].groups[0].standings[7].team.name;
                pos8Draw.Text = standings.data.stages[0].groups[0].standings[7].drawn + "D";
                pos8Won.Text = standings.data.stages[0].groups[0].standings[7].won + "W";
                pos8Loss.Text = standings.data.stages[0].groups[0].standings[7].lost + "L";
                pos8GoalDiff.Text = standings.data.stages[0].groups[0].standings[7].goal_diff + "GD";
                pos8Matches.Text = standings.data.stages[0].groups[0].standings[7].matches + "PL";
                pos8Point.Text = standings.data.stages[0].groups[0].standings[7].points + "PT";
            }
            catch
            {
                //Standing Team 8 - Catch Null errors
                pos8Team.Text = null;
                pos8Draw.Text = null;
                pos8Won.Text = null;
                pos8Loss.Text = null;
                pos8GoalDiff.Text = null;
                pos8Matches.Text = null;
                pos8Point.Text = null;

            }
            try
            {
                //Standing Team 9 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos9Team.Text = standings.data.stages[0].groups[0].standings[8].team.name;
                pos9Draw.Text = standings.data.stages[0].groups[0].standings[8].drawn + "D";
                pos9Won.Text = standings.data.stages[0].groups[0].standings[8].won + "W";
                pos9Loss.Text = standings.data.stages[0].groups[0].standings[8].lost + "L";
                pos9GoalDiff.Text = standings.data.stages[0].groups[0].standings[8].goal_diff + "GD";
                pos9Matches.Text = standings.data.stages[0].groups[0].standings[8].matches + "PL";
                pos9Point.Text = standings.data.stages[0].groups[0].standings[8].points + "PT";
            }
            catch
            {
                //Standing Team 9 - Catch Null errors
                pos9Team.Text = null;
                pos9Draw.Text = null;
                pos9Won.Text = null;
                pos9Loss.Text = null;
                pos9GoalDiff.Text = null;
                pos9Matches.Text = null;
                pos9Point.Text = null;

            }
            try
            {
                //Standing Team 10 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos10Team.Text = standings.data.stages[0].groups[0].standings[9].team.name;
                pos10Draw.Text = standings.data.stages[0].groups[0].standings[9].drawn + "D";
                pos10Won.Text = standings.data.stages[0].groups[0].standings[9].won + "W";
                pos10Loss.Text = standings.data.stages[0].groups[0].standings[9].lost + "L";
                pos10GoalDiff.Text = standings.data.stages[0].groups[0].standings[9].goal_diff + "GD";
                pos10Matches.Text = standings.data.stages[0].groups[0].standings[9].matches + "PL";
                pos10Point.Text = standings.data.stages[0].groups[0].standings[9].points + "PT";
            }
            catch
            {
                //Standing Team 10 - Catch Null errors
                pos10Team.Text = null;
                pos10Draw.Text = null;
                pos10Won.Text = null;
                pos10Loss.Text = null;
                pos10GoalDiff.Text = null;
                pos10Matches.Text = null;
                pos10Point.Text = null;

            }
            try
            {
                //Standing Team 11 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos11Team.Text = standings.data.stages[0].groups[0].standings[10].team.name;
                pos11Draw.Text = standings.data.stages[0].groups[0].standings[10].drawn + "D";
                pos11Won.Text = standings.data.stages[0].groups[0].standings[10].won + "W";
                pos11Loss.Text = standings.data.stages[0].groups[0].standings[10].lost + "L";
                pos11GoalDiff.Text = standings.data.stages[0].groups[0].standings[10].goal_diff + "GD";
                pos11Matches.Text = standings.data.stages[0].groups[0].standings[10].matches + "PL";
                po11Point.Text = standings.data.stages[0].groups[0].standings[10].points + "PT";
            }
            catch
            {
                //Standing Team 11 - Catch Null errors
                pos11Team.Text = null;
                pos11Draw.Text = null;
                pos11Won.Text = null;
                pos11Loss.Text = null;
                pos11GoalDiff.Text = null;
                pos11Matches.Text = null;
                pos1Point.Text = null;

            }
            try
            {
                //Standing Team 12 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos12Team.Text = standings.data.stages[0].groups[0].standings[11].team.name;
                pos12Draw.Text = standings.data.stages[0].groups[0].standings[11].drawn + "D";
                pos12Won.Text = standings.data.stages[0].groups[0].standings[11].won + "W";
                pos12Loss.Text = standings.data.stages[0].groups[0].standings[11].lost + "L";
                pos12GoalDiff.Text = standings.data.stages[0].groups[0].standings[11].goal_diff + "GD";
                pos12Matches.Text = standings.data.stages[0].groups[0].standings[11].matches + "PL";
                po12Point.Text = standings.data.stages[0].groups[0].standings[11].points + "PT";
            }
            catch
            {
                //Standing Team 12 - Catch Null errors
                pos12Team.Text = null;
                pos12Draw.Text = null;
                pos12Won.Text = null;
                pos12Loss.Text = null;
                pos12GoalDiff.Text = null;
                pos12Matches.Text = null;
                po12Point.Text = null;

            }
            try
            {
                //Standing Team 13 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos13Team.Text = standings.data.stages[0].groups[0].standings[12].team.name;
                pos13Draw.Text = standings.data.stages[0].groups[0].standings[12].drawn + "D";
                pos13Won.Text = standings.data.stages[0].groups[0].standings[12].won + "W";
                pos13Loss.Text = standings.data.stages[0].groups[0].standings[12].lost + "L";
                pos13GoalDiff.Text = standings.data.stages[0].groups[0].standings[12].goal_diff + "GD";
                pos13Matches.Text = standings.data.stages[0].groups[0].standings[12].matches + "PL";
                po13Point.Text = standings.data.stages[0].groups[0].standings[12].points + "PT";
            }
            catch
            {
                //Standing Team 13 - Catch Null errors
                pos13Team.Text = null;
                pos13Draw.Text = null;
                pos13Won.Text = null;
                pos13Loss.Text = null;
                pos13GoalDiff.Text = null;
                pos13Matches.Text = null;
                po13Point.Text = null;

            }
            try
            {
                //Standing Team 14 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos14Team.Text = standings.data.stages[0].groups[0].standings[13].team.name;
                pos14Draw.Text = standings.data.stages[0].groups[0].standings[13].drawn + "D";
                pos14Won.Text = standings.data.stages[0].groups[0].standings[13].won + "W";
                pos14Loss.Text = standings.data.stages[0].groups[0].standings[13].lost + "L";
                pos14GoalDiff.Text = standings.data.stages[0].groups[0].standings[13].goal_diff + "GD";
                pos14Matches.Text = standings.data.stages[0].groups[0].standings[13].matches + "PL";
                po14Point.Text = standings.data.stages[0].groups[0].standings[13].points + "PT";
            }
            catch
            {
                //Standing Team 14 - Catch Null errors
                pos14Team.Text = null;
                pos14Draw.Text = null;
                pos14Won.Text = null;
                pos14Loss.Text = null;
                pos14GoalDiff.Text = null;
                pos14Matches.Text = null;
                po14Point.Text = null;

            }
            try
            {
                //Standing Team 15 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos15Team.Text = standings.data.stages[0].groups[0].standings[14].team.name;
                pos15Draw.Text = standings.data.stages[0].groups[0].standings[14].drawn + "D";
                pos15Won.Text = standings.data.stages[0].groups[0].standings[14].won + "W";
                pos15Loss.Text = standings.data.stages[0].groups[0].standings[14].lost + "L";
                pos15GoalDiff.Text = standings.data.stages[0].groups[0].standings[14].goal_diff + "GD";
                pos15Matches.Text = standings.data.stages[0].groups[0].standings[14].matches + "PL";
                po15Point.Text = standings.data.stages[0].groups[0].standings[14].points + "PT";
            }
            catch
            {
                //Standing Team 15 - Catch Null errors
                pos15Team.Text = null;
                pos15Draw.Text = null;
                pos15Won.Text = null;
                pos15Loss.Text = null;
                pos15GoalDiff.Text = null;
                pos15Matches.Text = null;
                po15Point.Text = null;

            }
            try
            {
                //Standing Team 16 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos16Team.Text = standings.data.stages[0].groups[0].standings[15].team.name;
                pos16Draw.Text = standings.data.stages[0].groups[0].standings[15].drawn + "D";
                pos16Won.Text = standings.data.stages[0].groups[0].standings[15].won + "W";
                pos16Loss.Text = standings.data.stages[0].groups[0].standings[15].lost + "L";
                pos16GoalDiff.Text = standings.data.stages[0].groups[0].standings[15].goal_diff + "GD";
                pos16Matches.Text = standings.data.stages[0].groups[0].standings[15].matches + "PL";
                po16Point.Text = standings.data.stages[0].groups[0].standings[15].points + "PT";
            }
            catch
            {
                //Standing Team 16 - Catch Null errors
                pos16Team.Text = null;
                pos16Draw.Text = null;
                pos16Won.Text = null;
                pos16Loss.Text = null;
                pos16GoalDiff.Text = null;
                pos16Matches.Text = null;
                po16Point.Text = null;

            }
            try
            {
                //Standing Team 17 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos17Team.Text = standings.data.stages[0].groups[0].standings[16].team.name;
                pos17Draw.Text = standings.data.stages[0].groups[0].standings[16].drawn + "D";
                pos17Won.Text = standings.data.stages[0].groups[0].standings[16].won + "W";
                pos17Loss.Text = standings.data.stages[0].groups[0].standings[16].lost + "L";
                pos17GoalDiff.Text = standings.data.stages[0].groups[0].standings[16].goal_diff + "GD";
                pos17Matches.Text = standings.data.stages[0].groups[0].standings[16].matches + "PL";
                po17Point.Text = standings.data.stages[0].groups[0].standings[16].points + "PT";
            }
            catch
            {
                //Standing Team 17 - Catch Null errors
                pos17Team.Text = null;
                pos17Draw.Text = null;
                pos17Won.Text = null;
                pos17Loss.Text = null;
                pos17GoalDiff.Text = null;
                pos17Matches.Text = null;
                po17Point.Text = null;

            }
            try
            {
                //Standing Team 18 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos18Team.Text = standings.data.stages[0].groups[0].standings[17].team.name;
                pos18Draw.Text = standings.data.stages[0].groups[0].standings[17].drawn + "D";
                pos18Won.Text = standings.data.stages[0].groups[0].standings[17].won + "W";
                pos18Loss.Text = standings.data.stages[0].groups[0].standings[17].lost + "L";
                pos18GoalDiff.Text = standings.data.stages[0].groups[0].standings[17].goal_diff + "GD";
                pos18Matches.Text = standings.data.stages[0].groups[0].standings[17].matches + "PL";
                po18Point.Text = standings.data.stages[0].groups[0].standings[17].points + "PT";
            }
            catch
            {
                //Standing Team 18 - Catch Null errors
                pos18Team.Text = null;
                pos18Draw.Text = null;
                pos18Won.Text = null;
                pos18Loss.Text = null;
                pos18GoalDiff.Text = null;
                pos18Matches.Text = null;
                po18Point.Text = null;

            }
            try
            {
                //Standing Team 19 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos19Team.Text = standings.data.stages[0].groups[0].standings[18].team.name;
                pos19Draw.Text = standings.data.stages[0].groups[0].standings[18].drawn + "D";
                pos19Won.Text = standings.data.stages[0].groups[0].standings[18].won + "W";
                pos19Loss.Text = standings.data.stages[0].groups[0].standings[18].lost + "L";
                pos19GoalDiff.Text = standings.data.stages[0].groups[0].standings[18].goal_diff + "GD";
                pos19Matches.Text = standings.data.stages[0].groups[0].standings[18].matches + "PL";
                po19Point.Text = standings.data.stages[0].groups[0].standings[18].points + "PT";
            }
            catch
            {
                //Standing Team 19 - Catch Null errors
                pos19Team.Text = null;
                pos19Draw.Text = null;
                pos19Won.Text = null;
                pos19Loss.Text = null;
                pos19GoalDiff.Text = null;
                pos19Matches.Text = null;
                po19Point.Text = null;

            }
            try
            {
                //Standing Team 20 - Name, Wins, Draws, Losses, Matches Played, Goal Difference, Points
                pos20Team.Text = standings.data.stages[0].groups[0].standings[19].team.name;
                pos20Draw.Text = standings.data.stages[0].groups[0].standings[19].drawn + "D";
                pos20Won.Text = standings.data.stages[0].groups[0].standings[19].won + "W";
                pos20Loss.Text = standings.data.stages[0].groups[0].standings[19].lost + "L";
                pos20GoalDiff.Text = standings.data.stages[0].groups[0].standings[19].goal_diff + "GD";
                pos20Matches.Text = standings.data.stages[0].groups[0].standings[19].matches + "PL";
                po20Point.Text = standings.data.stages[0].groups[0].standings[19].points + "PT";
            }
            catch
            {
                //Standing Team 20 - Catch Null errors
                pos20Team.Text = null;
                pos20Draw.Text = null;
                pos20Won.Text = null;
                pos20Loss.Text = null;
                pos20GoalDiff.Text = null;
                pos20Matches.Text = null;
                po20Point.Text = null;

            }
        }
        private async void refresh(object sender, EventArgs e)
        {
            OnAppearing();
        }

    }

}
