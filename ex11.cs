int monstro = 10;
int humano = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monstro -= roll;
    Console.WriteLine($"Monstro perdeu {roll} de vida e agora tem {monstro} de vida");

    if(monstro <= 0) continue;
    roll = dice.Next(1,11);
    humano -= roll;
    Console.WriteLine($"humano tem {humano} de vida e tomou {roll} de dano");
    
}

while (humano > 0 && monstro > 0 );

Console.WriteLine(humano > monstro ?"Humano venceu" : "Monstro venceu");
