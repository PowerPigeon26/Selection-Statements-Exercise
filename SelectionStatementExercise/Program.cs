namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number! It is between 1 and 1000.");
            while (true)
            {
                var userInput = int.Parse(Console.ReadLine());
                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Nice, you got it!");
                    break;
                }
            }
        }
    }
}
