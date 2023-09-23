namespace jrOS // Note: actual namespace depends on the project name.
{
     class settingsClass
    {
        public static void settings()
        {
           
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
          string setting;
                Console.Title = "jrOS Settings";
                Console.Clear();
                
                Console.WriteLine("Type Help for commands");
                setting = Console.ReadLine();
                
                if(setting == "help")
                {
                    Console.Clear();
                    Console.WriteLine("The current commands are:\ncolor set: all of the color commands are currently broken :(\nreset color: this command resets the color resets to white\ntheme set: this sets the theme of everything, the commands are theme set dark or theme set light\nlogin: this shows the current user login info\nedit login: this command lets you edit your jrOS login.\nadmin: this command brings the admin login screen the username and password are admin\ntype rainbow or monkey for a suprise ;)");
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
                if(setting == "monkey")
                {
                    miscClass.monkey();
                }
                if(setting == "rainbow")
                {
                    miscClass.rainbow();
                }
                if(setting == "edit login")
                {
                    Console.Clear();
                    Console.WriteLine("Enter new username:");
                    string Uinput;
                    Uinput = Console.ReadLine();
                    using (StreamWriter writer = new StreamWriter(ufilePath))
                    {
                        writer.WriteLine(Uinput);
                    }
                    Console.WriteLine("Done!");
                      Console.WriteLine("Enter new password:");
                    string Pinput;
                    Pinput = Console.ReadLine();
                    using (StreamWriter writer = new StreamWriter(pfilePath))
                    {
                        writer.WriteLine(Pinput);
                    }
                    Console.WriteLine("Done!");
                }
                
                if(setting == "admin")
                {
                    Console.Clear();
                    string apass;
                    string auser;
                    Console.WriteLine("enter username");
                    auser = Console.ReadLine();
                    Console.WriteLine("enter password");
                    apass = Console.ReadLine();
                    if(auser == "admin" | apass == "admin")
                    {
                        Console.WriteLine("Correct!");
                        Console.ReadKey();
                        AdminClass.adminstart();
                    }
                    else
                    {
                        Console.WriteLine("incorrect");
                    }
                    
                }
        }
    }
}        