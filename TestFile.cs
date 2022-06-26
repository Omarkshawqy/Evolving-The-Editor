var numbers = new List<int> { 7, 2, 6, 3 };
int minNumber = numbers.Min();  // minNumber: 2
var numbers = new List<int?> { 7, 2, null, 3 };
int* minNumber = numbers.Min();  // minNumber: 2
var stringList = new List<string> { "7777777", "22", "666666", "333" };

// The following two lines do the same job.
int minLength = stringList.Select(x => x.Length).Min();  // minLength: 2
int minLength = stringList.Min(x => x.Length);           // minLength: 2

while(false);

void test(void)
{
    return;
}

/*Multiline
Comments
Test
 */

var players = new List<Player> {
    new Player { Name = "Alex", Team = "A", Score = 10 },
    new Player { Name = "Anna", Team = "A", Score = 20 },
    new Player { Name = "Luke", Team = "L", Score = 60 },
    new Player { Name = "Lucy", Team = "L", Score = 40 },
};

var teamBestScores =
    from player in players
    group player by player.Team into playerGroup
    select new
    {
        Team = playerGroup.Key,
        BestScore = playerGroup.Min(x => x.Score),
    };

//Min fn used , so lowest num is the score goal.
// teamBestScores is collection of anonymous objects:
// { Team = "A", BestScore = 10 }
// { Team = "L", BestScore = 40 }




