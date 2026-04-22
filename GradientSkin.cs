using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Text;

namespace SIMS3
{
    internal class GradientPanel : Panel
    {
        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color GradientTop { get; set; }

        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color GradientBottom { get; set; }

        public GradientPanel()
        {
            GradientTop = ColorTranslator.FromHtml("#1f1f98");
            GradientBottom = ColorTranslator.FromHtml("#1ca7ec");
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            using (LinearGradientBrush lgb = new LinearGradientBrush(
                this.ClientRectangle,
                this.GradientTop,
                this.GradientBottom,
                90f))
            {
                Graphics g = e.Graphics;
                g.FillRectangle(lgb, this.ClientRectangle);
            }

            base.OnPaint(e);
        }
    }
}

