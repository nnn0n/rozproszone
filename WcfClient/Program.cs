using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfClient.ServiceReference2;

namespace WcfClient
{
    /// <summary>
    /// Klasa klienta, wywołuje usługę u hosta i odbiera wynik
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            NewClient client = new NewClient();

            string text, reversed;
            text = Console.ReadLine();

            reversed = client.ReverseString(text);
            Console.WriteLine(reversed);

            Console.ReadLine();
            client.Close();
        }
    }
}
