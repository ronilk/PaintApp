using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class Form1 : Form
    {
        //Shape currShape;
        IHostHandler tool;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Shape.SetPen(Color.Black);            
            tool = ToolFactory.GetToolObject("Rectangle");
            Graphics g = panel1.CreateGraphics();
            tool.SetHost(g);   
            BindEvents(tool);

            //System.Drawing.Graphics formGraphics = panel1.CreateGraphics();
            //string drawString = "Sample Text";
            //System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 116);
            //System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            //int x = 327;
            //int y = 64;
            //System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            //g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            //g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            
        }

        private void BindEvents(IHostHandler tool)
        {
            //Graphics g = panel1.CreateGraphics();
            //tool.SetHost(g);

            if (tool is IMouseEvents)
            {
                panel1.MouseDown += new MouseEventHandler((tool as IMouseEvents).OnMouseDownEvent);
                //panel1.MouseMove += new MouseEventHandler((s, em) => currShape.OnMouseMoveEvent(s, em, g));
                panel1.MouseMove += new MouseEventHandler((tool as IMouseEvents).OnMouseMoveEvent);
                panel1.MouseUp += new MouseEventHandler((tool as IMouseEvents).OnMouseUpEvent);
            }
        }

        private void UnBindEvents(IHostHandler tool)
        {
            if (tool is IMouseEvents)
            {
                panel1.MouseDown -= new MouseEventHandler((tool as IMouseEvents).OnMouseDownEvent);
                //panel1.MouseMove += new MouseEventHandler((s, em) => currShape.OnMouseMoveEvent(s, em, g));
                panel1.MouseMove -= new MouseEventHandler((tool as IMouseEvents).OnMouseMoveEvent);
                panel1.MouseUp -= new MouseEventHandler((tool as IMouseEvents).OnMouseUpEvent);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult res = colorDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                Color c = colorDialog1.Color;
                Shape.SetPen(c);
                Pencil.SetBrush(c);
            }
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            SetUpTool("Ellipse");
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            SetUpTool("Rectangle");
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            SetUpTool("Pencil");
        }

        private void SetUpTool(string toolName)
        {
            UnBindEvents(tool);
            tool = ToolFactory.GetToolObject(toolName);
            Graphics g = panel1.CreateGraphics();
            tool.SetHost(g);
            BindEvents(tool);
        }
        
    }
}
