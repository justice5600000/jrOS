using System;

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
           Console.Title = "jrOS login";
           

           Console.WriteLine("enter username");
           username = Console.ReadLine();
           //edit this to set username
           if(username == "username")
           
            Console.WriteLine("enter password");
            password = Console.ReadLine();
            //edit this to set password
            if(password == "password")
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
            Console.WriteLine("Which app do you want to open?\nDice\nCalculator\nMath Game\nSettings\nCredits");
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
                Console.WriteLine("     -----Coding-----\n          Justice5600000\n     -----Teaching me to write c#-----\n     Brackeys on youtube\n     Mike Dane on youtube");
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
                Console.Title = "Settings";
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
                    Console.WriteLine("The current commands are:\ncolor set, this command can set the color red orange yellow green cyan blue and purple\nreset color, this command resets the color resets to white\ntype rainbow in the home screen for a suprise ;)");
                    Console.ReadKey();
                }
            }
            

           
            


        }            
        }           
}   }    }    
          

                
            
           



            
           
       
                
                
            
            
           



    

