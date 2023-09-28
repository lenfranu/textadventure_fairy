using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnusperKnusperKnäuschen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abschnitt für das Titelbild
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************************************************************************");

            Console.WriteLine("                               Märchenwald                                         ");
            Console.WriteLine("            Teste dein Wissen und erobere den Märchenwald                          ");

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************************************************************************");

            Console.WriteLine("Drücke die a-Taste und bestätige mit der Enter-Taste um das Spiel zu starten!");
            string starteingabe = Console.ReadLine();
            if (starteingabe == "a")
            {
                //a wurde eingegeben, das Spiel startet
                System.Console.Clear();
            }
            else
            {
                //falsche Eingabe! Das Spiel wird beendet
                Console.WriteLine("Du hast nicht a eingegeben sonder" + starteingabe + "\n Das Spiel wird beendet. Versuch es nocheinmal!");
            }
            //Disposition
            Console.WriteLine ("Nach einer langen Reise hast du endlich den Märchenwald erreicht! \n");
            Console.WriteLine ("Doch dein Abenteuer hat erst begonnen.");
            Console.WriteLine("Nur wer sich als würdig erweist, darf auch im Märchenwald verweilen und von seiner Magie profitieren.");
            Console.WriteLine("Beweise dich in Mut, Verstand und Wissen um...");
            Console.WriteLine("------------------------");
            //Szene 1 
            Console.WriteLine("Du betrittst den Wald und folgst dem Weg vor dir. Aufeinmal findest du dich vor einer Kreuzung wieder.");
            Console.WriteLine("Wohin führt dich dein Weg?");
            //Option A
            Console.WriteLine("A: Nach Rechts - Jemand hat den Weg mit Brotkrumen gekennzeichnet, da muss sich etwas wichtiges verbergen!");
            //Option B
            Console.WriteLine("B: Nach Links - Der Pfad scheint mit Steinplatten ausgelegt zu sein, die im Licht eine gelbliche Farbe annehmen.");
            string eingabeWeg = Console.ReadLine();
            if (eingabeWeg.ToLower() == "a")
            {
                //Szene 2A
                Console.WriteLine("Du folgst der Spur aus Brotkrumen und stösst auf ein buntes Haus aus Pfefferkuchen.");
                Console.WriteLine("Die süssen Versuchungen sind unwiderstehbar und du kannst nicht anders als davon zu kosten.");
                Console.WriteLine("Doch kaum brichst du dir ein Stück des Dachs ab, steht die Hexe bereits neben dir.");
                Console.WriteLine("Du wirst ihr nächstes Festtagsmahl...");
                Console.WriteLine("GAME OVER");
            }
            else if (eingabeWeg.ToLower() == "b")
            {
                //Szene 2B
                Console.WriteLine("Auf dem Pfad begegnet dir eine alte Frau.");
                Console.WriteLine("Sie trägt einen prallgefüllten Korb mit sich und möchte dir ein Objekt deiner Wahl schenken.");
                Console.WriteLine("Die Auswahl der Objekte kommt dir merkwürdig vertraut vor.");
                Console.WriteLine("Wähle das Objekt achtsam aus.");
                Console.WriteLine("Wählst du...");
                //Auswahlmöglichkeiten Switchcase - bei else if drin, weil gehört dazu
                Console.WriteLine("A: Einen Apfel");
                Console.WriteLine("B: Einen Spiegel");
                Console.WriteLine("C: Einen Gürtel");
                Console.WriteLine("D: Einen Kamm");
                string hexenObjekt = Console.ReadLine();
                switch (hexenObjekt.ToLower())
                {
                    case "a":
                        Console.WriteLine("Kaum hast du einen Biss davon genommen, fällst du tot zur Erde nieder.");
                        Console.WriteLine("GAME OVER");
                        break;
                    case "b":
                        Console.WriteLine("Aus dem Spiegel ertönt eine Stimme:");
                        Console.WriteLine(" > Gratuliere, Ihr hast die richtige Wahl getroffen.");
                        Console.WriteLine(" > Als Lohn möchte Euch dich weiter in die richtige Richtung weisen.:");
                        Console.WriteLine(" > Wo die Königin der Herzen ihrem Volk den Kopf verdreht, und ein Hutmacher Maus und Hase zum Tee einlädt,");
                        Console.WriteLine(" > dorthin müsst Ihr Reisen und einmal mehr Mut und Grips beweisen.");
                        Console.WriteLine("Wohin machst du dich auf den Weg?");
                        Console.WriteLine("A: Nimmerland");
                        Console.WriteLine("B: Wunderland");
                        string Land = Console.ReadLine();
                        if (Land.ToLower() == "a")
                        {
                            //Szene 3A
                            Console.WriteLine("Du begibst dich ins Nimmerland und triffst auf die verlorenen Jungen.");
                            Console.WriteLine("Die Idee von einem Leben, ohne jemals erwachsen zu werden, lullt dich ein.");
                            Console.WriteLine("Deine Mission ist vergessen, du verbleibst im Nimmerland und verbringst ein Leben voller Abenteuer.");
                            Console.WriteLine("GAME OVER");
                        }
                        else if (Land.ToLower() == "b")
                        {
                            Console.WriteLine("Du machst dich auf in Richtung Wunderland");
                            Console.WriteLine("Vor dir erstreckt sich ein Garten voller weisser Rosen.");


                        }
                        break;
                    case "c":
                        Console.WriteLine("Die Frau schnürt dir den Gürtel zugleich um und zieht so fest zu, dass dir die Luft wegbleibt.");
                        Console.WriteLine("GAME OVER");
                        break;
                    case "d":
                        Console.WriteLine("Der Kamm war vergiftet und wirkt sobald du ihn an dich nimmst.");
                        Console.WriteLine("GAME OVER");
                        break;
                }
                
            }
                
            else
            {
                //Meldung bei Ungültiger Eingabe
                Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet.");
            }

            Console.ReadKey();
        }
        private static void SlowTyping (string myText)
        {
            for (int i = 0; i < myText.Length; i++)
            {
                Console.Write(myText[i]);
                System.Threading.Thread.Sleep(70);
            }
        }
    }
}
