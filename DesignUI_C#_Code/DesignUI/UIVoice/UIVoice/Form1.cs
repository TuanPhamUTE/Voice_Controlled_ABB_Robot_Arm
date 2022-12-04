using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace UIVoice
{
    public partial class Form1 : Form
    {
        //Field
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(15,btnHome.Height);
            panelMenu.Controls.Add(leftBorderBtn);

            // Select Home Form when start
            SetHome();
            OpenChildForm(new HOME());

            //Form 
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(255, 128, 128);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color ABBSTUDIO = Color.FromArgb(0, 0, 113);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(200, 247, 243);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = Color.Red;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon current child form
                iconChild.IconChar = currentBtn.IconChar;
                iconChild.IconColor = Color.FromArgb(0, 0, 113);
            }
        }

        private void SetHome()
        {
            DisableButton();
            //***************** Start Home **********************************************//
            currentBtn = (IconButton)btnHome;
            currentBtn.BackColor = Color.FromArgb(200, 247, 243);
            currentBtn.ForeColor = RGBColor.ABBSTUDIO;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = RGBColor.ABBSTUDIO;
            //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            //currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            // Left border button
            leftBorderBtn.BackColor = Color.Red;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();

            // Icon current child form
            iconChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            iconChild.IconColor = Color.FromArgb(0, 0, 113);
            //***************** End Home **********************************************//
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(32, 178, 170);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm == new HELP() || currentChildForm == new ABOUT() || currentChildForm == new HOME())
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ChildForm);
            panelDesktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        string receivedData;
        private void loadData(string data)
        {
            receivedData = "";
            receivedData = data;

            // Turn off menu
            if (receivedData == "ON")
            {
                btnAbout.Enabled = false;
                btnHelp.Enabled = false;
                btnHome.Enabled = false;
                btnIBR1200.Enabled = false;
            }
            else if (receivedData == "OFF")
            {
                btnAbout.Enabled = true;
                btnHelp.Enabled = true;
                btnHome.Enabled = true;
                btnIBR1200.Enabled = true;
            }
            //else if (receivedData == "YUMI ON")
            //{
            //    btnAbout.Enabled = false;
            //    btnHelp.Enabled = false;
            //    btnHome.Enabled = false;
            //    btnIBR1200.Enabled = false;
            //}
            //else if (receivedData == "YUMI OFF")
            //{
            //    btnAbout.Enabled = true;
            //    btnHelp.Enabled = true;
            //    btnHome.Enabled = true;
            //    btnIBR1200.Enabled = true;
            //}
        }

        IBR1200 IBR1200_form = new IBR1200();
        private void IBR1200_Form()
        {
            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //}
            currentChildForm = IBR1200_form;
            IBR1200_form.TopLevel = false;
            IBR1200_form.FormBorderStyle = FormBorderStyle.None;
            IBR1200_form.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(IBR1200_form);
            panelDesktop.Tag = IBR1200_form;
            IBR1200_form.BringToFront();
            IBR1200_form.truyenData = new IBR1200.TruyenChoCha(loadData);
            IBR1200_form.Show();
        }

        YUMI YUMI_form = new YUMI();
        private void YUMI_Form()
        {
            //if (currentChildForm != null)
            //{
            //    currentChildForm.Close();
            //}
            currentChildForm = YUMI_form;
            YUMI_form.TopLevel = false;
            YUMI_form.FormBorderStyle = FormBorderStyle.None;
            YUMI_form.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(YUMI_form);
            panelDesktop.Tag = YUMI_form;
            //YUMI_form.BringToFront();
            //YUMI_form.truyenData2 = new YUMI.TruyenChoCha2(loadData);
            //YUMI_form.Show();
        }

        private int t = 0;
        int countClick = 0;
        private void btnHome_Click(object sender, EventArgs e)
        {
            countClick = 0;
            ActivateButton(sender, RGBColor.ABBSTUDIO);
            OpenChildForm(new HOME());
        }

        private void btnLogo1_Click(object btnHome, EventArgs e)
        {
            countClick = 0;
            SetHome();
            OpenChildForm(new HOME());
        }
        private void btnLogo2_Click(object btnHome, EventArgs e)
        {
            countClick = 0;
            SetHome();
            OpenChildForm(new HOME());
        }

        private void btnYUMI_Click(object sender, EventArgs e)
        {
            countClick = 0;
            ActivateButton(sender, RGBColor.ABBSTUDIO);
            YUMI_Form();
        }

        
        private void btnIBR1200_Click(object sender, EventArgs e)
        {
            countClick=1;
            ActivateButton(sender, RGBColor.ABBSTUDIO);
            //OpenChildForm(new CONTROLLER());
            IBR1200_Form();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.ABBSTUDIO);
            OpenChildForm(new HELP());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.ABBSTUDIO);
            OpenChildForm(new ABOUT());
        }


        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconChild_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show("Do you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
