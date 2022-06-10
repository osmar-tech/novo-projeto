// using carrega biblioteca.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// nome do ambiente desenvolvido pelo projeto.
namespace Teste
    
{    // nome da classe do arquivo.
    internal class Program
    {
        public static void WorkingWithIthinteger()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
            c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;

            Console.ReadLine();


        }
        private static string a;

        // cabeçalho do projeto
        static void Main(string[] args)
            /* chaves “ {} ” servem para delimitar um bloco de instruções, o início e término de 
            métodos, classes, namespaces ou comandos.*/
        {
            // WorkingWithIthinteger();
            string nome;
           Console.WriteLine("Digite seu nome");
            nome=Console.ReadLine();
            Console.WriteLine("Seu nome: " + nome);
            Console.ReadKey();
        }
    }
}
