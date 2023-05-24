
using System.IO;


namespace jrOS // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] async)
        {
        string username;
           string password;
           string start = "f";
           string app;
           string  vfilePath = @"C:\jrOS\code\textdata\version.txt";
           string pfilePath = @"C:\jrOS\userandpass\pass.txt";
           string ufilePath = @"C:\jrOS\userandpass\user.txt";
           
           

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
           Console.ForegroundColor = ConsoleColor.DarkMagenta;
           Console.WriteLine("       _ _____");
           Console.WriteLine(@"      | |  __ \");
           Console.WriteLine("      | | |__) |___  ___");
           Console.WriteLine(@"  _   | |  _  // _ \/ __|");
           Console.WriteLine(@" | |__| | | \ \ (_) \__ \");
           Console.WriteLine(@"  \____/|_|  \_\___/|___/");
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine(strver + "\nenter username");
           username = Console.ReadLine();
           if(username == struser)
           
            Console.WriteLine("enter password");
            password = Console.ReadLine();
            if(password == strpass)
            {
                
                Console.WriteLine("Correct! Press any key to start");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Opening");
                start = "t";
                
                while (start == "t")
           {
            // main selection screen after login prompt
            Console.Clear();
            Console.Title = "jrOS Home";
            Console.WriteLine("Which app do you want to open?\nDice\nCalculator\nMath Game\nUrNote\nTester\nSettings\nCredits");
            Console.WriteLine("");
            app = Console.ReadLine();
            // calculator start
            if(app == "calculator")
            {
                CalcClass.calculator();
            }
            // calculator end
            // dice start
            if(app == "dice")
            {
              DiceClass.Dice();
            }
            //dice end
            //math game start (ripped from other project)
            if(app == "math game")
            {
                MgameClass.Mgame();
            }
            //math game end
            //credits start
            if(app == "credits")
            {
                miscClass.credits();
            }
            //credits end
            if(app == "rainbow")
            {
                miscClass.rainbow();
            }
            if(app == "settings")
            {
                settingsClass.settings();
            }
            if(app == "monkey")
            {
                miscClass.monkey();  
            }
            if(app == "tester")
            {
             testerClass.testerapp();
            }
            if(app == "urnote")
           {
            UrNoteClass.UrNote();
           }
           if(app == "shutdown")
           {
            start = "f";
            Console.WriteLine("press any key to shutdown");
            Console.ReadKey();
           }
           if(app == "test")
           {
            testClass.testapp();
           }
            }
         } 
         if(username == "admin")
        {
            Console.WriteLine("enter password");
            password = Console.ReadLine();
            if(password == "admin")
            {
               AdminClass.adminstart();
            }
            else
            {
                Console.WriteLine("incorrect");
                Console.ReadKey();
               
            }
         }           
        }  
            
    }
}
