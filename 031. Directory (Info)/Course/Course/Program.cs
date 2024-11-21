using System.IO;


namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Directory, DirectoryInfo

                Operações com pastas (create, enumerate, get files, etc.)
                Directory
                    Static members

                DirectoryInfo
                    Instance Members
             */

            string path = @"C:\Users\lucas.porto\OneDrive - HARALD INDUSTRIA E COMERCIO DE ALIMENTOS SA\Documentos\Estágio\Pessoal\CursoCSharp\CursoCSharp--Tempo-Limitado-\031. Directory (Info)\myfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //visualizando as pastas
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //visualizando os arquivos
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");//Criando uma pasta no diretório

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }


        }
    }
}
