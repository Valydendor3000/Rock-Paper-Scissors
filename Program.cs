namespace RockPaperScissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            // Set score to 0
            int score = 0;


            // Specify the number of rounds we will play
            int rounds = 3;

            Console.WriteLine("Time for Rock Paper Scissors \nThere are going to be " + rounds + " rounds and you have to win 2 of them.\n" +
                "I refuse to believe that you don't know how to play Rock Paper Scissors. \n" +
                "Input your choice when prompted and hope that you chose the option that beats the computers.\n" +
                "Pkease enter your name. \n");


            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            // Prepare to generate random numbers 
            Random random = new Random();

            // Loop until the rounds are over
            for (int i = 0; i < rounds; i++)


            // Display round number
                Console.WriteLine("\nRound " + (i + 1));

            // Generate a random integer
            int number = random.Next(0, 200);

            string play = "";

            while (true)
            {
                Console.WriteLine("Please enter your guess: e for even, o for odd");
                // Read player input
                play = Console.ReadLine();

                if (play == "Rock") || (play == "Paper") || (play == "Scissors"))
                {
                    // If the player enters either e or o, get out of the loop
                    break;
                }

                // If the player input is not e or o, go to the top of the loop and ask again.
                // We need to handle player errors. 
            }






















        }
    }
}