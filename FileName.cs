using System;
using System.Collections.Generic;
using System.Text;

namespace STUDY.GuessIt
{
    internal class FileName
    {
       public static void abra()
        {
            List<string> frases = new()
            {
                "It seems like you want to",
                "I think you want to",
                "I believe you want to",
                "It looks like you want to",
                "From what I understand, you want to",
                "Apparently, you want to",
                "I guess you want to",
                "It sounds like you want to",
                "Seems like you're trying to",
                "I think you're trying to",
                "It looks like you're trying to",
                "I believe you're trying to"
            };
            Random random = new();

            int indice = random.Next(frases.Count); //---decidindo o indice da lista

            string fraseEscolhida = frases[indice];//---


            Console.WriteLine("What u want to do ma boi?");
            string escolha = Console.ReadLine()!;
            string escolhaLower = escolha.ToLower(); // escolha em lower

            string dance = escolhaLower.Contains("dance") ? $"{fraseEscolhida} dance" : "";
            string play = escolhaLower.Contains("play") ? $"{fraseEscolhida} play" : "";
         

            List<string> escolhaLista = new List<string> { dance, play, nothing }; //-- armazena as escolhas em uma lista

            foreach (string g in escolhaLista)
            {
                if (g != "")
                {
                    Console.WriteLine(g);
                }
            }
        }
    }
}
