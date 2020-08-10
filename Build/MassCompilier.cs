using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    class MassCompilier
    {

        static long[] Masses = {87819,
115026,
134815,
137411,
67764,
99126,
73336,
66216,
81346,
94695,
76336,
148938,
100089,
67341,
101811,
83239,
58537,
146622,
140006,
95115,
87728,
51664,
93463,
127521,
62195,
135326,
104650,
121170,
142794,
125892,
112521,
81326,
110930,
125273,
70131,
52291,
116316,
50670,
82145,
89869,
55474,
146525,
67064,
118129,
74723,
111269,
128051,
131256,
145221,
71059,
137530,
94041,
92331,
134280,
133517,
59611,
113590,
96394,
64731,
53491,
83163,
56863,
51928,
126075,
92833,
106741,
94873,
97241,
105203,
147315,
108651,
67542,
111622,
83522,
125500,
149284,
70747,
78945,
125322,
141425,
111995,
66892,
131105,
86896,
87588,
140571,
116504,
76218,
146224,
127819,
59032,
102767,
137517,
126448,
141218,
102267,
78692,
96306,
56531,
80841};

        public static double MassCalc()
        {
            MassCompilier MV = new MassCompilier();
            double totalDistance = 0;
            foreach (long Mass in Masses)
            {
                MV.distanceCalc = Mass;
                double moduleTotalFuel = 0;
                do
                {
                    moduleTotalFuel += MV.distanceCalc;
                    MV.distanceCalc = MV.distanceCalc;

                }
                while (MV.distanceCalc > 0);
                totalDistance += moduleTotalFuel;
            }
            return totalDistance;
        }
        private double _DistanceCalc;

        public double distanceCalc {
            get { return _DistanceCalc; }
            set { _DistanceCalc = Math.Floor(value / 3) - 2; }
        }
        public double tDistance {
            get { return MassCalc(); }
            }
    }
}
