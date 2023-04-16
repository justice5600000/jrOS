using System;
using System.IO;
using System.Linq;
namespace jrOS // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string username;
           string password;
           string start = "f";
           string app;
           string typecalc;
           int num01;
           int num02;
           string cresult;
           string  vfilePath = @"C:\jrOS\code\textdata\version.txt";
        string  un1filePath = @"C:\jrOS\UrNote\note1.txt";
        string  un2filePath = @"C:\jrOS\UrNote\note2.txt";
        string  un3filePath = @"C:\jrOS\UrNote\note3.txt";
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
           

           Console.WriteLine(strver + "\nenter username");
           username = Console.ReadLine();
           //edit this to set username
           if(username == struser)
           
            Console.WriteLine("enter password");
            password = Console.ReadLine();
            //edit this to set password
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
            Console.WriteLine("Which app do you want to open?\nDice\nCalculator\nMath Game\nUrNote\nSettings\nCredits");
            Console.WriteLine("");
            app = Console.ReadLine();
            // calculator start
            if(app == "calculator")
            {
                Console.Clear();
                Console.Title = "jrOS Calculator";
                Console.WriteLine("Type help to see commands\nWhat type of problem would you like to solve?");
                typecalc = Console.ReadLine();
                if(typecalc == "add")
                {
                    Console.Clear();
                    Console.WriteLine("Enter first number: ");
                    num01 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    num02 = Convert.ToInt32(Console.ReadLine());

                    cresult = Convert.ToString(num01 + num02);

                    Console.WriteLine("The result is " + cresult + "!");
                    Console.ReadKey();
                }
                if(typecalc == "subtract")
                {
                    Console.Clear();
                    Console.WriteLine("Enter first number: ");
                    num01 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    num02 = Convert.ToInt32(Console.ReadLine());

                    cresult = Convert.ToString(num01 - num02);

                    Console.WriteLine("The result is " + cresult + "!");
                    Console.ReadKey();
                }
                if(typecalc == "multiply")
                {
                    Console.Clear();
                    Console.WriteLine("Enter first number: ");
                    num01 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    num02 = Convert.ToInt32(Console.ReadLine());

                    cresult = Convert.ToString(num01 * num02);

                    Console.WriteLine("The result is " + cresult + "!");
                    Console.ReadKey();
                }
                if(typecalc == "divide")
                {
                    Console.Clear();
                    Console.WriteLine("Enter first number: ");
                    num01 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number: ");
                    num02 = Convert.ToInt32(Console.ReadLine());

                    cresult = Convert.ToString(num01 / num02);

                    Console.WriteLine("The result is " + cresult + "!");
                    Console.ReadKey();
                }
                if(typecalc == "help")
                {
                    Console.Clear();
                    Console.WriteLine("The supported commands are:\nadd\nsubtract\nmultiply\ndivide");
                    Console.ReadKey();
                }
            }
            // calculator end
            // dice start
            if(app == "dice")
            {
                Console.Title = "jrOS Dice";
                Console.Clear();
                int dmax;
                Console.WriteLine("enter dice size");
                dmax = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("press any key to start");
                Console.ReadKey();
                Console.Clear();
               Random numberGen = new Random();
               
               int roll = 0;

               while(roll != 999)
               {
                roll = numberGen.Next(1, dmax);
                Console.WriteLine("you rolled " + roll);
                Console.ReadKey();
                Console.Clear();
               }
            }
            //dice end
            //math game start (ripped from other project)
            if(app == "math game")
            {
                Console.Clear();
                 Console.Title = "jrOS Math Game";
          Console.WriteLine("Press Any Key To Start.");
          Console.ReadKey();
          Console.Clear();

          int answer01;
          int answer02;
          int answer03;

          Console.WriteLine("10 * 2 + 3");
          answer01 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("5 * 5 + 10");
          answer02 = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("2 * 5 + 5");
          answer03 = Convert.ToInt32(Console.ReadLine());

          if(answer01 == 23 && answer02 == 35 && answer03 == 15)
          {
            Console.WriteLine("You Got All Correct!\nPress any key to exit.");
            Console.ReadKey();
          }
          else
          {
            Console.WriteLine("You Got Some Incorrect.\nPress any key to exit.");
            Console.ReadKey();
          }
            }
            //math game end
            //credits start
            if(app == "credits")
            {
                Console.Clear();
                Console.Title = "Credits";
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("     -----Coding-----");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("      Justice5600000");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("     -----teaching me to write c#-----");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("           Brackeys on yt              ");
                Console.WriteLine("           Mike Dane on yt             ");
                Console.WriteLine("           C Plus+ on yt             ");
                Console.WriteLine("           Stack Overflow             ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();


            }
            //credits end
            if(app == "rainbow")
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
            if(app == "settings")
            {
                string setting;
                Console.Title = "jrOS Settings";
                Console.Clear();
                Console.WriteLine("Type Help for commands");
                setting = Console.ReadLine();
                if(setting == "color set red")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Done!");
                    Console.ReadKey();
                }
                if(setting == "color set orange")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Done!");
                    Console.ReadKey();
                }
                if(setting == "color set yellow")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Done!");
                    Console.ReadKey();
                }
                if(setting == "color set green")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Done!");
                    Console.ReadKey();
                }
                if(setting == "color set cyan")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Done!");
                    Console.ReadKey();
                }
                if(setting == "color set blue")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Done!");
                    Console.ReadKey();
                }
               if(setting == "color set purple")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Done!");
                    Console.ReadKey();
                }
                if(setting == "reset color")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Done!");
                    Console.ReadKey();
                }
                if(setting == "help")
                {
                    Console.Clear();
                    Console.WriteLine("The current commands are:\ncolor set, this command can set the color red orange yellow green cyan blue and purple\nreset color, this command resets the color resets to white\ntheme set this sets the theme of everything, the commands are theme set dark or theme set light\nlogin, this shows the current user login info\ntype rainbow or monkey in the home screen for a suprise ;)");
                    Console.ReadKey();
                }
                if(setting == "theme set light")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                   Console.BackgroundColor = ConsoleColor.White;
                   Console.WriteLine("Done!");
                }
                if(setting == "theme set dark")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                   Console.BackgroundColor = ConsoleColor.Black;
                   Console.WriteLine("Done!");
                }
                if(setting == "login")
                {
                    Console.Clear();
                    Console.WriteLine("Your username is " + struser + "\nYour password is " + strpass + "\nTo change these go into the userandpass folder and change the .txt files.");
                    Console.ReadKey();
                }
            }
            if(app == "monkey")
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
            if(app == "tester")
            {
                Console.Clear();
                Console.Title = "jrOS tester";
                string tstType;
                Console.WriteLine("What varibule type would you like to test? ");
                tstType = Console.ReadLine();
                if(tstType == "string")
                {
                    Console.Clear();
                    string tstString;
                    Console.Write("What would you like it to say?: ");
                    tstString = Console.ReadLine();
                    Console.WriteLine("Your string says " + tstString + "!");
                    Console.ReadKey();
                }
                 if(tstType == "int")
                {
                    Console.Clear();
                    int tstString;
                    Console.Write("What number would you like it to have?: ");
                    tstString = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your int is " + tstString + "!");
                    Console.ReadKey();
                }
                if(tstType == "char")
                {
                    Console.Clear();
                    char tstString;
                    Console.Write("What number would you like it to have?: ");
                    tstString = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Your char says " + tstString + "!");
                    Console.ReadKey();
                }

            }
            if(app == "urnote")
           {
            Console.Clear();
            Console.Title = "jrOS UrNote";
            Console.WriteLine("Choose a number to read that UrNote note" );
            int notenum;
            notenum = Convert.ToInt16(Console.ReadLine());
            if(notenum == 1)
            {
                Console.Clear();
                 List<string> note = new List<string>();
            note = File.ReadAllLines(un1filePath).ToList();
            var strnote = String.Join(",", note.ToArray());
            Console.WriteLine(strnote);
            Console.ReadKey();
            }
            if(notenum == 2)
            {
                Console.Clear();
                 List<string> note = new List<string>();
            note = File.ReadAllLines(un2filePath).ToList();
            var strnote = String.Join(",", note.ToArray());
            Console.WriteLine(strnote);
            Console.ReadKey();
            }
            if(notenum == 3)
            {
                Console.Clear();
                 List<string> note = new List<string>();
            note = File.ReadAllLines(un3filePath).ToList();
            var strnote = String.Join(",", note.ToArray());
            Console.WriteLine(strnote);
            Console.ReadKey();
            }
            
        
            
           }










            }

           
            


        }            
        }           
}   }     
          

                
            
           



            
           
       
                
                
            
            
           



    

