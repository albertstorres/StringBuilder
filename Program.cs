using System;
using System.Text;//OBRIGATÓRIO PARA USO DO STRINGBUILDER.
namespace Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = new StringBuilder();//CRIANDO VARIÁVEL DO TIPO STRINGBUILD
            texto.Append("Este texto é um teste");//MUDA A FORMA DE ATRIBUIR VALORES A TEXTO.
            texto.Append("Este texto é um teste");//CADA LINHA É COLADA JUNTO A ANTERIOR.
            texto.Append("Este texto é um teste");

            texto.ToString();//CONVERTENDO STRINGBUILD PARA STRING. TEXTOS MUITO GRANDES O WRITELINE NÃO CONSEGUE CONVERTER.

            Console.WriteLine(texto);//RETORNA "Estetexto é um testeEste texto é um testeEste texto é um teste"
        }
    }
}
