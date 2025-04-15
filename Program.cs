using System.Security.Cryptography;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        /// 

        public static int SumTwoNumbers(int x, int y)
        {

            return x + y;   
        
        }

        public static string GuessEvemnOrOdd(int number)
        {
            if (number % 2 == 0)
                return "Even";
            else
                return "Odd";
        }

        public static void printValue(string input)
        { 
            Console.WriteLine("the result of this operation is: " + input); 
        }



        public static void printValue(int input)
        {
            Console.WriteLine("the result of this operation is: " + input);
        }


        public static void ExitApp(ref bool flag)
        {
            flag = false;

        }

        static void Main(string[] args)
        {

            //List
            List<int> numbers = new List<int>();
            numbers.Clear();




            //welcome message --> function
            bool ProgramContinue = true;
            do
            {
                //showMenu --> 
                // int choice = showmneu();

                ExitApp(ref ProgramContinue);

            }
            while (ProgramContinue != false);

            //Thank you message --> function


            //escape characters
            Console.WriteLine("Welcome to program menu \n 1.Print your name \n 2.sum 2 numbers \n 3. Check Even or Odd ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter your name ");
                    string name = Console.ReadLine();
                    printValue(name);
                    break;

                case 2:
                    Console.WriteLine("Enter 2 numbers to sum ");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    int result = SumTwoNumbers(x,y);
                    printValue(result); // run method with int param
                    printValue(result.ToString()); // run method with string param

                    break;

                case 3:
                    Console.WriteLine("Enter number");
                    int input = int.Parse(Console.ReadLine());
                    string result2 = GuessEvemnOrOdd(input);
                    printValue(result2);

                    break;

                default:

                    break;


            }



            //test( "karim",25);

            //test2();

            //value type vs reference type assignment 
            //int a = 10;
            //int b = a;

            //string x = "karim";           
            //string y = x;

            //string z = System.String.Copy(x);

            //int[] k = { 1, 2, 3 };
            //int[] h = k;

            //int[] g = new int[3]; 
            //Array.Copy(k,g,3);






            ////float StudentMark;

            ////Console.WriteLine(" Enter your mark ");
            ////StudentMark = float.Parse(Console.ReadLine());

            ////Console.WriteLine("Your mark is " + StudentMark + "degrees");

            //////---------------------------------------------

            ////float Angle;
            ////Console.WriteLine(" Enter the angle ");
            ////Angle = float.Parse(Console.ReadLine());

            ////double result;
            ////result = Math.Cos(Angle);
            ////Console.WriteLine("Cos of input = " + result);
            ////---------------------------------------------------------------------------
            ////int num1, num2;

            ////Console.WriteLine(" Enter first number ");
            ////num1 = int.Parse(Console.ReadLine());

            ////Console.WriteLine(" Enter second number ");
            ////num2 = int.Parse(Console.ReadLine());

            ////int result = num1 + num2;
            ////Console.WriteLine(result);
            ////---------------------------------------------

            //float StudentMark;

            //Console.WriteLine("\nEnter your degree \n");
            //StudentMark = float.Parse(Console.ReadLine());


            //if (StudentMark >= 50)
            //{
            //    Console.WriteLine("You passed");
            //}
            //else
            //{
            //    Console.WriteLine("You failed");

            //}

            ////-------------------------------Part1 Solving
            //////postfix and prefix
            ////int x , k;
            ////x = k = 6;          

            ////int y = x++; //postfix
            ////int z = ++k; //prefix

            ////Console.WriteLine(y + "  " + z); //y=6 , z=7

            //////Even or Odd
            ////Console.Write("Enter a number: ");
            ////int num = int.Parse(Console.ReadLine());

            ////if (num % 2 == 0)
            ////    Console.WriteLine("The number is Even.");
            ////else
            ////    Console.WriteLine("The number is Odd.");


            ////Console.WriteLine("-------------------------------------------------");
            //////-------------------------------------------------------


            ////////Largest of Three Numbers
            ////Console.Write("Enter first number: ");
            ////int num1 = int.Parse(Console.ReadLine());

            ////Console.Write("Enter second number: ");
            ////int num2 = int.Parse(Console.ReadLine());

            ////Console.Write("Enter third number: ");
            ////int num3 = int.Parse(Console.ReadLine());

            ////int largest = num1;

            ////if(largest > num2)
            ////{
            ////    if (largest > num3)
            ////        Console.WriteLine("The largest number is:"+largest);
            ////}
            ////else 
            ////{
            ////    largest = num2;

            ////    if (largest > num3)
            ////        Console.WriteLine("The largest number is:" + largest);
            ////    else
            ////        Console.WriteLine("The largest number is:" + num3);

            ////}

            ////Console.WriteLine("-------------------------------------------------");

            ////////-----------------------------------------------------------

            ////////Temperature Converter
            ////Console.Write("Enter temperature in Celsius: ");
            ////double celsius = double.Parse(Console.ReadLine());

            ////double fahrenheit = (celsius * 9 / 5) + 32;

            ////Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            ////Console.WriteLine("-------------------------------------------------");

            ////////----------------------------------------------------------

            ////////Simple Discount Calculator
            ////Console.Write("Enter the price of the item: ");
            ////double price = double.Parse(Console.ReadLine());
            ////double discount = 0;

            ////double finalPrice;

            ////if(price >100)
            ////{
            ////    discount = (price / 100) * 10;
            ////    finalPrice = price - discount;
            ////    Console.WriteLine("Final price is:" + finalPrice);

            ////}
            ////else 
            ////{
            ////    Console.WriteLine("Final price is:" + price);

            ////}

            ////Console.WriteLine("-------------------------------------------------");

            ////////-------------------------------------------------------------

            ////////Grading System
            ////Console.Write("Enter student score: ");
            ////int score = int.Parse(Console.ReadLine());
            ////char grade;

            ////if (score >= 90)
            //// grade = 'A';            
            ////else if (score >= 80)
            ////    grade = 'B';
            ////else if (score >= 70)
            ////    grade = 'C';
            ////else if (score >= 60)
            ////    grade = 'D';
            ////else
            ////    grade = 'F';






            ////Console.WriteLine("The student's grade is: " + grade);
            ////Console.WriteLine("-------------------------------------------------");

            ////////-------------------------------------------------------

            ////////Swap Two Numbers
            ////Console.Write("Enter first number: ");
            ////int a = int.Parse(Console.ReadLine());

            ////Console.Write("Enter second number: ");
            ////int b = int.Parse(Console.ReadLine());

            ////int c;

            ////c = a;
            ////a = b;
            ////b = c;

            ////Console.WriteLine("After swapping: First Number = " + a + ", Second Number = " + b);
            ////Console.WriteLine("-------------------------------------------------");


            ////////------------------------------------------------------------

            ////////Days to Weeks and Days Converter
            ////Console.Write("Enter number of days: ");
            ////int days = int.Parse(Console.ReadLine());

            ////int weeks = days / 7;
            ////int remainingDays = days % 7;

            ////Console.WriteLine( days + " days = " + weeks + " week(s) and " + remainingDays + " day(s)");
            ////Console.WriteLine("-------------------------------------------------");

            ////////-----------------------------------------------------------

            ////////Simple Calculator
            ////Console.Write("Enter first number: ");
            ////double FirstNumber = double.Parse(Console.ReadLine());

            ////Console.Write("Enter operator (+, -, *, /): ");
            ////char op = Console.ReadKey().KeyChar;
            ////Console.WriteLine();

            ////Console.Write("Enter second number: ");
            ////double SecondNumber = double.Parse(Console.ReadLine());

            ////double result = 0;

            ////if (op == '+')
            ////    result = FirstNumber + SecondNumber;
            ////else if (op == '-')
            ////    result = FirstNumber - SecondNumber;
            ////else if (op == '*')
            ////    result = FirstNumber * SecondNumber;
            ////else if (op == '/')
            ////{
            ////    if (SecondNumber != 0)
            ////        result = FirstNumber / SecondNumber;
            ////    else
            ////    {
            ////        Console.WriteLine("Cannot divide by zero!");
            ////        return;
            ////    }
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Invalid operator!");
            ////    return;
            ////}

            ////Console.WriteLine("Result: " + result );
            ////Console.WriteLine("-------------------------------------------------");

            //////-----------------------------------------------

            ////Console.WriteLine("Enter your grade :");
            ////char Grade = Console.ReadKey().KeyChar;


            ////if (Grade == 'A')
            ////    Console.WriteLine("Excellent");
            ////else if(Grade == 'B')
            ////    Console.WriteLine("Good");
            ////else if(Grade == 'C')
            ////    Console.WriteLine("avg");
            ////else
            ////    Console.WriteLine("fail");


            ////switch(grade)
            ////{

            ////    case 'A':
            ////        Console.WriteLine("Excellent");
            ////        break;

            ////    case 'B':
            ////        Console.WriteLine("good");
            ////        break;

            ////    case 'C':
            ////        Console.WriteLine("avg");
            ////        break;

            ////    default:
            ////        Console.WriteLine("fail");
            ////        break;

            ////}

            ////--------------------------------------------------


            ////Console.WriteLine("enter a number ");
            ////int n = int.Parse(Console.ReadLine());

            ////int counter;

            ////for (counter = 0; counter <= n; counter++)
            ////{
            ////    Console.WriteLine("Karim");

            ////}


            ////int num = 20;

            ////while(num != 20)
            ////{
            ////    Console.WriteLine("guess a number again");
            ////    num = int.Parse(Console.ReadLine());
            ////}

            ////int num = 0;

            ////do
            ////{
            ////    Console.WriteLine("guess a number ");
            ////    num = int.Parse(Console.ReadLine());
            ////}
            ////while (num != 20);

            //////-----------------Logic operators
            ////int x, y;
            ////x = y = 5;

            ////bool isThursday, morning;
            ////isThursday = true;
            ////morning = true;


            ////if(    isThursday &&  (x>y)  && morning      )
            ////{
            ////    Console.WriteLine("");

            ////}


            ////if (isThursday || (x > y) || morning)
            ////{
            ////    Console.WriteLine("");

            ////}
            //--------------------------Explain examples on switch and looping
            //Console.WriteLine("Enter any number :\n");
            //int input = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for(int counter=1 ; counter <= input  ; counter++)
            //{

            //    if (counter % 2 == 0)
            //        sum = sum + counter;

            //}

            //Console.WriteLine("sum = " + sum);

            //---------------------------------------------------
            //char choice;

            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine("Enter the operation number :\n1. Addition\n2. Subtraction ");
            //    Console.WriteLine("3. Multiplication\n4. Division");

            //    int OperationNumber = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter first number :");
            //    int FirstNumber = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter first number :");
            //    int SecondNumber = int.Parse(Console.ReadLine());


            //    double result = 0;

            //    bool isActive = false;

            //    switch (OperationNumber)
            //    {


            //        case 1:
            //            result = FirstNumber + SecondNumber;
            //            break;

            //        case 2:
            //            result = FirstNumber - SecondNumber;
            //            break;

            //        case 3:
            //            result = FirstNumber * SecondNumber;
            //            break;

            //        case 4:

            //            if (SecondNumber == 0)
            //            {
            //                Console.WriteLine("Division by zero not allowed");
            //                isActive = true;

            //            }
            //            else
            //            {
            //                result = FirstNumber / SecondNumber;
            //            }

            //            break;

            //        default:
            //            Console.WriteLine("Wrong Choice");
            //            isActive = true;
            //            break;
            //    }


            //    if (!isActive)
            //    {
            //        Console.WriteLine(result);
            //    }

            //    Console.WriteLine("Do you want another operation ? y / n");
            //     choice = Console.ReadKey().KeyChar;

            //} while (choice == 'y' || choice == 'Y');

            //Console.WriteLine("\ngood bye");

            //----------------------------nested for loop


            //for (int i = 0 ; i <= 10; i += 2 ) //Increment for
            //{

            //}


            //for (int i = 20 ; i >= 10;  i-=2 ) //decremental for
            //{ }


            //for (int i = 1; i <= 5; i++)
            //{

            //    for (int j=1; j<=5; j++)
            //    {
            //        Console.Write(i*j + " ");

            //    }
            //    Console.WriteLine();

            //}



            //for(int i = 1;i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++) // Controls columns
            //    {
            //        Console.Write("* ");
            //    }

            //    Console.WriteLine();
            //}



            //Console.WriteLine("enter number of rows : ");
            //int n = int.Parse(Console.ReadLine());


            //for(int i=1; i<=n; i++)
            //{
            //    for(int j=n-i; j>=1; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= i*2-1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}








            ////-- Multiplication table
            //for (int i = 1; i <= 5; i++) // Outer loop for rows
            //{
            //    for (int j = 1; j <= 5; j++) // Inner loop for columns
            //    {
            //        Console.Write((i * j) + "\t"); // Print product
            //    }
            //    Console.WriteLine(); // New line after each row
            //}


            //Console.WriteLine();
            ////----- Right-Angled Triangle
            //int m = 5; // Number of rows

            //for (int i = 1; i <= m; i++) // Controls rows
            //{
            //    for (int j = 1; j <= i; j++) // Controls columns
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine(); // Move to next line
            //}


            //Console.WriteLine();
            ////--Pyramid Pattern
            //int n = 5; // Number of rows
            //for (int i = 1; i <= n; i++) // Controls rows
            //{
            //    for (int j = 1; j <= n - i; j++) // Prints spaces
            //    { Console.Write(" "); }
            //    for (int k = 1; k <= 2 * i - 1; k++) // Prints stars
            //    { Console.Write("*"); }
            //    Console.WriteLine(); // Move to the next line
            //}



            ///////////////////////////////////////////////////// factorial
            //int result = 1;

            //for(int i =1; i<=n; i++)

            //{
            //    result *= i;


            //}

            //Console.WriteLine(result);

            /////----------------Array
            ///



            //int[] numbers = new int[3]; //initialize array

            //Console.WriteLine("Enter 3 numbers ");

            ////fill array
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    numbers[i] = int.Parse(Console.ReadLine()); 
            //}

            //int sum = 0;
            ////print array elements
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //   sum = sum + numbers[i];
            //}

            //// i++ --> i+=1 --> i = i+1
            //int[,] numbers2 = new int[2, 5];
            ////numbers2[0, 0] = 10; // first row , first column
            ////numbers2[0, 2] = 15; // first row, third column

            //////Console.WriteLine(numbers2[0, 2]);

            //Console.WriteLine(numbers2.Length);

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine(numbers2[i, j]);
            //    }

            //}








            //int n = 0;
            //Console.WriteLine("Enter number of student :");
            //n = int.Parse(Console.ReadLine());

            //double[] grades = new double[n];

            //Console.WriteLine("Enter students grades");

            //for (int i = 0; i < n; i++) 
            //{
            //    grades[i] = double.Parse(Console.ReadLine()); 
            //}


            //double sum = 0;
            //double avg;

            //for (int i = 0; i < n; i++)
            //{
            //  sum += grades[i]; 
            //}

            //avg = sum / n;
            //Console.WriteLine("The average is : " + avg);

            //--Function calling structure
            /*
             1- Function implement 
             
            2- (if already implemented ) Function Usage ( calling )
             
          structure:  ClassName.FunctionName ( parameter1, parameter2 .....)

         function return:  inplace of calling

            example:    Math.Pow(2,3) ----> 8

            Console.Writeline(   Math.Pow(2,3)    ); --> print 8

            int result = Math.Pow(2,3); ---> result = 8

             int result = Math.Pow(2,3) + 16; ---> result = 24

             * 
             */
            //--- repo name 
            //-- SimpleStudentManagementProject_CSharpProject1 



            ////////////////////////////////////////////////



            int R,t;

            // int, float, double, char, bool --> stack storage (constant space)

            // string, array, list, any data structure --> heap storage (variable space)  

            // stack storage have initial value --> don't ever produce null reference exception
            // heap storage starts with Null until you assign value --> can produce null exception

            string M = "hello";
            char[] C = new char[] {'h','e','l','l','o' };

            int[] marks = new int[10];
            int[] ages = new int[5];
            string[] names= new string[5];  


            for(int i=0; i < marks.Length; i++) 
            {
             //   Console.WriteLine(marks[i] + names[i]); //Indexoutof range
            }


            bool successede = true;

            try
            {
                //string input = "12k";
                Console.WriteLine("enter degree");
                string degree = Console.ReadLine();
                int output = int.Parse(degree);    // may format exception

            }
            catch(Exception e)
            {

                Console.WriteLine("Degree didn't saved because of the followin error: "+ e.Message);
                successede = false;
            }


            //try
            //{
            //    string[] Studentnames=new string[10];
            //    // names= database.getNamesTable;
            //    for(int i=0; i < Studentnames.Length; i++)
            //    {
            //        Console.Write(Studentnames[i]);
            //    }
            //}
            //catch(Exception e)
            //{ 
            //    Console.WriteLine(e.Message);
            //}


            //---------------------------------------------
            //handle run time errors

            //try
            //{

            //    int x, y;
            //    double z;
            //    bool k;

            //    x = 10;
            //    y = 0;
            //    z = x / y; //division by zero exception
            //}
            //catch(Exception e) 
            //{
            //    Console.WriteLine("Division failed due to :" + e.Message);
            
            //}

            //Console.WriteLine("after exception handeled");
            //Console.ReadLine();

            //string numberStr = "123";
            //    if (int.TryParse(numberStr, out int number))
            //    {
            //        Console.WriteLine($"Conversion successful: {number}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Conversion failed.");
            //    }




            
            //    string Number = "123abc";
                
            //    if (int.TryParse(Number, out int result))
            //    {
            //        Console.WriteLine($"Conversion successful: {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Conversion failed.");
            //    }





            //    string decimalStr = "12.34";
            //    if (double.TryParse(decimalStr, out double decimalNumber))
            //    {
            //        Console.WriteLine($"Converted to double: {decimalNumber}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for double.");
            //    }





            //    string dateStr = "2024-03-24";
            //    if (DateTime.TryParse(dateStr, out DateTime date))
            //    {
            //        Console.WriteLine($"Parsed date: {date}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid date format.");
            //    }

            }

       public static void test(string age, int salary)
        {


        }

        public static void test2(string country="Oman")
        {

            int z = 10;
            IncrementValue(z);

            string name = "karim";
      //      PrintName(name);    

        }

        public static void IncrementValue(int x)
        { x++;

            Console.WriteLine(x);
        }


        public static void getIndex(out int order)
        {
           string[] names = { "karim","ahmed"};

           string input = Console.ReadLine();

            order = Array.IndexOf(names, input);
                  
        }
    }

    }
