using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pso._1
{
    public class Position
    {

        #region [Properties]
        
        public double X { get; set; }
        public double Y { get; set; }
        public double Z => (3 * X * X) - (2 * X * Y) + (3 * Y * Y) - X - Y;

        #endregion


        #region [ctor]

        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }

        #endregion


        #region [Methods]



        #endregion

    }
}
