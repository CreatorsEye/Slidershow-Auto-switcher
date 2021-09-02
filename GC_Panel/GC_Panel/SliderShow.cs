using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC_Panel
{
    public partial class SliderShow : UserControl
    {
        // time to create shortcut code
        private Bitmap image1 = GC_Panel.Properties.Resources._1;
        private Bitmap image2 = GC_Panel.Properties.Resources._2;
        private Bitmap image3 = GC_Panel.Properties.Resources._3;
        private Bitmap image4 = GC_Panel.Properties.Resources._4;
        // checkbox stat
        private Bitmap checkon = GC_Panel.Properties.Resources.radiobutton_checked;
        private Bitmap checkoff = GC_Panel.Properties.Resources.radiobutton_no_checked;

        // add as many you want to shortcut the code

        public SliderShow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // in timer will auto switch image after you add this code

        if (Wallpapers.Image == image1)
{
    Wallpapers.Image = image2;
            // if wallpapers image = 1 change into image 2
    btn2.Image = checkon;
    btn1.Image = checkoff;
    btn3.Image = checkoff;
    btn4.Image = checkoff;

}
        else if (Wallpapers.Image == image2)
        {
            Wallpapers.Image = image3;
            // if wallpapers image = 2 change into image 3
            btn3.Image = checkon;
            btn1.Image = checkoff;
            btn2.Image = checkoff;
            btn4.Image = checkoff;
        }
        else if (Wallpapers.Image == image3)
        {
            Wallpapers.Image = image4;
            // if wallpapers image = 3 change into image 4
            btn4.Image = checkon;
            btn1.Image = checkoff;
            btn3.Image = checkoff;
            btn2.Image = checkoff;
        }
        else
        {
            Wallpapers.Image = image1;
            // back into first stat wallpapers image 1
            btn1.Image = checkon;
            btn2.Image = checkoff;
            btn3.Image = checkoff;
            btn4.Image = checkoff;
        }

        }
    }
}
