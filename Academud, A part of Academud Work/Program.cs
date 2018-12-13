using System;


namespace Academud__A_part_of_Academud_Work
{
    public class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0, j = 0; i < 20001; i++, j++)
            {

                int top = Console.CursorTop;
                int left = Console.CursorLeft;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("BOOTING UP ACADEMUD : {0}%", i, j);

            }
            Console.Clear();

            int value = Startgame();
            Reception(value);
            value = Classroom1();
            Break();
            value = Classroom2(value);
            Lunch(value);
            Project();
            Event();
            value = Citystroll();
            Endgame(value);
            Gameover();
        }



        private static void Printstats()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Academud                               Karma: {Data.Karma}                                Warmth: {Data.Warmth} ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        private static int Startgame()
        {

            Console.Write("Välkommen till "); Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Academud";
            string title = @"
                                     ,,                                            ,,  
      db                           `7MM                                          `7MM  
     ;MM:                            MM                                            MM  
    ,V^MM.    ,p6'bo   ,6'Yb.   ,M''bMM  .gP'Ya   MMpMMMb.pMMMb.  7M    7M    ,M''bMM
   ,M  `MM   6M'  OO  8)   MM ,AP    MM ,M'   Yb  MM    MM    MM  MM    AM  MM     MM
   mmmq  MA  8M      ,pm   8M  MM    8M 'm MM MM  MM    MM    MM  8M    MM  MM     MM
  A'     VML YM.    , 8M   MM `Mb    MM YM.    ,  MM    MM    MM  MM    MM  `Mb    MM  
.AMA.   .AMMA.YMbmd'  `Moo9^Yo.`Wbmd'MML `Mbmmd'  MML   MML   MML  Mbod'YML.   Wmd'MML";
            Console.WriteLine(title);
            Console.WriteLine("_______________________________________________________________________________________ ");
            Console.Write("                                                               A part of Academud Work.");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write("\n'Här tror vi på ett growth mudset.'");
            Console.WriteLine("\n\nKlicka på valfri knapp för att börja spela");
            Console.ReadKey();


            Console.Clear();
            Data.Room = "Startup";
            Printstats();


            Console.Write("Det är en vanlig dag i innerstaden Göteborg, det regnar snett underifrån och du befinner dig utanför Östra Hamngatan 16.");
            Console.WriteLine("Dörren in till United Spaces tillika ditt andra hem är dessvärre låst, hur skall du ta dig in?\n");
            Console.WriteLine("1. Ring upp till receptionen via porttelefonen.");
            Console.WriteLine("2. Stå och vänta i regnet på att någon skall släppa in dig, gud va pinsamt.");
            Console.WriteLine("3. Installera ParaKey-appen på din allt för gamla smartphone med risk för vattenskada pga regnet.\n");
            Console.WriteLine(">");
            int svar = int.Parse(Console.ReadLine());


            return svar;



        }

        private static void Reception(int value)
        {
            Data.Room = "Receptionen";
            Console.Clear();
            Printstats();
            if (value == 1)
            {
                Console.WriteLine("*Ring* *Ring* Detta är United Spaces du pratar med Eva.\n");
                Console.WriteLine("Du svarar: ");
                Console.WriteLine("1. Jag jobbar för Academud!");
                Console.WriteLine("2. Släpp in mig jag är 2 minuter sen.");
                Console.WriteLine("3. En falafel stal min måsrulle!");
                Console.WriteLine(">");

                int svar2 = int.Parse(Console.ReadLine());
                if (svar2 == 1 || svar2 == 2 || svar2 == 3)
                {
                    Console.Clear();
                    Printstats();
                    Console.WriteLine("'Och hur var namnet?' Frågar Eva. \n");
                    Console.Write("- Mitt namn är ");
                    Data.Playername = Console.ReadLine();
                    Console.WriteLine("Tack, du är välkommen in! ");
                }
            }
            if (value == 2)
            {
                Console.WriteLine("Du står i regnet och väntar ivrigt på att någon skall öppna den nedrans dörren.");
                Console.WriteLine("En äldre herre dyker upp från tomma intet och brister ut 'Dig har jag aldrig sett här förr, vad heter du?\n ");
                Console.Write("Mitt namn är ");
                Data.Playername = Console.ReadLine();
                Console.WriteLine("- Ah nej jag pratade inte med dig säger herren och går vidare.");
                Console.ReadKey();

            }
            if (value == 3)
            {
                string tos;
                Console.WriteLine("Du tar fram din telefon, en IPhone vars batteri håller på att ta slut fastän jag laddade den hela natten.");
                Console.WriteLine("Appstore ber dig att acceptera deras nya ToS.\n");
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
                Printstats();
                Console.WriteLine("Du accepterar snällt Apples nya ToS och installerar ParaKey.");
                Console.WriteLine("Nu har du installerat ParaKey-appen och appen ber dig om ett namn.\n");
                Console.Write("Mitt namn är ");
                Data.Playername = Console.ReadLine();
                Console.WriteLine("Appen svarar snällt tillbaka att du är välkommen in.");
                Console.ReadKey();
            }


            Console.Clear();
            Printstats();
            Console.WriteLine("Väl uppe i receptionen känner du doften av kaffe och vill genast hämta en kopp.");
            Console.WriteLine("'Oj, jag kanske borde hänga av mig jackan först' Tänker du.");
            Console.WriteLine("\nVill du hänga av dig jackan?");
            Console.WriteLine("1. Ja");
            Console.WriteLine("2. Nej");
            string jacka = Console.ReadLine();
            string jackasvar = jacka.Trim().ToLower();
            if (jackasvar == "1")
            {
                Console.Clear();
                Printstats();
                Console.WriteLine("Du går och hänger av dig jackan, 'skönt' tänker du då det är väldigt varmt här inne.");
                Data.Warmth = 0;
                Data.Jacket = false;
                Console.ReadKey();
                Console.Clear();
                Printstats();
            }
            if (jackasvar == "2")
            {
                Console.Clear();
                Printstats();
                Console.WriteLine("Med jackan på rusar du genast till kaffemaskinen. 'Herregud va varmt det är.' tänker du.");
                Data.Warmth = 1;
                Data.Jacket = true;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nDin värmenivå har ökat.");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
                Printstats();
            }

            if (Data.Warmth == 1)
            {
                Console.WriteLine("Halvvägs till klassrummet kommer du på att du glömt vilken dag det är.");
            }
            else
            {
                Console.WriteLine("På väg mot klassrummet så funderar du på vad som kommer att hända idag.");
                Console.WriteLine("Detta kan vara svårt iom. att du inte vet vilken dag det är.\n");
            }

            Console.WriteLine("Du kollar på din kalender och ser att idag är en:\n ");
            Console.WriteLine("1. Måndag");
            Console.WriteLine("2. Onsdag");
            Console.Write(">");
            int dagsval = int.Parse(Console.ReadLine());
            if (dagsval == 1)
            {
                Data.Day = "måndag";
            }
            else
            {
                Data.Day = "onsdag";
            }


        }
        private static int Classroom1()
        {
            Console.Clear();
            Printstats();
            int svar;
            Console.WriteLine("Du traskar in till BEIJING 1 och slår dig ner vid ett av de rosenröda skrivborden.");
            Console.Write("Bredvid dig sitter: ");
            Data.ClassMate = Console.ReadLine();
            Console.WriteLine();

            if (Data.Playername == Data.ClassMate)
            {
                Console.WriteLine("Okej. Du sitter alltså bredvid dig själv. Inget konstigt med det alls. ");
            }
            else if (Data.ClassMate == "Georg" || Data.ClassMate == "George")
            {
                Console.WriteLine($"Du är nog lite morgontrött, för plötsligt inser du att stolen är tom och att {Data.ClassMate} som alltid håller tiden är lite försenad.");
                Console.WriteLine($"Ett par minuter efter 9 kommer dock {Data.ClassMate} och sätter sig bredvid just dig!");
            }
            else if (Data.ClassMate == "KG" || Data.ClassMate == "Karl")
                Console.WriteLine($"Du noterar att {Data.ClassMate} med spjutspetsprecision håller på att väga kaffebönor på sin medtagna minivåg, det hela ser mycker rofyllt ut.");
            else if (Data.ClassMate == "Erik" || Data.ClassMate == "Eric")
                Console.WriteLine($"{Data.ClassMate} möter dig med en vänlig nick och informerar om att han har full koll på ventilationen i rummet. En gång vakt alltid vakt?");
            else if (Data.ClassMate == "Oscar" || Data.ClassMate == "Oskar")
                Console.WriteLine($"{Data.ClassMate} hälsar dig på det ödmjuka sätt som bara en person som pysslat med återvinningsföretagande kan. ");
            else if (Data.ClassMate == "Rebecka" || Data.ClassMate == "Rebecha" || Data.ClassMate == "Rebecca" || Data.ClassMate == "Rebekka")
                Console.WriteLine($"{Data.ClassMate} sitter och spanar på sina intet anande hundar live i mobilen och klurar på om Yoshi slutligen lyckats ta en kråka.");
            else if (Data.ClassMate == "Sara" || Data.ClassMate == "Sarah" || Data.ClassMate == "Zara")
                Console.WriteLine($"Du tittar dig lite försiktigt omkring så att {Data.ClassMate}s vapendragare Heidi inte sitter och blänger på dig för att du tagit hennes givna plats.");
            else if (Data.ClassMate == "Rikard" || Data.ClassMate == "Rickard" || Data.ClassMate == "Richard")
                Console.WriteLine($"{Data.ClassMate} sitter som vanligt i strumplästen och sippar på kaffe. Det ser knappast seriöst ut.");
            else if (Data.ClassMate == "Elin")
                Console.WriteLine($"{Data.ClassMate} ber om ursäkt för kommande frågor och du tänker att de nog kommer snart.");
            else if (Data.ClassMate == "Erika" || Data.ClassMate == "Erica" || Data.ClassMate == "Ericka")
                Console.WriteLine($"Klassens huvudstadsrepresentant tillika världsvana utlandsstudent hälsar dig med ett glatt 'Ohayō gozaimasu!'");
            else if (Data.ClassMate == "Tobias" || Data.ClassMate == "Tobbe" || Data.ClassMate == "Tobbias")
                Console.WriteLine($"Det norrländska lugnet från den nu lika fullfjädrade bohuslänningen smittar av sig på dig. Det här blir en härlig dag!");
            else if (Data.ClassMate == "Jonathan" || Data.ClassMate == "Jonatan")
                Console.WriteLine($"Den klättrande kickboxarkillen som INTE har jobbat som lisebergskanin (yeah right!) hälsar dig morgonglatt!");
            else if (Data.ClassMate == "Magnus" || Data.ClassMate == "Mange")
                Console.WriteLine($"{Data.ClassMate} är redan i full gång med kodandet. Han håller på att utveckla något nytt operativsystem. Inget märkvärdigt alls.");
            else if (Data.ClassMate == "Heidi")
                Console.WriteLine($"Du tittar dig lite försiktigt omkring så att {Data.ClassMate}s vapendragare Sara inte sitter och blänger på dig för att du tagit hennes givna plats.");
            else if (Data.ClassMate == "Olof")
                Console.WriteLine($"{Data.ClassMate} ser lite butter ut och när du frågor honom om det muttrar han något om Tottenham och hur mycket fotboll suger ibland. ");
            else if (Data.ClassMate == "Alexander" || Data.ClassMate == "Alex")
                Console.WriteLine($"{Data.ClassMate} sitter i vanlig ordning med hörlurarna på och lyssnar på egenkomponerad blip-blop.");

            Console.WriteLine();
            Console.Write("Tryck på valfri knapp för att fortsätta");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Dagen börjar i vanlig ordning med att Oscar kör en kort genomgång och att ingen, märkligt nog, har några frågor på kommande uppgift. ");
            Console.WriteLine($"I slutet av timmen avslutar Oscar med en kluring att återvända till efter rasten: ");
            Console.WriteLine($"- Vilken variabeltyp är den sparsammaste vi kan använda?");
            Console.WriteLine($"{Data.ClassMate} skruvar lite på sig. Hur tar du dig an kluringen? ");
            Console.WriteLine("\n1. Du kan svaret och tänker inte mer på det - dags för rast! ");
            Console.WriteLine($"2. Du börjar klura tillsammans med din vapendragare {Data.ClassMate} innan ni sticker på rast.");
            Console.Write("> ");
            svar = int.Parse(Console.ReadLine());
            Console.WriteLine($"'Förresten {Data.Playername}', säger {Data.ClassMate}, 'kan du snälla påminna mig om min intervju jag har efter lunch?' ");
            Console.WriteLine("'Absolut! Jag påminner dig sedan!");

            if (svar == 1)
            {
                Data.Karma--;
            }
            else
                Data.Karma++;

            Console.ReadKey();
            Console.Clear();

            return svar;
        }

        private static void Break()
        {

            Data.Room = "Rast";

            Console.WriteLine($"Så många val! Vad vill du göra på rasten?");
            Console.WriteLine();
            Console.Write("1. Pingis! Rundpingis! Massa pingis! ");

            if (Data.Playername != "Magnus")
            {
                Console.WriteLine("Skynda dig så du får Magnus super-rack!");
            }
            else
            {
                Console.WriteLine("Skynda dig innan någon tar ditt super-rack!");
            }

            Console.WriteLine("2. Se på pingis - det är ju så kul att se när andra har kul...");
            Console.WriteLine("3. Sitt kvar och var väldigt väldigt tråkig\n");

            do
            {
                Console.WriteLine("Ditt val:");
                int svar = int.Parse(Console.ReadLine());

                Console.Clear();


                if (svar == 1)
                {
                    if (Data.Warmth == 1)
                    {
                        Console.WriteLine("Nu spelar du alltså pingis med jackan på. Svetten rinner, du luktar och är långt ifrån 'Business Casual'. Korkat.");
                        Data.Warmth++;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Din värmenivå har ökats.");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.ReadKey();
                        Console.Clear();

                    }


                    Console.WriteLine($"Äh, forehanden är inte riktigt med idag. Ändå har du tagit dig till final mot {Data.ClassMate}");
                    Console.WriteLine("Serven är gjord och det är sudden death!Vilken kombination av slag tror du tar dig vinnande ur bataljen?");
                    Console.WriteLine();
                    Console.WriteLine("Ange '1' för forehand, '2' för backhand. För att vinna ska summan av dina val över 5 slag vara 8.\n");

                    int counter = 0;

                    for (int i = 1; i <= 5; i++)
                    {
                        Console.Write($"Slag {i}: ");
                        int slagPingis = int.Parse(Console.ReadLine());
                        counter += slagPingis;
                    }

                    Console.Clear();

                    if (counter == 8)
                    {
                        Console.WriteLine($"WOHO! Grattis till vinsten. Du krossa {Data.ClassMate}!");
                        Console.WriteLine("Med stoltheten pumpande i bröstet - kan du samla dig och vara en bra vinnare? (y/n)?");
                        Console.WriteLine();
                        Console.WriteLine("1. Självfallet!");
                        Console.WriteLine("2. Nejnejnej, pingis är på är på liv och död!");
                        Console.WriteLine();
                        Console.WriteLine("Ditt val: ");
                        int svarVinnare = int.Parse(Console.ReadLine());
                        Console.ReadKey();
                        Console.Clear();


                        if (svarVinnare == 1)
                        {
                            Console.WriteLine("Du skakar hand och öser beröm över din motståndare! Vilket spel! Glatt traskar ni arm i arm tillbaka till klassrummet.\n");
                            Data.Karma++;
                            Console.WriteLine($"Din Karma-nivå är nu: {Data.Karma}");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Du slänger dig upp på bordet skrålandes 'Segern är MIN, segern är MIN!!!");
                            Console.WriteLine($"Glad i hågen klappar du {Data.ClassMate} på huvudet med orden 'Bättre lycka nästa gång - SUCKER!'");
                            Data.Karma--;
                            Console.WriteLine($"Din Karma-nivå är nu: {Data.Karma}");
                            Console.ReadKey();
                        }
                    }

                    else
                    {
                        Console.WriteLine($"NEJ! {Data.ClassMate} krossa dig!");
                        Console.WriteLine("Nyligen klådd - kan du samla dig och vara en bra förlorare?");
                        Console.WriteLine();
                        Console.WriteLine("1. Självfallet!");
                        Console.WriteLine("2. Nejnejnej, pingis är på liv och död!");
                        Console.WriteLine();
                        Console.WriteLine("Ditt val: ");
                        int svarFörlorare = int.Parse(Console.ReadLine());
                        Console.ReadKey();
                        Console.Clear();


                        Console.Clear();

                        if (svarFörlorare == 1)
                        {
                            Console.WriteLine("Du skakar hand och öser beröm över din motståndare! Vilket spel! Glatt traskar ni arm i arm tillbaka till klassrummet.\n");
                            Data.Karma++;
                            Console.WriteLine($"Din Karma-nivå är nu: {Data.Karma}");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Besvikelsen går inte att kontrollera! Du slår racket i bordet och ropar ett par mindre väl valda svordomar.");
                            Console.WriteLine(" Usch så pinsamt att förstöra stämningen nu när ni ska tillbaka till klassrummet.\n");
                            Data.Karma--;
                            Console.WriteLine($"Din Karma-nivå är nu: {Data.Karma}");
                            Console.ReadKey();
                        }
                    }



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
                    Console.WriteLine("Äntligen klar! Och samtidigt tog rasten är slut.......jahopp.");

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
            int svar = value;
            Console.WriteLine("Åter i klassrummet tittar Oscar finurligt och förväntansfullt ut mot klassen.");
            Console.WriteLine($"'Är det någon som vågar gissa på min kluring? {Data.Playername} kanske? Vilken är den sparsammaste variabeln?'");

            if (value == 1)
            {
                Console.WriteLine("1. Det sanna svaret är bool!");
                Console.WriteLine("2. Decimal, de kan ju ha supersmå tal!");
                Console.WriteLine("3. Eh, jag var helt säker på svaret men drabbades av minnesförlust under rasten...");
                Console.Write("> ");
                Console.ReadLine();
                Console.WriteLine("'Det var dessvärre fel, det otroligt roliga svaret är INTE-GER! Fattar ni? Hehehehe!'");
            }

            else
            {
                Console.WriteLine("1. Yep! Helt på egen hand förstod jag att det var en ordvits! INTE-GER!");
                Console.WriteLine($"2. Du är en rolig göbbe du! Jag och {Data.ClassMate} löste det tillsammans, det är ju en INTE-GER!");
                Console.Write("> ");
                svar = int.Parse(Console.ReadLine());
                Console.WriteLine("Helt korrekt fnissar Oscar! ");
                if (svar == 1)
                {
                    Console.WriteLine($"{Data.ClassMate} ger dig en kylig blick och du skäms lite för att du tog åt dig äran själv.");
                    Data.Karma--;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"{Data.ClassMate} ger dig en high five och du tänker att det är jäkla käckt med peer-to-peer!");
                    Data.Karma++;
                    Console.ReadLine();
                }

            }

            Console.WriteLine();
            Console.Write("Tryck på valfri knapp för att fortsätta");
            Console.ReadKey();
            Console.Clear();

            return svar;
        }

        private static void Lunch(int value)
        {

            Data.Room = "Lunch";

            Console.WriteLine("Du tittar upp precis när Songül kommer in i klassrummet");
            Console.WriteLine("'Hej allihop, alltså SÅ HIMLA roligt att vara här hos er! Nu blir det lunch med oss från Academud Work!");

            Console.WriteLine();
            Console.WriteLine("Tryck på valfri knapp för att fortsätt");
            Console.ReadKey();
            Console.Clear();

            if (value <= 1)
            {
                Console.WriteLine($"{Data.ClassMate} har, helt rimligt, ingen lust att sitta bredvid dig på lunchen");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Du får sitta ensam och skamsen med din sallad tills Songül förbarmar sig över dig");
            }
            else
            {
                Console.WriteLine($"Glada i hågen sätter ni er tillsammmans, du och {Data.ClassMate}");
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Songül delar ut era sallader och slår sig ner");
            }
            Console.WriteLine();
            Console.WriteLine("Hon vänder sig till dig 'Har du någon fundering såhär långt?'");
            Console.WriteLine();

            Console.WriteLine("1. Nej, jag är fullärd!");
            Console.WriteLine("2. Nej .....(men jag kommer fråga massor sen på mail)");
            if (Data.Jacket == true)
            {
                Console.WriteLine("3. Nej, men jag skulle vilja ta av mig jackan ändå. Det är ju inte speciellt konsultmässigt att att jag har den på!");
                Data.Jacket = false;
                Data.Warmth++;
            }

            Console.WriteLine();
            Console.WriteLine("Ditt val: ");
            int svarFundering = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            if (svarFundering <= 1)
            {
                Console.WriteLine($"'Ingen är fullärd! Growth mudset är viktigt, {Data.Playername}!'");
            }
            else
            {
                Console.WriteLine($"'Okej, men Growth mudset är viktigt, {Data.Playername}!'");
            }

            Console.WriteLine();
            Console.WriteLine("'Så nu blir det en litet kunskapstest om jobbsök via Academud!'");

            string[] frågor1 = new string[] { "Vad är mycket mycket viktigt?\n 1. Positivt mudset\n 2. Negativt mudset", "Vilken nivå ska du kolla?\n 1. Erfarenhetsnivån\n 2. Havsnivån", "Vad kallar vi Cinode för också?\n 1. Academud-CV\n 2. Epic-CV", "Vad är du anställd som?\n 1. Ambulerande tjänsteman\n 2. IT-konsult" };

            int poäng = 0;

            foreach (var item in frågor1)
            {
                Console.WriteLine(item);
                Console.WriteLine();
                Console.Write("Ditt val: ");
                int svarTest = int.Parse(Console.ReadLine());

                if (svarTest == 1)
                {
                    poäng++;
                }

                Console.Clear();
            }

            if (poäng > 2)
            {
                Console.WriteLine("'Bra jobbat! Nu är du redo att ta dig an IT-branchen!'");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {

                Console.WriteLine("'Nja, detta får du nog titta på i helgen!'");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("'Tack för lunchen! Nu tror jag minsann det är dags för projektarbete!'");
            Console.WriteLine();
            Console.WriteLine("Tryck på valfri knapp för att fortsätta");
            Console.ReadKey();
            Console.Clear();

        }




        private static void Project()
        {
            Console.WriteLine("Mätt som ett smäck är du nu tillbaks i klassrummet och det har blivit dags för klassen att dela in sig i projektgrupper. ");
            Console.WriteLine("Lärar-Oscar har radat upp ett gäng projektidéer och du anmäler dig först av alla till att göra ett coolt MUD-spel!");

            if (Data.Karma <= -2)
            {
                Console.WriteLine("Några 'klasskamrater' som först verkade lika taggade som du på MUD sänker sina händer och ångrar sig.");
                Console.WriteLine("När hela klassen satt upp sig på olika projekt är du fortfarande ensam på ditt projekt... vad är det med folk!?");
                Console.WriteLine("Till slut lyckas Oscar flytta över en klasskamrat från en annan överfull grupp, din något motvilliga projekt-kompis blir: ");
            }

            else if (Data.Karma >= -1 && Data.Karma < 2)
            {
                Console.WriteLine("När alla delat in sig i grupper har du en hyfsat motiverad projekt-kompis med dig i din grupp, det blev: ");
            }

            else
            {
                Console.WriteLine("Alla verkar vilja vara med i din grupp, det slutar med att Oscar får dela upp er i flera smågrupper. ");
                Console.WriteLine("Till slut blir ni två personer i din grupp, din exalterade projekt-kompis blir: ");
            }
            Data.ProjectBuddy = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Tryck på valfri knapp för att fortsätta");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Du och {Data.ProjectBuddy} letar upp ett fancy mötesrum som ni nog egentligen borde betalat för... men vad skulle kunna gå fel?");
            Console.WriteLine("När ni suttit och skrivit ett tag märker du att det är rätt varmt i rummet och dålig ventilation. ");
            Console.WriteLine("Vill du göra någonting åt det?");
            Console.Write("1. Ja");
            Console.Write("2. Nej, jag gillar värme och kass luft.");
            int svar = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (svar == 1)
            {
                Console.WriteLine("Vad vill du göra åt det?");
                Console.WriteLine();
                if (Data.Jacket == true)
                {
                    Console.WriteLine("1. Ta av dig jackan");
                    Console.WriteLine("2. Knappra på ventilationen med hjälp av meckapären på väggen");
                    Console.WriteLine("3. Tio armhävningar borde öka syreflödet");
                    int svar2 = int.Parse(Console.ReadLine());
                    if (svar2 == 1)
                    {
                        Console.WriteLine("Du tar av dig jackan. Skönt, du frågar dig varför du inte tänkt på det tidigare?");
                        Data.Warmth--;
                    }
                    else if (svar2 == 2)
                    {
                        Console.WriteLine("Med några simpla klick på väggapparaturen kickar ventilationen igång. Göttigt!");
                        Data.Warmth--;
                    }
                    else
                    {
                        Console.WriteLine("Du slänger dig ner på golvet och känner blodet pumpa runt i hela kroppen medan du göra din armhävningar.");
                        Console.WriteLine($"{Data.ProjectBuddy} kollar förvirrat på dig och svimfärdig inser du att det kanske inte var din bästa idé i livet.");
                        Data.Warmth += 2;
                    }
                }

                else
                {
                    Console.WriteLine("1. Knappra på ventilationen med hjälp av meckapären på väggen");
                    Console.WriteLine("2. Tio armhävningar borde öka syreflödet");
                    int svar2 = int.Parse(Console.ReadLine());
                    if (svar2 == 1)
                    {
                        Console.WriteLine("Med några simpla klick på väggapparaturen kickar ventilationen igång. Göttigt!");
                        Data.Warmth--;
                    }
                    else
                    {
                        Console.WriteLine("Du slänger dig ner på golvet och känner blodet pumpa runt i hela kroppen medan du göra din armhävningar.");
                        Console.WriteLine($"{Data.ProjectBuddy} kollar förvirrat på dig och svimfärdig inser du att det kanske inte var din bästa idé i livet.");
                        Data.Warmth += 2;
                    }
                }
            }

            else
            {
                Console.WriteLine("Ooookej.... du fortsätter att andas in den bedrövliga luften och känner hur huvudet börjar dunka. Det har nog inget samband.");
                Data.Warmth++;
            }

            Console.WriteLine();
            Console.Write("Tryck på valfri knapp för att fortsätta");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Efter hårt arbete har det åter blivit dags för rast. När du tittar på {Data.ClassMate} i korridoren känns det som att du glömt någonting: ");
            Console.WriteLine($"1. Du börjar prata med {Data.ClassMate} om serien du såg på Netflix igår kväll!");
            Console.WriteLine($"2. Du påminner {Data.ClassMate} om att hen måste skynda sig till sin intervju!");
            svar = int.Parse(Console.ReadLine());
            if (svar == 1)
            {
                Data.Karma--;
            }
            else
            {
                Data.Karma++;
            }

            Console.WriteLine();
            Console.Write("Tryck på valfri knapp för att fortsätta");
            Console.ReadKey();
            Console.Clear();

        }

        private static void Event()
        {
            string dagsevent;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Klockan slog precis över till 14.00 och du grubblar över vad United Spaces bjuder på idag.");
            if (Data.Day == "måndag")
            {
                Console.WriteLine($"Det slår dig att det är {Data.Day} och det bjuds på fruitbowl i receptionen");
                Console.WriteLine("'Frukt, hur kul e de?' Tänker du för dig själv.");
                dagsevent = "fruitbowl";
            }
            else
            {

                Console.WriteLine($"Det slår dig att det är {Data.Day} och att det är Sugar Rush i receptionen");
                dagsevent = "sugar rush";


            }


            Random r = new Random();

            int val = r.Next(1, 100);
            int guess = 0;
            bool correct = false;

            Console.WriteLine("Du stöter på Eva vid receptionen som säger");
            Console.WriteLine($"\n-För att få ta del av {dagsevent}en så måste du gissa rätt nummer (Mellan 1-100)");

            while (!correct)
            {
                Console.Write("Gissning: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }

                if (guess < val)
                {
                    Console.WriteLine($"-Nix, siffran Eva tänker på är högre än: {guess}.  Kom igen nu {Data.Playername}.");
                }
                else if (guess > val)
                {
                    Console.WriteLine($"-Lägre än {guess} kan du!");
                }
                else
                {
                    correct = true;
                    Console.WriteLine($"-Bra jobbat {Data.Playername}, rätt svar var: {val}.");
                }

            }
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"{Data.ClassMate} ber dig hämta godis till er båda, vad gör du?\n");

            Console.WriteLine($"1. Hämta godis så att det räcker till både dig och {Data.ClassMate}.");
            Console.WriteLine($"2. {Data.ClassMate} kan gott få hämta sitt godis själv, tänker du.");
            if (Data.Jacket == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("[Dialogval upplåst] ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("3. Med tanke på att du fortfarande har jackan på dig så bestämmer du dig för att inte hämta godis alls och istället hänga av dig jackan.");
            }

            int svar = int.Parse(Console.ReadLine());

            if (svar == 1)
            {
                Data.Karma++;
            }
            else if (svar == 3)
            {
                Data.Warmth--;
                Data.Karma--;
                Data.Karma--;

            }
            else
            {
                Data.Karma--;
            }

        }

        private static int Citystroll()
        {
            Console.WriteLine("'Vilka ska med på promenad' Säger Oscar. Ska du med?\n");
            Console.WriteLine("1. Nej, jag ska bara titta liiiite till på en uppgift här.");
            Console.WriteLine("2. Ja, absolut! Känner mig ovanligt hurtfrisk, faktiskt!");

            Console.WriteLine();
            Console.WriteLine("Ditt val: ");
            int svarPromenad = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            if (svarPromenad == 1)
            {
                Console.WriteLine("'Nähä....det ser ut som att jag blir ensam då...' Säger Oscar och lämnar surmulet rummet.");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("'Vad roligt, då går vi mot kapprummet'!\n");
                Console.WriteLine();
                Console.WriteLine("1. Nej, jag behöver ingen jacka");
                Console.WriteLine("2. Ja, jacka är bra i det kyliga vädret!");

                Console.WriteLine();
                Console.WriteLine("Ditt val: ");
                int svarJacka = int.Parse(Console.ReadLine());
                Console.ReadKey();
                Console.Clear();

                if (Data.Jacket == true)
                {
                    Console.WriteLine("Suck.....");
                    Console.WriteLine("Nu har du två jackor på dig och ser ut som en idiot.");
                    Console.WriteLine("På Academud har vi mycket höga krav och du är tyvärr rökt.");
                    Console.WriteLine();
                    Console.ReadKey();
                    Gameover();
                }
                else if (Data.Warmth > 3)
                {
                    Console.WriteLine("OjOjOj");
                    Console.WriteLine("Du blir varm av promenaden");
                    Data.Warmth++;
                    Console.WriteLine();
                    Console.WriteLine($"Din värmenivå är nu: {Data.Warmth}");
                    Console.WriteLine();
                    Console.ReadKey();
                    Gameover();
                }
            }


            return svarPromenad;

        }

        private static void Endgame(int value)
        {
            int svar;
            if (value == 1)
            {
                Console.WriteLine("Oscar samlar åter klassen för att avsluta dagen tillsammans i klassrummet.");
                Console.WriteLine("'Det var härligt med lite luft! Hoppas det har gått bra med era projekt idag' säger Oscar.");

                Console.WriteLine();
                Console.Write("Tryck på valfri knapp för att fortsätta");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("'Det sista ni ska göra idag är att lösa en uppgift utan era datorer. Jag vill veta vilken output följande kod ger: '");
                Console.WriteLine(@"int[] a = { 10, 20, 30, 40, 50, 80 };\n
                Console.WriteLine(a[-1])");
                Console.WriteLine();
                Console.WriteLine("1. Den skriver ut 0");
                Console.WriteLine("2. Den skriver ut -10");
                Console.WriteLine("3. Den skriver ut 80");
                Console.WriteLine("4. Ingenting, det blir en exception");
                svar = int.Parse(Console.ReadLine());
                if (svar != 4)
                {
                    Console.WriteLine("Fel! Rätt svar var att det blir en exception. Det finns inget minusvärde i arrayen.");
                    Gameover();
                }
                else
                {
                    Console.WriteLine("Rätt svar! Härligt! Det finns inget minusvärde i arrayen, så det blir givetvis en exception.");
                    Console.WriteLine();
                    Console.WriteLine("Du har klarat Academud!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@" /$$$$$$$$/ $$                                                  /$$");
                    Console.WriteLine(@"|__  $$__/| $$                                                 | $$");
                    Console.WriteLine(@"   | $$   | $$$$$$$   /$$$$$$         /$$$$$$   /$$$$$$$   /$$$$$$$");
                    Console.WriteLine(@"   | $$   | $$__  $$ /$$__  $$       /$$__  $$ | $$__  $$ /$$__  $$");
                    Console.WriteLine(@"   | $$   | $$  \ $$| $$$$$$$$      | $$$$$$$$ | $$  \ $$| $$  | $$");
                    Console.WriteLine(@"   | $$   | $$  | $$| $$_____ /     | $$_____ /| $$  | $$| $$  | $$");
                    Console.WriteLine(@"   | $$   | $$  | $$|  $$$$$$$      |  $$$$$$$ | $$  | $$|  $$$$$$$");
                    Console.WriteLine(@"   |__/   |__/  |__/ \_______ /      \_______ /|__/  |__/ \_______/");

                }
            }

            else
            {
                Console.WriteLine("Klassen samlas åter i klassrummet för att runda av dagen tillsammans.");
                Console.WriteLine("Oscar kommer instormandes sist av alla och ser ut att vilja ha sönder någonting.");
                Console.WriteLine("Lite bekymrat frågar du om det har hänt någonting.");
                Console.WriteLine("'DET HADE FOLK VETAT OM IFALL NÅGON HADE FÖLJT MED MIG PÅ PROMENADEN!' gormar Oscar bestört.");
                Console.WriteLine("Det visar sig att måsarna har varit framme igen. Den här gången har de norpat Oscars mössa.");
                Console.WriteLine("'DET HADE ALDRIG HÄNT OM VI VARIT EN GRUPP!' menar Oscar sårat och kastar av sig jackan.");
                Console.WriteLine("Oscar samlar sig under en stund innan han lugnt, men med något mörkt i blicken, fortsätter: ");
                Console.WriteLine("'Vi ska avsluta dagen med en uppgift. Inga datorer tillåtna! Jag vill veta vad följande kod ger för output: '");

                Console.WriteLine();
                Console.Write("Tryck på valfri knapp för att fortsätta");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine(@"char A = 'P';\n
                char B = Convert.ToChar(76);\n
                A++;\n
                B++;\n
                Console.WriteLine(A + '  ' + B);");
                if (Data.Karma >= 3)
                {
                    Console.WriteLine("1. V R");
                    Console.WriteLine("2. O K");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[Dialogval upplåst]");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("3. Q M ");

                }

                else if (Data.Karma >= 0 && Data.Karma < 3)
                {
                    Console.WriteLine("1. V R");
                    Console.WriteLine("2. O K");
                    Console.WriteLine("3. Q M");
                    Console.WriteLine("4. A B76");
                }
                else
                {
                    Console.WriteLine("1. V R");
                    Console.WriteLine("2. O K");
                    Console.WriteLine("3. Q M");
                    Console.WriteLine("4. A B76");
                    Console.WriteLine("5. I E");
                }

                svar = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (svar != 3)
                {
                    Console.WriteLine("Oscar skakar suckande på huvudet.");
                    Console.WriteLine("'Med lite friskt syre i kroppen hade du kanske löst uppgiften.'");
                    Gameover();
                }
                else
                {
                    Console.WriteLine("Oscar kollar förvånat på dig när du uppger korrekt svar.");
                    Console.WriteLine("'Det var verkligen överraskande bra... ni lär er ju i en rasande takt!'");
                    Console.WriteLine("'Kom ihåg karma, det är nyckeln till framgång här på Academud!'");
                    Console.WriteLine();
                    Console.WriteLine("Du har klarat Academud!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@" /$$$$$$$$/ $$                                                  /$$");
                    Console.WriteLine(@"|__  $$__/| $$                                                 | $$");
                    Console.WriteLine(@"   | $$   | $$$$$$$   /$$$$$$         /$$$$$$   /$$$$$$$   /$$$$$$$");
                    Console.WriteLine(@"   | $$   | $$__  $$ /$$__  $$       /$$__  $$ | $$__  $$ /$$__  $$");
                    Console.WriteLine(@"   | $$   | $$  \ $$| $$$$$$$$      | $$$$$$$$ | $$  \ $$| $$  | $$");
                    Console.WriteLine(@"   | $$   | $$  | $$| $$_____ /     | $$_____ /| $$  | $$| $$  | $$");
                    Console.WriteLine(@"   | $$   | $$  | $$|  $$$$$$$      |  $$$$$$$ | $$  | $$|  $$$$$$$");
                    Console.WriteLine(@"   |__/   |__/  |__/ \_______ /      \_______ /|__/  |__/ \_______/");
                }

            }
        }

        private static void Gameover()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"  /$$$$$$                                                                                    /$$");
            Console.WriteLine(@" /$$__  $$                                                                                  | $$");
            Console.WriteLine(@"| $$  \__ /  /$$$$$$  /$$$$$$/$$$$   /$$$$$$         /$$$$$$  /$$    /$$ /$$$$$$    /$$$$$$ | $$");
            Console.WriteLine(@"| $$ /$$$$ | ____  $$| $$_  $$_  $$ /$$__  $$       /$$__  $$|  $$  /$$//$$__  $$  /$$__  $$| $$");
            Console.WriteLine(@"| $$| _  $$  /$$$$$$$| $$ \ $$ \ $$| $$$$$$$$      | $$  \ $$ \  $$/$$/| $$$$$$$$ | $$  \__/|__/");
            Console.WriteLine(@"| $$  \ $$ /$$__  $$| $$ | $$ | $$| $$_____ /      | $$  | $$  \  $$$/ | $$_____/ | $$          ");
            Console.WriteLine(@"|  $$$$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$       |  $$$$$$/   \  $/  |  $$$$$$$ | $$       /$$");
            Console.WriteLine(@" \______/  \_______/|__/ |__/ |__/ \_______/        \______/     \_/    \_______/ |__/      |__/");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vill du spela igen?");
            Console.WriteLine("1. Självklart vill jag spela det här fantastiska spelet igen!");
            Console.WriteLine("2. Jag skulle hellre gå runt med TRE jackor INOMHUS en hel dag. Nej tack.");
            int svar = int.Parse(Console.ReadLine());
            if (svar == 1)
            {
                Startgame();
            }
            else if (svar == 2)
            {
                Environment.Exit(0);
            }

        }

        private static string WriteoutTOS()
        {
            string tos = "1. Relationship With Apple; Apple ID and Password. You understand and agree that by registering with Apple to become an Apple Developer Apple Developer, no legal partnership or agency relationship is created between you and Apple.You agree not to represent otherwise. You also certify that you are at least thirteen years of age and you represent that you are legally permitted to register as an Apple Developer. This Agreement is void where prohibited by law and the right to register as an Apple Developer is not granted in such jurisdictions. Unless otherwise agreed or permitted by Apple in writing, you cannot share or transfer any benefits you receive from Apple in connection with being an Apple Developer. The Apple ID and password you use to log into your Apple Developer account cannot be shared in any way or with anyone.You are responsible for maintaining the confidentiality of your Apple ID and password and for any activity in connection with your account.\n Har du förstått? (y)";

            return tos;
        }
    }
}



