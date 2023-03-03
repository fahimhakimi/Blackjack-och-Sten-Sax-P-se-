// See https://aka.ms/new-console-template for more information

//Snyggare fönster 
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();

//Startsidan 
Console.WriteLine("Hej, detta programm är ett menyval, välj ett alternativ.");
Console.WriteLine("");

//Variabler 
string senasteBJvinnaren = "Ingen har vunnit än";
string senasteSSPvinnaren = "Ingen har vunnit än";
int svårighetsgrad = 2;
int svårighetsgradspoäng = 17;
Random slump = new Random();
string MenyVal = "0";

while (MenyVal != "6")
{
    Console.WriteLine("1. Spela Black Jack");
    Console.WriteLine("2. Senaste vinnaren på BJ");
    Console.WriteLine("3. Regler för Black Jack");
    Console.WriteLine("4. Sten-Sax-Påse");
    Console.WriteLine("5. Senaste vinnaren på SSP");
    Console.WriteLine("6. Avsluta programmet");
    Console.WriteLine("");
    Console.WriteLine("");

    Console.Write("Ditt svar:");
    string AnvndVal = Console.ReadLine();
    Console.WriteLine("");

    switch (AnvndVal)
    {
        case "1":



            int Spelarpoäng = 0;
            int Datorpoäng = 0;


            //Välkomstmedeelande 
            Console.WriteLine("Välkommen till Black Jack. \nVänligen välj svårighetsgraden för spelet.");
            Console.WriteLine("Ju lättare desto vid högre poäng slutar datorn dra kort.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Lätt");
            Console.WriteLine("2. Svår");
            Console.WriteLine("3. Mycket svår");
            Console.Write("Ditt svar: ");
            svårighetsgrad = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            //Svårighetsgrad väljs 
            if (svårighetsgrad == 1)
            {
                svårighetsgradspoäng = 20;
            }
            else if (svårighetsgrad == 2)
            {
                svårighetsgradspoäng = 19;
            }
            else if (svårighetsgrad == 3)
            {
                svårighetsgradspoäng = 17;
            }
            else
            {
                Console.WriteLine("Ogiltigt alternativ.");
                Console.WriteLine("Tryck enter för att gå till menyvalet.");
                Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("");
                break;

            }

            //Spelet börjar och de två första kortena dras 
            Console.WriteLine("Tryck enter för att dra de två första kortena.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            Spelarpoäng += slump.Next(1, 11);
            Datorpoäng += slump.Next(1, 11);

            Console.WriteLine("Poängställningenen efter kort 1");
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du: " + Spelarpoäng);
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dator: " + Datorpoäng);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();

            Spelarpoäng += slump.Next(1, 11);
            Datorpoäng += slump.Next(1, 11);

            Console.WriteLine("Poängställningenen efter kort 2");
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Du: " + Spelarpoäng);
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dator: " + Datorpoäng);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();

            //Spelaren kör mot datorn

            while (Spelarpoäng < 21)
            {

                Console.WriteLine("Vill du dra ett kort till? Mata in j för JA och n för NEJ.");
                Console.Write("Ditt svar: "); string Kortval = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine();

                while (Datorpoäng < Spelarpoäng && Datorpoäng < svårighetsgradspoäng)
                {
                    Datorpoäng += slump.Next(1, 11);
                }


                if (Kortval == "j")
                {
                    Spelarpoäng += slump.Next(1, 11);
                    Console.WriteLine("Poängställningenen");
                    Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Du: " + Spelarpoäng);
                    Thread.Sleep(200);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dator: " + Datorpoäng);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                    Console.WriteLine();

                }

                else if (Kortval == "n")
                {
                    break;
                }


                else
                {
                    Console.WriteLine("Ogiltigt alternativ.");
                    Console.WriteLine("Tryck enter för att gå till menyvalet.");
                    Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
                }




            }




            //Resultat avgörs

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Slutliga poängställningen");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Din totala poäng är " + Spelarpoäng + ".");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Datorns totala poäng är " + Datorpoäng + ".");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            if (Spelarpoäng > 21)
            {

                Console.WriteLine("Du valde att dra fler kort och din poäng blev större än 21.");
                Console.WriteLine();
                Console.WriteLine("Resultat");
                string streamer = "Datorn vann!";
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (char streamerchar in streamer)
                {
                    Thread.Sleep(500);
                    Console.Write(streamerchar);
                }


                senasteBJvinnaren = "Datorn";


            }
            else if (Datorpoäng > 21)
            {

                Console.WriteLine("Datorn valde att dra fler kort och dess poäng blev större än 21.");
                Console.WriteLine();
                Console.WriteLine("Resultat");
                string streamer = "Du vann grattis!";
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (char streamerchar in streamer)
                {
                    Thread.Sleep(500);
                    Console.Write(streamerchar);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Skriv ditt namn gärna så att vi sparar det som vinnare.");
                Console.Write("Ditt namn: ");
                senasteBJvinnaren = Console.ReadLine();

            }
            else if (Spelarpoäng > Datorpoäng)
            {

                Console.WriteLine("Du ligger närmare 21 än datorn.");
                Console.WriteLine();
                Console.WriteLine("Resultat");
                string streamer = "Du vann grattis!";
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (char streamerchar in streamer)
                {
                    Thread.Sleep(500);
                    Console.Write(streamerchar);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Skriv ditt namn gärna så att vi sparar det som vinnare.");
                Console.Write("Vad heter du? ");
                senasteBJvinnaren = Console.ReadLine();


            }
            else
            {
                Console.WriteLine("Datorn ligger närmare 21 än dig.");
                Console.WriteLine();
                Console.WriteLine("Resultat");
                string streamer = "Datorn vann!";
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (char streamerchar in streamer)
                {
                    Thread.Sleep(500);
                    Console.Write(streamerchar);
                }


                senasteBJvinnaren = "Datorn";


            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tryck enter för att spela om");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();





            break;

        case "2":

            Console.WriteLine("Senaste vinnaren på BJ är " + senasteBJvinnaren + " .");
            Console.WriteLine("Tryck enter för att gå till menyvalet.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            break;

        case "3":
            Console.WriteLine("I Blackjack kommer du att spela mot datorn och försöka tvinga datorn att få över 21 poäng.Både du och datorn får poäng genom att dra kort, varje kort är värt 1 – 10 poäng. När spelet börjar dras två kort till både dig och datorn. Därefter får du dra hur många kort som du vill tills du är nöjd med din totalpoäng, du vill komma så nära 21 som möjligt utan att få mer än 21 poäng. När du inte vill dra fler kort så kommer datorn att dra kort tills den har mer eller lika många poäng som dig.\r\nDu vinner om datorn får mer än totalt 21 poäng när den håller på att dra kort. Datorn vinner omden har mer poäng än dig när spelet är slut så länge som datorn inte har mer än 21 poäng. Om det skulle bli lika i poäng så vinner datorn. Om du får mer än 21 poäng när du drar kort så har du förlorat.\r\n");
            Console.WriteLine("Tryck enter för att gå till menyvalet.");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            break;

        case "4":



            Console.WriteLine("Välkommen till Sten-Sax-påse.");
            Console.WriteLine("Välje ett alternativ. (Menyval, 1/2/3)");
            Console.WriteLine("1. Sten");
            Console.WriteLine("2. Sax");
            Console.WriteLine("3. Påse");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Ditt val:");
            int användarval = Convert.ToInt32(Console.ReadLine());
            int datorval = new Random().Next(1, 4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Du valde " + hämtaval(användarval) + ".");
            Console.WriteLine("Datorn valde " + hämtaval(datorval) + ".");
            Console.WriteLine();
            Console.WriteLine();

            if (användarval == datorval)
            {
                Console.WriteLine("Ingen vann, försök igen.");


            }
            else if (användarval == 1 && datorval == 3 ||
                     användarval == 3 && datorval == 2 ||
                     användarval == 2 && datorval == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Resultat:");
                string streamer = "Datorn vann!";
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (char streamerchar in streamer)
                {
                    Thread.Sleep(500);
                    Console.Write(streamerchar);
                }
                senasteSSPvinnaren = "Dator";


            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Resultat:");
                string streamer = "Du vann grattis!";
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (char streamerchar in streamer)
                {
                    Thread.Sleep(500);
                    Console.Write(streamerchar);
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Skriv ditt namn gärna så att vi sparar det som vinnare.");
                Console.Write("Vad heter du? ");
                senasteSSPvinnaren = Console.ReadLine();
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tryck enter för att spela om.");
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();


            static string hämtaval(int val)
            {
                switch (val)
                {
                    case 1:
                        return "Sten";
                    case 2:
                        return "Sax";
                    case 3:
                        return "Påse";
                    default:
                        return "Ogiltigt val!";
                }
            }
            break;


        case "5":
            Console.WriteLine("Senaste vinnaren på SSP är " + senasteSSPvinnaren + ".");
            Console.WriteLine("Tryck enter för att gå till menyvalet.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            break;


        case "6":
            Console.WriteLine("Avslutar programmet.");
            Console.WriteLine("Tryck enter för att gå till menyvalet.");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            break;

        default:
            Console.WriteLine("Ogiltigt alternativ.");
            Console.WriteLine("Tryck enter för att gå till menyvalet.");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");
            break;







    }

}




