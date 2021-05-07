using EsercizioSpesa.Entites;
using EsercizioSpesa.Handlers;
using System;
using System.Collections.Generic;
using System.IO;

namespace EsercizioSpesa
{
    class Program
    {
        static void Main(string[] args)
        {
         

            FileSystemWatcher fsw = new FileSystemWatcher();

            //specifico la directory da tenere sotto controllo
            fsw.Path = @"C:\Users\simona.loperfido\Desktop\7 MAGGIO\ProvaPratica";

            //filtro che caratterizza i file da tenere sotto controllo
            fsw.Filter = "*.txt";

            //richiedo la notifica di un insieme di eventi
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastAccess;

            //abilitiamo le notifiche
            fsw.EnableRaisingEvents = true;

            //multicast delegate -> alla creazione del file viene gestito l'evento
            fsw.Created += GestioneSpesa.HandleNewTextFile;

            IFileSerializable spesa = new GestioneSpesa();
            spesa.LoadFromFile("spesa.txt");
            spesa.SaveToFile("spesa.txt");

            //Dovrei fare queste operazioni per ogni riga che vado a leggere
            //Chain of Responsibility pattern
            var manager = new Manager();
            var operationalManager = new OperationalManager();
            var ceo = new Ceo();
            var noApp = new NoApprovazione();

            //catena di responsabilità:
            manager.SetNext(operationalManager).SetNext(ceo).SetNext(noApp);
            //List<double> importo = new List<double> { 400, 560, 2000, 150, 60, 2700 };

            //foreach (var imp in importo)
            //{
            //    Console.WriteLine($"Hai speso {imp} euro - Sarà approvata la tua spesa?");
            //    var result = manager.Handle(imp); //invio richiesta

            //    //gestione risultato
            //    if (result != null)
            //    {
            //        Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nessuna spesa viene approvata sopra i " + imp);
            //    }
            //}


            //Factory pattern           
            //ICategoria categoria = CategoriaFactory.FactoryCategoria(param);
            //Console.WriteLine(categoria.TipoCategoria());


        }
    }
}
