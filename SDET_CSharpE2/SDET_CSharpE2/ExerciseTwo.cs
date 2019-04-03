using System;

using System.Collections.Generic;
using System.Text;

namespace SDET_CSharpE2
{
    class ExerciseTwo
    {
        private string name;
        private int age;

        //Constructor
        public ExerciseTwo()
        {
            name = "";
            age = 0;
        }

        public void RequestInfo()
        {
            string temp = "";
            Console.WriteLine("Input a name");
            name = Console.ReadLine();
            Console.WriteLine("Input an age");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);
        }

        //Constructor overloading
        public ExerciseTwo(string name, int age)
        {
            this.name =name;
            this.age = age;
        }

        //Method 
        public void SequenceNum(int l)
        {
            for (int i = 0; i <=l; i++)
            {
                Console.WriteLine(i);
            }
        }
        //Method overloading
        public void SequenceNum(int n, int l)
        {
            for (int i = n; i <= l; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void show()
        {
            Console.WriteLine("Name: {0}, age:{1}", name, age);
        }

        //Palindorme
        public void CheckForPalindrome(string word1, string word2)
        {            
            char[] input = word1.ToCharArray();
            string reverse= string.Empty;
            int l = input.Length - 1;

            char[] input2 = word2.ToCharArray();
            string reverse2 = string.Empty;
            int l2 = input2.Length - 1;

            while (l >= 0)
            {
                reverse = reverse + input[l];
                l--;
            }

            while (l2 >= 0)
            {
                reverse2 = reverse2 + input2[l2];
                l2--;
            }
            if (word1 == reverse)
            {
                Console.WriteLine("The first word {0} is a palindrome:{1}",word1, reverse);
            }
            else
            {
                Console.WriteLine("The first word {0} is not a palindrome:{1}", word1, reverse);
            }
            if (word2 == reverse2)
            {
                Console.WriteLine("The second word {0} is a palindrome:{1}", word2, reverse2);
            }
            else
            {
                Console.WriteLine("The second word {0} is not a palindrome:{1}", word2, reverse2);
            }
        }

        // Diagonal Print
        public void DiagonalPrint(int limit)
        {
            
            StringBuilder diagonal = new StringBuilder();
            for (int i = 1; i <= limit; i++)
            {
                for (int j = 0; j <i; j++)
                {
                    diagonal.Append(" ");
                }
                diagonal.Append(i);
                diagonal.Append("\n");
                
            }
            Console.WriteLine(diagonal);
        }
    }
}
