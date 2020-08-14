﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    class IntCodes
    {
        private static int[] IntCodeInput1 = {3,225,1,225,
            6,6,1100,1,
            238,225,104,
            0,1002,43,69,
            224,101,-483,
            224,224,4,224,
            1002,223,8,223,
            1001,224,5,224,
            1,224,223,223,
            1101,67,60,225,
            1102,5,59,225,
            1101,7,16,225,
            1102,49,72,225,
            101,93,39,224,
            101,-98,224,224,
            4,224,102,8,
            223,223,1001,224,
            6,224,1,224,
            223,223,1102,35,
            82,225,2,166,
            36,224,101,-4260,
            224,224,4,224,
            102,8,223,223,
            101,5,224,224,
            1,223,224,223,
            102,66,48,224,
            1001,224,-4752,224,
            4,224,102,8,
            223,223,1001,224,
            2,224,1,223,
            224,223,1001,
            73,20,224,1001,
            224,-55,224,4,
            224,102,8,223,
            223,101,7,224,
            224,1,223,224,
            223,1102,18,41,
            224,1001,224,-738,
            224,4,224,102,
            8,223,223,101,
            6,224,224,1,
            224,223,223,1101,
            68,71,225,1102,
            5,66,225,1101,
            27,5,225,1101,
            54,63,224,1001,
            224,-117,224,4,
            224,102,8,223,
            223,1001,224,2,
            224,1,223,224,
            223,1,170,174,
            224,101,-71,224,
            224,4,224,1002,
            223,8,223,1001,
            224,4,224,1,
            223,224,223,4,
            223,99,0,0,
            0,677,0,0,
            0,0,0,0,
            0,0,0,0,
            0,1105,0,99999,
            1105,227,247,1105,
            1,99999,1005,227,
            99999,1005,0,256,
            1105,1,99999,1106,
            227,99999,1106,0,
            265,1105,1,99999,
            1006,0,99999,1006,
            227,274,1105,1,
            99999,1105,1,280,
            1105,1,99999,1,
            225,225,225,1101,
            294,0,0,105,
            1,0,1105,1,
            99999,1106,0,300,
            1105,1,99999,1,
            225,225,225,1101,
            314,0,0,106,
            0,0,1105,1,
            99999,1007,226,226,
            224,1002,223,2,223,1006,224,329,1001,223,1,223,1007,226,677,224,102,2,223,223,1006,224,344,1001,223,1,223,108,677,677,224,102,2,223,223,1005,224,359,1001,223,1,223,1007,677,677,224,1002,223,2,223,1006,224,374,101,1,223,223,8,677,226,224,1002,223,2,223,1006,224,389,101,1,223,223,7,226,226,224,1002,223,2,223,1005,224,404,101,1,223,223,7,677,226,224,102,2,223,223,1005,224,419,1001,223,1,223,8,226,677,224,1002,223,2,223,1005,224,434,101,1,223,223,1008,226,677,224,102,2,223,223,1006,224,449,1001,223,1,223,7,226,677,224,1002,223,2,223,1006,224,464,1001,223,1,223,108,677,226,224,102,2,223,223,1005,224,479,101,1,223,223,108,226,226,224,1002,223,2,223,1006,224,494,101,1,223,223,8,226,226,224,1002,223,2,223,1005,224,509,1001,223,1,223,1107,677,226,224,102,2,223,223,1005,224,524,1001,223,1,223,1107,226,226,224,102,2,223,223,1005,224,539,1001,223,1,223,1108,677,677,224,1002,223,2,223,1006,224,554,101,1,223,223,107,226,677,224,102,2,223,223,1005,224,569,1001,223,1,223,1108,226,677,224,1002,223,2,223,1005,224,584,1001,223,1,223,1107,226,677,224,1002,223,2,223,1005,224,599,1001,223,1,223,1008,226,226,224,1002,223,2,223,1005,224,614,101,1,223,223,107,226,226,224,102,2,223,223,1006,224,629,1001,223,1,223,1008,677,677,224,1002,223,2,223,1006,224,644,101,1,223,223,107,677,677,224,1002,223,2,223,1005,224,659,101,1,223,223,1108,677,226,224,1002,223,2,223,1006,224,674,1001,223,1,223,4,223,99,226

            };
        private static int[] IntCodeInput = { 1, 0, 0, 3,
            1, 1, 2, 3,
            1, 3, 4, 3,
            1, 5, 0, 3,
            2, 10, 1, 19,
            1, 19, 9, 23,
            1, 23, 6, 27,
            2, 27, 13, 31,
            1, 10, 31, 35,
            1, 10, 35, 39,
            2, 39, 6, 43,
            1, 43, 5, 47,
            2, 10, 47, 51,
            1, 5, 51, 55,
            1, 55, 13, 59,
            1, 59, 9, 63,
            2, 9, 63, 67,
            1, 6, 67, 71,
            1, 71, 13, 75,
            1, 75, 10, 79,
            1, 5, 79, 83,
            1, 10, 83, 87,
            1, 5, 87, 91,
            1, 91, 9, 95,
            2, 13, 95, 99,
            1, 5, 99, 103,
            2, 103, 9, 107,
            1, 5, 107, 111,
            2, 111, 9, 115,
            1, 115, 6, 119,
            2, 13, 119, 123,
            1, 123, 5, 127,
            1, 127, 9, 131,
            1, 131, 10, 135,
            1, 13, 135, 139,
            2, 9, 139, 143,
            1, 5, 143, 147,
            1, 13, 147, 151,
            1, 151, 2, 155,
            1, 10, 155, 0,
            99, 2, 14, 0,
            0 };
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
        private void intCodeAdd(int shift1, int shift2, int locChangePosition)
        {
            int temp = IntCodeInput[IntCodeInput[shift1]] + IntCodeInput[IntCodeInput[shift2]];
            if (IntCodeInput[locChangePosition] < IntCodeInput.Length)
            {
                IntCodeInput[IntCodeInput[locChangePosition]] = temp;
            }
        }
        private void intCodeMult(int shift1, int shift2, int locChangePosition)
        {
            int temp = IntCodeInput[IntCodeInput[shift1]] * IntCodeInput[IntCodeInput[shift2]];
            if (IntCodeInput[locChangePosition] < IntCodeInput.Length)
            {
                IntCodeInput[IntCodeInput[locChangePosition]] = temp;
            }
        }
        private bool checkOutputNounVerb(int Ouptput)
        {
            return chkOutput == Ouptput;
        }

        private int[] GetCommandParameters(int input)
        {
            int[] output =  new int[4];
            char[] inputCharArry = input.ToString().ToCharArray();
            switch( inputCharArry.Length)
            {
                case 5:
                    output[0] = Convert.ToInt32(input.ToString().Substring(input.ToString().Length - 2));
                    output[1] = inputCharArry[3];
                    output[2] = inputCharArry[4];
                    output[3] = inputCharArry[5];
                    break;
                case 4:
                    output[0] = Convert.ToInt32(input.ToString().Substring(input.ToString().Length - 2));
                    output[1] = inputCharArry[3];
                    output[2] = inputCharArry[4];
                    break;
                case 3:
                    output[0] = Convert.ToInt32(input.ToString().Substring(input.ToString().Length - 2));
                    output[1] = inputCharArry[3];
                    break;
                default:
                    output[0] = input;
                    break;
            }
            return output;
        }

        private void IntCodeReader(ref int[] inputIntCode)
        {
            for (int i = 0; i < inputIntCode.Length; i += 4)
            {
                int[] CommandCode = GetCommandParameters(inputIntCode[i]);
                switch (CommandCode[0])
                {
                    case 1:
                        intCodeAdd(inputIntCode[CommandCode[1]], inputIntCode[CommandCode[2]], inputIntCode[CommandCode[3]]);
                        break;
                    case 2:
                        intCodeMult(inputIntCode[CommandCode[1]], inputIntCode[CommandCode[2]], inputIntCode[CommandCode[3]]);
                        break;
                    case 3:

                        break;
                    case 4:
                        
                        break;
                    case 99:
                        i = inputIntCode.Length;
                        break;
                }
            }
        }
        private void IntCodeReader()
        {
            for (int i = 0; i < IntCodeInput.Length; i += 4)
            {
                switch (IntCodeInput[i])
                {
                    case 1:
                        intCodeAdd(i + 1, i + 2, i + 3);
                        break;
                    case 2:
                        intCodeMult(i + 1, i + 2, i + 3);
                        break;
                    case 99:
                        i = IntCodeInput.Length;
                        break;
                }
            }
        }
        private void IntCodeLoop()
        {
            for(int i = 0; i <= 99; i++)
            {
                for( int j = 0; j <= 99; j++)
                {
                    IntCodeInputCopy.CopyTo(IntCodeInput,0);
                    IntCodeInput[1] = i;
                    IntCodeInput[2] = j;
                    IntCodeReader();
                    
                    if(checkOutputNounVerb(IntCodeInput[0]))
                    {
                        _NounVerb = (100*i)+j;
                    }
                }
            }
            
        }
        public void TEST(int componentID)
        {
            IntCodeReader(ref IntCodeInput1);
        }
        public IntCodes(int CheckOutput)
        {
            IntCodeInputCopy = new int[IntCodeInput.Length];
                IntCodeInput.CopyTo(IntCodeInputCopy, 0);
            chkOutput = CheckOutput;
            IntCodeInput[1] = 12;
            IntCodeInput[2] = 2;
            IntCodeReader();
            IntCodeOutput = new int[IntCodeInput.Length];
            IntCodeInput.CopyTo(IntCodeOutput,0);
            IntCodeLoop();

        }

    }
}
