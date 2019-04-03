using System;

namespace SDET_CSharpE2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseTwo obj1 = new ExerciseTwo();
            obj1.RequestInfo();

            ExerciseTwo obj2 = new ExerciseTwo("Carlos", 30);

            ExerciseTwo obj3 = new ExerciseTwo();
            //Properties
            obj3.Name = "Antonio";
            obj3.Age = 31;
            
            //Constructors call
            obj1.show();
            obj2.show();
            obj3.show();


            //Method overloading
            obj1.SequenceNum(10);
            Console.WriteLine("------------------------------------------------------");
            obj2.SequenceNum(5,10);
            Console.WriteLine("------------------------------------------------------");

            //Check a word = palindrome

           //obj1.Word = "step on no pets";
            obj1.CheckForPalindrome("step on no pets", "hello world");
            //Console.WriteLine("-----------------------");
            //obj1.Word = "hello world";
            //obj1.CheckForPalindrome();
            Console.WriteLine("------------------------------------------------------");

            //Print Diagonal of Numbers with top
            obj1.DiagonalPrint(10);
        }
    }
}
