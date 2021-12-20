using AnimatedTextGenerator.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimatedTextGenerator.CustomControls
{
    public partial class MaterialTextBox : UserControl
    {
        private Color _BorderColor = ColorTheme.Surface;
        private Color _ActiveBorderColor = ColorTheme.Primary;
        private int _BorderSize = 2;
        private const int PaddingBottom = 2;

        bool _IsLoaded = false;
        private System.Windows.Forms.Timer t;
        PointF p1;
        PointF p2;
        private int StepCounterIn;
        private int StepCounterOut;
        private int Duration = 200;
        private int StepDuration = 10;
        public MaterialTextBox()
        {
            InitializeComponent();
            p1 = new PointF(this.Padding.Left, this.Height - 1);
            p2 = new PointF(this.Width - this.Padding.Right, this.Height - 1);
            t = new();
            t.Interval = StepDuration;
        }

        //now we do some magic
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!_IsLoaded) 
            {
                Graphics g = e.Graphics;
            
                using (Pen pen = new(_BorderColor, _BorderSize))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    g.DrawLine(pen, this.Padding.Left, this.Height-1, this.Width - this.Padding.Right, this.Height - 1);
                }
                _IsLoaded = true;
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode) UpdateControHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControHeight();
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            //_BorderColor = ColorTheme.Primary;
            StepCounterIn = 0;
            t.Stop();
            t.Tick += FadeIn;
            t.Start();
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            //_BorderColor = ColorTheme.Surface;
            StepCounterOut = 0;
            t.Tick += FadeOut;
            t.Stop();
            t.Start();
        }

        private void UpdateControHeight()
        {
            if (!textBox1.Multiline)
            {
                int height = TextRenderer.MeasureText("test", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new System.Drawing.Size(0, height);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void UpdatePadding()
        {
            var p = this.Padding;
            p.Bottom = _BorderSize + PaddingBottom;
            this.Padding = p;
        }

        void FadeIn(object? sender, EventArgs e)
        {
            try
            {
                StepCounterIn++;
                float mid = this.Width / 2;
                float stepw = (mid / Duration) * StepDuration;

                float x = stepw * StepCounterIn;

                using (Pen pen = new(_ActiveBorderColor, _BorderSize))
                {
                    this.CreateGraphics().DrawLine(pen, mid, this.Height - 1, mid + x, this.Height - 1);

                    this.CreateGraphics().DrawLine(pen, mid, this.Height - 1, mid - x, this.Height - 1);
                }

                if (StepCounterIn * StepDuration > Duration)
                {
                    StepCounterIn = 0;
                    t.Tick -= FadeIn;
                    t.Stop();
                }
            }
            catch (System.ObjectDisposedException) { }
        }
        void FadeOut(object? sender, EventArgs e) 
        {
            try
                {
                StepCounterIn++;
                float mid = this.Width / 2;
                float stepw = (mid / Duration) * StepDuration;

                float x = stepw * StepCounterIn;

                using (Pen pen = new(_BorderColor, _BorderSize))
                {
                    this.CreateGraphics().DrawLine(pen, 0, this.Height - 1, 0 + x, this.Height - 1);

                    this.CreateGraphics().DrawLine(pen, this.Width, this.Height - 1, this.Width - x, this.Height - 1);
                }

                if (StepCounterOut * StepDuration > Duration)
                {
                    StepCounterOut = 0;
                    t.Tick -= FadeOut;
                    t.Stop();
                }

            }
            catch(System.ObjectDisposedException) { }
        }

        public Color BorderColor { get => _BorderColor; set{ _BorderColor = value; this.Invalidate(); }  }
        public int BorderSize { get => _BorderSize; set { _BorderSize = value; UpdatePadding();  this.Invalidate(); } }
        public string Txt { get => this.textBox1.Text; set => this.textBox1.Text = value;}
                
    }
}
