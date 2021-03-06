﻿using MyMSMQClient.MyMSMQService;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
                String message;

                for (int i = 0; i < 5; i++)
                {
                    if (i == 3)
                    {
                        // so we will trigger the execptioin or poison message handling
                        message = "Bad";
                    }
                    else
                    {
                        message = "Message " + i;
                    }

                    Console.WriteLine("Sending..." + message);

                    client.SendMessage(message);

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
