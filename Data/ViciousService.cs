﻿using System;
using System.Threading.Tasks;

namespace ViciousMockeryGenerator.Data
{
    public class ViciousService
    {
        private static readonly string[] Nouns = new[]
       {
            "assface", "buttmuncher", "conehead", "buckethead", "shit", "bitch", "rat monkey", "lake of shame", "coward", "bugbrain",
            "piece of garbage", "fun sucker", "disappointment", "slob", "insult", "prick", "piece of shit"
        };

        private static readonly string[] Adjectives = new[]
      {
            "sick", "dumb", "rusty", "corny", "fidgety", "impatient", "dripping", "sweaty", "utter", "useless", "complete", 
            "crappy", "controlling", "rude", "dark", "cranky", "disappointing", "despised-by-your-own-mom"
        };

        private static readonly string[] Clause = new[]
        {
            "because", "and", "and so"
        };


        public Task<ViciousMockery> GetVicious()
        {
            var rnd = new Random();
            int n1Index = rnd.Next(Nouns.Length);
            int n2Index = rnd.Next(Nouns.Length);
            int a1Index = rnd.Next(Adjectives.Length);
            int a2Index = rnd.Next(Adjectives.Length);
            int cIndex = rnd.Next(Clause.Length);

            string article1;
            string article2;

            var adj1 = Adjectives[a1Index];
            var noun2 = Nouns[n2Index];

            if (StartsWithVowel(adj1))
            {
                article1 = "an";
            }
            else
            {
                article1 = "a";
            }

            if (StartsWithVowel(noun2))
            {
                article2 = "an";
            }
            else
            {
                article2 = "a";
            }

            var viciousmock = new ViciousMockery() { Insult = $"You're {article1} {adj1} {Adjectives[a2Index]} {Nouns[n1Index]} {Clause[cIndex]} you are {article2} {Nouns[n2Index]}!!!" };
            return Task.FromResult(viciousmock);
        }

        private bool StartsWithVowel(string str)
        {
            if (str.StartsWith("a") || str.StartsWith("i") || str.StartsWith("o") || str.StartsWith("e") || str.StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
