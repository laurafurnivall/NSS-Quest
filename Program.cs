using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20
            );

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            // Make a new "Adventurer" object using the "Adventurer" class
            Console.Write("What's you're name adventurer? ");
            string adventurerName = Console.ReadLine();
            Console.Write("What is your robe color? ");
            string robeColorAnswer = Console.ReadLine();
            Console.Write("What is your robe length in feet? ");
            string robeLengthAnswer = Console.ReadLine();
            Robe theRobe = new Robe()
            {
                Colors = robeColorAnswer,
                Length = int.Parse(robeLengthAnswer)
            };
            Console.Write("On a scale of 1-10, how shiny is your hat? ");
            string hatAnswer = Console.ReadLine();
            Hat theHat = new Hat()
            {
                ShininessLevel = int.Parse(hatAnswer)
            };

            Adventurer theAdventurer = new Adventurer($"{adventurerName}", theRobe, theHat);
            theAdventurer.GetDescription();
            Console.WriteLine(theAdventurer.Shine.ShininessDescription());

            // A list of challenges for the Adventurer to complete
            // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle
            };

            // Loop through all the challenges and subject the Adventurer to them
            foreach (Challenge challenge in challenges)
            {
                challenge.RunChallenge(theAdventurer);

            }

            // This code examines how Awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }
            RunAgain(args);
        }

        public static void RunAgain(string[] args)
        {
            Console.WriteLine("Do you want to play again?\n\t1)Yes\n\t2)No");
            string playAgain = Console.ReadLine();
            int play = int.Parse(playAgain);

            switch (play)
            {
                case 1:
                    Main(args);
                    break;
                case 2:
                    break;
            }
        }
    }
}