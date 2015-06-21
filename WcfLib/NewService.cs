using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfLib
{
    /// <summary>
    /// Implementacja interfejsu INew
    /// </summary>
    public class NewService : INew
    {
        /// <summary>
        /// Metoda odwracająca string
        /// </summary>
        /// <param name="s">String wejściowy</param>
        /// <returns>Odwrócony string</returns>
        public string ReverseString(string s)
        {
            Console.WriteLine("otrzymano wiadomość: " + s);
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
