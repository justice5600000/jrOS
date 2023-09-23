
using System.Drawing;
using System.IO;


namespace jrOS // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static Random _random = new Random();
private static ConsoleColor GetRandomConsoleColor()
{
    var consoleColors = Enum.GetValues(typeof(ConsoleColor));
    return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
}

        static void Main(string[] async)
        {
            string username;
            string password;
            string start = "f";
           string app;
           string  vfilePath = @"C:\jrOS\code\textdata\version.txt";
           string pfilePath = @"C:\jrOS\code\textdata\userandpass\pass.txt";
           string ufilePath = @"C:\jrOS\code\textdata\userandpass\user.txt";
           
           

            List<string> version = new List<string>();
            version = File.ReadAllLines(vfilePath).ToList();
            var strver = String.Join(",", version.ToArray());     

            List<string> pass = new List<string>();
            pass = File.ReadAllLines(pfilePath).ToList();
            var strpass = String.Join(",", pass.ToArray());

            List<string> user = new List<string>();
            user = File.ReadAllLines(ufilePath).ToList();
            var struser = String.Join(",", user.ToArray());
           
           

           Console.Title = "jrOS login";
           
                      Console.ForegroundColor = (ConsoleColor)_random.Next(15);
           Console.WriteLine(@"    _       ___  ____  ");
           Console.WriteLine(@"   (_)_ __ / _ \/ ___| ");
           Console.WriteLine(@"   | | '__| | | \___ \ ");
           Console.WriteLine(@"   | | |  | |_| |___) |");
           Console.WriteLine(@"  _/ |_|   \___/|____/ ");
           Console.WriteLine(@" |__/                  ");
           Console.ForegroundColor = ConsoleColor.White;
           //login start
           
           Console.WriteLine(strver + "\nenter username");
           username = Console.ReadLine();
           Console.WriteLine("enter password");
           password = Console.ReadLine();
           if(username == struser | password == strpass)
           {
            //main menu start
            Console.WriteLine("Correct! Press any key to start");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Opening");
                start = "t";
                
                while (start == "t")
           {
            // main selection screen after login prompt
            Console.Clear();
            string[] menuOptions = { "Calculator", "Dice", "Math Game", "UrNote", "Tester", "Settings", "Credits", "GitHub"};
        int selectedIndex = 0;

        Console.CursorVisible = false;
        bool start2 = true;

        while (start2 == true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("jrOS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":\n");
            Console.Title = "jrOS";

            // Display the menu options
            for (int i = 0; i < menuOptions.Length; i++)
            {
               
                if (i == selectedIndex)
                {

                   Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("> " + menuOptions[i]);
                }
                else
                {
                    
                    Console.WriteLine("  " + menuOptions[i]);
                }

                Console.ResetColor();
            }

            // Get user input
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;

            // Handle user input
            if (key == ConsoleKey.UpArrow)
            {
                selectedIndex = (selectedIndex - 1 + menuOptions.Length) % menuOptions.Length;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                selectedIndex = (selectedIndex + 1) % menuOptions.Length;
            }
            else if (key == ConsoleKey.Enter)
            {
                // Perform action based on selected index
                Console.Clear();

                switch (selectedIndex)
                {
                    case 0:
                       CalcClass.calculator();
                        break;
                    case 1:
                        DiceClass.Dice();
                        break;
                    case 2:
                       MgameClass.Mgame();
                        break;
                    case 3:
                     UrNoteClass.UrNote();
                        break;
                        case 4:
                        testerClass.testerapp();
                        break;
                        case 5:
                       settingsClass.settings();
                        break;
                        case 6:
                        miscClass.credits();
                        break;
                        case 7:
                        miscClass.GitOpener();
                        break;
                        
                }

                Console.ReadLine(); // Wait for user input before continuing
            }
           }
           }
           }
           else
           {
            Console.WriteLine("Incorrect!");
            Console.ReadKey();
           }
            
                
                
        
            
         
                      
        }  
            
    }
}
