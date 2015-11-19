using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using Zhuang.BPM.Services.Test;

namespace Zhuang.BPM.ConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHostManager.OpenRESTfulTestHost();
            Console.ReadKey();
        }
    }
}
