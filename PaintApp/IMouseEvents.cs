using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public interface IMouseEvents
    {
        void OnMouseDownEvent(object source, MouseEventArgs e);
        void OnMouseMoveEvent(object source, MouseEventArgs e);
        void OnMouseUpEvent(object source, MouseEventArgs e);
    }
}
