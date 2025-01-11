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
            if (tall <= 140) 
            {
                Console.WriteLine("How does it feel to be a Dwraf?");
            }

        }
    }
}
