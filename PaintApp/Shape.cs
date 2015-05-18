using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public class Shape : IMouseEvents, IHostHandler
    {
        protected static Graphics g;
        protected static bool isButtonClicked;
        protected static Pen selPen = new Pen(Color.Black);
        protected static int startX;
        protected static int startY;
        protected static int currentX;
        protected static int currentY;
        protected static int lengthX;
        protected static int lengthY;
        protected static int previousX;
        protected static int previousY;
        protected static int prevLengthX;
        protected static int prevLengthY;
        //protected static int LengthX
        //{
        //    get { return _lengthX; }
        //    private set { _lengthX = Math.Abs(currentX - startX); }
        //}

        //protected static int LengthY
        //{
        //    get { return _lengthY; }
        //    private set { _lengthY = Math.Abs(currentY - startY); }
        //}

        public void OnMouseDownEvent(object source, MouseEventArgs e)
        {
            Shape.isButtonClicked = true;
            Shape.startX = e.X;
            Shape.startY = e.Y;
        }

        public virtual void OnMouseMoveEvent(object source, MouseEventArgs e)
        { }

        public void OnMouseUpEvent(object source, MouseEventArgs e)
        {
            Shape.isButtonClicked = false;
        }

        public static void SetPen(Color setColor)
        {
            selPen.Color = setColor;
        }

        protected static void SetLengths()
        {
            //lengthX = Math.Abs(currentX - startX);
            //lengthY = Math.Abs(currentY - startY);
            //prevLengthX = Math.Abs(previousX - startX);
            //prevLengthY = Math.Abs(previousY - startY);
            lengthX = (currentX - startX);
            lengthY = (currentY - startY);
            prevLengthX = (previousX - startX);
            prevLengthY = (previousY - startY);
        }

        public void SetHost(Graphics gr)
        {
            g = gr;
        }

        
    }
}
