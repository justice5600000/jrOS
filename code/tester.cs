namespace jrOS // Note: actual namespace depends on the project name.
{
     class testerClass
    {
        public static void testerapp()
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
    }
}        