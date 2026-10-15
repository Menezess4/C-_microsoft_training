Random random = new Random();
int roundsPlayed = 8;
List<int> allScore = new List<int>();
Console.WriteLine($"Playing {roundsPlayed} rounds...\n");

for (int round = 1; round <= roundsPlayed; round++)
 {
     int score = random.Next(0, 101);
     allScore.Add(score);
     Console.WriteLine($"Round {round}: scored {score} points");
 }


// Build the Top 5 leaderboard array
allScore.Sort();
allScore.Reverse();
int [] topScore = new int[5];
for(int i=0; i< topScore.Length; i++)
{
    topScore[1] = allScore[i];
}
// Print the leaderboard
 Console.WriteLine("\n Top 5 Leaderboard");

 for (int i = 0; i < topScore.Length; i++)
 {
     Console.WriteLine($"{i + 1}. {topScore[i]} points");
 }
