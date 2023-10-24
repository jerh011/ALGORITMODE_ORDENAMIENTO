using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITMODE_ORDENAMIENTO
{

    public class Metodos
    {
        int[] valores = { 19, 25, 99, 100, 55, 1, 468, 0, 250, 45, 25, 68, 5 };
        public void insertar()
        {
            int moverElemento;
            int insertar;
            for (int i = 1; i < valores.Length; i++)
            {
                insertar = valores[i];
                moverElemento = i;
                while (moverElemento > 0 && valores[moverElemento - 1] > insertar)
                {
                    valores[moverElemento] = valores[moverElemento - 1];
                    moverElemento--;
                    Console.WriteLine($"dentro del while{string.Join(" | ", valores)}");
                }
                valores[moverElemento] = insertar;
                Console.WriteLine($"dentro del for {string.Join(" | ", valores)}");
            }
        }
        public void Burbuja()
        {
            int temp;
            for (int i = 0; i < valores.Length - 1; i++)
            {
                for (int j=i+1;j<valores.Length;j++)
                {
                    if (valores[j] < valores[i])
                    { 
                        temp= valores[i];
                        valores[i] = valores[j];
                        valores[j] = temp;
                    }
                }
                Console.WriteLine($"dentro del for{string.Join(" | ", valores)}");
            }
            Console.WriteLine(string.Join(" | ", valores));
        }
    }
}
