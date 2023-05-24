namespace jrOS // Note: actual namespace depends on the project name.
{
     class CalcClass
    {
        public static void calculator()
        {
            string typecalc;
           int num01;
           int num02;
           string cresult;
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
    }
}        