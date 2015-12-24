using MyMSMQClient.MyMSMQService;
using System;
using System.Collections.Generic;
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
            client.SendMessage("Hello World!! 1234");
            client.SendMessage("Hello World!! aaaa");
            client.SendMessage("Hello World!! bbbb");
            client.SendMessage("Hello World!! cccc");
            client.Close();
        }
    }
}
