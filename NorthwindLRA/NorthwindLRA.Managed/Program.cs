using NorthwindLRA.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindLRA.Managed
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                var bootsrapper = new ApplicationBootstrapper();
                bootsrapper.Start();

                Console.WriteLine("Bootstrapper initialized, server ready.");
                Console.ReadLine();
            }
            else
            {
                ServiceBase.Run(new ServiceBase[] { new ApplicationService() });
            }
        }
    }
}
