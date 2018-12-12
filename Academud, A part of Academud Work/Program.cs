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

            for (int i = 0, j = 0; i < 20001; i++, j++)
            {
                int top = Console.CursorTop;
                int left = Console.CursorLeft;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("BOOTING UP ACADEMUD : {0}%", i, j);
                
            }
            Console.Clear();
            Console.WriteLine("#########");
            int y, b;
            for (y = 1; y <= 7; y++)
            {

                for (b = 1; b <= y; b++)
                {
                    for (b = 1; b <= y; b++)
                    {
                        for (b = 2; b <= y; b++)
                        {
                            
                            Console.Write("#");
                        }
                        
                        Console.Write("#");
                    }
                    
                    Console.Write("*");
                }
                
                Console.WriteLine(" *######");
            }
            Console.WriteLine();

            int value = Startgame();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Karma: {Data.Karma}");
            Console.WriteLine($"Värmenivå: {Data.Warmth}");
            Console.WriteLine($"Rum Nr: {Data.Room}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
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


      

        private static int Startgame()
        {
            
            Console.Write("Välkommen till "); Console.ForegroundColor = ConsoleColor.Green;           
            Console.Write(" Academud, A part of Academud Work."); Console.ForegroundColor = ConsoleColor.Gray;      
            Console.Write(" Här tror vi på ett growth mudset.");
            Console.WriteLine("\n\nKlicka på valfri knapp för att börja spela");
            Console.ReadKey();
           
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
            Console.Clear();
            
            if (value == 1)
            {
                Console.WriteLine("*Ring* *Ring* Detta är United Spaces du pratar med Eva.\n");
                Console.WriteLine("Du svarar: ");
                Console.WriteLine("1. Jag jobbar för Academud!");
                Console.WriteLine("2. Släpp in mig jag är 2 minuter sen");
                Console.WriteLine("3. En falafel stal min måsrulle!");

                int svar2 = int.Parse(Console.ReadLine());
                if (svar2 == 1 || svar2 == 2 || svar2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("'Och hur var namnet?' Frågar Eva. \n");
                    Console.Write("- Mitt namn är ");
                    Data.Playername = Console.ReadLine();
                    Console.WriteLine("Tack, du är välkommen in!");
                }
            }
            if (value == 2)
            {
                Console.WriteLine("Du står i regnet och väntar ivrigt på att någon skall öppna den nedrans dörren.");
                Console.WriteLine("En äldre herre dyker upp från tomma intet och brister ut 'Dig har jag aldrig sett här förr, vad heter du?\n ");
                Console.Write("- Mitt namn är ");
                    Data.Playername = Console.ReadLine();
                Console.WriteLine("Ah nej jag pratade inte med dig säger herren och går vidare.");
                Console.ReadKey();

            }
            if (value == 3)
            {
                string tos;
                Console.WriteLine("Jag tar fram min telefon, en IPhone vars batteri håller på att ta slut fastän jag laddade den hela natten.");
                Console.WriteLine("Appstore ber mig att acceptera deras nya ToS.\n");
                Console.WriteLine("Vill du läsa hela Appstores ToS? (y/n)");
                tos = Console.ReadLine();
                string tos2 = tos.Trim().ToLower();
                if (tos2 == "y")
                {
                    string tosm = WriteoutTOS();
                    Console.WriteLine(tosm);
                    Console.ReadLine();

                }
                Console.Clear();
                Console.WriteLine("Du accepterar snällt Apples nya ToS och installerar ParaKey.");
                Console.WriteLine("Nu har du installerat ParaKey-appen och appen dig om ett namn.\n");
                Console.Write("Mitt namn är ");
                Data.Playername = Console.ReadLine();
                Console.WriteLine("Appen svarar snällt tillbaka att du är välkommen in.");
                Console.ReadKey();
            }


            Console.Clear();
            Console.WriteLine("Väl uppe i receptionen känner du doften av kaffe och vill genast hämta en kopp.");
            Console.WriteLine("'Oj, jag kanske borde hänga av mig jackan först' Tänker du.");
            Console.WriteLine("Vill du hänga av dig jackan? (y/n)");
            string jacka = Console.ReadLine();
            string jackasvar = jacka.Trim().ToLower();
            if (jackasvar == "y")
            {
                Console.Clear();
                Console.WriteLine("Du går och hänger av dig jackan, 'skönt' tänker du då det är väldigt varmt här inne.");
                Data.Warmth = 0;
            }
            if (jackasvar == "n")
            {
                Console.Clear();
                Console.WriteLine("Med jackan på rusar du genast till kaffemaskinen. 'Herregud va varmt det är.' tänker du.");
                Data.Warmth = 1;
                Console.WriteLine($"Din värmenivå är nu: {Data.Warmth}");
                
            }







                int svar = int.Parse(Console.ReadLine());     
            return svar;

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









        private static string WriteoutTOS()
        {
            string tos = "1. Relationship With Apple; Apple ID and Password. You understand and agree that by registering with Apple to become an Apple Developer Apple Developer, no legal partnership or agency relationship is created between you and Apple.You agree not to represent otherwise. You also certify that you are at least thirteen years of age and you represent that you are legally permitted to register as an Apple Developer. This Agreement is void where prohibited by law and the right to register as an Apple Developer is not granted in such jurisdictions. Unless otherwise agreed or permitted by Apple in writing, you cannot share or transfer any benefits you receive from Apple in connection with being an Apple Developer. The Apple ID and password you use to log into your Apple Developer account cannot be shared in any way or with anyone.You are responsible for maintaining the confidentiality of your Apple ID and password and for any activity in connection with your account.\n Har du förstått? (y)";

            return tos;
        }
    }
}
