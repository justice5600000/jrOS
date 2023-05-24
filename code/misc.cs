//shhhh this is a secret
namespace jrOS // Note: actual namespace depends on the project name.
{
     class miscClass
    {
        public static void rainbow()
        {
             Console.Title = "RaInBoW";
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("R");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("A");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("I");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("N");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("B");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("W");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

        }
        public static void monkey()
        {
                     string monkeycolor;
                Console.Clear();
                Console.Title = "Monkey";
                Console.WriteLine("What color?");
                monkeycolor = Console.ReadLine();
                if(monkeycolor == "white")
                {
                    Console.Clear();
                Console.Title = "Monkey";
                Console.WriteLine("w   c(. .)o   (");
                Console.WriteLine(" |_   (-)     _| ");
                Console.WriteLine("       |     |     ");
                Console.WriteLine("       ()____|            ");
                Console.WriteLine("       //               ");
                Console.WriteLine("       ||              ");
                Console.WriteLine("       mm                ");
                Console.ReadKey();
                }
                if(monkeycolor == "black")
                {
                   Console.Clear();
                   Console.ForegroundColor = ConsoleColor.Black;
                   Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("w   c(. .)o   (");
                Console.WriteLine(" |_   (-)     _| ");
                Console.WriteLine("       |     |     ");
                Console.WriteLine("       ()____|            ");
                Console.WriteLine("       //               ");
                Console.WriteLine("       ||              ");
                Console.WriteLine("       mm                ");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                   Console.BackgroundColor = ConsoleColor.Black;
                
                }

        }
        public static void credits()
        {
            Console.Clear();
                Console.Title = "Credits";
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("     -----Coding-----");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("      Justice5600000");
                Console.WriteLine("     ----------------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("     -----teaching me to write c#-----");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("           Brackeys on yt              ");
                Console.WriteLine("           Mike Dane on yt             ");
                Console.WriteLine("           C Plus+ on yt             ");
                Console.WriteLine("           Stack Overflow             ");
                Console.WriteLine("     ---------------------------------");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
        }
    }
}        