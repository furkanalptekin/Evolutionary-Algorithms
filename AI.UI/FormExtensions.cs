using System;
using System.Windows.Forms;

namespace AI.UI
{
    public static class FormExtensions
    {
        #region ProgressBar
        /// <summary>
        /// Progress barı bir adım ilerletir. (Animasyonsuz)
        /// </summary>
        /// <param name="pb"></param>
        public static void PerformStepNoAnimation(this ProgressBar pb)
        {
            int nextValue = pb.Value + pb.Step;
            Action PerformStep = () =>
            {
                if (nextValue >= pb.Maximum)
                {
                    pb.Maximum = nextValue + 1;
                    pb.Value = nextValue + 1;
                    pb.Maximum = nextValue;
                }
                else
                    pb.Value = nextValue + 1;

                pb.Value = nextValue;
            };

            if (pb.InvokeRequired)
                pb.Invoke((Action)(() =>
                    PerformStep()
                ));
            else
                PerformStep();
        }
        #endregion

        #region Invokes
        /// <summary>
        /// Label textini değiştirir. Ui thread de çalışıyorsa invoke eder.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="value"></param>
        public static void ChangeText(this Label label, string value)
        {
            if (label.InvokeRequired)
                label.Invoke((Action)(() =>
                    label.Text = value
                ));
            else
                label.Text = value;
        }

        /// <summary>
        /// Charta yeni değer ekler. Ui thread de çalışıyorsa invoke eder.
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="value"></param>
        public static void AddValue(this System.Windows.Forms.DataVisualization.Charting.Chart chart, double value)
        {
            int count = chart.Series["Func"].Points.Count + 1;
            if (chart.InvokeRequired)
                chart.Invoke((Action)(() =>
                    chart.Series["Func"].Points.AddXY(count, value)
                ));
            else
                chart.Series["Func"].Points.AddXY(count, value);
        }

        /// <summary>
        /// Buttonun enabled değerini değiştirir. Ui thread de çalışıyorsa invoke eder.
        /// </summary>
        /// <param name="button"></param>
        /// <param name="value"></param>
        public static void SetEnabledValue(this Button button, bool value)
        {
            if (button.InvokeRequired)
                button.Invoke((Action)(() =>
                    button.Enabled = value
                ));
            else
                button.Enabled = value;
        }
        #endregion
    }
}