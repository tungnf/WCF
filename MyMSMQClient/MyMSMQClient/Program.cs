using MyMSMQClient.MyMSMQService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMSMQClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MsmqContractClient client = new MsmqContractClient();
            try
            {
                client.SendMessage("Message 1");
                client.SendMessage("Message 2");
                client.SendMessage("Bad");
                client.SendMessage("Message 3");
                client.Close();
            } catch (Exception e) {
                Debug.WriteLine(e.ToString());
            }
        }
    }
}
