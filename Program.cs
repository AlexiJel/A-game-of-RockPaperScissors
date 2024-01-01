const string Rock = "Rock";
const string Scissors = "Scissors";
const string Paper = "Paper";

Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string playersMove = Console.ReadLine();

if (playersMove == "r")
{
    playersMove = Rock;
}
else if (playersMove == "p")
{
    playersMove = Paper;
}
else if (playersMove == "s")
{
    playersMove = Scissors;
}
else
{
    Console.WriteLine("Invalid input.Try again...");
    return;
}

Random random = new Random();
int randomComputerMove = random.Next(1, 4);
string computerMove = "";

switch (randomComputerMove)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}

Console.WriteLine($"The computer chose {computerMove}");

string outcome = "";

if (computerMove == Rock && playersMove == Scissors)
{
    outcome = "You lose";
}
else if (computerMove == Scissors && playersMove == Paper)
{
    outcome = "You lose";
}
else if (computerMove == Paper && playersMove == Rock)
{
    outcome = "You lose";
}
else if (computerMove == Rock && playersMove == Paper)
{
    outcome = "You win";
}
else if (computerMove == Paper && playersMove == Scissors)
{
    outcome = "You win";
}
else if (computerMove == Scissors && playersMove == Rock)
{
    outcome = "You win";
}
else 
{
    outcome = "This game was a draw";
}

Console.WriteLine(outcome);

