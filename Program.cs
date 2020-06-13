using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GenerateNewBarcode(SelectKala());
            }
            catch (Exception t)
            {
                Console.WriteLine(t.Message.ToString());
                Console.ReadKey();
            }
            
            
        }

        private static void GenerateNewBarcode(int kala)
        {
            GenerateBarcode(kala, SelectBatch());

            Console.Write("Do You Want To Continue With This Fani ? (y/n Or o = Exit) ");
            var n = Console.ReadLine();
            if (n=="n")
            {
                Console.WriteLine("\n");
                GenerateNewBarcode(SelectKala());
            }
            else if (n=="o")
            {
                Environment.Exit(0);
            }
            GenerateNewBarcode(kala);
        }

        private static void GenerateBarcode(int kala, string[] batch)
        {
            var bdata = new DataBarcode(kala, batch[0], int.Parse(batch[1]), int.Parse(batch[2]));
            var file = new FileBarcode(batch[0]);

            GenerateBarcodeUseCase usecase = new GenerateBarcodeUseCase();
            usecase.Generate(bdata, file);

            Console.WriteLine("Barcode: " + batch[0] + " Created .");
            Console.WriteLine("\n");
        }

        private static string[] SelectBatch()
        {
            Console.WriteLine("\n");
            Console.Write("Please Write Barcode-Roz-Start : ");
            string data = Console.ReadLine();
            var batch = data.Split('-');
            return batch;
        }

        private static int SelectKala()
        {
            
            Console.Write(
                "YG20216602    - 6602 \n" +
                "7590019       - 0019 \n" +
                "IK003231DG    - 3231 \n" +
                "IK008055VC    - 8055 \n" +
                "YG20286303    - 6303 \n" +
                "YG20216594    - 6303 \n" +
                "YG00025580    - 5580 \n" +
                "Pleas Select Kala : "
            );
            int kala = int.Parse(Console.ReadLine());
            return kala;
        }

    }
}
