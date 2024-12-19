
//Namespace above

//Main Class
internal class Program

{   //Entry Point Method
    private static void Main(string[] args)
    {
        string name = "Fiona L";
        int age = 35;

        // START HERE //
        // Console.WriteLine(name + " is " + age);
        // Console.WriteLine("{0} is {1}", name,age);

        // SET UP VARS / HEADER
        string appName = "Number Guesser";
        string appVersion = "1.0.0 ";
        string appAuthor = "Fiona L";

        // Change text colour
        Console.ForegroundColor = ConsoleColor.Green;

        // Write out app info
        Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

        // Reset text colour
        Console.ResetColor();

        // Ask user's name
        Console.WriteLine("What is your name?");

        // Get user input
        string inputName = Console.ReadLine();

        Console.WriteLine("Hello {0}, let's play a game", inputName);

        while (true) {

        // Set correct number
        // int corrrectNumber = 7;

        // Create a new Random object
        Random random = new Random();

        // Set as random number
        int corrrectNumber = random.Next(1, 10);


        // Init guess var
        int guess = 0;

        // Ask user for number 
        Console.WriteLine("Guess a number between 1 and 10");

        // While guess is not correct
        while (guess != corrrectNumber)
        {
            // Get users input
            string input = Console.ReadLine();

            // Make sure it's a number
            if (!int.TryParse(input, out guess))
            {
                // Change text colour
                Console.ForegroundColor = ConsoleColor.Red;

                // Tell user it's not a number
                Console.WriteLine("Please enter an actual number");

                // Reset text colour
                Console.ResetColor();

                //Keep going
                continue;

            }
            // Cast to int and put in guess
            guess = Int32.Parse(input);

            // Match guess to correct number
            if (guess != corrrectNumber)
            {


                // Change text colour
                Console.ForegroundColor = ConsoleColor.Red;

                // Tell user it's the wrong number
                Console.WriteLine("Wrong number, please try again");

                // Reset text colour
                Console.ResetColor();


            }
        }
        // Change text colour
        Console.ForegroundColor = ConsoleColor.Yellow;

        // Tell user it's the right number
        Console.WriteLine("You are CORRECT !!!!");

        // Reset text colour
        Console.ResetColor();
        }

    }
}