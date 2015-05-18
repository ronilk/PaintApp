using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApp
{
    public class ToolFactory
    {
        public static IHostHandler GetToolObject(string name)
        {
            IHostHandler tool = null;
            switch (name)
            {
                case "Rectangle":
                    tool = new Rectangle();
                    break;
                case "Ellipse":
                    tool = new Ellipse();
                    break;
                case "Pencil":
                    tool = new Pencil();
                    break;
                default:
                    break;
            }

            return tool;
        }
    }
}
