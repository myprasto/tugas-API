﻿using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    class Program
    {
        static void Main()
        {
            using (var host = new NancyHost(new Uri("http://localhost:1234/")))
            {
                Console.WriteLine("Nancy now listening - navigating to http://localhost:1234/. Press enter to stop");
                try
                {
                    Process.Start("http://localhost:1234/dinosaur/");
                    host.Start();
                }
                catch (Exception)
                {
                }
                Console.ReadKey();
            }
            Console.WriteLine("Stopped. Good bye!");
        }
    }
}
