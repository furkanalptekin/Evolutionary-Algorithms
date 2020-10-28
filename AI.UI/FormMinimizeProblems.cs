using AI.Algorithms;
using AI.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AI.UI
{
    public partial class FormMinimizeProblems : Form
    {
        public static FormMinimizeProblems Instance;
        private static AlgorithmTypes _algorithmType;
        private FunctionNames _functionName;
        private BaseAlgorithm _algorithm;

        private FormMinimizeProblems()
        {
            InitializeComponent();
        }

        public static FormMinimizeProblems GetInstance(AlgorithmTypes type)
        {
            if (Instance == null)
                Instance = new FormMinimizeProblems();

            _algorithmType = type;
            return Instance;
        }

        /// <summary>
        /// Farklı tür algoritmalar için gerekli olan bölümleri form üzerinde ayarlar.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public Form SetFormFields(Color color)
        {
            switch (_algorithmType)
            {
                #region GA
                case AlgorithmTypes.GA:
                    numericUpDownRate.Visible = true;
                    numericUpDownRate.Value = 0.001M;
                    labelRate.Visible = true;
                    labelRate.Text = "Mutation Rate : ";
                    labelRate.Location = new System.Drawing.Point(3, 117);
                    labelRate2.Visible = false;
                    numericUpDownRate2.Visible = false;
                    labelName.Text = "GENETİK ALGORİTMA (GA)";
                    break;
                #endregion
                #region PSO
                case AlgorithmTypes.PSO:
                    numericUpDownRate.Visible = true;
                    numericUpDownRate.Value = 2;
                    labelRate.Text = "C1 : ";
                    labelRate.Visible = true;
                    labelRate.Location = new System.Drawing.Point(64, 117);
                    labelRate2.Visible = true;
                    numericUpDownRate2.Visible = true;
                    labelName.Text = "PARÇACIK SÜRÜ OPTİMİZASYONU (PSO)";
                    break;
                #endregion
                #region ABC
                case AlgorithmTypes.ABC:
                    numericUpDownRate.Visible = false;
                    labelRate.Visible = false;
                    labelRate2.Visible = false;
                    numericUpDownRate2.Visible = false;
                    labelName.Text = "YAPAY ARI KOLONİSİ (ABC)";
                    break;
                    #endregion
            }

            #region Colors
            chart1.Series[0].Color = color;
            labelName.ForeColor = color;
            buttonCalculate.BackColor = color;
            progressBar1.ForeColor = color;
            progressBar1.BackColor = color;
            #endregion

            comboBoxAlgorithm.Items.Clear();

            for (int i = 1; i <= Enum.GetValues(typeof(FunctionNames)).Length; i++)
                comboBoxAlgorithm.Items.Add((FunctionNames)i);

            return this;
        }

        private void ChangeLabels(string labelName, System.Windows.Point point)
        {
            foreach (var label in FindLabelsByName(labelName))
            {
                if (label.Name.EndsWith("X"))
                    label.ChangeText(point.X.ToString());
                if (label.Name.EndsWith("Y"))
                    label.ChangeText(point.Y.ToString());
                if (label.Name.EndsWith("Func"))
                    label.ChangeText(point.CalculateFunction(_functionName).ToString());
            }
        }
        private void Clear()
        {
            chart1.Series["Func"].Points.Clear();
            foreach (Label label in panel1.Controls.OfType<Label>())
                if (label.Name.Contains("X") || label.Name.Contains("Y") || label.Name.Contains("Func"))
                    label.Text = "-";

            progressBar1.Value = 0;
            progressBar1.Maximum = (int)numericUpDownGeneration.Value;
        }

        #region Events
        #region Form Events
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Clear();
            var function = comboBoxAlgorithm.SelectedItem;
            if (function == null)
            {
                MessageBox.Show("Fonksiyon boş geçilemez.", "Fonksiyon Seçiniz!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _functionName = (FunctionNames)function;
            var generation = (int)numericUpDownGeneration.Value;
            var populationSize = (int)numericUpDownPopulation.Value;

            switch (_algorithmType)
            {
                case AlgorithmTypes.GA:
                    _algorithm = new GeneticAlgorithm(_functionName, populationSize, generation)
                        .SetValues(mutationRate: (double)numericUpDownRate.Value);
                    break;
                case AlgorithmTypes.PSO:
                    //_algorithm = new PSO(_functionName, populationSize, generation)
                    //    .SetValues(c1: (double)numericUpDownRate.Value, c2: (double)numericUpDownRate2.Value);
                    MessageBox.Show("PSO is WIP", "WIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case AlgorithmTypes.ABC:
                    _algorithm = new ABC(_functionName, populationSize, generation);
                    break;
            }

            _algorithm.AlgorithmStarted += OnAlgoritmStarted;
            _algorithm.AlgorithmEnded += OnAlgorithmEnded;
            _algorithm.GenerationEnded += OnGenerationEnded;
            _algorithm.RunAsync();
        }

        #endregion
        #region Algorithm Events

        private void OnAlgoritmStarted(object sender, EventArgs e)
        {
            buttonCalculate.SetEnabledValue(false);
            ChangeLabels("Beginning", (System.Windows.Point)_algorithm.BestIndividual);
        }

        private void OnAlgorithmEnded(object sender, EventArgs e)
        {
            var best = (System.Windows.Point)_algorithm.BestIndividual;
            ChangeLabels("Current", best);
            ChangeLabels("Final", best);
            buttonCalculate.SetEnabledValue(true);
        }

        private void OnGenerationEnded(object sender, EventArgs e)
        {
            var best = (System.Windows.Point)_algorithm.BestIndividual;
            chart1.AddValue(best.CalculateFunction(_functionName));

            progressBar1.PerformStepNoAnimation();
            progressBar1.CustomText = $"{chart1.Series["Func"].Points.Count} / {(int)numericUpDownGeneration.Value}";

            ChangeLabels("Current", best);
            System.Threading.Thread.Sleep((int)numericUpDownChartDelay.Value);
        }
        #endregion
        #endregion

        private List<Label> FindLabelsByName(string name)
        {
            return panel1.Controls
                .OfType<Label>()
                .Where(x => x.Name.Contains(name))
                .ToList();
        }
    }
}