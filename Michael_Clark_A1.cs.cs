using System;

namespace Rock_Paper_Scissors_Game
{
    internal class Rock_Paper_Scissors_Game
    {
        static void Main(string[] args)
        {
           
            int playerCount = 0;
            int computerCount = 0;
            int rounds = 3;
            Console.WriteLine
                ("We are going to play Rock Paper Scissors. I refuse to belive that you don't know how to play. \n");

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            Random rnd = new Random();

            for (int i = 0; i < rounds; i++)
            { 
                Console.WriteLine("\nRound " + (i + 1));

                Console.WriteLine
                       ("Select your play:\n1->ROCK\n2->PAPER\n3->SCISSOR");

                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };

                int n = rnd.Next(0, 3);

                Console.WriteLine
                    ("Enter your choice: \n");

                string user = Console.ReadLine().ToUpper();


                while (true)
                {

                    

                    if (user == "ROCK" && choices[n] == "SCISSOR")
                    {
                        Console.WriteLine(name + ":" + user + " Computer:" + choices[n]);
                        Console.WriteLine("User wins \n");
                        playerCount += 1;
                        Console.WriteLine(name + " score is " + playerCount + ", Computer score is " + computerCount + "\n");
                        break;
                    }

                    else if (user == "ROCK" && choices[n] == "PAPER")
                    {
                        Console.WriteLine(name + ":" + user + " Computer:" + choices[n]);
                        Console.WriteLine("Computer wins \n");
                        computerCount += 1;
                        Console.WriteLine(name + " score is " + playerCount + ", Computer score is " + computerCount + "\n");
                        break;
                    }

                    else if (user == "PAPER" && choices[n] == "ROCK")
                    {
                        Console.WriteLine(name + ":" + user + " Computer:" + choices[n]);
                        Console.WriteLine("User wins \n");
                        playerCount += 1;
                        Console.WriteLine(name + " score is " + playerCount + ", Computer score is " + computerCount + "\n");
                        break;
                    }

                    else if (user == "PAPER" && choices[n] == "SCISSOR")
                    {
                        Console.WriteLine(name + ":" + user + " Computer:" + choices[n]);
                        Console.WriteLine("Computer Wins \n");
                        computerCount += 1;
                        Console.WriteLine(name + " score is " + playerCount + ", Computer score is " + computerCount + "\n");
                        break;
                    }

                    else if (user == "SCISSOR" && choices[n] == "ROCK")
                    {
                        Console.WriteLine(name + ":" + user + " Computer:" + choices[n]);
                        Console.WriteLine("Computer Wins \n");
                        computerCount += 1;
                        Console.WriteLine(name + " score is " + playerCount + ", Computer score is " + computerCount + "\n");
                        break;
                    }

                    else if (user == "SCISSOR" && choices[n] == "PAPER")
                    {
                        Console.WriteLine(name + ":" + user + " Computer:" + choices[n]);
                        Console.WriteLine("User wins \n");
                        playerCount += 1;
                        Console.WriteLine(name + " score is " + playerCount + ", Computer score is " + computerCount + "\n");
                        break;
                    }

                    else if (user == "SCISSOR" && choices[n] == "SCISSOR")
                    {
                        Console.WriteLine(name + ":" + user + " Computer:" + choices[n]);
                        Console.WriteLine("Tie\n");
                        Console.WriteLine(name + " score is " + playerCount + ", Computer score is " + computerCount + "\n");
                        break;
                    }

                    else if (user == "PAPER" && choices[n] == "PAPER")
                    {
                        Console.WriteLine(name + ":" + user + " Computer:" + choices[n]);
                        Console.WriteLine("Tie\n");
                        Console.WriteLine(name + " score is " + playerCount + ", Computer score is " + computerCount + "\n");
                        break;
                    }

                    else if (user == "ROCK" && choices[n] == "ROCK")
                    {
                        Console.WriteLine(name + ":" + user + " Computer:" + choices[n]);
                        Console.WriteLine("Tie\n");
                        Console.WriteLine(name + " score is " + playerCount + ", Computer score is " + computerCount + "\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        break;
                    }

                }
            }   

            Console.WriteLine(name + " won " + playerCount + " times \n");
            Console.WriteLine("Computer won " + computerCount + " times \n");
            if(playerCount < computerCount)
            {
                Console.WriteLine("Don't Worry. It's Common to lose to a computer.");
            }
            else if (playerCount == computerCount)
            {
                Console.WriteLine("Keep trying. You're getting better.");
            }
            else
            {
                Console.WriteLine("Great Job! You win!");
            }
        }
    }
}