using System;

namespace Academud__A_part_of_Academud_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Värmecounter ??? Skapa värde för värmen genom Data.Warmth
            // Karma värde ???
            // Rumsnamn/värde ???
           

            int value = Startgame();
            value = Reception(value);
           
            value = Classroom1(value);
            value = Break(value);
            value = Classroom2(value);
            value = Lunch(value);
            value = Project(value);
            value = Event(value);
            value = Citystroll(value);
            value = Endgame(value);



            Gameover();

        }

        private static void Jacketon()
        {
            throw new NotImplementedException();
        }

        private static int Startgame()
        {
            
            Console.Write("Välkommen till "); Console.ForegroundColor = ConsoleColor.Green;           
            Console.Write(" Academud, A part of Academud Work."); Console.ForegroundColor = ConsoleColor.Gray;      
            Console.Write(" Här tror vi på ett growth mudset.");
            Console.WriteLine("\nKlicka på valfri knapp för att börja spela");
            Console.ReadKey();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            

            Console.Write("Det är en vanlig dag i innerstaden Göteborg, det regnar snett underifrån och du befinner dig utanför Östra Hamngatan 16.");
            Console.WriteLine("Dörren in till United Spaces tillika ditt andra hem är dessvärre låst, hur skall du ta dig in?\n");
            Console.WriteLine("1. Ring upp till receptionen via porttelefonen.");
            Console.WriteLine("2. Stå och vänta i regnet på att någon skall släppa in dig, gud va pinsamt.");
            Console.WriteLine("3. Installera ParaKey-appen på din allt för gamla smartphone med risk för vattenskada pga regnet.\n");
            Console.WriteLine("Ditt val: ");
           int svar = int.Parse(Console.ReadLine());


            return svar;



        }

        private static int Reception(int value)
        {
            throw new NotImplementedException();


             //Kalla Jacketon(); om användare väljer att ej hänga av sig jackan.  (Data.Warmth är värdet för hettan)
        }
        private static int Classroom1(int value)
        {
            throw new NotImplementedException();
        }

        private static int Break(int value)
        {
            throw new NotImplementedException();
        }

        private static int Classroom2(int value)
        {
            throw new NotImplementedException();
        }

        private static int Lunch(int value)
        {
            throw new NotImplementedException();
        }

        private static int Project(int value)
        {
            throw new NotImplementedException();
        }

        private static int Event(int value)
        {
            throw new NotImplementedException();
        }

        private static int Citystroll(int value)
        {
            throw new NotImplementedException();
        }

        private static int Endgame(int value)
        {
            throw new NotImplementedException();
        }





        private static void Gameover()
        {
            throw new NotImplementedException();
        }
    }
}
