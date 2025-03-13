namespace CSharpCourseExplainationExamples
{
    internal class Program
    {
        // single line comment

        /*
         this is 
         multiline comment 
         */

        /// <summary>
        /// This method prints a greeting message.
        /// </summary> 
        static void Main(string[] args)
        {

            //float StudentMark;

            //Console.WriteLine(" Enter your mark ");
            //StudentMark = float.Parse(Console.ReadLine());

            //Console.WriteLine("Your mark is " + StudentMark + "degrees");

            ////---------------------------------------------

            //float Angle;
            //Console.WriteLine(" Enter the angle ");
            //Angle = float.Parse(Console.ReadLine());

            //double result;
            //result = Math.Cos(Angle);
            //Console.WriteLine("Cos of input = " + result);
            //---------------------------------------------------------------------------
            //int num1, num2;

            //Console.WriteLine(" Enter first number ");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine(" Enter second number ");
            //num2 = int.Parse(Console.ReadLine());

            //int result = num1 + num2;
            //Console.WriteLine(result);
            //---------------------------------------------

            float StudentMark;

            Console.WriteLine("\nEnter your degree \n");
            StudentMark = float.Parse(Console.ReadLine());


            if (StudentMark >= 50)
            {
                Console.WriteLine("You passed");
            }
            else
            {
                Console.WriteLine("You failed");

            }

            //-------------------------------Part1 Solving
            ////postfix and prefix
            //int x , k;
            //x = k = 6;          

            //int y = x++; //postfix
            //int z = ++k; //prefix

            //Console.WriteLine(y + "  " + z); //y=6 , z=7

            ////Even or Odd
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //    Console.WriteLine("The number is Even.");
            //else
            //    Console.WriteLine("The number is Odd.");


            //Console.WriteLine("-------------------------------------------------");
            ////-------------------------------------------------------


            //////Largest of Three Numbers
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter third number: ");
            //int num3 = int.Parse(Console.ReadLine());

            //int largest = num1;

            //if(largest > num2)
            //{
            //    if (largest > num3)
            //        Console.WriteLine("The largest number is:"+largest);
            //}
            //else 
            //{
            //    largest = num2;

            //    if (largest > num3)
            //        Console.WriteLine("The largest number is:" + largest);
            //    else
            //        Console.WriteLine("The largest number is:" + num3);

            //}

            //Console.WriteLine("-------------------------------------------------");

            //////-----------------------------------------------------------

            //////Temperature Converter
            //Console.Write("Enter temperature in Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());

            //double fahrenheit = (celsius * 9 / 5) + 32;

            //Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            //Console.WriteLine("-------------------------------------------------");

            //////----------------------------------------------------------

            //////Simple Discount Calculator
            //Console.Write("Enter the price of the item: ");
            //double price = double.Parse(Console.ReadLine());
            //double discount = 0;

            //double finalPrice;

            //if(price >100)
            //{
            //    discount = (price / 100) * 10;
            //    finalPrice = price - discount;
            //    Console.WriteLine("Final price is:" + finalPrice);

            //}
            //else 
            //{
            //    Console.WriteLine("Final price is:" + price);

            //}

            //Console.WriteLine("-------------------------------------------------");

            //////-------------------------------------------------------------

            //////Grading System
            //Console.Write("Enter student score: ");
            //int score = int.Parse(Console.ReadLine());
            //char grade;

            //if (score >= 90)
            // grade = 'A';            
            //else if (score >= 80)
            //    grade = 'B';
            //else if (score >= 70)
            //    grade = 'C';
            //else if (score >= 60)
            //    grade = 'D';
            //else
            //    grade = 'F';






            //Console.WriteLine("The student's grade is: " + grade);
            //Console.WriteLine("-------------------------------------------------");

            //////-------------------------------------------------------

            //////Swap Two Numbers
            //Console.Write("Enter first number: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int b = int.Parse(Console.ReadLine());

            //int c;

            //c = a;
            //a = b;
            //b = c;

            //Console.WriteLine("After swapping: First Number = " + a + ", Second Number = " + b);
            //Console.WriteLine("-------------------------------------------------");


            //////------------------------------------------------------------

            //////Days to Weeks and Days Converter
            //Console.Write("Enter number of days: ");
            //int days = int.Parse(Console.ReadLine());

            //int weeks = days / 7;
            //int remainingDays = days % 7;

            //Console.WriteLine( days + " days = " + weeks + " week(s) and " + remainingDays + " day(s)");
            //Console.WriteLine("-------------------------------------------------");

            //////-----------------------------------------------------------

            //////Simple Calculator
            //Console.Write("Enter first number: ");
            //double FirstNumber = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //Console.Write("Enter second number: ");
            //double SecondNumber = double.Parse(Console.ReadLine());

            //double result = 0;

            //if (op == '+')
            //    result = FirstNumber + SecondNumber;
            //else if (op == '-')
            //    result = FirstNumber - SecondNumber;
            //else if (op == '*')
            //    result = FirstNumber * SecondNumber;
            //else if (op == '/')
            //{
            //    if (SecondNumber != 0)
            //        result = FirstNumber / SecondNumber;
            //    else
            //    {
            //        Console.WriteLine("Cannot divide by zero!");
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator!");
            //    return;
            //}

            //Console.WriteLine("Result: " + result );
            //Console.WriteLine("-------------------------------------------------");

            ////-----------------------------------------------

            //Console.WriteLine("Enter your grade :");
            //char Grade = Console.ReadKey().KeyChar;


            //if (Grade == 'A')
            //    Console.WriteLine("Excellent");
            //else if(Grade == 'B')
            //    Console.WriteLine("Good");
            //else if(Grade == 'C')
            //    Console.WriteLine("avg");
            //else
            //    Console.WriteLine("fail");


            //switch(grade)
            //{

            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;

            //    case 'B':
            //        Console.WriteLine("good");
            //        break;

            //    case 'C':
            //        Console.WriteLine("avg");
            //        break;

            //    default:
            //        Console.WriteLine("fail");
            //        break;

            //}

            //--------------------------------------------------


            Console.WriteLine("enter a number ");
            int n = int.Parse(Console.ReadLine());

            int counter;

            for (counter = 0; counter <= n; counter++)
            {
                Console.WriteLine("Karim");

            }


            //int num = 20;

            //while(num != 20)
            //{
            //    Console.WriteLine("guess a number again");
            //    num = int.Parse(Console.ReadLine());
            //}

            int num = 0;

            do
            {
                Console.WriteLine("guess a number ");
                num = int.Parse(Console.ReadLine());
            }
            while (num != 20);

            //-----------------Logic operators
            int x, y;
            x = y = 5;
           
            bool isThursday, morning;
            isThursday = true;
            morning = true;


            if(    isThursday &&  (x>y)  && morning      )
            {
                Console.WriteLine("");

            }


            if (isThursday || (x > y) || morning)
            {
                Console.WriteLine("");

            }
            //--------------------------Explain examples on switch and looping

        }





    }

}
