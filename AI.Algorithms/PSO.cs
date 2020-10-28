using AI.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AI.Algorithms
{
    public class PSO : BaseAlgorithm
    {
        private List<Particle> _population;
        private Particle _gBest;
        private double _c1, _c2;

        public PSO(FunctionNames functionName, int populationSize, int generation)
            : base(functionName, populationSize, generation)
        {

        }

        public PSO SetValues(double c1, double c2)
        {
            _c1 = c1;
            _c2 = c2;
            return this;
        }

        public override async Task RunAsync()
        {
            throw new System.NotImplementedException();
        }

        protected override async Task CalculateAsync()
        {
            throw new System.NotImplementedException();
        }

        protected override void Init()
        {
            throw new System.NotImplementedException();
        }
    }
}