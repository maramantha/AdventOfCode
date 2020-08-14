using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    class PasswordCheck
    {
        private int _Password;
        public int Password
        {
            get { return _Password; }
        }
        public struct PWHitCounter
        {
            public char chkMatch;
            public int numberOfHits;
        }
        public struct PWboundaries
        {
            public int minVal;
            public int maxVal;
        }
        private bool adjacentMatch(int val)
        {
            PWHitCounter HC = new PWHitCounter();
            List<PWHitCounter> LPW = new List<PWHitCounter>();
            bool chkOutput = true;
            char[] chkVal = val.ToString().ToCharArray();
            for (int i = 0; i < chkVal.Length-1; i++)
            {
                if(chkVal[i] == chkVal[i+1])
                {
                    PWHitCounter HC1 = new PWHitCounter();
                    HC1.chkMatch = chkVal[i];
                    HC1.numberOfHits = 2;
                    for (int j = i +1; j<chkVal.Length-1;j++)
                    {
                        
                        if (chkVal[j] == chkVal[i])
                        {
                            HC1.numberOfHits++;
                            i = j;
                        } else
                        {
                            j = chkVal.Length;
                            
                        }
                    }
                    LPW.Add(HC1);

                }
            }
            if (LPW.Count > 0)
            {
                foreach (PWHitCounter Hit in LPW)
                {
                    if (Hit.numberOfHits % 2 != 0)
                    {
                        chkOutput = false;
                    }
                }
                return chkOutput;
            }

                return false;
        }
        private bool NeverDecrease(int val)
        {
            string chkVal = val.ToString();
            for (int i = 0; i < chkVal.Length-1; i++)
            {
                if (Convert.ToInt32(chkVal[i]) > Convert.ToInt32(chkVal[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }

        private void PasswordGuesser(PWboundaries bd)
        {
            for(int i = bd.minVal; i <= bd.maxVal; i++)
            {
                if(i > 100000)
                {
                    if(adjacentMatch(i))
                    {
                        if(NeverDecrease(i))
                        {
                            _Password++;
                        }
                    }
                }
            }
        }

        public PasswordCheck(int Min, int Max)
        {
            PWboundaries Bound = new PWboundaries();
            Bound.minVal = Min;
            Bound.maxVal = Max;
            PasswordGuesser(Bound);
        }
    }
}
