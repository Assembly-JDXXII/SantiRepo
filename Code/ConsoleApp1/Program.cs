using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            Console.WriteLine("How old are you");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 18) 
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            //Exercicio 2
            Console.WriteLine("How tall are you");
            int tall = Convert.ToInt32(Console.ReadLine());
            if (tall <= 147) 
            {
                Console.WriteLine("How does it feel to be a Dwraf?");
            }
            
            //Exercico 3
            Console.WriteLine("What's your marks in Maths?");
            int maths = Convert.ToInt32(Console.ReadLine());
            if (maths >= 65)
            {
                Console.WriteLine("What's your marks in Physics?");
                int phy = Convert.ToInt32(Console.ReadLine());
                if(phy >= 55)
                {
                    Console.WriteLine("What's your marks in Chemistry?");
                    int chem = Convert.ToInt32(Console.ReadLine());
                    if(chem >= 50)
                    {
                        int all = maths + phy + chem;
                        if(all >= 180)
                        {
                            Console.WriteLine("You are eligible for admission");
                        }
                    }
                }
            }
            
            //Exercício 4
            Console.WriteLine("How's the temperature outside(degrees celsius)");
            int outside = Convert.ToInt32(Console.ReadLine());
            if (outside < 0)
                Console.WriteLine("Freazing weather");
            if (outside >= 0 && outside < 10)
                Console.WriteLine("Very cold weather");
            if (outside >= 10 && outside < 20)
                Console.WriteLine("Cold weather");
            if (outside >= 20 && outside < 30)
                Console.WriteLine("Normal in temp");
            if (outside >= 30 && outside < 40)
                Console.WriteLine("Its Hot");
            if (outside >= 40)
                Console.WriteLine("Its very hot");
            
            //Exercício 5
            Console.WriteLine("One letter of the alphabet");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' 
                || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
                Console.WriteLine("The letter is a vowel");
            else
                Console.WriteLine("The letter is a consonent");
            
            //Exercício 6
            Console.WriteLine("What's your profit?");
            int profit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's your loss?");
            int loss = Convert.ToInt32(Console.ReadLine());
            int gain = profit - loss;
            Console.WriteLine("You can book your profit amount: " +  gain);
            
            //Exercício 7 e 8
            Console.WriteLine("Month Number");
            int month = Convert.ToInt32(Console.ReadLine());
            if (month == 1)
                Console.WriteLine("January, Month have 31 days");
            if (month == 2)
                Console.WriteLine("February, Month have 28 days");
            if (month == 3)
                Console.WriteLine("March, Month have 31 days");
            if (month == 4)
                Console.WriteLine("April, Month have 30 days");
            if (month == 5)
                Console.WriteLine("May, Month have 31 days");
            if (month == 6)
                Console.WriteLine("June, Month have 30 days");
            if (month == 7)
                Console.WriteLine("July, Month have 31 days");
            if (month == 8)
                Console.WriteLine("August, Month have 31 days");
            if (month == 9)
                Console.WriteLine("September, Month have 30 days");
            if (month == 10)
                Console.WriteLine("October, Month have 31 days");
            if (month == 11)
                Console.WriteLine("November, Month have 30 days");
            if (month == 12)
                Console.WriteLine("December, Month have 31 days");
            
            //Exercício 9
            Console.WriteLine("1 Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Another Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 % 2 == 0 || num1 % 3 == 0 && num2 % 2 == 0 || num2 % 3 == 0)
                Console.WriteLine(num1 * num2);
            else
                Console.WriteLine(num1 + num2);
            
            //Exercício 10
            Console.WriteLine("Year");
            int year =  Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
                Console.WriteLine(year +"-True");
            else
                Console.WriteLine(year +"-False");
        }
    }
}
