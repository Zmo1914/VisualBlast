using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBlast.DataModel
{
    public abstract class Coordinates
    {
        private Coordinates coordinates;

        public int PointNumber { get; set; }
        public double PointNorthing { get; set; }
        public double PointEasting { get; set; }
        public double PointElevation { get; set; }

        public Coordinates(int pointNumber, double pointNorthing, double pointEasting, double pointElevation)
        {
            PointNumber = pointNumber;
            PointNorthing = pointNorthing;
            PointEasting = pointEasting;
            PointElevation = pointElevation;
        }
    }
}
