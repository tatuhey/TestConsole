using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vel = AstroMath.AstroMath.StarVelocity(500.1, 500);
            double dis = AstroMath.AstroMath.StarDistance(0.547);
            double kel = AstroMath.AstroMath.TempInKelvin(27);
            double eve = AstroMath.AstroMath.EventHorizon(8.2e36);
            Console.WriteLine(vel.ToString());
            Console.WriteLine(dis.ToString());
            Console.WriteLine(kel.ToString());
            Console.WriteLine(eve.ToString());
            Console.ReadLine();
        }
    }
}
