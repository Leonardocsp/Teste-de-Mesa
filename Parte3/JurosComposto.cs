using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class JurosComposto
    {
        public void Juros()
        {
            decimal valorPresente, taxa, valorFuturo, ano, rendimento, resgate;

            int mes;

            valorPresente = 1000.00m;

            taxa = 3.00m / 100;

            mes = 6;

            decimal[] meses = new decimal[mes];

            Console.WriteLine($"Valor Presente: {valorPresente:F2}");

            for (int i = 0; i < meses.Length; i++)
            {

                valorFuturo = valorPresente * (decimal)Math.Pow((double)(1 + taxa), i);

                meses[i] = valorFuturo;


                rendimento = valorFuturo - valorPresente;

                Console.WriteLine($"Mes: {i}");
                Console.WriteLine($"Saldo: {valorFuturo:F2}");
                Console.WriteLine($"Valor de Rendimento: {rendimento:F2}");

                if (i == 5)
                {
                    bool saqueValido = false;

                    while (!saqueValido)
                    {
                        Console.WriteLine("Digite o valor que deseja resgatar: ");
                        resgate = Convert.ToDecimal(Console.ReadLine());

                        if (resgate > valorPresente)
                        {
                            Console.WriteLine("Saque não pode ser maior que o valor presente. Tente novamente.");
                        }
                        else
                        {
                            valorFuturo -= resgate;
                            valorPresente -= resgate;

                            rendimento = valorFuturo - valorPresente;

                            Console.WriteLine($"Novo Saldo: {valorFuturo:F2}");

                            meses[i] = valorFuturo;
                            valorPresente = valorFuturo;
                            saqueValido = true;
                        }
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {

                valorFuturo = valorPresente * (decimal)Math.Pow((double)(1 + taxa), i + 1);

                meses[i] = valorFuturo;


                rendimento = valorFuturo - valorPresente;

                Console.WriteLine($"Mes: {i + 6}");
                Console.WriteLine($"Saldo: {valorFuturo:F2}");
                Console.WriteLine($"Valor de Rendimento: {rendimento:F2}");
            }

            Console.ReadKey();
        }
    }
}
