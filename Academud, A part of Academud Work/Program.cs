using System;

namespace Academud__A_part_of_Academud_Work
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Data data = new Data();
            Data.Karma = 0;
            // Värmecounter ??? Skapa värde för värmen genom Data.Warmth
            // Karma värde ???
            // Rumsnamn/värde ???


            int value = Startgame();
            value = Reception(value);
            value = Classroom1();
            Break();
            value = Classroom2(value);
            value = Lunch(value);
            value = Project(value);
            value = Event(value);
            value = Citystroll(value);
            value = Endgame(value);


            Oscar();

            Gameover();

        }

        private static void Oscar()
        {
            Data.FavoritColor = "blue";
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
            throw new NotImplementedException();
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
    }
}
