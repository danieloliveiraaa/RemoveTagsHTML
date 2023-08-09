using System;
using System.Text.RegularExpressions;

namespace RemoveTagsHTML
{
    class Program
    {
        //DANIEL OLIVEIRA
        //teste
        //recebendo um texto em HTML, removendo suas tags (<div> <a> por exemplo), mantendo o texto original.

        static void Main(string[] args)
        {
            var htmlString = "Olá, tudo bem! <div></div>Você clicou no globinho? Ele é um link digital.<div></div>caso não consiga, me comunique para corrigir.";

            string texto = RemoveHtmlTags(htmlString);

            Console.WriteLine("TEXTO ORIGINAL:" + htmlString);
            Console.WriteLine("TEXTO CORRIGIDO:" + texto);
        }

        public static string RemoveHtmlTags(string htmlString)
        {
            string tags = @"<[^>]+?>";

            string texto = Regex.Replace(htmlString, tags, string.Empty);

            return texto;
        }
    }
}
