using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public class Pencil : IMouseEvents, IHostHandler
    {
        protected static Graphics g;
        protected static bool isButtonClicked;
        protected static SolidBrush br = new SolidBrush(Color.Black);

        public void OnMouseDownEvent(object source, MouseEventArgs e)
        {
            isButtonClicked = true;
        }

        public void OnMouseMoveEvent(object source, MouseEventArgs e)
        {
            if (isButtonClicked)
            {
                g.FillRectangle(br, e.X, e.Y, 1, 1);
            }
        }

        public void OnMouseUpEvent(object source, MouseEventArgs e)
        {
            isButtonClicked = false;
        }

        public void SetHost(Graphics gr)
        {
            g = gr;
        }

        public static void SetBrush(Color c)
        {
            br.Color = c;
        }
    }
}
