using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, mod, i, f, c, t, restart;
            double n;
            
            start=0;
            mod=0;
            i=0;
            t=0;
            c=0;

            for(restart=1;restart!=0;restart=restart+0)
            { 
//pagina iniziale
                Console.Clear();
                Console.WriteLine("INDOVINA IL NUMERO");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("scegliere un opzione: ");
                Console.WriteLine("1) Gioca");
                Console.WriteLine("2) Altro");
                Console.WriteLine("3) Esci");


                do
                {
                    start=int.Parse(Console.ReadLine());

                }while(start<0||start>3);

//selezione
                switch (start)
                {

        // gioco
                    case 1:

            //seleziona modalità
                        Console.Clear();
                        Console.WriteLine("INDOVINA IL NUMERO");
                        Console.WriteLine(" ");
                        Console.WriteLine(" ");
                        Console.WriteLine("scegliere la difficoltà: ");
                        Console.WriteLine("1) Easy");
                        Console.WriteLine("2) Normal");
                        Console.WriteLine("3) Hard");
                        Console.WriteLine(" ");
                        Console.WriteLine("4) Indietro");

                        do
                        {
                            mod = int.Parse(Console.ReadLine());

                        } while (mod < 0 || mod > 4);

                        break;

        //crediti
                    case 2:

                        Console.Clear();
                        Console.WriteLine(" ");
                        Console.WriteLine("CreatorName: ");
                        Console.WriteLine("Andrea Sarselli");
                        Console.ReadKey();
                        break;

        //exit
                    case 3:

                        Environment.Exit(0);
                        break;
                }


//modalità
                switch (mod)
                {

        //easy
                    case 1:

                        Console.Clear();
                        Console.WriteLine("DIFFICOLTA' EASY");
                        Console.WriteLine("questa difficoltà non ha limiti di tentativi");
                        Console.WriteLine(" ");
                        Console.WriteLine("premi un tasto qualsiasi per iniziare");
                        Console.ReadKey();
                        break;
            
        //normal
                    case 2:

                        Console.Clear();
                        Console.WriteLine("DIFFICOLTA' NORMAL");
                        Console.WriteLine("questa difficoltà ha un limite di 5 tentativi");
                        t=5;
                        Console.WriteLine(" ");
                        Console.WriteLine("premi un tasto qualsiasi per iniziare");
                        Console.ReadKey();
                        break;
                   
        //hard
                    case 3:

                        Console.Clear();
                        Console.WriteLine("DIFFICOLTA' HARD");
                        Console.WriteLine("questa difficoltà ha un limite di 3 tentativi");
                        t = 3;
                        Console.WriteLine(" ");
                        Console.WriteLine("premi un tasto qualsiasi per iniziare");
                        Console.ReadKey();
                        break;
                  
        //back    
                    case 4:

                        restart=0;
                        break;
                }
                

//genera numero
                Random r = new Random();
                n = r.Next(10);


//giochi
                Console.Clear();

                if (restart!=0)
                {
                    switch (mod)
                    {
                        case 1:

//gioco EASY
                            do
                            {

        //indovina
                                Console.WriteLine("inserisci un numero (compreso tra 0 e 9)");
                                f = int.Parse(Console.ReadLine());

            //indovinato
                                if (f == n)
                                {
                                    Console.Clear();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("BRAVO HAI INDOVINATO");
                                    i = 4;
                                }

            //sbagliato
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("MI SPIACE, HAI SBAGLIATO");
                                    Console.WriteLine("premi un tasto qualsiasi per riprovare");

                                }

    //fine
        //numero tentativi
                                c = c + 1;

                                Console.ReadKey();
                                Console.Clear();

                            } while (i != 4);

        //vittoria
                            Console.WriteLine(" ");
                            Console.WriteLine("Congratulazioni hai VINTO!!");
                            Console.WriteLine(" ");
                            Console.WriteLine("hai impiegato " + c + " tentativi per indovinare");
                            Console.ReadKey();
                            c = 0;
                            break;



                        default:

//gioco NORMAL - HARD
                            do
                            {

        //indovina
                                Console.WriteLine("inserisci un numero (compreso tra 0 e 9)");
                                f = int.Parse(Console.ReadLine());

            //indovinato
                                if (f == n)
                                {
                                    Console.Clear();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("BRAVO HAI INDOVINATO");
                                    i = 4;
                                }

            //sbagliato
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine(" ");
                                    Console.WriteLine("MI SPIACE, HAI SBAGLIATO");
                                    Console.WriteLine("premi un tasto qualsiasi per riprovare");

                                }

        //numero tentativi
                                c = c + 1;

                                Console.ReadKey();
                                Console.Clear();

                            } while (i != 4 && c != t);

    //fine
                            if (i == 4)
                            {
        //vittoria
                                Console.WriteLine(" ");
                                Console.WriteLine("Congratulazioni hai VINTO!!");
                                Console.WriteLine(" ");
                                Console.WriteLine("hai impiegato " + c + " tentativi per indovinare");
                                Console.ReadKey();
                                c=0;
                            }
                            else
                            {
        //troppi tentativi
                                Console.WriteLine(" ");
                                Console.WriteLine("TROPPI TENTATIVI!");
                                Console.WriteLine(" ");
                                Console.WriteLine("hai impiegato troppi tentativi per indovinare!");
                                Console.WriteLine("il numero da indovinare era " + n);
                                Console.ReadKey();
                            }
                            break;
                    }
                }

//restart
                restart =1;
            }
        }
    }
}


