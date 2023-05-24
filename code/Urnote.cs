namespace jrOS // Note: actual namespace depends on the project name.
{
     class UrNoteClass
    {
        public static void UrNote()
        {
             string  un1filePath = @"C:\jrOS\UrNote\note1.txt";
           string  un2filePath = @"C:\jrOS\UrNote\note2.txt";
           string  un3filePath = @"C:\jrOS\UrNote\note3.txt";
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