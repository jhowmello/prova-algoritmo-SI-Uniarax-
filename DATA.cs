//Autor João M. Gregroio
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            
            Console.WriteLine("Digite a primeira data (no formato dd/MM/yyyy):");
            string data1Input = Console.ReadLine();
            DateTime data1 = DateTime.ParseExact(data1Input, "dd/MM/yyyy", null);

            
            Console.WriteLine("Digite a segunda data (no formato dd/MM/yyyy):");
            string data2Input = Console.ReadLine();
            DateTime data2 = DateTime.ParseExact(data2Input, "dd/MM/yyyy", null);

            
            TimeSpan diferenca = data2 - data1;
            int diasDiferenca = Math.Abs(diferenca.Days);

            
            Console.WriteLine($"A diferença entre as datas é de {diasDiferenca} dia(s).");
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato de data inválido. Por favor, use o formato dd/MM/yyyy.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}