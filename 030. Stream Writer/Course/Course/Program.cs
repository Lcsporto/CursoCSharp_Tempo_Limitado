namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             É uma stream capaz de escrever caracteres a partir de uma stream binária (Ex. FileStream)
             */

            string sourcePath = @"C:\Users\lucas.porto\OneDrive - HARALD INDUSTRIA E COMERCIO DE ALIMENTOS SA\Documentos\Estágio\Pessoal\CursoCSharp\CursoCSharp--Tempo-Limitado-\030. Stream Writer\file1.txt";
            string targetPath = @"C:\Users\lucas.porto\OneDrive - HARALD INDUSTRIA E COMERCIO DE ALIMENTOS SA\Documentos\Estágio\Pessoal\CursoCSharp\CursoCSharp--Tempo-Limitado-\030. Stream Writer\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error Ocurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
