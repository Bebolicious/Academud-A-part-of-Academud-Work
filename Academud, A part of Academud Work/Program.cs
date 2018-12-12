using System;

namespace Academud__A_part_of_Academud_Work
{
    public class Program
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
           Reception(value); 
           

           
            value = Classroom1();
            Break();
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

        private static void Reception(int value)
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


               
            

            //Kalla Jacketon(); om användare väljer att ej hänga av sig jackan.  (Data.Warmth är värdet för hettan)
        }
        private static int Classroom1()
        {
            int svar;
            Console.Write("Du traskar in till BEIJING 1 och slår dig ner vid ett av de rosenröda skrivborden. Bredvid dig sitter: ");
            Data.ClassMate = Console.ReadLine();
            Console.WriteLine();

            if (Data.Playername == Data.ClassMate)
            {
                Console.WriteLine("Okej. Du sitter alltså bredvid dig själv. Inget konstigt med det alls. ");
            }
            else if (Data.ClassMate == "Georg")
            {
                Console.WriteLine("Du är nog lite morgontrött, för plötsligt inser du att stolen är tom och att Georg som alltid håller tiden är lite försenad.");
                Console.WriteLine("Ett par minuter efter 9 kommer dock Georg och sätter sig bredvid just dig!");
            }
            else if (Data.ClassMate == "KG" || Data.ClassMate == "Karl")
                Console.WriteLine("Du noterar att KG med spjutspetsprecision håller på att väga kaffebönor på sin medtagna minivåg, det hela ser mycker rofyllt ut.");
            else if (Data.ClassMate == "Erik")
                Console.WriteLine();
            else if (Data.ClassMate == "Oscar")
                Console.WriteLine();
            else if (Data.ClassMate == "Rebecka")
                Console.WriteLine("Rebecka sitter och spanar på sina intet anande hundar live i mobilen och klurar på om Yoshi slutligen lyckats ta en kråka.");
            else if (Data.ClassMate == "Sara")
                Console.WriteLine();
            else if (Data.ClassMate == "Rikard")
                Console.WriteLine("Rikard sitter som vanligt i strumplästen och sippar på kaffe. Det ser knappast seriöst ut.");
            else if (Data.ClassMate == "Elin")
                Console.WriteLine("Elin ber om ursäkt för kommande frågor och du tänker att de nog kommer snart.");
            else if (Data.ClassMate == "Erika")
                Console.WriteLine();
            else if (Data.ClassMate == "Tobias")
                Console.WriteLine();
            else if (Data.ClassMate == "Jonathan")
                Console.WriteLine();
            else if (Data.ClassMate == "Magnus")
                Console.WriteLine("Magnus är redan i full gång med kodandet. Han håller på att utveckla något nytt operativsystem. Inget märkvärdigt alls.");
            else if (Data.ClassMate == "Heidi")
                Console.WriteLine();
            else if (Data.ClassMate == "Olof")
                Console.WriteLine("Olof ser lite butter ut och när du frågor honom om det muttrar han något om Tottenham och hur mycket fotboll suger ibland. ");
            else if (Data.ClassMate == "Alexander")
                Console.WriteLine("Alexander sitter i vanlig ordning med hörlurarna på och lyssnar på egenkomponerad blip-blop.");

            Console.WriteLine();
            Console.WriteLine("Dagen börjar i vanlig ordning med att Oscar kör en kort genomgång och att ingen, märkligt nog, har några frågor på kommande uppgift. ");
            Console.WriteLine($"I slutet av timmen avslutar Oscar med en kluring att återvända till efter rasten: Vilken variabeltyp är den sparsammaste vi kan använda?\n");
            Console.WriteLine($"{Data.ClassMate} skruvar lite på sig. Hur tar du dig an kluringen? ");
            Console.WriteLine("1. Du kan svaret och tänker inte mer på det - dags för rast! ");
            Console.WriteLine($"2. Du börjar klura tillsammans med din vapendragare {Data.ClassMate} innan ni sticker på rast.");
            svar = int.Parse(Console.ReadLine());

            if (svar == 1)
            {
                Data.Karma--;
            }
            else
                Data.Karma++;

            return svar;
        }

        private static void Break()
        {
            Console.WriteLine($"{Data.Playername}, du måste ta rast!\n Jaså, du 'ska bara'....? Men pingis då?\n");
            Console.Write("1. Pingis! Rundpingis! All pingis! ");

            if (Data.Playername != "Magnus")
            {
                Console.WriteLine("Snabbt, så du får Magnus super-rack!");
            }
            else
            {
                Console.WriteLine("Snabbt, innan någon tar ditt super-rack!");
            }

            Console.WriteLine("2. Se på pingis - det är ju kul att se när andra har kul...");
            Console.WriteLine("3. Sitt kvar och var väldigt väldigt tråkig\n");

            do
            {
                Console.WriteLine("Ditt val:\n");
                int svar = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();


                if (svar == 1)
                {
                    if (Data.Jacket == true)
                    {
                        Console.WriteLine("Nu spelar du alltså pingis med jackan på. Svetten rinner, du luktar och är långt ifrån 'Business Casual'. Korkat.");
                        Data.Warmth++;
                    }
                    else
                    {
                        Console.WriteLine($"Äh, forehanden är inte riktigt med idag. Ändå har du tagit dig till final mot {Data.ClassMate}.\n Serven är gjord och det är sudden death! Vilken kombination av slag tror du tar dig vinnande ur bataljen?");
                        Console.WriteLine("Ange '1' för forehand, '2' för backhand. För att vinna ska summan av dina val över 5 slag vara 8.\n");

                        int counter = 0;

                        for (int i = 1; i <= 5; i++)
                        {
                            Console.Write($"Slag {i}: ");
                            int slagPingis = int.Parse(Console.ReadLine());
                            counter += slagPingis;
                        }

                        Console.ReadKey();
                        Console.Clear();

                        if (counter == 8)
                        {
                            Console.WriteLine($"WOHO! Grattis till vinsten. Du krossa {Data.ClassMate}!");
                        }

                        else
                        {
                            Console.WriteLine($"NEJ! {Data.ClassMate} krossa dig! Nyligen klådd - kan du samla dig och vara en bra förlorare? (y/n)");
                            string svarFörlorare = Console.ReadLine();

                            if (svarFörlorare == "y")
                            {
                                Console.WriteLine("Du skakar hand och öser beröm över din motståndare! Vilket spel! Glatt traskar ni arm i arm tillbaka till klassrummet.\n");
                                Data.Karma++;
                            }
                            else
                            {
                                Console.WriteLine("Besvikelsen går inte att kontrollera! Du slår racket i bordet och ropar ett par mindre väl valda svordomar. Usch så pinsamt att förstöra stämningen nu när ni ska tillbaka till klassrummet.\n");
                                Data.Karma--;
                            }
                        }

                    }

                    Console.ReadKey();
                    Console.Clear();

                    break;
                }

                else if (svar == 2)
                {
                    Console.WriteLine("På vägen ut stoppas du av Eva från receptionen: 'Något verkar krångla med din Parakey - Minns du ditt lösenord?'");
                    Console.WriteLine("Hmmm, var det inte något med ditt namn plus den senaste siffran du angav här i spelet?\n");

                    string svarString = svar.ToString();
                    string password = Data.Playername + svarString;
                    string input;

                    do
                    {
                        Console.WriteLine("Ange lösenord:");
                        input = Console.ReadLine();

                    } while (input != password);

                    Console.WriteLine();
                    Console.WriteLine("Äntlitgen klar! Och rasten är slut.......jahopp.");

                    Console.ReadKey();
                    Console.Clear();

                    break;
                }

                else if (svar == 3)
                {
                    Console.WriteLine($"{Data.ClassMate} drar med dig ändå! Välj 1 eller 2!");
                }

                else
                {
                    Console.WriteLine("Tyvärr har du bara dessa alternativ! Kom igen och välj!");
                }

            } while (true);
        }

        private static int Classroom2(int value)
        {
            int svar;
            Console.WriteLine("Åter i klassrummet tittar Oscar finurligt och förväntansfullt ut mot klassen.");
            Console.WriteLine($"-Är det någon som vågar gissa på min kluring? {Data.Playername} kanske? Vilken är den sparsammaste variabeln?");

            if (value == 1)
            {
                Console.WriteLine("1. Det sanna svaret är bool!");
                Console.WriteLine("2. Decimal, de kan ju ha supersmå tal!");
                Console.WriteLine("3. Eh, jag var helt säker på svaret men drabbades av minnesförlust under rasten...");
                svar = int.Parse(Console.ReadLine());
                Console.WriteLine("Det var dessvärre fel, det otroligt roliga svaret är INTE-GER! Fattar ni? Hehehehe!");
            }

            else
            {
                Console.WriteLine("1. Yep! Helt på egen hand förstod jag att det var en ordvits! INTE-GER!");
                Console.WriteLine($"2. Du är en rolig göbbe du! Jag och {Data.ClassMate} löste det tillsammans, det är ju en INTE-GER!");
                svar = int.Parse(Console.ReadLine());
                Console.WriteLine("Helt korrekt fnissar Oscar! ");
                if (svar == 1)
                {
                    Console.WriteLine($"{Data.ClassMate} ger dig en kylig blick och du skäms lite för att du tog åt dig äran själv.");
                    Data.Karma--;
                }
                else
                {
                    Console.WriteLine($"{Data.ClassMate} ger dig en high five och du tänker att det är jäkla käckt med peer-to-peer!");
                    Data.Karma++;
                }

             }

            return svar;
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
