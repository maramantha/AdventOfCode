using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    class IntCodes
    {
        private static int[] IntCodeInput = { 1, 0, 0, 3, 1, 1, 2, 3, 1, 3, 4, 3, 1, 5, 0, 3, 2, 10, 1, 19, 1, 19, 9, 23, 1, 23, 6, 27, 2, 27, 13, 31, 1, 10, 31, 35, 1, 10, 35, 39, 2, 39, 6, 43, 1, 43, 5, 47, 2, 10, 47, 51, 1, 5, 51, 55, 1, 55, 13, 59, 1, 59, 9, 63, 2, 9, 63, 67, 1, 6, 67, 71, 1, 71, 13, 75, 1, 75, 10, 79, 1, 5, 79, 83, 1, 10, 83, 87, 1, 5, 87, 91, 1, 91, 9, 95, 2, 13, 95, 99, 1, 5, 99, 103, 2, 103, 9, 107, 1, 5, 107, 111, 2, 111, 9, 115, 1, 115, 6, 119, 2, 13, 119, 123, 1, 123, 5, 127, 1, 127, 9, 131, 1, 131, 10, 135, 1, 13, 135, 139, 2, 9, 139, 143, 1, 5, 143, 147, 1, 13, 147, 151, 1, 151, 2, 155, 1, 10, 155, 0, 99, 2, 14, 0, 0 };
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
