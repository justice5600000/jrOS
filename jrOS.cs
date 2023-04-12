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
           string typeapp;
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
            Console.WriteLine("Which app do you want to open?\nDice\nCalculator\nMath Game\nCredits");
            typeapp = Console.ReadLine();
            // calculator start
            if(typeapp == "calculator")
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
            if(typeapp == "dice")
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
            if(typeapp == "math game")
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
            //settings start
            if(typeapp == "credits")
            {
                Console.Clear();
                Console.WriteLine("     -----Coding-----\n     Justice5600000\n     -----Teaching me to write c#-----\n     Brackeys on youtube\n     Mike Dane on youtube");
                Console.ReadKey();
            }
            

           
            


        }            
        }           
}   }    }    
          

                
            
           



            
           
       
                
                
            
            
           



    

