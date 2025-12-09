using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpDataStrucsAlgos.EventHandler;

// We created a separate class
// that will hold data to be passed
// to subscribers
public class GoalScoredArgs {
    public string Scorer { get; set; }
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }

    public GoalScoredArgs(string scorer, int team1Score, int team2Score) {
        Scorer = scorer;
        Team1Score = team1Score;
        Team2Score = team2Score;
    }
}

public class FootballMatch(string team1, string team2) {
    // We are now using the built-in EventHandler delegate 
    public event EventHandler<GoalScoredArgs> GoalScored;

    public string Team1 { get; private set; } = team1;
    public string Team2 { get; private set; } = team2;

    public int Team1Score { get; private set; }
    public int Team2Score { get; private set; }

    public void IncreaseTeam1Score() {
        Team1Score++;
        // this --> because the event occurred in this class
        GoalScored?.Invoke(this, new GoalScoredArgs(Team1, Team1Score, Team2Score));
    }

    public void IncreaseTeam2Score() {
        Team2Score++;
        GoalScored?.Invoke(this, new GoalScoredArgs(Team2, Team1Score, Team2Score));
    }
}

/*
    var footballMatch = new FootballMatch("Barcelona", "Real Madrid");

    footballMatch.GoalScored += (sender, eventArgs) =>
    {
        Console.WriteLine($"{eventArgs.Scorer} scored!");
        Console.WriteLine($"Score is {eventArgs.Team1Score}:{eventArgs.Team2Score}.");
    };

    footballMatch.IncreaseTeam1Score();
    footballMatch.IncreaseTeam2Score();
*/
