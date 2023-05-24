namespace jrOS // Note: actual namespace depends on the project name.
{
     class settingsClass
    {
        public static void settings()
        {
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
                if(setting == "version")
                {
                    Console.Clear();
                    Console.WriteLine("the current version is ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(strver);
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                }
        }
    }
}        