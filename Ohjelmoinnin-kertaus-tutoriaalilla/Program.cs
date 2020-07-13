using System;
using System.Dynamic;
using System.Text;
using System.Collections;
using System.Globalization;

namespace Ohjelmoinnin_kertaus_tutoriaalilla
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1 DATA TYPES AND VARIABLES, part 1
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            */

            ///////////////////////////////


            //1.2 DATA TYPES AND VARIABLES, part 2
            /*
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");

            string myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");

            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            */

            ///////////////////////////////

            //2.1 THE IF DECISION STATEMENT, part 1
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a new car!";

            else if(userValue == "2")
                message = "You won a new boat!";

            else if(userValue == "3")
                message = "You won a new trailer!";

            else
            {
                message = "Sorry, we didn't understand. ";
                message += "You lose!";
            }

            Console.WriteLine(message);
            */

            ///////////////////////////////

            //2.2 THE IF DECISION STATEMENT, part 2
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");

            Console.WriteLine("You entered {0}, therefore you won a {1}.", userValue, message);
            */

            ///////////////////////////////

            //3 FOR ITERATION
            /*
            for(int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
                if(i == 7)
                {
                    Console.WriteLine("Found seven");
                    break;
                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            Console.ReadLine();
            */

            ///////////////////////////////

            //4.1 ARRAYS, part 1
            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            //Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            */

            ///////////////////////////////

            //4.2 ARRAYS, part 2
            /*
            int[] numbers = new int[] { 4, 7, 12, 28, 33, 45 };

            string[] names = new string[] { "Mark", "Anthony", "Elisabeth", "Alexandra", "Kevin" };

            for (int nu = 0; nu < numbers.Length; nu++)
            {
                Console.WriteLine(numbers[nu]);
            }

            Console.WriteLine();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            string quote = "This is what you want, this is what you get.";

            char[] splitQuote = quote.ToCharArray();
            Array.Reverse(splitQuote);

            foreach (var quoteChar in splitQuote)
            {
                Console.Write(quoteChar);
            }

            Console.ReadLine();
            */

            ///////////////////////////////

            //5.1 METHODS, part 1
            /*
            HelloWorld();
            Console.ReadLine();
            */

            ///////////////////////////////

            //5.2 METHODS, part 2
            /*
            Console.WriteLine("The Name Game");

            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            DisplayResult(
                ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city)
                );

            Console.WriteLine();

            DisplayResult(
                ReverseString(firstName) + " " +
                ReverseString(lastName) + " " +
                ReverseString(city)
                );
            
            Console.ReadLine();
            */

            ///////////////////////////////

            //6 WHILE ITERATION STATEMENT
            /*
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            */

            ///////////////////////////////

            //7 WORKING WITH STRINGS
            /*
            //string myString = "My \"so-called\" life";

            //string myString = "What if I need a\nnew line?";
            //string myString = "Go to your c:\\drive";
            //string myString = @"Go to your c:\drive";

            //string myString = String.Format("{1} = {0}", "First", "Second");

            //string myString = String.Format("{0:c}", 123.45);

            //string myString = String.Format("{0:n}", 19578720455);

            //string myString = String.Format("Percentage: {0:P}", .123);

            //string myString = String.Format("Phone Number: {0:(###) ###-####}", 3154687543);

            //
            //
            // Sub-case 1 starts
            //string myString = "  Hello everybody, it's really me   ";

            //myString = myString.Substring(5,13);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(5, 13);
            //myString = myString.Trim();

            //myString = String.Format("Length before: {0} -- Length after {1}",
            //    myString.Length, myString.Trim().Length);

            //Sub-case 1 ends
            //
            //

            //
            //
            //Sub-case 2 starts
            //string myString = "";

            //for(int i = 0; i < 100; i++)
            //{
            //    myString += "--" + i.ToString();
            //}

            //Console.WriteLine(myString);
            //Sub-case 2 ends
            //
            //

            StringBuilder myString = new StringBuilder();

            for (int o = 0; o < 100; o++)
            {
                myString.Append("--");
                myString.Append(o);
            }

            Console.WriteLine(myString);
            */

            ///////////////////////////////

            //8 WORKING WITH DATES AND TIMES
            /*
            DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(547).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(7).ToString());
            //Console.WriteLine(myValue.AddDays(-17).ToLongDateString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1985, 07, 31);
            DateTime myBirthday = DateTime.Parse("31/7/1985");
            Console.WriteLine(myBirthday.ToLongDateString());

            //DateTime myBirthday = DateTime.Parse("31/7/1985");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            */

            ///////////////////////////////

            //9 UNDERSTANDING CLASSES

            // Sub-case 1 starts

            Car myCar = new Car();
            //myCar.Make = "Oldsmobile";
            //myCar.Model = "Cutlas Supreme";
            //myCar.Year = 1986;
            //myCar.Color = "Silver";

            //Console.WriteLine("{0} | {1} | {2} | {3}",
            //    myCar.Make, myCar.Model,
            //    myCar.Year, myCar.Color);

            //decimal value = DetermineMarketValue(myCar);
            //Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
            //Console.WriteLine("{0:C}", value);

            //Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            // Sub-case 1 ends

            ///

            // Sub-case 2 starts

            Car myOtherCar;
            myOtherCar = myCar;

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Console.WriteLine("{0}, {1}, {2}, {3}",
                myOtherCar.Make, myOtherCar.Model,
                myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0}, {1}, {2}, {3}",
               myCar.Make, myCar.Model,
               myCar.Year, myCar.Color);

            myOtherCar = null;

            //Console.WriteLine("{0}, {1}, {2}, {3}",
            //    myOtherCar.Make, myOtherCar.Model,
            //    myOtherCar.Year, myOtherCar.Color);

            myCar = null;

            // Sub-case 2 ends
        }

        ////// METHODS //////

        // 9 UNDERSTANDING CLASSES
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.00M;
            return carValue;
        }

        //6 WHILE ITERATION STATEMENT methods
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }

            else if (result == "2")
            {
                GuessingGame();
                return true;
            }

            else if (result == "3")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers!");

            Console.Write("Type a number: ");
            int usersChoice = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter < usersChoice + 1)
            {
                Console.Write(counter);
                Console.Write(".");
                counter++;
            }

            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;

            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();

                guesses++;

                if (result == randomNumber.ToString())
                    incorrect = false;

                else
                    Console.WriteLine("Wrong, guess again.");

            } while (incorrect);

            Console.WriteLine("You guessed right! It took you {0} guesses", guesses);

            Console.ReadLine();
        }

        //5.2 METHODS, part 2
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(
            string reversedFirstName,
            string reversedLastName,
            string reversedCity)
        {
            Console.Write("Results: ");

            Console.Write(
                String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");

            Console.Write(message);
        }

        //5.1 METHODS, part 1
        private static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
    }

    ////// CLASSES //////

    //9 UNDERSTANDING CLASSES

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;

            else
                carValue = 2000;

            return carValue;
        }
    }
}
