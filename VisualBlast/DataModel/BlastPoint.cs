using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBlast.DataModel
{
    class BlastPoint : DrillPoint
    {
        public int PointExplosiveQuantity { get; set; }
        public double PointBurden { get; set; }
        public DetonatorDelay PointDetonatorDelay { get; set; }

        public BlastPoint(int pointNumber, double pointNorthing, double pointEasting, double pointElevation,
            int pointDiameter, double pointLength, double pointSubDrill, int pointExplosiveQuantity, double pointBurden, DetonatorDelay pointDetonatorDelay)
            : base(pointNumber, pointNorthing, pointEasting, pointElevation,
            pointDiameter, pointLength, pointSubDrill)
        {
            PointExplosiveQuantity = pointExplosiveQuantity;
            PointBurden = pointBurden;
            PointDetonatorDelay = pointDetonatorDelay;
        }
    }
}
