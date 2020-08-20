using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    class Day7AmplificationCircuit : IntCodesModified
    {
        private int[] intCodes;
        private int _AmpOutput;
        public int AmpOutput
        {
            get { return _AmpOutput; }
        }
        private void Reseter()
        {
            this.intCodeReset();
        }

        public void additionalCall(int i)
        {
            this.intCodeAdditionalPass(i);
        }
        public void additionalCall(int[] i, int a)
        {
            intCodes = i;
            this.initialPass(a, intCodes);
            _AmpOutput = this.NounVerb;
        }
        public Day7AmplificationCircuit()
        {
        }
    }
}
