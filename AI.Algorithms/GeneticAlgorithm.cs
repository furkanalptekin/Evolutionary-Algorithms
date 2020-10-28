using AI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AI.Algorithms
{
    public class GeneticAlgorithm : BaseAlgorithm
    {
        private List<Point> _population;
        private double _mutationRate;

        public GeneticAlgorithm(FunctionNames functionName, int populationSize, int generation)
            : base(functionName, populationSize, generation)
        {

        }

        public GeneticAlgorithm SetValues(double mutationRate)
        {
            _mutationRate = mutationRate;
            return this;
        }

        protected override void Init()
        {
            _population = new List<Point>();

            for (int i = 0; i < _populationSize; i++)
                _population.Add(GeneratePoint());
        }

        public override async Task RunAsync()
        {
            Init();
            await CalculateAsync();
        }

        protected override async Task CalculateAsync()
        {
            for (int i = 0; i < _generation; i++)
            {
                _currentGeneration = i + 1;
                await SelectionAsync();
            }

            OrderPopulation();
            await Task.Run(() => OnAlgorithmEnded(EventArgs.Empty));
        }

        private async Task SelectionAsync()
        {
            OrderPopulation();

            if (_currentGeneration == 1)
                await Task.Run(() => OnAlgorithmStarted(EventArgs.Empty));

            var selection = _population.GetRange(0, _populationSize / 2);
            await Task.Run(() => CrossOver(selection));
        }

        private void CrossOver(List<Point> selection)
        {
            List<int> _randomValues = new List<int>();
            var newPopulation = new List<Point>();

            for (int i = 0; i < selection.Count / 2; i++)
                _randomValues.Add((int)Math.Ceiling(_random.NextDouble() * selection.Count / 2));

            newPopulation.AddRange(selection.GetRange(0, selection.Count / 4));

            for (int i = 0; i < selection.Count / 2 - 1; i += 2)
            {
                Point[] children = new Point[]
                {
                    GeneratePoint(),
                    GeneratePoint()
                };

                double beta = _random.NextDouble();
                for (int j = 0; j < children.Length; j++)
                {
                    children[j] = new Point(
                        selection[_randomValues[i]].X - beta * (selection[_randomValues[i]].X - selection[_randomValues[i + 1]].X),
                        selection[_randomValues[i]].Y - beta * (selection[_randomValues[i]].Y - selection[_randomValues[i + 1]].Y));
                }

                newPopulation.AddRange(children);
            }

            _population.Clear();
            _population.AddRange(newPopulation);
            Mutate();
        }

        private void Mutate()
        {
            for (int i = 0; i < _population.Count; i++)
                if (_random.NextDouble() < _mutationRate)
                    _population[i] = GeneratePoint();

            Populate();
        }

        private void Populate()
        {
            int neededMembers = _populationSize - _population.Count;
            for (int i = 0; i < neededMembers; i++)
                _population.Add(GeneratePoint());

            OnGenerationEnded(EventArgs.Empty);
        }

        private void OrderPopulation()
        {
            _population = _population.OrderBy(x => x.CalculateFunction(_functionName)).ToList();
            BestIndividual = _population[0];
        }
    }
}