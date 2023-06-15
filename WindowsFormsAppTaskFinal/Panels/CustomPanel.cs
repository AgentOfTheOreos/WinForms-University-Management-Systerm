using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsAppTaskFinal.Panels
{

    public class CustomPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the custom border
            using (var borderPen = new Pen(Color.White, 2)) // Change the color and thickness as desired
            {
                var borderRect = new Rectangle(0, 0, Width - 1, Height - 1);
                e.Graphics.DrawRectangle(borderPen, borderRect);
            }
        }
    }
}