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
        }

    }
}
