using EchoServiceClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace EchoServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            try
            {
                String message;

                for (int i = 0; i < 10; i++)
                {
                    message = "Message [" + i + "]";
                    Console.WriteLine("Sending..." + message);

                    client.Echo(message);

                    // wait 500ms
                    Thread.Sleep(500);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }

        }
    }
}
