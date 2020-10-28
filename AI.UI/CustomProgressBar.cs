using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AI.UI
{
    public class CustomProgressBar : ProgressBar
    {
        //https://stackoverflow.com/a/7490884 -> Colored Progress Bar
        //https://stackoverflow.com/a/3529945 -> Text

        public string CustomText { get; set; }
        public Color TextColor { get; set; }

        public CustomProgressBar()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // None... Helps control the flicker.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            const int inset = 1; // A single inset value to control the sizing of the inner rect.

            using (Image offscreenImage = new Bitmap(Width, Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    Rectangle rect = new Rectangle(0, 0, Width, Height);
                    if (ProgressBarRenderer.IsSupported)
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);

                    rect.Inflate(new Size(-inset, -inset)); // Deflate inner rect.
                    rect.Width = (int)(rect.Width * ((double)Value / Maximum));
                    if (rect.Width == 0) rect.Width = 1; // Can't draw rec with width of 0.

                    LinearGradientBrush brush = new LinearGradientBrush(rect, this.BackColor, this.ForeColor, LinearGradientMode.ForwardDiagonal);
                    offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);

                    e.Graphics.DrawImage(offscreenImage, 0, 0);
                    if (CustomText != null)
                    {
                        using (Font font = new Font(FontFamily.GenericSerif, 10, FontStyle.Bold))
                        {
                            SizeF len = e.Graphics.MeasureString(CustomText, font);
                            // Calculate the location of the text (the middle of progress bar)
                            // Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)), Convert.ToInt32((rect.Height / 2) - (len.Height / 2)));
                            Point location = new Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2));
                            // The commented-out code will centre the text into the highlighted area only. This will centre the text regardless of the highlighted area.
                            // Draw the custom text
                            e.Graphics.DrawString(CustomText, font, new SolidBrush(TextColor), location);
                        }
                    }
                }
            }
        }
    }
}