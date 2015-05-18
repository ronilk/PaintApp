using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PaintApp
{
    public class Rectangle : Shape
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
                g.DrawRectangle(new Pen(Color.White), startX, startY, prevLengthX, prevLengthY);
                g.DrawRectangle(selPen, startX, startY, lengthX, lengthY);
            }
        }
    }
}
