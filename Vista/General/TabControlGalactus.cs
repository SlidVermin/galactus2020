using System.Drawing;
using System.Windows.Forms;

namespace Vista.General
{
    class TabControlGalactus : TabControl
    {
        public TabControlGalactus() {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            SizeMode = TabSizeMode.Normal;
            ItemSize = new Size(120, 120);
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();
            Alignment = TabAlignment.Left;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap b = new Bitmap(Height, Width);
            Graphics g = Graphics.FromImage(b);
            Rectangle tabRectangulo = new Rectangle(0,0,b.Width,b.Height);

            g.Clear(Color.FromArgb(226, 234, 243));

            for (var i = 0; i <= TabCount -1; i++)
            {
                tabRectangulo = GetTabRect(i);
 
                if (i == SelectedIndex)
                {
                    g.FillRectangle(Brushes.LightSteelBlue, tabRectangulo);
                }
                else {
                    g.FillRectangle(Brushes.WhiteSmoke, tabRectangulo);
                }

                g.DrawString(TabPages[i].Text, Font, Brushes.Black, tabRectangulo, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

            } 

            e.Graphics.DrawImage(b, 0, 0);

            g.Dispose(); b.Dispose();
            base.OnPaint(e);
        }

    }
}
