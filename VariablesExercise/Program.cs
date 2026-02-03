namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bob";
            int age = 20;
            char initial = 'G';
            bool isMale = true;
            double currentWeight = 250.5;
            decimal targetWeight = 200.1m;

            Console.WriteLine($"{firstName} {initial} : {age} years old");
            Console.WriteLine($"He is male : {isMale} ");
            Console.WriteLine($"Current weight is {currentWeight} pounds, and his target weight is {targetWeight} pounds");

        }
        }
    }

