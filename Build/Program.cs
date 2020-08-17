﻿using System;

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
            IntCodesModified IC = new IntCodesModified(i);
            return IC.IntCodeOutput[0].ToString();
        }
        private static string OrbittingComputer()
        {
            Day6UniversalOrbitMap UOM = new Day6UniversalOrbitMap();
            return UOM.orbits.ToString();
        }
        private static string FindSanta()
        {
            Day6UniversalOrbitMap UOM = new Day6UniversalOrbitMap();
            UOM.ToSanta("YOU", "SAN");
            return UOM.amountToSanta.ToString() + "Total Number of Orbits to Santa.";
        }
        private static string[] SIF()
        {
            Day8SpaceImageFormat SIFForce = new Day8SpaceImageFormat(25, 6, "222202222222222222222221022222220122202022222220222212222220222022002022222200122222222212222222222220222222122222220222122222221222220222222122220222222222222222222222222211022222220222202222222221222202222222222022022222222212022222222202222222222222222222122222211222222222222222122222222222221222222212222222222222222212022222220222202222222222222222222222122222022222222212022222222202222222222220222222222222221222122222221222120222222022222222222222222222222222222212022222220022202122222221222202222222022222002022222202222222222212222222222222222222122222200222022222221222021222222022220222222212222212222222222221222222220222222122222221222222222220222121222022222222022222220212222222222220222222122222200222122222221222022222222022222222222222222222222222222211022222221122212022222220222222222222022020202222222222022222221222222222222220222222122222212222222222221222220222222222220222222222222212222222222210022222222222202122222222222202222221022221012222222200222222220202222222222222022222122222211222022222221222122222222222220222222222222222222222222220122222220222212122222220222222222221222100222022222212222222221202222222222222122222222222210222122222220222022222222022222222222212222212222222222221022222220222202222222222222222222221122101112222222222022222222212222222222221022222222222201222222222220222122222222022221222222222222212222222222210222222222222202222222222222222222220022011122022222201222222221202222222222221022222022222221222222222220222220222222222222222222222222202222222222201122222222022212022222221222212222220022020220222222202222222222212122222222222022222222222212222022222221222020222220222221222222222222212222222222220222222220022212122222222222222222221122111202222222200222222221222122222222220022222222222222222222222020222121222221022221222222212222202222222222220222222222222222222222121222202222220022121210122222220022222221202022222222220222222222222221222022222220222020222221222220222222212222212222222222211122222221122212122222120222212222222122112211222222211122222222222022222222221222222222222210222222222021222120222222122222222222202222222222222222221122222222122202122222020222202222221222122111222222222122222221222022222222220222222122222202222222222220222222222221222220222222222222212222222222202122222220022202022222221222202222220122001000222222220122222220202222222222221222222022222201222122222020222020222222022222222222222222202222222222221222222221122222022222122222212222221122120211122222210202222221212222222222222122222022222210222220222121222220222220022221222222202222202222222222210222212222022202222222022222222222222122000110122222221112222222212122222222220022222222222220222121222120222121222220222221222222202222211222222222211222212220022222122222021222202222221022100002022222200102222222212022222222220022222022222212222020222022222220222220122222222222222222212222222222220222222220022202122222021222212222221122202201222222202002222220202022222222222122222222222201222121222021222222222221222221222202222222200222222222202022202222222212122222022222222222222022111120122222210122222221202122221222221122222122222212222022222121222120222220222221222222222222222222222222210022202222222222022222020222212222221122020222022222202012222220202122220222220022222022222202222120221222222022222220022221222212212222202222222222222020212222222212122222122222212222222022121200222222221022222222202022222222222222222222222201222221221020222120222221222221222212212222222222222222220220212222022202122222021222212222222122002011122222222102221220202022220222222122222122222211222221220022222021222222122221222222212222201222222222201222212220122202222222221222221222220022202101022222210102220222202122220222221022222122222222222221221020222020222221022221222212202222201222222222222122212220122212022222222222221222222122102001221222201102221220222122220222220122222222222221222220222222222120222222222220222222212222200222222222200022202221122202022222022222222222220222111111020222220222222222202222221222220122222122222222222121222021222121222221222220222222212222212222222222222021202221222222122222100222221222220122201102022222202112221220202122221222221022220022222200222021222021222122222221222221222222212222222222222222202222202220222202022222201222212222222222021110021222211002221220202122220222221222220022222210222120220022222021222221022220222212222222220222222222222020202220122202122222211222200222221122000001020222220112221221202222221222221022222122222201222222220022222221222222122220222202202222220222222222222022212221022212222222222222212222221022002120021222220102221220202022221222222122221121222221222222220221222021222222022220222222222222221222222222222022212222222212222222222222202222220222111221121222200122221210222022220222221122222020222201222020220122222122122220222222222212202222220222222222222021202201022222122222012222202222221122102211220222200222222212222122221222221022222020222222222021220122222021022221122221202222212222202222222222221110212211122222122222200222221222220222001100121222211222222220212122222222222122221222222222222222222120222020022220022220212222222222221222222222202102212221022222022222011222201222221222021121022222202222221220222122221222220122220122222221220120221022222122022221122221202212202220221222222222220020222210222222122022001202200222222222022011121222200222221201212022220222221122220020222210222221220022202222122220022221222222222220211222221222200201202212122222222022200212221222220222212111221222202202221202222022221222220022221122222220221220220222222220022221022222222212222222220222220222210010202210022212022122100222220222221022000220020222202202220220212122221222220122220221222210222220222122202022022222122220222222202221222222222222222001202211022202022222121212211222220222202112221222102012220202202122222222221022221120222200222220222021212022022221022220202202222220220222222222202212212210222222122222000202202222220022011011122222101012221220222022222222221222221122222202222221220221222222222220122221212222202222212222221222220001212210222222222222201202201022222022000200120222222122220212212122220222221222222121222211222121222220212020022221222222222202212222210222222222211102202210122212220222012212222022221022202222222222102212221010202022220222220122221122222201220022221121222122122220022220202202202222222222222222201212202211122212220022002222200122222222221010021222212102221110222022222222222222222021222200211221221221202220122221122221212222202222211222220222201102212210222222222022022222221122220122201010021222210012220111202222220222220222221021222221222022220120212122222220222220222212222220202222220222220100202221222202221022212202211022222222211222020222020212221010222222222220220222220220222222221022220121222021222222122222212202222220220222222222202110202210022212021222112222212022221022212220020202220222221222212222222221222222220021222211212122222021212221222221222220222202222221201222222222210212202220222202222222001222212022220022000021120222120112221210212022222220222122221220222011201121222222202122122221122222222202212221220222221022222020222211022222022022012222202222221122122000122202100012220120212122220220221022220122222000202121221020222021022220222222202212212221220222220022220202202212022202121222202222220122220122122100220212011202220111212222220220222222222120222110220222221120222121122222122222202212212220201222221022220221222202222202220022200222200022221212022211020212112112220122202222220221220120222122222002212022200220202121122220022220202212202222220222220222211122222221222202021122210202201022220222010202220212201222220221222122221222220220222222022011221020202120212021122220122221212212222120201222221222220222222201222222222022011212202022220102222020120222201202221102202122221222220021220020022001222121201021222021022222222222202222222022201222221122222221222200222222022122201202220022221102222112222202022202222102212022220221221222222022222001202122212021202121022222122220202222212020202222222022212200222201222222220122011212212022222222200222022202222012222002202222221220220020220020022220202220220020202222222221022222222222212221220222222122202121212201222202220022002202221122222112110102022202000022221000222022221222210021221121022110202022212021212220022222022220202202202120212220222222222012222210222202022222010222210022222222110212122222100212222001202122221221221222202020122110201021212122202112022222222220222202202021202222222022202201222200122212121222011222210022220222212201220222200022222002202222220220221222202222122021201121201121202201022221222222222202212020221220222222212000202210122212020212200202211022222112221110221222211002220001222222220220202222221222122000210222220222222112012221122220202212212121220221222022200001202200022202021012222212212222222222020220120212122222220100202122221020221020212121122221202020221220212021212220222220202202212220221221221222201120202201122212021022021222221220222202022211221212212112220210202022222122202121221021222201220020211022212201102202222220212212222122201221220122220201222201122212220012110202201120222112022010120222010102221012202120220022200221212122022111222220210221202012222221122222202202212022212222221022220020202202122202020212212212211121222122111012220222000002221201202120222122201022221220022211220120202120212121112201122222202212202221202220220122222012202221122222021022211202211221221202102220221222112202222212212020220222211220201222122111210120220221212220122222122221202222222021210220221122200020202222022212120212110202212120222122000122022222011102221220212021222020221121212121222101202122220122212122222211022222002202202021210221221022220121212222022222221202110222202221221002221101221212011202220021202122222122210021212121122101221220211021202221212210122221012222222122222222222022210010002212022222021022101212201222222112120011221222111022220021212020221020221021212220222112001122222122212111002200222222012212222220210222222122202101212220222222021012221222222120220102221221021212111022220001222121220121200022211020021100021122222220212102102212122220222212212222001222221022222221012201022212222212122202200222221202012002020222012012222120222022221121221220220120122022100120221020212121112201222220212202212122221220222022201220022200122202022102021202220022021122001212222212221202222102212021222022200220220120220210222021212020212000012220122221212202222120212221222022211212022202222222220022020202222222221022010120022222011002220012212120220021202212221222120221022022200201222201202201022221222212212121100221222222211210122211222222220002011212202021021222121020121222121102222211222121222120222211210121222002100020210211212220112201222221002222222021021222222122201022222221222202020012110212210122122121220102122202202112220110202220221122220121221221120212211020221211202021212221112221012222212022112221221022202022102212222212021202010222220121020010101121120222010202222022222221220020220002211220120121112022200101212001002222220222002212212021122220220222201000102210222202020012022222220221221012001121120202210122222121012221222122200202222120221001002221210212202200202220010221212212222221100221220122210100222211222212020022120202202022121100102220120212021222221000102020222222200020222121122221111122220112202012022222210220012222212120112220220022202201122202222202120212111222210122121212211212120202111022221002212122221021201012211122222220122221212000212210222220201220112222212222121221221122222110202222022202121102022202202221222222221210021212022022220011022220220021221122212120122110000220212001222120202222012222022202212122212222220222220022012222122222021122120221222220022112121221120212212122222201122221222021212101222121122000001221210200212002001011000221212202222122001220220122222211022210222202122012012202212120222122022010221202202012221122102022221022201212202101020121221020221221202201220212020222222212202220120220222222200010122221122212122202010202210221022012102221221212012122220012122021221222221220201110020202012222222110222012002111011220202212212021002222221022202222102222122202120022211222221220122011202221022212122102220220012021022122211210211111021022020220220100202110200101021220002222202022112121221122202002012222122212222222220211200120122112201120122212211102220201022120222122221100210220222202000221222112222200012100101222112212102220211022222122212102212220122221122012001220222020121011021122021212202112221012022221120222222201212220222202112221220021222120122021110211222202122021012022221122222212022220122222121222122220201121020102122111220222112112222001222221220120201202202221022000012021211211212012011110102202022202002221121220220022220112022201022210021022210222220221220022011001120222102002220120022222022021210002212210122002002022222010222121101211021222212202122220010022021222222002022201022200021202210202112221020002212221020202101222221110020021122120220201221102221212012122212100202200200121220011022222102221002020020222211100222210222222022122022211201022221211111210122202000212222001112022020021200010201212121000101220222011222210100102112200212202210222210220122122211120122221022201021102010211002122020200210212121222010022222012101120022120210210211011020001020120200010222122210102111001102222000021020021020122212222222212122202020202011222212120021002022012220222101002221012102120120102221202210110020202020021221220222000100121110112022222202022002221021222211221002222022201022122221221120220120100210201022222111112222202020220121202221001202011221122120020220211222220120222120221012222200220022220022222221002112212222212222002221210101021120111020101122212211102222122120021121111201221220110022211000222201020212221121201101102212212200022122122020121120100212200102212121112001221110221120201210201122212100012222100122021222020000201202022221011121220201110202020122021010011222212212122211021121220021122102210202210221222200221210220102002100002021222010202220101020022022011222200222001122001012021210202202012002000021010212222020020022221022220011202122220112222221202122212102221111200221020221212211102221101012022201021100222211021120022101022220111222000212020120120212222212020011122221021102111222222222202222212121211101222001201202110020212200002220120201221220212101212222101022001121220202011202112121212202010112212102020020121220022220211222222202202020002202222210022012001022000120202021012221222200120201211202220210120022000222122211220202100002101222200122212212221022201222022011212222210112212120112011202202220111022211012222222101102221200221222112220102202202100020112000221212010212121102120020001010222112022010201122121122210122220002222220122222220121022202201212010120212002212222211102222100120001102211122020212011022202211212110221112110200212222200022201112220121202010212212012201122212121211102221200122011002221212201212222122112122200210111021201112121121110020211100212220111201102110100120202112201101211001111111220100121022110210011011222111121100221020111120010201010001201000000020211220100120001110012102001220021012001110111121111");
            //Day8SpaceImageFormat SIFForce = new Day8SpaceImageFormat(2, 2, "0222112222120000");
            string[] collect = SIFForce.FindMessage();
            return collect;
        }
        static void Main(string[] args)
        {

            //Console.WriteLine(MassCalculator());
            //Console.WriteLine(IntCodesFinder());
            //string[] output = WireCross();
            //Console.WriteLine(output[0]);
            //Console.WriteLine(output[1]);
            //Console.WriteLine(VenusPW() + " Number of Possible Passwords.");
            //Console.WriteLine(ACSystemCheck(1)); //inflight
            //Console.WriteLine(OrbittingComputer()); //inflight day 2
            //Console.WriteLine(FindSanta());
            string[] SIFoutput = SIF();
            string SIFMessage="";
            foreach(string line in SIFoutput)
            {
                SIFMessage+=line;
            }
            Console.WriteLine(SIFMessage);


        }
    }
}
