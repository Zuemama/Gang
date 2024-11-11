using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // Number(40);
          Program.Add(10, 20);
        }

       static int Add(int FN, int SN)
        {
          return FN + SN;
        }

        static void Number(int Target)
        {
          int Start = 0;
          while (Start <= Target)
          {
            Console.WriteLine(Start);
            Start = Start + 2;
          }

        }

        }
    
    }
