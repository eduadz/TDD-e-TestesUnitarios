using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.services
{
    public class CalculadoraImp
    {
        private List<string> listaHistorico;
        public CalculadoraImp()
        {
            listaHistorico = new List<string>();
        }
        
        public int Somar(int n1, int n2)
        {       
            listaHistorico.Insert(0, "Resultado: "+ (n1+n2));
            return n1+n2;
        }
        public int Multiplicar(int n1, int n2)
        {
            listaHistorico.Insert(0, "Resultado: "+ (n1+n2));
            return n1*n2;
        }
        public int Dividir(int n1, int n2)
        {   
            listaHistorico.Insert(0, "Resultado: "+ (n1+n2));
            return n1/n2;
        }
        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count-3);
            return listaHistorico;
        }
    }
}