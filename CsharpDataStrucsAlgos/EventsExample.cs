using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.Events;

/*
    var footballMatch = new FootballMatch("Barcelona", "Real Madrid");

    // We can only attach a method to the event
    // or unregister it.
    // No other actions are possible
    footballMatch.GoalScored += (scorer, team1Score, team2Score) =>
    {
        Console.WriteLine($"{scorer} scored. Current score is {team1Score}:{team2Score}.");
    };

    footballMatch.IncreaseTeam1Score();
    footballMatch.IncreaseTeam1Score();
 */
public class FootballMatch {
    // We still need a delegate
    public delegate void GoalScoredHandler(string scoringTeam, int team1score, int team2score);

    // We decorate the delegate variable with the event keyword
    public event GoalScoredHandler GoalScored;

    public string Team1 { get; private set; }
    public string Team2 { get; private set; }

    public int Team1Score { get; private set; }
    public int Team2Score { get; private set; }

    public FootballMatch(string team1, string team2) {
        Team1 = team1;
        Team2 = team2;
    }

    public void IncreaseTeam1Score() {
        Team1Score++;

        // Inside the class that declared the event,
        // we have access to all public members of the delegate
        GoalScored?.Invoke(Team1, Team1Score, Team2Score);
    }

    public void IncreaseTeam2Score() {
        Team2Score++;
        GoalScored?.Invoke(Team2, Team1Score, Team2Score);
    }
}
