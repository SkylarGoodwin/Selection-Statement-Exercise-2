namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What is your favorite school subject");
           var subject = Console.ReadLine();

           switch (subject.ToLower()){

            case "math":
                Console.WriteLine("An infinite number of mathematicians walk into a bar. The first orders a beer. The second orders a half of a beer. The third orders a quarter of a beer. The fourth begins to order, but the bartender cuts him off, saying 'You guys need to know your limits', and putting 2 beers on the bar.");
                break;
            case "chemestry":
                Console.WriteLine("Two atoms are walking down the street. One atom says to the other, 'Hey! I think I lost an electron!' The other asks, 'Are you sure?' 'Yes, I'm positive!'");
                break;
            case "english":
                Console.WriteLine("Knock knock. Who's there? To. To Who? No, To whom!");
                break;
            case "programming" or "computer science":
                Console.WriteLine("A guy walks into a bar and asks for 1.4 root beers. The bartender says 'I’ll have to charge you extra, that’s a root beer float'. The guy says 'In that case, better make it a double.");
                break;
            default:
                Console.WriteLine($"I don't have a joke for {subject}");
                break;
           }

        }
    }
}