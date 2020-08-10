using System;

namespace AdventOfCode2019
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MassCompilier MassValue = new MassCompilier();
            Console.WriteLine(MassValue.tDistance + " Total Fuel Needed.");
            IntCodes IC = new IntCodes(19690720);
                Console.WriteLine(IC.IntCodeOutput[0].ToString());
            Console.WriteLine(IC.NounVerb);
        }
    }
}
