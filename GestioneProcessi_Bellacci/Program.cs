using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneProcessi_Bellacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sull'esercitazione dei processi");

            //avvia un processo
            Process.Start("Notepad.exe");

            Console.ReadLine();
        }
    }
}
