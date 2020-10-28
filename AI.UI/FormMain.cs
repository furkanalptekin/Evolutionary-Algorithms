using AI.Algorithms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AI.UI
{
    public partial class FormMain : Form
    {
        private readonly Panel _panel;
        private readonly Random _random;
        private Button _button;

        public FormMain()
        {
            InitializeComponent();
            _panel = new Panel();
            _random = new Random();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetPanelColor(object sender, Color color)
        {
            if (_button != null)
            {
                _button.TextAlign = ContentAlignment.MiddleLeft;
                _button.ImageAlign = ContentAlignment.MiddleLeft;
                _button.ForeColor = Color.Gainsboro;
                _button.FlatAppearance.BorderSize = 0;
            }
            _button = (Button)sender;
            _button.ForeColor = color;
            _button.FlatAppearance.BorderSize = 1;
            _button.FlatAppearance.BorderColor = color;
            _button.ImageAlign = ContentAlignment.MiddleRight;
            _button.TextAlign = ContentAlignment.MiddleRight;

            panelMenu.Controls.Add(_panel);
            _panel.Size = new Size(12, _button.Size.Height);
            _panel.Location = new Point(_button.Location.X, _button.Location.Y);
            _panel.BackColor = color;
            _panel.BringToFront();
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(_random.Next(100, 255), _random.Next(100, 255), _random.Next(100, 255));
        }

        private void OpenForm(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = false;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void ButtonAlgorithm_Click(object sender, EventArgs e)
        {
            var buttonName = ((Button)sender).Name.Substring("button".Length);
            var tempColor = GetRandomColor();
            var type = (AlgorithmTypes)Enum.Parse(typeof(AlgorithmTypes), buttonName);

            SetPanelColor(sender, tempColor);
            OpenForm(FormMinimizeProblems.GetInstance(type).SetFormFields(tempColor));
        }

        private void PanelName_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Would you like to open Github page?", "Github", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Process.Start("https://github.com/furkanalptekin");
            }
        }
    }
}