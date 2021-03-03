using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
        List<string> listas = new List<string>();

        for (int i = 0; i < totalDeCasosDeTeste && i < 100; i++)
        {
            string[] itens = Console.ReadLine().Split(); //separa itens de compra
            var listaProcessada = itens.Distinct();      //retira duplicidade pela funcao Linq
            listaProcessada = listaProcessada            //ordena pela funcao Linq
                                             .Where(x => x != null)
                                             .OrderBy(x => x);

            string listaConcatenada = "";                //agrupa novamente os itens
            foreach (var item in listaProcessada)
            {
                listaConcatenada += item + " ";
            }

            listas.Add(listaConcatenada.Trim());         //Anexa a lista processada ao conjunto
        }
        //imprime listas anexadas
        foreach (string l in listas)
        {
            Console.WriteLine(l);
        }
    }
}
