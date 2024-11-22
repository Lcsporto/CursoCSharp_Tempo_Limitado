using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\CursoCSharp\CursoCSharp--Tempo-Limitado-\000. Exercícios\016. Arquivos";

            try
            {
                using (StreamReader sr = File.OpenText(path + @"\file1.csv"))
                {
                    List<Itens> list = new List<Itens>();//Criando uma lista de intens;
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] Product = line.Split(","); //Faz a quebra das informações do Texto CSV.

                        string name = Product[0]; //Armazena as infomrações;
                        string price = Product[1];
                        string quantity = Product[2];

                        list.Add(new Itens(name, price, quantity));//Faz a instanciação do item;
                    }

                    string targetPath = path + @"\out";
                    Directory.CreateDirectory(targetPath);//Cria uma nova pasta no diretório

                    string targetFile = targetPath + @"\summary.csv";//Criando o caminho do arquivo com a sua extensão

                    using (StreamWriter sw = File.AppendText(targetFile))
                    {
                        sw.WriteLine("Nome;Preco Total");
                        foreach (Itens item in list)
                        {
                            sw.WriteLine($"{item.Name};{item.TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} ");
                        }
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error Ocurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
