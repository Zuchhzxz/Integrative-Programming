using System.Text;
using System.Collections.Generic;
using System.Web;
using System.Threading;

namespace ArrayList
{

    class String_Builder
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Guessing Game");
            Console.WriteLine("-");
            Console.WriteLine("I. Are These Words the Same?");
            Console.WriteLine("Choose True or False?");

            Console.WriteLine("A.");
            Console.Write("Word: Robot");
            Console.WriteLine(" ");
            Console.Write("Input: Robot");
            String robot = Console.ReadLine();
            StringBuilder wordA = new StringBuilder("Robot");
            StringBuilder wordB = new StringBuilder("Robot");
            Console.WriteLine(wordA.Equals(wordB));

            Console.WriteLine("-");

            Console.WriteLine("B.");
            Console.Write("Word: Netflix");
            Console.WriteLine(" ");
            Console.Write("Input: Flix");
            String netflix = Console.ReadLine();
            StringBuilder wordC = new StringBuilder("Netflix");
            StringBuilder wordD = new StringBuilder("Flix");
            Console.WriteLine(wordC.Equals(wordD));

            Console.WriteLine("-");

            Console.WriteLine("C.");
            Console.Write("Word: Ezekiel");
            Console.WriteLine(" ");
            Console.Write("Input: Kiel");
            String Ezekiel = Console.ReadLine();
            StringBuilder wordE = new StringBuilder("Ezekiel");
            StringBuilder wordF = new StringBuilder("Kiel");
            Console.WriteLine(wordE.Equals(wordF));

            Console.WriteLine("-");

            Console.WriteLine("D.");
            Console.Write("Word: Yasuo");
            Console.WriteLine(" ");
            Console.Write("Input: Yasuo");
            String yasuo = Console.ReadLine();
            StringBuilder wordG = new StringBuilder("Yasuo");
            StringBuilder wordH = new StringBuilder("Yasuo");
            Console.WriteLine(wordE.Equals(wordF));

            Console.WriteLine("Congrats");

            Console.Write("\nPress any key to exit...");

            Console.ReadKey();

        }
    }
}
