﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    //day 5 AOC
    class IntCodesModified
    {
        private static int[] IntCodeTest = { 3, 0, 4, 0, 99 };
        private static int[] IntCodeInput = { 3, 225, 1, 225, 
            6, 6, 1100, 1, 
            238, 225, 104, 0, 
            1002, 43, 69, 224, 
            101, -483, 224, 224, 
            4, 224, 1002, 223, 
            8, 223, 1001, 224, 
            5, 224, 1, 224, 
            223, 223, 1101, 67, 
            60, 225, 1102, 5, 
            59, 225, 1101, 7, 
            16, 225, 1102, 49, 
            72, 225, 101, 93, 
            39, 224, 101, -98, 
            224, 224, 4, 224, 
            102, 8, 223, 223, 
            1001, 224, 6, 224, 
            1, 224, 223, 223, 
            1102, 35, 82, 225, 
            2, 166, 36, 224, 
            101, -4260, 224, 224, 
            4, 224, 102, 8, 
            223, 223, 101, 5, 
            224, 224, 1, 223, 
            224, 223, 102, 66, 
            48, 224, 1001, 224, 
            -4752, 224, 4, 224, 
            102, 8, 223, 223, 
            1001, 224, 2, 224, 
            1, 223, 224, 223, 
            1001, 73, 20, 224, 
            1001, 224, -55, 224, 
            4, 224, 102, 8, 
            223, 223, 101, 7, 
            224, 224, 1, 223, 
            224, 223, 1102, 18,
            41, 224, 1001, 224, 
            -738, 224, 4, 224,
            102, 8, 223, 223,
            101, 6, 224, 224,
            1, 224, 223, 223,
            1101, 68, 71, 225,
            1102, 5, 66, 225,
            1101, 27, 5, 225, 
            1101, 54, 63, 224,
            1001, 224, -117, 224,
            4, 224, 102, 8,
            223, 223, 1001, 224,
            2, 224, 1, 223,
            224, 223, 1, 170,
            174, 224, 101, -71,
            224, 224, 4, 224,
            1002, 223, 8, 223,
            1001, 224, 4, 224,
            1, 223, 224, 223,
            4, 223, 99, 0,
            0, 0, 677, 0,
            0, 0, 0, 0,
            0, 0, 0, 0,
            0, 0, 1105, 0,
            99999, 1105, 227, 247,
            1105, 1, 99999, 1005,
            227, 99999, 1005,0,
            256, 1105, 1, 99999,
            1106, 227, 99999, 1106,
            0, 265, 1105, 1,
            99999, 1006, 0, 99999,
            1006, 227, 274, 1105,
            1, 99999, 1105, 1,
            280, 1105, 1, 99999,
            1, 225, 225, 225,
            1101, 294, 0, 0,
            105, 1, 0, 1105,
            1, 99999, 1106, 0,
            300, 1105, 1, 99999,
            1, 225, 225, 225,
            1101, 314, 0, 0,
            106, 0, 0, 1105,
            1, 99999, 1007, 226,
            226, 224, 1002, 223,
            2, 223, 1006, 224,
            329, 1001, 223, 1,
            223, 1007, 226, 677,
            224, 102, 2, 223,
            223, 1006, 224, 344, 
            1001, 223, 1, 223,
            108, 677, 677, 224,
            102, 2, 223, 223,
            1005, 224, 359, 1001,
            223, 1, 223, 1007,
            677, 677, 224, 1002, 223, 2, 223, 1006, 224, 374, 101, 1, 223, 223, 8, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 389, 101, 1, 223, 223, 7, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 404, 101, 1, 223, 223, 7, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 419, 1001, 223, 1, 223, 8, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 434, 101, 1, 223, 223, 1008, 226, 677, 224, 102, 2, 223, 223, 1006, 224, 449, 1001, 223, 1, 223, 7, 226, 677, 224, 1002, 223, 2, 223, 1006, 224, 464, 1001, 223, 1, 223, 108, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 479, 101, 1, 223, 223, 108, 226, 226, 224, 1002, 223, 2, 223, 1006, 224, 494, 101, 1, 223, 223, 8, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 509, 1001, 223, 1, 223, 1107, 677, 226, 224, 102, 2, 223, 223, 1005, 224, 524, 1001, 223, 1, 223, 1107, 226, 226, 224, 102, 2, 223, 223, 1005, 224, 539, 1001, 223, 1, 223, 1108, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 554, 101, 1, 223, 223, 107, 226, 677, 224, 102, 2, 223, 223, 1005, 224, 569, 1001, 223, 1, 223, 1108, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 584, 1001, 223, 1, 223, 1107, 226, 677, 224, 1002, 223, 2, 223, 1005, 224, 599, 1001, 223, 1, 223, 1008, 226, 226, 224, 1002, 223, 2, 223, 1005, 224, 614, 101, 1, 223, 223, 107, 226, 226, 224, 102, 2, 223, 223, 1006, 224, 629, 1001, 223, 1, 223, 1008, 677, 677, 224, 1002, 223, 2, 223, 1006, 224, 644, 101, 1, 223, 223, 107, 677, 677, 224, 1002, 223, 2, 223, 1005, 224, 659, 101, 1, 223, 223, 1108, 677, 226, 224, 1002, 223, 2, 223, 1006, 224, 674, 1001, 223, 1, 223, 4, 223, 99, 226 };
        private int[] IntCodeInputCopy;


        private int[] _IntCodeOutput;
        public int[] IntCodeOutput
        {
            get { return _IntCodeOutput; }
            set { _IntCodeOutput = value; }
        }
        private int chkOutput;
        private int _NounVerb;
        public int NounVerb
        {
            get { return _NounVerb; }
        }
        private int intCodeAdd(int shift1, int shift2)
        {
            return  shift1 + shift2;
        }
        private int intCodeMult(int shift1, int shift2)
        {
            return  shift1 * shift2;
        }
        private bool checkOutputNounVerb(int Ouptput)
        {
            return chkOutput == Ouptput;
        }
        private void IntCodeReader(ref int[] input)
        {
            for (int i = 0; i < input.Length; i += 4)
            {
                int opcode = input[i] % 10;
                int p1 = input[i] / 100 % 10;
                int p2 = input[i] / 1000 % 10;
                int p3 = input[i] / 10000 % 10;
                switch (opcode)
                {
                    case 1:
                        input[p3 > 0 ? input[i + 3] : input[input[p3]]] = intCodeAdd(p1>0? input[i+1]: input[input[p1]], p2 > 0 ? input[i + 2] : input[input[p2]]);
                        break;
                    case 2:
                        input[p3 > 0 ? input[i + 3] : input[input[p3]]] = intCodeMult(p1 > 0 ? input[i + 1] : input[input[p1]], p2 > 0 ? input[i + 2] : input[input[p2]]);
                        break;
                    case 3:
                        input[input[i + 1]] = chkOutput;
                        i += 2;
                        break;
                    case 4:
                        if (input[i + 2] == 99)
                        {
                            i = input.Length;
                        }
                        i -= 2;
                        break;
                    case 99:
                        i = input.Length;
                        break;
                }
            }
        }
        private void IntCodeLoop()
        {
            for (int i = 0; i <= 99; i++)
            {
                for (int j = 0; j <= 99; j++)
                {
                    IntCodeInputCopy.CopyTo(IntCodeInput, 0);
                    IntCodeInput[1] = i;
                    IntCodeInput[2] = j;
                    IntCodeReader(ref IntCodeInput);

                    if (checkOutputNounVerb(IntCodeInput[0]))
                    {
                        _NounVerb = (100 * i) + j;
                    }
                }
            }

        }
        public IntCodesModified(int CheckOutput)
        {
            IntCodeInputCopy = new int[IntCodeInput.Length];
            IntCodeInput.CopyTo(IntCodeInputCopy, 0);
            chkOutput = CheckOutput;
            IntCodeReader(ref IntCodeInput);
            IntCodeOutput = new int[IntCodeInput.Length];
            IntCodeInput.CopyTo(IntCodeOutput, 0);
            //IntCodeLoop();

        }
    }
}