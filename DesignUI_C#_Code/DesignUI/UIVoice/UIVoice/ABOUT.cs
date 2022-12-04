using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace UIVoice
{
    
    public partial class ABOUT : Form
    {
        // Nice shape button
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nleft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllisp,
            int nHeightEllisp
        );
        
        public ABOUT()
        {
            InitializeComponent();
        }

        private void ABOUT_Load(object sender, EventArgs e)
        {
            //btnDiscorver.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,btnDiscorver.Width,btnDiscorver.Height,30,30));
            //btnFacebook.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnFacebook.Width, btnFacebook.Height, 30, 30));
            //btnYoutube.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnYoutube.Width, btnYoutube.Height, 30, 30));
        }

        private void btnDiscorver_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://webshop.robotics.abb.com/gl");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100007058026521");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/playlist?list=PLpC3GniHRC0OSOFkgt7dYTpNbvlrT5anz");
        }
    }
}
