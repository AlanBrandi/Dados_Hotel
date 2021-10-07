using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando o vetor Cliente.
            Cliente[] vect = new Cliente[10];
            //Pegando quantos quartos serão ocupados.
            Console.WriteLine("Quantos quartos serão ocupados? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Hospede #{i}");
                //Coletando o nome.
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                //Coletando o email.
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                //coletando o quarto e criando a quantidade necessaria de quartos que foram realmente ocupados.
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Cliente(nome, email);
            }
            //Demonstrando os quartos ocupados
            Console.WriteLine();
            Console.WriteLine("Quantos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                //Excluindo os vazios.
                if(vect[i] != null)
                {
                    //Demonstrando os quartos em ordem numérica
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
