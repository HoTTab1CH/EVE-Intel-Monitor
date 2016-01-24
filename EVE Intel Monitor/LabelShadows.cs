using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace EVE_Intel_Monitor
{
    class LabelShadows : Label
    {
        //private bool _drawGradient = false;
        //private Color _startColor = Color.White;
        //private Color _endColor = Color.LightSkyBlue;
        //private float _angle = 0;

        //private bool _drawShadow = false;
        //private float _yOffset = 1;
        //private float _xOffset = 1;
        //private Color _shadowColor = Color.Gray;

        ////paint method using new private variables to control appearance        
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    e.Graphics.SmoothingMode =
        //       System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        //    if (_drawGradient == true)
        //    {
        //        LinearGradientBrush brush = new LinearGradientBrush(new
        //           Rectangle(0, 0, this.Width, this.Height),
        //           _startColor, _endColor, _angle, true);
        //        e.Graphics.FillRectangle(brush, 0, 0,
        //           this.Width, this.Height);
        //    }

        //    if (_drawShadow == true)
        //        e.Graphics.DrawString(this.Text, this.Font,
        //          new SolidBrush(_shadowColor), _xOffset,
        //          _yOffset, StringFormat.GenericDefault);

        //    e.Graphics.DrawString(this.Text, this.Font,
        //          new SolidBrush(this.ForeColor), 0, 0,
        //          StringFormat.GenericDefault);
        //}


    }
}
