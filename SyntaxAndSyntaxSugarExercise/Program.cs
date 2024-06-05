namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SyntaxSugar());

        }

        static string SyntaxSugar() {

            var answer = 4;
            string response;
            response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            return response ;
        }
    }
}
