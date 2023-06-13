using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_For_Contagem {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite uma quantidade numeros inteiros para iniciar o programa: ");
            int N = int.Parse(Console.ReadLine());//digitei, agora sistema ira capturar o valor
            int soma = 0;
            //suponha que digite 3, basicamente o programa ira me possibilitar digitar 3 numeros inteiros.
            //os numeros no final do programa serão somados.

            for (int i=1;i<=N;i++) {
                //enquanto o valor i=1 for menor ou igual quantidade do valor N, continue executando
                Console.Write("Valor #{0}:", i);

                int valor = int.Parse(Console.ReadLine());
                soma +=valor;

            }
            Console.WriteLine("Soma Total = " + soma);
            Console.ReadKey();
        }
    }
}
