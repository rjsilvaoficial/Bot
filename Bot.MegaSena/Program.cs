using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bot.MegaSena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número do concurso: ");

            string numeroDoConcurso = Console.ReadLine();

            if (String.IsNullOrEmpty(numeroDoConcurso))
            {
                numeroDoConcurso = "2462";
            }

            string url = @"https://www.google.com/search?q=concurso+da+mega+sena+" + numeroDoConcurso + "&sxsrf=ALiCzsaLezldtWshHIbhJJ9fSonyWDd4Aw%3A1667787714350&ei=wmtoY8SBFfPX1sQP8oG7mA0&ved=0ahUKEwjE6piygZv7AhXzq5UCHfLADtMQ4dUDCA8&uact=5&oq=concurso+da+mega+sena+2463&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMgYIABAWEB46CggAEEcQ1gQQsAM6BwgAELADEEM6BAgAEEM6BwgAEIAEEAM6CwgAEIAEELEDEIMBSgQIQRgASgQIRhgAUJsmWL8-YKlCaAFwAXgAgAF6iAHABJIBAzAuNZgBAKABAcgBCsABAQ&sclient=gws-wiz-serp";
            //string url = @"https://www.google.com/search?q=concurso+da+mega+sena+2462&sxsrf=ALiCzsaLezldtWshHIbhJJ9fSonyWDd4Aw%3A1667787714350&ei=wmtoY8SBFfPX1sQP8oG7mA0&ved=0ahUKEwjE6piygZv7AhXzq5UCHfLADtMQ4dUDCA8&uact=5&oq=concurso+da+mega+sena+2463&gs_lcp=Cgxnd3Mtd2l6LXNlcnAQAzIFCAAQgAQyBggAEBYQHjIGCAAQFhAeMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeMgYIABAWEB46CggAEEcQ1gQQsAM6BwgAELADEEM6BAgAEEM6BwgAEIAEEAM6CwgAEIAEELEDEIMBSgQIQRgASgQIRhgAUJsmWL8-YKlCaAFwAXgAgAF6iAHABJIBAzAuNZgBAKABAcgBCsABAQ&sclient=gws-wiz-serp";


            //string url = "https://loterias.caixa.gov.br/Paginas/Mega-Sena.aspx";

            string html;

            using(WebClient webClient = new WebClient())
            {
                //webClient.Headers["Cookie"] = "security=true";
                
                html = webClient.DownloadString(url);
            }

            string start = "Veja as dezenas sorteadas:";

            string teste = html.Substring(html.IndexOf(start));

            teste = teste.Substring(0, 54);

            Console.WriteLine(teste);


            Console.ReadKey();
        }
    }
}
