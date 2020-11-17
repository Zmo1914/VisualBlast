using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBlast.DataModel
{
    class DrillPoint : Coordinates
    {
        public int PointDiameter { get; set; }
        public double PointLength { get; set; }
        public double PointSubDrill { get; set; }

        public DrillPoint(int pointNumber, double pointNorthing, double pointEasting, double pointElevation, 
            int pointDiameter, double pointLength, double pointSubDrill)
            : base(pointNumber, pointNorthing, pointEasting, pointElevation)
        {
            PointDiameter = pointDiameter;
            PointLength = pointLength;
            PointSubDrill = pointSubDrill;
        }
    }
}
