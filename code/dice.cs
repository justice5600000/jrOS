namespace jrOS // Note: actual namespace depends on the project name.
{
     class DiceClass
    {
        public static void Dice()
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
    }
}        