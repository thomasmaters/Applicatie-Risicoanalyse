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

        /// <summary>
        /// Sets the size of the tooltip when it pops up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnPopup(object sender, PopupEventArgs e) 
        {
            e.ToolTipSize = new Size(300, 300);
        }

        /// <summary>
        /// Drawing of the tooltip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;
            
            // to set the tag for each button or object
            Control parent = e.AssociatedControl;
           
            if (parent.Tag != null)
            {
                Image image = parent.Tag as Image;
                
                if(image != null)
                {
                    //create image brush.
                    TextureBrush b = new TextureBrush(new Bitmap(image,e.Bounds.Size));// get the image from Tag

                    g.FillRectangle(b, e.Bounds);
                    b.Dispose();
                }
            }
                
            g.Dispose();
        }
    }
}
