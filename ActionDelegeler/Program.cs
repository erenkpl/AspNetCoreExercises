using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegeler
{
    internal class Program
    {
        // func, action, predicate
        static void Main(string[] args)
        {
            Action action = new Action(SelamVer); // CTRL ve . (nokta) basınca otomatik metod önerisi verir.
            action.Invoke(); // invoke, delegenin işaret ettiği metodları çağırmak için kullanılır.
            
            Action<string> action2 = new Action<string>(SelamVer2);
            action2 += SelamVer3;
            action2.Invoke("Eren");
            
            // Action tanımlama şekilleri
            Action<string> action3 = new Action<string>(name =>
            {
                Console.WriteLine(name);
            });
            action3.Invoke("Eren");

            // Parametre almayan action tanımlama
            Action action4 = new Action(() =>
            {
                Console.WriteLine("Parametre almayan action tanımı");
            });
            action4.Invoke();

        }

        private static void SelamVer2(string name)
        {
            Console.WriteLine("Selam" + name);
        }
        private static void SelamVer3(string name)
        {
            Console.WriteLine("Selam " + name + " Nasılsın?");
        }

        private static void SelamVer()
        {
            Console.WriteLine("Selam");
        }
    }
}
