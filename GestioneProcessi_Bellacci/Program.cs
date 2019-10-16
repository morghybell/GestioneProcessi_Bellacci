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

            //avvia un processo corrispondente al file TextFile1.txt creato in precedenza
            Process.Start("Notepad.exe", @"C:\Users\studenti\Desktop\GestioneProcessi_Bellacci\GestioneProcessi_Bellacci\TextFile1.txt");

            //avvia un altro processo corrispondente ad una pagina di chrome
            Process.Start("Chrome.exe", @"http://secondarieclago.it/");

            //la variabile app assume il valore di un nuovo processo
            var app = new Process();
            app.StartInfo.FileName = @"Notepad.exe";
            app.Start();

            //avvia un altro processo corrispondente al file TextFile1.txt creato in precedenza
            app.StartInfo.Arguments= @"C:\Users\studenti\Desktop\GestioneProcessi_Bellacci\GestioneProcessi_Bellacci\TextFile1.txt";
            app.Start();

            //chiude tutti i processi con notepad (minuscolo)
            var process = Process.GetProcesses();
            foreach (var p in process)
            {
                if (p.ProcessName == "notepad")
                {
                    p.Kill();
                }
            }
            Console.WriteLine("Programma Terminato");

            Console.ReadLine();
        }
    }
}
