using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019
{
    class WireCross
    {
        private int _LenthOfWire;

        public int LenOfWire
        {
            get { return _LenthOfWire; }
            set { _LenthOfWire = value;  }
        }
        public struct XYCoord
        {
            public int x;
            public int y;
        }

        List<XYCoord> Path = new List<XYCoord>();
        List<XYCoord> CollisionNodes = new List<XYCoord>();

        public int XCoordCol(int i)
        {
            return CollisionNodes[i].x;
        }
        public int YCoordCol(int i)
        {
            return CollisionNodes[i].y;
        }

        public int NumOfColNodes()
        {
            return CollisionNodes.Count;
        }

        public int NumOfNodes()
        {
            return Path.Count;
        }

        public XYCoord RtnCoordinate(int aryPos)
        {
                return Path[aryPos];
        }

        private int slope(int a, int b)
        {
            if (a == b)
            {
                return 0;
            }else
            {
                return (a - b) / Math.Abs(a - b);
            }
        }
        public bool LengthOfWire(XYCoord w1p1, XYCoord w1p2, int X, int Y)
        {
            if((w1p1.x ==w1p2.x && 
                w1p2.x == X && 
                (Y >= Math.Min(w1p2.y, w1p1.y) && 
                    Y <= Math.Max(w1p2.y, w1p1.y))))
            {
                _LenthOfWire += Math.Abs(Y - w1p1.y);
                return true;
            } else if((w1p1.y == w1p2.y &&
               w1p2.y == Y &&
               (X >= Math.Min(w1p1.x, w1p2.x) && X <= Math.Max(w1p1.x, w1p2.x))))
            {
                _LenthOfWire += Math.Abs(X - w1p1.x);
                return true;
            } else
            {
                if(w1p1.x == w1p2.x)
                {
                    _LenthOfWire += Math.Max(w1p2.y, w1p1.y) - Math.Min(w1p2.y, w1p1.y);
                }
                else
                {
                    _LenthOfWire += Math.Max(w1p2.x, w1p1.x)- Math.Min(w1p2.x, w1p1.x);
                }
                return false;
            }
                    
        }
        private XYCoord colCoordinate(XYCoord w1p1, XYCoord w1p2, XYCoord w2p1, XYCoord w2p2)
        {
            XYCoord NewCoordFAilure = new XYCoord() { x = 0, y = 0 };

            for (int i = Math.Min(w1p2.x, w1p1.x); i<=Math.Max(w1p2.x, w1p1.x); i++)
            {
                for(int j = Math.Min(w2p2.x, w2p1.x); j <= Math.Max(w2p2.x, w2p1.x); j ++)
                {
                    if(i ==j)
                    {
                        for(int a = Math.Min(w1p2.y, w1p1.y); a <= Math.Max(w1p2.y, w1p1.y); a ++)
                        {
                            for (int b = Math.Min(w2p2.y, w2p1.y); b <= Math.Max(w2p2.y, w2p1.y); b ++)
                            {
                                if(a ==b)
                                {
                                    XYCoord NewCoord = new XYCoord() { x = i, y =a };
                                    return NewCoord;
                                }
                            }
                        }
                    }
                }
            }
            return NewCoordFAilure;
        }

        public void Collision(XYCoord Wire1Node1 , XYCoord Wire1Node2, XYCoord Wire2Node1, XYCoord Wire2Node2)
        {
            var aSide = (Wire2Node2.x - Wire2Node1.x) * (Wire1Node1.y - Wire2Node1.y) - (Wire2Node2.y - Wire2Node1.y) * (Wire1Node1.x - Wire2Node1.x) > 0;
            var bSide = (Wire2Node2.x - Wire2Node1.x) * (Wire1Node2.y - Wire2Node1.y) - (Wire2Node2.y - Wire2Node1.y) * (Wire1Node2.x - Wire2Node1.x) > 0;
            var cSide = (Wire1Node2.x - Wire1Node1.x) * (Wire2Node1.y - Wire1Node1.y) - (Wire1Node2.y - Wire1Node1.y) * (Wire2Node1.x - Wire1Node1.x) > 0;
            var dSide = (Wire1Node2.x - Wire1Node1.x) * (Wire2Node2.y - Wire1Node1.y) - (Wire1Node2.y - Wire1Node1.y) * (Wire2Node2.x - Wire1Node1.x) > 0;
            if( aSide != bSide && cSide != dSide)
            {
                XYCoord Colid = colCoordinate(Wire1Node1, Wire1Node2, Wire2Node1, Wire2Node2);
                if (!CollisionNodes.Contains(Colid))
                {
                    CollisionNodes.Add(Colid);
                }
            }
        }

        public void AddCoordinate(string Direction)
        {

            int amount = Convert.ToInt32( Direction.Substring(1, Direction.Length-1));
            int changedLoc;
            int Motion;
            if(Direction[0] =='L'||Direction[0] == 'D')
            {
                Motion = -1;
            } else
            {
                Motion = 1;
            }
            if (Path.Count == 0)
            {
                changedLoc = 0;
                XYCoord NewCoord = new XYCoord() { x = changedLoc, y = changedLoc };
                Path.Add(NewCoord);
            }
            else
            {
                if(Direction[0] == 'U'|| Direction[0] == 'D')
                {
                    changedLoc = Path[Path.Count - 1].y + (Motion * amount);
                    XYCoord NewCoord = new XYCoord() { x = Path[Path.Count - 1].x, y = changedLoc };
                    Path.Add(NewCoord);
                } else
                {
                    changedLoc = Path[Path.Count - 1].x + (Motion * amount);
                    XYCoord NewCoord = new XYCoord() { x = changedLoc, y = Path[Path.Count - 1].y };
                    Path.Add(NewCoord);
                }
                
            }
            
        }

        public WireCross()
        {
            AddCoordinate( "O0");
        }
    }
}
