using AI.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AI.Algorithms
{
    public class ABC : BaseAlgorithm
    {
        private int _scoutLimit;
        private Point[] _foodSources;
        private int[] _trialCounter;

        private readonly int _dimensions = 2;

        public ABC(FunctionNames functionName, int populationSize, int generation)
            : base(functionName, populationSize, generation)
        {

        }

        protected override void Init()
        {
            _scoutLimit = _populationSize * _dimensions / 2;
            _foodSources = GenerateFoodSources();
            _trialCounter = new int[_foodSources.Length];
            BestIndividual = _foodSources.OrderByDescending(x => x.CalculateFitnessFunction(_functionName)).FirstOrDefault();
            OnAlgorithmStarted(EventArgs.Empty);
        }

        public override async Task RunAsync()
        {
            Init();

            for (int i = 0; i < _generation; i++)
                await CalculateAsync();

            await Task.Run(() => OnAlgorithmEnded(EventArgs.Empty));
        }

        protected override async Task CalculateAsync()
        {
            BestIndividual = _foodSources.OrderByDescending(x => x.CalculateFitnessFunction(_functionName)).FirstOrDefault();

            for (int i = 0; i < _foodSources.Length; i++)
                _foodSources[i] = ImproveFoodSource(i);

            var probabilities = CalculateProbabilities();
            for (int i = 0; i < _foodSources.Length; i++)
                _foodSources[i] = ImproveFoodSource(Utilities.RouletteWheelSelection(_random, probabilities));

            TrialControl();
            await Task.Run(() => OnGenerationEnded(EventArgs.Empty));
        }

        private double[] CalculateProbabilities()
        {
            var probabilities = new double[_foodSources.Length];
            var total = _foodSources.Sum(x => x.CalculateFitnessFunction(_functionName));

            for (int i = 0; i < _foodSources.Length; i++)
                probabilities[i] = _foodSources[i].CalculateFitnessFunction(_functionName) / total;

            return probabilities;
        }

        private Point ImproveFoodSource(int index)
        {
            Point point = new Point();
            int dimension = _random.Next(_dimensions);
            int neighbor;

            do
            {
                neighbor = _random.Next(_foodSources.Length);
            } while (index == neighbor);

            if (dimension == 0)
            {
                point.X = Utilities.LimitValue(_limits, _foodSources[index].X + Utilities.GenerateRandomValue(_random, -1, 1) * (_foodSources[index].X - _foodSources[neighbor].X), "X");
                point.Y = _foodSources[index].Y;
            }
            else
            {
                point.X = _foodSources[index].X;
                point.Y = Utilities.LimitValue(_limits, _foodSources[index].Y + Utilities.GenerateRandomValue(_random, -1, 1) * (_foodSources[index].Y - _foodSources[neighbor].Y), "Y");
            }

            if (point.CalculateFitnessFunction(_functionName) < _foodSources[index].CalculateFitnessFunction(_functionName))
            {
                _trialCounter[index]++;
                return _foodSources[index];
            }

            _trialCounter[index] = 0;
            return point;
        }

        private Point[] GenerateFoodSources()
        {
            Point[] Values = new Point[_populationSize / 2];
            for (int i = 0; i < _populationSize / 2; i++)
                Values[i] = Utilities.GenerateRandomPoint(_random, _limits);

            return Values;
        }

        private void TrialControl()
        {
            for (int i = 0; i < _trialCounter.Length; i++)
            {
                if (_trialCounter[i] > _scoutLimit)
                {
                    _foodSources[i] = Utilities.GenerateRandomPoint(_random, _limits);
                    _trialCounter[i] = 0;
                }
            }
        }
    }
}