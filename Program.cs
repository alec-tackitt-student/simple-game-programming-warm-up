
class program{

    
    
    public static void Main(string[] args){
        System.Console.WriteLine("Dice game");
        System.Console.WriteLine("");
        System.Console.WriteLine("In this game you and a computer Rival will play 10 rounds");
        System.Console.WriteLine("where you will each roll a 6-sided dice, and the player ");
        System.Console.WriteLine("with the highest dice value will win the round. The player ");
        System.Console.WriteLine("who wins the most rounds wins the game. Good luck!");   
        System.Console.WriteLine("");    
        System.Console.WriteLine("Press any key to start. . .");
        Console.ReadKey();
        Game();
        System.Console.WriteLine("press any key to exit");
        Console.ReadKey();
        

    }

    public static void Game(){
        Random rnd = new Random();
        int roundNumber = 1;
        int yourScore = 0;
        int rivalScore = 0;
        while (roundNumber <= 10) {
            int rivalNum = rnd.Next(1,6);
            int yourNum = rnd.Next(1,6);
            System.Console.WriteLine($"round {roundNumber}");
            System.Console.WriteLine($"Rival rolled a {rivalNum}");
            System.Console.WriteLine("press any key to roll the dice. . .");
            Console.ReadKey();
            System.Console.WriteLine($"you rolled a {yourNum}");
            if (rivalNum > yourNum){
                System.Console.WriteLine("the rival won this round!");
                rivalScore++;
                System.Console.WriteLine($"the score is now - You : {yourScore}. Rival : {rivalScore}.");
            }
            else if (rivalNum < yourNum){
                System.Console.WriteLine("you won this round!");
                yourScore++;
                System.Console.WriteLine($"the score is now - You : {yourScore}. Rival : {rivalScore}.");
            }
            else {
                System.Console.WriteLine("this round is a draw!");
                System.Console.WriteLine($"the score is now - You : {yourScore}. Rival : {rivalScore}.");
            }
            System.Console.WriteLine("press any key to continue. . .");
            Console.ReadKey();
            roundNumber++;
            System.Console.WriteLine("");
        }

        System.Console.WriteLine("Game over.");
        System.Console.WriteLine($"The score is now - You : {yourScore}. Rival : {rivalScore}");
        if (yourScore > rivalScore){
            System.Console.WriteLine("You won!");
        }
        else if (yourScore < rivalScore) {
            System.Console.WriteLine("Rival won!");
        }
        else{
            System.Console.WriteLine("It was a tie!");
        }
    }
}