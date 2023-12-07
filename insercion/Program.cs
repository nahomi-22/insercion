using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace insercion
{
    class insercion
    {
        private int[] vector;

        public void Ingreso()
        {
            Console.WriteLine("A continuacion, encontrara una app que se encarga de organizar los numeros ingresados en orden ascendente");
            Console.WriteLine("\n/Metodo de Ordenamiento Insercion\\");
            Console.WriteLine("\nIngrese los 10 valores a organizar:");


            string linea;


            vector = new int[10];
            for (int n = 0; n < vector.Length; n++)
            {
                Console.Write("Elemento " + (n + 1) + ": ");
                linea = Console.ReadLine();
                vector[n] = int.Parse(linea);
            }             
        }

        public void InsercionDirecta()
        {
            int v;
            int j;
            for (int i = 0; i < vector.Length; i++)
            {
                v = vector[i];
                j = i - 1;
                while (j >= 0 && vector[j] > v)
                {
                    vector[j + 1] = vector[j];
                }
                vector[j + 1] = v;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Vector ordenados en forma ascendente");
            string NombreArchivo = "DatosOrdenados.txt";
            StreamWriter writer = File.AppendText(NombreArchivo);

            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + " ");
                writer.WriteLine(vector[f]);
            }
            Console.ReadKey();


            writer.Close();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                insercion pv = new insercion();
                pv.Ingreso();
                pv.InsercionDirecta();
                pv.Imprimir();
            }
            catch
            {
                Console.Write("Error en el sistema. debido a su valor ingresado");
            }
        }
    }
}
