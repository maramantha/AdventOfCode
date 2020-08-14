using System;

namespace AdventOfCode2019
{
    class Program
    {
        private static string MassCalculator()
        {
            MassCompilier MassValue = new MassCompilier();
            return MassValue.tDistance.ToString() + " Total Fuel Needed.";
        }
        
        private static string IntCodesFinder()
        {
            IntCodes IC = new IntCodes(19690720);
            return "Orgin Int Value: " + IC.IntCodeOutput[0].ToString() + " Noun/Verb Output: " + IC.NounVerb.ToString();

        }
        private static string[] WireCross()
        {
            WireGenerator WG = new WireGenerator();
            
            string[] Partition = new string[2];
            Partition[0] = WG.ManhattanNumber.ToString() + " is the Manhattan Number to the closest collision.";
            Partition[1] = WG.CollisonLength() + " is the closest collision in terms of steps.";

            return Partition;
        }
        private static string VenusPW()
        {
            PasswordCheck PWC = new PasswordCheck(372037, 905157);
                       
            return PWC.Password.ToString();
        }
        private static string ACSystemCheck(int i)
        {
            IntCodes IC = new IntCodes(i);
            IC.TEST(i);
            return "Hello World!";
        }
        static void Main(string[] args)
        {

            //Console.WriteLine(MassCalculator());
            //Console.WriteLine(IntCodesFinder());
            //string[] output = WireCross();
            //Console.WriteLine(output[0]);
            //Console.WriteLine(output[1]);
            Console.WriteLine(VenusPW() + " Number of Possible Passwords.");
            //Console.WriteLine(ACSystemCheck(1));
        }
    }
}
