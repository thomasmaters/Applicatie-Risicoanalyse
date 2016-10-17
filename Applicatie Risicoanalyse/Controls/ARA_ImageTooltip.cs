using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Applicatie_Risicoanalyse.Controls
{
    public partial class ARA_ImageTooltip : ToolTip
    {
        public ARA_ImageTooltip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private void OnPopup(object sender, PopupEventArgs e) // use this event to set the size of the tool tip
        {
            e.ToolTipSize = new Size(300, 200);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e) // use this to customzie the tool tip
        {
            Graphics g = e.Graphics;
            
            // to set the tag for each button or object
            Control parent = e.AssociatedControl;
           
            if (parent.Tag != null)
            {
                Image pelican = parent.Tag as Image;
                //create your own custom brush to fill the background with the image
                TextureBrush b = new TextureBrush(new Bitmap(pelican));// get the image from Tag

                g.FillRectangle(b, e.Bounds);
                b.Dispose();
            }
                
            g.Dispose();
        }
    }
}
