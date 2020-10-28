using System;
using System.Threading.Tasks;

namespace AI.Core
{
    public abstract class BaseAlgorithm
    {
        public object BestIndividual { get; set; }

        protected System.Collections.Generic.IList<System.Windows.Point> _limits;
        protected FunctionNames _functionName;
        protected Random _random;

        protected int _currentGeneration;
        protected int _generation;
        protected int _populationSize;

        public event EventHandler AlgorithmStarted;
        public event EventHandler GenerationEnded;
        public event EventHandler AlgorithmEnded;

        protected BaseAlgorithm(FunctionNames functionName, int populationSize, int generation)
        {
            _random = new Random();
            _functionName = functionName;
            _limits = FunctionLimits.GetLimits(_functionName);
            _populationSize = populationSize;
            _generation = generation;
        }

        protected abstract void Init();

        public abstract Task RunAsync();

        protected abstract Task CalculateAsync();

        protected virtual System.Windows.Point GeneratePoint() => Utilities.GenerateRandomPoint(_random, _limits);

        protected virtual void OnAlgorithmStarted(EventArgs e) => AlgorithmStarted?.Invoke(this, e);

        protected virtual void OnAlgorithmEnded(EventArgs e) => AlgorithmEnded?.Invoke(this, e);

        protected virtual void OnGenerationEnded(EventArgs e) => GenerationEnded?.Invoke(this, e);
    }
}