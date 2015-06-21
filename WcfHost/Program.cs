using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfLib;

namespace WcfHost
{
    /// <summary>
    /// Klasa hosta, ustawia nasłuchiwanie i udostępnia usługę
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("net.tcp://192.168.0.10:8000/WCF/");
            ServiceHost selfHost = new ServiceHost(typeof(NewService), baseAddress);
            NetTcpBinding b = new NetTcpBinding();
            b.Security.Mode = SecurityMode.None;

            try
            {
                selfHost.AddServiceEndpoint(typeof(INew), b, "NewService");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                //smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
