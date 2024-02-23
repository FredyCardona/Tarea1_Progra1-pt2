using System;
using System.IO; // Necesitas importar System.IO para utilizar TextWriter y TextReader

namespace Sentencias
{
    class SentenciaUsing
    {
        public static void Main(string[] args)
        {
            string s; // Debes declarar la variable 's' antes de usarla
            using (TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("linea uno");
                w.WriteLine("linea dos");
            }
            using (TextReader r = File.OpenText("log.txt"))
            {
                while ((s = r.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
