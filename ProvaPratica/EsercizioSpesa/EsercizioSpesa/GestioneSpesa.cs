using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa
{
    public class GestioneSpesa : IFileSerializable
    {
        public DateTime Data { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public double Importo { get; set; }



        public static void HandleNewTextFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Un nuovo file è stato creato {e.Name}");

            //Lettura del file
            using StreamReader reader = File.OpenText(e.FullPath);
            Console.WriteLine($"--- Lettura di {e.Name} ---");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            //chiusura del flusso di lettura
            reader.Close();

            Console.WriteLine("Fine del contenuto");
        }

        public void SaveToFile(string fileName)
        {
            try
            {
                using StreamWriter writer = File.CreateText(@"C:\Users\simona.loperfido\Desktop\7 MAGGIO\ProvaPratica\" + fileName);
                string instanceData = $"Values:{Data};{Categoria};{Descrizione};{Importo}";

                writer.WriteLine(instanceData);
                writer.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void LoadFromFile(string fileName)
        {
            
            try
            {
                using StreamReader reader = File.OpenText(@"C:\Users\simona.loperfido\Desktop\7 MAGGIO\ProvaPratica\" + fileName);
                string instanceData = reader.ReadLine().Split(":")[1];

                string[] values = instanceData.Split(";");

                Categoria = values[1];

                bool resultOk = double.TryParse(values[1], out double importo);
                if (resultOk)
                {
                    Importo = importo;
                }

                
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

    }
}
