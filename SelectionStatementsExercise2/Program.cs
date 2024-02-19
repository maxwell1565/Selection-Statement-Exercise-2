namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("What is your favorite school subject?");

            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "english":
                    Console.WriteLine("Thats a very interesting subject!");
                    break;

                    case "math":
                    Console.WriteLine("Thats a very interesting subject!");
                    break;

                case "spanish":
                    Console.WriteLine("Thats a very interesting subject!");
                    break;

                case "gym":
                    Console.WriteLine("I bet you are a healthy person!");
                    break;

                case "history":
                    Console.WriteLine("Thats a very interesting subject!");
                    break;
                default:
                    Console.WriteLine("I'm sure that's a cool subject!");
                    break;
            }
        }
        
    }
}