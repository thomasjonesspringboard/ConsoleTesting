using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    internal class Class2
    {
        static void foo() {
            var _production = Environment.GetEnvironmentVariable("SITProduction");

            Console.WriteLine($"_production = {_production}");

            foreach (EnvironmentVariableTarget enumValue in Enum.GetValues(typeof(EnvironmentVariableTarget)))
            {
                Console.WriteLine(enumValue.ToString());
            }
        }

}
}
