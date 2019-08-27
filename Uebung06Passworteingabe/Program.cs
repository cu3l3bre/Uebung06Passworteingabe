/*
 * Aufgabe: Identifizieren Sie die Eingabe des Passworts "geheim" wie folgt:
 *
 *            - mit einem Zähler (int count) zählen Sie die aktuell bereits 
 *              eingegeben Zeichen bzw. die Gesamtanzahl des/der Zeichen
 *            - mit der ersten Anweisung prüfen Sie, ob es ein 'g' ist
 *            - wenn dies nicht der Fall ist verlassen Sie die main-Routine
 *              mit 'return'
 *            - ansonsten wird das nächste Zeichen wird eingegeben
 *            - eine switch-Anweisung prüft, ob es sich um ein korrektes
 *              Zeichen handelt (d.h. 'e', 'h', 'e', 'i', 'm')
 *            - die Anweisung im jeweiligen case-Zweig prüft, ob die Nummer,
 *              d.h. die Stelle des eingegebenen Zeichens stimmt
 *            - wenn ein Zeichen falsch ist (falsches Zeichen oder falsche Stelle),
 *              setzen Sie ein zuvor auf 'false' gesetztes Flag 'bool verkehrt'
 *              auf 'true'
 *
 *            - verwenden Sie zur Eingabesteuerung eine geeignete Wiederholungschleife
 */

using System;


namespace Uebung06Passworteingabe
{
    class Program
    {
        static void Main(string[] args)
        {

            bool verkehrt = false;
            bool eingabeBeenden = false;

            int eingegebeneZeichen = 0;
            string eingabe = "";
            char zeichen = '0';


            while(!eingabeBeenden)
            {
                Console.WriteLine("Bitte geben Sie ein Zeichen ein");
                eingabe = Console.ReadLine();

                zeichen = eingabe[0];
                eingegebeneZeichen++;

                switch (zeichen)
                {
                    case 'g':
                        if(eingegebeneZeichen == 1)
                        {
                            Console.WriteLine("Das war korrekt");
                        }
                        else
                        {
                            Console.WriteLine("Buchstabe korrekt aber falsche Position");
                            verkehrt = true;
                            eingabeBeenden = true;
                        }
                        break;

                    case 'e':
                        if ((eingegebeneZeichen == 2) || (eingegebeneZeichen == 4))
                        {
                            Console.WriteLine("Das war korrekt");
                        }
                        else
                        {
                            Console.WriteLine("Buchstabe korrekt aber falsche Position");
                            verkehrt = true;
                            eingabeBeenden = true;
                        }
                        break;

                    case 'h':
                        if (eingegebeneZeichen == 3)
                        {
                            Console.WriteLine("Das war korrekt");
                        }
                        else
                        {
                            Console.WriteLine("Buchstabe korrekt aber falsche Position");
                            verkehrt = true;
                            eingabeBeenden = true;
                        }
                        break;

                    case 'i':
                        if (eingegebeneZeichen == 5)
                        {
                            Console.WriteLine("Das war korrekt");
                        }
                        else
                        {
                            Console.WriteLine("Buchstabe korrekt aber falsche Position");
                            verkehrt = true;
                            eingabeBeenden = true;
                        }
                        break;

                    case 'm':
                        if (eingegebeneZeichen == 6)
                        {
                            Console.WriteLine("Das war korrekt");
                            eingabeBeenden = true;
                        }
                        else
                        {
                            Console.WriteLine("Buchstabe korrekt aber falsche Position");
                            verkehrt = true;
                            eingabeBeenden = true;
                        }
                        break;

                    default:
                        verkehrt = true;
                        eingabeBeenden = true;
                        break;

                }



            }

            if(verkehrt)
            {
                Console.WriteLine("Die Eingabe war nicht korrekt, Program wird beendet");
            }
            else
            {
               Console.WriteLine("----- Das Passwort war korrekt -----");
            }

            Console.ReadKey();
        }
    }
}
