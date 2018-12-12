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
            Break();
            value = Classroom2();
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
            Console.Clear();

            

            Console.Write("Det är en vanlig dag i innerstaden Göteborg, det regnar snett underifrån och du befinner dig utanför Östra Hamngatan 16.");
            Console.WriteLine("Dörren in till United Spaces, tillika ditt andra hem, är dessvärre låst - Hur skall du ta dig in?\n");
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

        private static void Break()
        {

            Console.WriteLine($"{Data.Playername}, du måste ta rast!\n Jaså, du 'ska bara'....? Men pingis då?\n");
            Console.Write("1. Pingis! Rundpingis! All pingis! ");

            if (Data.Playername != "Magnus" )
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
                            }
                            else
                            {
                                Console.WriteLine("Besvikelsen går inte att kontrollera! Du slår racket i bordet och ropar ett par mindre väl valda svordomar. Usch så pinsamt att förstöra stämningen nu när ni ska tillbaka till klassrummet.\n");
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

        private static int Classroom2()
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
