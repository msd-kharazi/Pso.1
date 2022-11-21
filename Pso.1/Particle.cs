using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pso._1
{
    internal class Particle
    {
        private readonly Random rand;

        #region [Properties]

        public double Target { get; set; }
        public Position MinLimit { get; }
        public Position MaxLimit { get; }
        public List<Position> AllPositions { get; set; }
        public List<double> AllErrors { get; set; }
        public List<Velocity> AllVelocities { get; set; }
        public Position PersonalBest { get; set; }
        public double LeastError { get; set; }

        public double W { get; }
        public double C1 { get; }
        public double C2 { get; }


        #endregion


        #region [ctor]

        public Particle(double target,Position minLimit,Position maxLimit, Position firstPosition, Velocity firstVelocity,double w,double c1,double c2)
        {
            Target = target;
            MinLimit = minLimit;
            MaxLimit = maxLimit;

            AllPositions = new List<Position>
            {
                firstPosition
            };

            PersonalBest = firstPosition;

            LeastError = Math.Abs(firstPosition.Z - target);

            AllErrors = new List<double>
            {
                LeastError
            };

            AllVelocities = new List<Velocity>
            {
                firstVelocity
            };


            W = w;
            C1 = c1;
            C2 = c2;

            rand = new Random();
        }

        #endregion


        #region [Methods]



        #endregion

        public KeyValuePair<Position,double> Move(Position globalBest)
        {
            var currentPosition = AllPositions.Last();
            var currentVelocity = AllVelocities.Last();
            var c1Random =C1* rand.NextDouble();
            var c2Random =C2 * rand.NextDouble();

            var newVelocity = new Velocity(
                (W * currentVelocity.X) + (c1Random * (PersonalBest.X - currentPosition.X)) + (c2Random * (globalBest.X - currentPosition.X)),
                (W * currentVelocity.Y) + (c1Random * (PersonalBest.Y - currentPosition.Y)) + (c2Random * (globalBest.Y - currentPosition.Y)) 
            );

            AllVelocities.Add(newVelocity);


            var newX = newVelocity.X + currentPosition.X;
            
            if (newX > MaxLimit.X)
            {
                newX = MaxLimit.X;
            }

            if (newX < MinLimit.X)
            {
                newX = MinLimit.X;
            }

            var newY = newVelocity.Y + currentPosition.Y;
            
            if (newY > MaxLimit.Y)
            {
                newY = MaxLimit.Y;
            }

            if (newY < MinLimit.Y)
            {
                newY = MinLimit.Y;
            }


            var newPosition = new Position(newX,newY);
            AllPositions.Add(newPosition);
             
            var error =Math.Abs(newPosition.Z - Target);

            AllErrors.Add(error);


            if (error < LeastError)
            {
                PersonalBest = newPosition;
                LeastError = error; 
            }

            var result = new KeyValuePair<Position, double>(PersonalBest, LeastError);
            return result;  
        }

         
    }
}
