using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfLib
{
    /// <summary>
    /// Interfejs-kontrakt
    /// </summary>
    [ServiceContract]
    public interface INew
    {
        /// <summary>
        /// Metoda odwracająca string
        /// </summary>
        /// <param name="s">String wejściowy</param>
        /// <returns>Odwrócony string</returns>
        [OperationContract]
        string ReverseString(string s);
    }
}
