using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject
{
    public class Calculadora
    {
        private List<string> _historico;

        public List<string> Historico
        {
            get => _historico.GetRange(_historico.Count - 3, 3);
        }

        public Calculadora()
        {
            _historico = new List<string>();
        }

        public int Somar(params int[] valoresSomar)
        {
            int resultado = valoresSomar.Sum();
            _historico.Add($"{string.Join(" + ", valoresSomar)} = {resultado}");
            return resultado;
        }

        public int Subtrair(int valorInicial, params int[] valoresSubtrair)
        {
            int resultado = valorInicial - valoresSubtrair.Sum();
            _historico.Add($"{valorInicial} - ({string.Join(" + ", valoresSubtrair)}) = {resultado}");
            return resultado;
        }

        public int Dividir(int valorADividir, int valorDivisor)
        {
            int resultado = valorADividir / valorDivisor;
            _historico.Add($"{valorADividir} / {valorDivisor} = {resultado}");
            return resultado;
        }
        public int Multiplicar(params int[] valoresMultiplicar)
        {
            int resultado = 0;

            bool PrimeiraPassagemNoForeach = true;

            foreach (int val in valoresMultiplicar)
            {
                if (PrimeiraPassagemNoForeach)
                    resultado += val;
                else
                    resultado *= val;
                PrimeiraPassagemNoForeach = false;
            }

            _historico.Add($"{string.Join(" x ", valoresMultiplicar)} = {resultado}");
            return resultado;
        }

        public void ImprimirHistorico()
        {
            Console.WriteLine(string.Join("\n", Historico));
        }

    }
}
