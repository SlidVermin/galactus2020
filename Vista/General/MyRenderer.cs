using System.Drawing;
using System.Windows.Forms;

namespace Vista.General
{
    class MyRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = e.Item.Selected ? Color.DarkSeaGreen : Color.Transparent;
           using(SolidBrush brush = new SolidBrush(c)){
                e.Graphics.FillRectangle(brush, rc);
            }
          
      }
    }
}
