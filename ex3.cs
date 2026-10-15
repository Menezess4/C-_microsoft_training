Random random = new Random();
int secretnumeber = random.Next(1, 21);
int maxguesses = 5;
int guesscount = 0;
bool won = false;
// Ask the player to guess
while (guesscount < maxguesses){
    guesscount ++;
    int guess = Convert.ToInt32(Console.ReadLine());
    // Check the guess and give feedback
    if (guess == secretnumeber){
        won = true;
        Console.WriteLine($"You chosse the right number, if  {guesscount} guesses ");
        break;       
}
    else if(guess != secretnumeber){
        Console.WriteLine("Miss");
        
    }
}
// Announce the result
if (won == true)
{
    Console.WriteLine("You won");
}
