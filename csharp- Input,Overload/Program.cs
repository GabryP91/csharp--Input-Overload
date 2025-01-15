/*
 
Esercizi – C#:

    1. Scrivere un programma che chieda all’utente di inserire dalla tastiera nome, cognome, età e
    numero di telefono. Visualizzare poi a schermo le informazioni inserite.

    2. Scrivere un programma che prenda due numeri interi dalla console e calcoli e visualizzi sulla
    console stessa la somma, la media, il prodotto.

    3. Creare tre metodi con lo stesso nome, ma parametri diversi per numero o per tipo, in modo da
    effettuare un overload.

    4. Creare una classe CalcolatriceAvanzata con i metodi di somma, sottrazione, moltiplicazione e
    divisione. Tutti questi metodi dovranno restituire (e non stampare) un risultato.
    Ognuno dei metodi sopra citati deve accettare (overload):
    • due argomenti in ingresso di tipo numerico decimale.
    • tre argomenti in ingresso di tipo numerico decimale.
    • due argomenti in ingresso di tipo numerico decimale e un argomento di tipo
    stringa per aggiungere un messaggio.

    5. All’interno della classe col metodo Main fornire gli esempi che restituiscano i risultati delle
    operazioni a schermo.
    BONUS: chiedere all’utente di inserire i parametri dei metodi da tastiera. 

*/

using System;

namespace csharp__Input_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO 1
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 1\n");

            DatiPersona();


            // ESERCIZIO 2
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 2\n");

            Operazioni();


            // ESERCIZIO 3
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 3\n");

            Stampa("Ciao");
            Stampa("Ciao", 42);
            Stampa("Ciao", 42, true);


            // ESERCIZIO 4 + BONUS
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine("ESERCIZIO 4\n");

            CalcolatriceAvanzata prova = new CalcolatriceAvanzata();


            Console.WriteLine("il risultato del primo overraide del metodo Somma sarà {0}\n", prova.Somma(12.6, 5.8, 23.8));

            Console.WriteLine("il risultato del secondo overraide del metodo Somma sarà {0}\n", prova.Somma(12.6, 5.8, ""));

            Console.WriteLine("Parte bonus:\n");

            double result = prova.Somma();

            Console.WriteLine("\nIl risultato sarà {0}\n", result);


        }

        static void DatiPersona()
        {
            Console.WriteLine("\nInserire il proprio nome:\n");
            string  nome = Console.ReadLine();

            Console.WriteLine("\nInserire il proprio cognome:\n");
            string cognome = Console.ReadLine();

            Console.WriteLine("\nInserire la propria età:\n");
            string eta = Console.ReadLine();

            Console.WriteLine("\nNome: {0}, Cognome: {1}, Età: {2}\n", nome, cognome, eta);
            
        }

        static void Operazioni()
        {
            int num1, num2;

            Console.WriteLine("\nInserire primo numero:\n");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero");
            }

            Console.WriteLine("\nInserire secondo numero:\n");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero");
            }

            Console.WriteLine("\nNum1: {0}, Num2: {1}, Somma: {2}\n", num1, num2, num1+ num2);

            Console.WriteLine("\nNum1: {0}, Num2: {1}, Media: {2}\n", num1, num2, (num1 + num2)/2);

            Console.WriteLine("\nNum1: {0}, Num2: {1}, Prodotto: {2}\n", num1, num2, num1 * num2);

        }

        static void Stampa(string messaggio)
        {
            Console.WriteLine($"Messaggio: {messaggio}");
        }

        static void Stampa(string messaggio, int numero)
        {
            Console.WriteLine($"Messaggio: {messaggio}, Numero: {numero}");
        }

        static void Stampa(string messaggio, int numero, bool BoolVal)
        {
           

            Console.WriteLine($"Messaggio: {messaggio}, Numero: {numero}, Booleano: {BoolVal}");
        }


    }

    public class CalcolatriceAvanzata
    {
        private double num1,num2;
        public CalcolatriceAvanzata() { }

        public CalcolatriceAvanzata(double primo, double secondo)
        {
            this.num1 = primo;
            this.num2 = secondo;
        }

        public double Somma() {

            double val1, val2;

            Console.WriteLine("\nInserire primo numero:\n");
            while (!double.TryParse(Console.ReadLine(), out val1))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            Console.WriteLine("\nInserire secondo numero:\n");
            while (!double.TryParse(Console.ReadLine(), out val2))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero");
            }

            return val1 + val2;

        }

        //overload
        public double Somma(double primo, double secondo, double terzo)
        {

            return primo + secondo + terzo;

        }

        //overload
        public string Somma(double primo, double secondo, string mex)
        {

            mex = $"La somma di {primo} e {secondo} è: {primo + secondo}";

            return mex;

        }

        public double Sottrazione(double primo, double secondo) 
        { 
            return primo - secondo;
        }

        public double Moltiplicazione(double primo, double secondo)
        {
            return primo * secondo;
        }

        public double Divisione(double primo, double secondo)
        {
            if (secondo == 0)
            {
                Console.WriteLine("Errore: Divisione per zero non consentita.");
                return double.NaN;
            }

            return primo / secondo;
        }


    }
}
