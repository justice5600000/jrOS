namespace jrOS // Note: actual namespace depends on the project name.
{
     class MgameClass
    {
        public static void Mgame()
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
    }
}        