using System.Linq;

namespace Pso._1
{
    public partial class ntxtMaxZ : Form
    {



        #region [Properties]



        #endregion



        public ntxtMaxZ()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            rtLog.Clear();
            
            var random = new Random();
            var globalBestPosition = new Position((double)ntxtMaxX.Value, (double)ntxtMaxY.Value);

            var globalBest = new KeyValuePair<Position, double>(globalBestPosition, (double)Math.Abs(globalBestPosition.Z - (double)ntxtTargetZ.Value));


            rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"First GBest: ({globalBest.Key.X},{globalBest.Key.Y},{globalBest.Key.Z})"}).ToArray();
            rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"First min error: {globalBest.Value}"}).ToArray();
            rtLog.Lines = rtLog.Lines.Concat(new List<string> { Environment.NewLine, Environment.NewLine, Environment.NewLine }).ToArray();


            var swarm = Enumerable.Range(0, (int)ntxtParticlesCount.Value).Select(x => new Particle((double)ntxtTargetZ.Value,
                new Position((double)ntxtMinX.Value, (double)ntxtMinY.Value),
                new Position((double)ntxtMaxX.Value, (double)ntxtMaxY.Value)
                , new Position(random.Next((int)ntxtMinX.Value, (int)ntxtMaxX.Value), random.Next((int)ntxtMinY.Value, (int)ntxtMaxY.Value))
                , new Velocity(random.NextDouble(), random.NextDouble())
                , (double)ntxtW.Value, (double)ntxtC1.Value, (double)ntxtC2.Value)).ToList();


            foreach (var iteration in Enumerable.Range(0, (int)ntxtIterationCount.Value))
            {
                rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"Iteration {iteration+1}:", Environment.NewLine }).ToArray();

                KeyValuePair<Position, double>? tempGlobalBest = null;
                for (var counter = 0; counter < swarm.Count; counter++)
                {

                    rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"Particle {counter+1}:"}).ToArray();
                    var particle = swarm[counter];
                    var moveResult = particle.Move(globalBest.Key);

                    var particleNewLocation = particle.AllPositions.Last();
                    rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"Moved to ({particleNewLocation.X},{particleNewLocation.Y},{particleNewLocation.Z})" }).ToArray();
                    rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"PBest is: ({moveResult.Key.X},{moveResult.Key.Y},{moveResult.Key.Z})" }).ToArray();
                    rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"Least error is: {moveResult.Value}" }).ToArray();

                    if (tempGlobalBest == null)
                    {
                        tempGlobalBest = moveResult;
                    }
                    else
                    {
                        if (moveResult.Value < tempGlobalBest.Value.Value)
                        {
                            tempGlobalBest = moveResult;
                        }
                    }

                    rtLog.Lines = rtLog.Lines.Concat(new List<string> {Environment.NewLine,Environment.NewLine}).ToArray();

                }


                if (tempGlobalBest.Value.Value<globalBest.Value)
                {
                    globalBest= tempGlobalBest.Value;
                }


                rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"Iteration {iteration + 1} done." }).ToArray();
                rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"GBest is: ({globalBest.Key.X},{globalBest.Key.Y},{globalBest.Key.Z})" }).ToArray();
                rtLog.Lines = rtLog.Lines.Concat(new List<string> { $"Min error: {globalBest.Value}" }).ToArray();
                rtLog.Lines = rtLog.Lines.Concat(new List<string> { "*****************************************************"}).ToArray();
                rtLog.Lines = rtLog.Lines.Concat(new List<string> { Environment.NewLine, Environment.NewLine }).ToArray();
            }


            btnStart.Enabled = true;

        }
    }
}