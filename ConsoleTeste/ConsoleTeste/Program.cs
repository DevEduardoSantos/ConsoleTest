using System;
using System.IO;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\Temp\MeusProjetos\dados_iniciais.txt";
            int id = 1; // inicializa o ID

            StreamWriter sw = null;
            try
            {
                sw = File.AppendText(@"C:\Windows\Temp\MeusProjetos\dados_finais.txt");

                StreamReader sr = null;
                try
                {
                    sr = File.OpenText(path);
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        int index = line.Length;
                        line = line + ";" + id.ToString();
                        sw.WriteLine(line);
                        id++;
            }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
    }
}
