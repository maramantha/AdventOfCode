using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    //day 5 AOC
    class IntCodesModified
    {

        private List<int> IntCodeInput = new List<int>();



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
            return shift1 + shift2;
        }
        private int intCodeMult(int shift1, int shift2)
        {
            return shift1 * shift2;
        }
        private bool checkOutputNounVerb(int Ouptput)
        {
            return chkOutput == Ouptput;
        }
        private int choice(int item, int a, int i)
        {
            if (item != 0)
            {
                return a + i;
            }
            else
            {
                return IntCodeInput[a + i];
            }
        }

        private void SetIndexLoc(int index, int value)
        {
            if (index < IntCodeInput.Count)
            {
                IntCodeInput[(int)index] = value;
            }
            else
            {
                while (IntCodeInput.Count < index)
                {
                    IntCodeInput.Add(0);
                }

                IntCodeInput.Add(value);
            }
        }
        private int IntCodeReader()
        {
            int i = 0;
            while (i < IntCodeInput.Count)
            {
                int opcode = IntCodeInput[i] % 100;
                if (opcode == 99)
                {
                    return IntCodeInput[0];
                }
                int p1 = IntCodeInput[i] / 100 % 10;
                p1 = choice(p1, 1, i);
                int p2 = IntCodeInput[i] / 1000 % 10;
                p2 = choice(p2, 2, i);
                int p3 = IntCodeInput[i] / 10000 % 10;
                p3 = choice(p3, 3, i);
                switch (opcode)
                {
                    case 1:
                        IntCodeInput[p3] = intCodeAdd(IntCodeInput[p1], IntCodeInput[p2]);
                        i += 4;
                        break;
                    case 2:
                        IntCodeInput[p3] = intCodeMult(IntCodeInput[p1], IntCodeInput[p2]);
                        i += 4;
                        break;
                    case 3:
                        IntCodeInput[IntCodeInput[i + 1]] = chkOutput;
                        i += 2;
                        break;
                    case 4:
                        if (IntCodeInput[i + 2] == 99)
                        {
                            return IntCodeInput[IntCodeInput[i + 1]];
                        }
                        i += 2;
                        break;
                    case 5:
                        if (IntCodeInput[p1] != 0)
                        {
                            i = IntCodeInput[p2];
                        }
                        else
                        {
                            i += 3;
                        }
                        break;
                    case 6:
                        if (IntCodeInput[p1] == 0)
                        {
                            i = IntCodeInput[p2];
                        }
                        else
                        {
                            i += 3;
                        }
                        break;
                    case 7:
                        if (IntCodeInput[p1] < IntCodeInput[p2])
                        {
                            IntCodeInput[p3] = 1;
                        }
                        else
                        {
                            IntCodeInput[p3] = 0;
                        }
                        i += 4;
                        break;
                    case 8:
                        if (IntCodeInput[p1] == IntCodeInput[p2])
                        {
                            IntCodeInput[p3] = 1;
                        }
                        else
                        {
                            IntCodeInput[p3] = 0;
                        }
                        i += 4;
                        break;

                    case 99:
                        i = IntCodeInput.Count;
                        break;
                    default:
                        i += 4;
                        break;
                }
            }
            return IntCodeInput[0];
        }
        public void intCodeAdditionalPass(int i)
        {
            chkOutput = i;
            _NounVerb = IntCodeReader();
        }
        public void intCodeReset()
        {
            IntCodeInput.Clear();
            foreach (int i in _IntCodeOutput)
            {
                IntCodeInput.Add(i);
            }
        }
        public void initialPass(int CheckOutput, int[] IntCodeInputlist)
        {

            chkOutput = CheckOutput;
            foreach (int i in IntCodeInputlist)
            {
                IntCodeInput.Add(i);
            }
            _NounVerb = IntCodeReader();
            _IntCodeOutput = IntCodeInput.ToArray();
        }
        public IntCodesModified()
        {
        }
    }
}
