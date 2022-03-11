using System;

namespace IntroductionToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faith");
            //integer - int - whole numbers e.g 1, 2, 3, 4, 5, 10000 2X10-8 

            //double 2.34, 5.9872
            //long - 239463653535
            //decimal - 2345.374676, 
            //char - 'C', 'a', 'g', 'K'
            //string => words 

            int myAge = 25;
            string myName = "Bucky";
            int x = 1;
            double y = 2.56D;
            decimal priceOfPetrol = 150.34M;

            //Console.WriteLine("My Age is: "+ myAge); //My Age is 25
            //Console.WriteLine("My Name is: "+ myName);
            //char firstLetter = 't';
            //Console.WriteLine("The First letter is " + firstLetter);
            //Console.Write(myName);
            //Console.Write(myAge);

            ////type casting 
            ////string stringMyAge = (string) myAge;
            //int value = 255;
            //long valueToLong = value;
            //double valueToDouble = value;
            //Console.WriteLine("Value (255) converted to Long => " + valueToLong);
            //Console.WriteLine("Value (255) converted to Double => " + valueToDouble);

            //double myWeightInKg = 57.89;
            //int weightToInteger = (int)myWeightInKg; //57
            //Console.WriteLine("Weight 57.89 converted to Integer = " + weightToInteger);
            //long weightToLong = (long)myWeightInKg;
            //Console.WriteLine(weightToLong);

            //int newWeight = Convert.ToInt32(myWeightInKg);
            //Console.WriteLine("New Weight converted using System.Convert = " + newWeight);
            //string weightString = Convert.ToString(myWeightInKg);

            //string course = "C# for \tbeginners "; // \t \r
            ////Console.WriteLine(course);
            ////Console.WriteLine(course + " part 1");
            //string name = "Vivek";
            //string greeting = "Hello " + name;
            ////Console.WriteLine(greeting);

            ////Console.WriteLine("Hello " + name + ". Welcome to the C# for beginners course");
            ////Console.WriteLine($"Hello {name}. Welcome to the C# for beginners course");
            ////Console.WriteLine(string.Format("Hello {0}. You are {1} years old.", name, myAge));
            ////Console.WriteLine(name.Split());
            ////string sentence = "The Lazy Brown Fox Leaped Over the Frog";
            ////string wordSubstring = sentence.Substring(8);
            ////Console.WriteLine(wordSubstring);

            //int varX = 3;
            //int varY = 5;
            //int result = varX + varY;
            ////Arithmetic operators: +, -, *, / , 
            //Console.WriteLine($"Result of {varX} + {varY} = {result}");
            //Console.WriteLine($"Result of {varX} - {varY} = {varX - varY}");
            //Console.WriteLine($"Result of {varX} x {varY} = {varX * varY}");
            //Console.WriteLine($"Result of {varX} / {varY} = {varX / varY}");
            //Console.WriteLine($"Result of Modulo {varY} % {varX} = {varY % varX}");

            ////Parentheses Exponent Multiplication Division Addition Substraction 
            //int precedence = 5 - (2 + 2) * 3; //9
            //Console.WriteLine($"PRECENDENCE after FORCING => {precedence}");
            ////2 raise to the power of 4 = 16
            //int resultExponent = Convert.ToInt32( Math.Pow(2, 4));
            ////Console.WriteLine(resultExponent);
            //int negativeInteger = -289;
            //Console.WriteLine($"Absolute value of {negativeInteger} = {Math.Abs(negativeInteger)}");
            ////Math Functions
            ////PI, E, Sin, Cos, Tan, Floor, Ceiling, Sqrt, ASin, ACos, ATan, Min, Max, Pow, Abs, 
            //Console.WriteLine("PI value from the Math class = {0}", Math.PI);
            //Console.WriteLine("EXP value from the Math class = {0}", Math.E);
            //double angle = 30;
            //Console.WriteLine("Sin {0} = {1}", angle, Math.Sin(angle));
            //Console.WriteLine("Cos {0} = {1}", angle, Math.Cos(angle));
            //Console.WriteLine("Tan {0} = {1}", angle, Math.Tan(angle));
            //double weight = 250.678;
            //Console.WriteLine("Floor of {0} = {1}", weight, Math.Floor(weight));
            //Console.WriteLine("Ceil of {0} = {1}", weight, Math.Ceiling(weight));
            //Console.WriteLine("Square root of {0} = {1}", angle, Math.Sqrt(angle));
            //int a = 56;
            //int b = 78;
            //Console.WriteLine("Minimum Value between {0} and {1} = {2}", a, b, Math.Min(a, b));
            //Console.WriteLine("Maximum Value between {0} and {1} = {2}", a, b, Math.Max(a, b));

            int applicantAge = 17;
            //if else 
            // x>y X<Y, >= <= == , logical !=
            if(applicantAge >= 18)
            {
                Console.WriteLine("Yes! You can apply for a driver's license");
            }else if(applicantAge == 17)
            {
                Console.WriteLine("Oh You're 17, Nice. you're almost there... Just 1 year to go");
            }
            else
            {
                Console.WriteLine("Oops! Sorry you're not yet of age. You can only apply when you're 18 and above");
            }
            
            if(x != y)
            {
                Console.WriteLine("X ({0}) is not equal to Y ({1})", x, y);
            }
            else
            {
                Console.WriteLine("X ({0}) is equal to Y ({1})", x,y);
            }

            //logical operators, &&, || 
            int ageOfPerson = 35;
            bool isGraduatedFromHighSchool = false;

            //if(ageOfPerson >= 18 || isGraduatedFromHighSchool)
            //{
            //    Console.WriteLine("Oh! You are 18+ and have graduated from High school. You may apply to college");

            //}
            //else
            //{
            //    Console.WriteLine("Please wait till you're 18 and above");
            //}

            //switch (ageOfPerson)
            //{
            //    case 18:
            //        Console.WriteLine("Oh! You are 18+ and have graduated from High school. You may apply to college");
            //        break;
            //    case 16:
            //        Console.WriteLine("You're 16");
            //        break;
            //    case 15:
            //        Console.WriteLine("You're 15");
            //        break;

            //    default:
            //        Console.WriteLine("You're none of the set ages");
            //        break;

            //}

            //Console.WriteLine("Please enter your Name:");
            //string userName = Console.ReadLine();
            ////int age = Convert.ToInt32(Console.ReadLine()); //System.FormatException...
            //Console.WriteLine("Your name is: {0}", userName);
            //char c = Convert.ToChar(Console.Read());
            //Console.WriteLine("The Character you entered was {0}", c);

            //Receive user input

            //Multiply by 256

            //Output to the console...

            /**
             * The askldlasd 
             * This is another line
             * 
             * And another line of comments...
             * 
             */

            ///acccept user input for a weight in KG
            ///Convert to Pound (LB)..
            ///Print Pound value to console...
            //1KG = 2.205Pound....
            const double KG_TO_POUND_VALUE = 2.205;

            //Console.WriteLine("Please enter your weight in KG e.g 56.7: ");
            //double weightInKg = Convert.ToDouble(Console.ReadLine());
            //Console.WrighteLine("Your Weight {0}Kg convert to LB = {1} lbs", weightInKg, weightInKg * KG_TO_POUND_VALUE);

            //Console.WriteLine("Please enter your weight in Pounds (lbs): ");
            //double weightInLbs = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Your Weight {0} LBS converted to KG = {1} KG", weightInLbs, (weightInLbs / KG_TO_POUND_VALUE));

            Console.WriteLine("Please enter your weight in KG: ");
            double weightInKg = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height in metres: ");
            double heightInMetres = Convert.ToDouble(Console.ReadLine());

            //BMI = Weight(Kg) / (Height(M)**2)
            double bodyMassIndex = (weightInKg / (Math.Pow(heightInMetres, 2)));
            Console.WriteLine($"With Weight of {weightInKg}KG and a height of {heightInMetres} metres, your BODY MASS INDEX is: {bodyMassIndex}");







        }
    }
}
