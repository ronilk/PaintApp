using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public class Ellipse : Shape
    {
        public override void OnMouseMoveEvent(object source, MouseEventArgs e)
        {
            if (isButtonClicked)
            {
                previousX = currentX;
                previousY = currentY;
                currentX = e.X;
                currentY = e.Y;
                SetLengths();
                g.DrawEllipse(new Pen(Color.White), startX, startY, prevLengthX, prevLengthY);
                g.DrawEllipse(selPen, startX, startY, lengthX, lengthY);
            }
        }
    }
}
