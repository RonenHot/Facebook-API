using System;
using System.Windows.Forms;

namespace FacebookDesktopApplication
{
    internal class PainterCloserVisitor
    {
        public void PaintAndClose(Form i_ToPaintAndClose)
        {
            if(i_ToPaintAndClose != null)
            {
                i_ToPaintAndClose.BackColor = System.Drawing.Color.Yellow;
                i_ToPaintAndClose.Close();
            }
            else
            {
                throw new Exception("no Form has been sent over");
            }
        }
    }
}