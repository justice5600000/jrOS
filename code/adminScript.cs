namespace jrOS // Note: actual namespace depends on the project name.
{
     class AdminClass
    {
        public static void adminstart()
        {
            string start;
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
                start = "a";
                while(start == "a")
                {
                    Console.Clear();
                    Console.Title = "jrOS Admin";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("What would you like to do, admin?");
                    app = Console.ReadLine();
                   //app start
                   
                   if(app == "shutdown")
           {
            start = "f";
            Console.WriteLine("press any key to shutdown");
            Console.ReadKey();
           } 
                    if(app == "display")
                    {
                        Console.Clear();
                        Console.Title = "jrOS Admin Display";

                        string displayO;
                        Console.WriteLine("What would you like to display?");
                        displayO = Console.ReadLine();
                        if(displayO == "userinfo");
                        {
                            Console.WriteLine(struser);
                        Console.WriteLine(strpass);
                        Console.ReadKey();
                        }
                        if(displayO == "notes")
                        {
                            Console.WriteLine("test");
                            Console.ReadKey();
                        }
                        
                    }
                    if(app == "loop")
                    {
                        int Lstart;
                        string Linput;
                        Lstart = 0;
                        Console.WriteLine("what does it say");
                        Linput = Console.ReadLine();
                        Lstart = 1;
                        while(Lstart == 1)
                        {
                            Console.WriteLine(Linput);
                        }

                    }
                    if(app == "line")
                    {
                        Console.Clear();
                        int linestart = 1;
                        while(linestart == 1)
                        {
                           
                          Console.WriteLine(@"                                                                 \");
                          
                          Console.WriteLine("                                                                 -");
                          
                          Console.WriteLine("                                                                 /");
                          
                          Console.WriteLine("                                                                 |");
                         
                        }
                    }
                    if(app == "SWtest")
                    {
                        string opps;
                        opps = "asd";
                         using (StreamWriter writer = new StreamWriter("data.txt"))
                       {
                       writer.WriteLine("Hello, World!" + opps);
                        }
                        Console.WriteLine("done!, check data.txt");
                        Console.ReadKey();
                    }
                   
                }
        }
    }
}        