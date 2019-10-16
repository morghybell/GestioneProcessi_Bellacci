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

            //avvia un altro processo corrispondente al file TextFile1.txt creato in precedenza
            Process.Start("Notepad.exe", @"C:\Users\studenti\Desktop\GestioneProcessi_Bellacci\GestioneProcessi_Bellacci\TextFile1.txt");

            //avvia un altro processo corrispondente ad una pagina di chrome
            Process.Start("Chrome.exe", @"http://secondarieclago.it/");

            Console.ReadLine();
        }
    }
}
