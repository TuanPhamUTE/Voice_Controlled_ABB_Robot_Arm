using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace UIVoice
{
    public partial class HELP : Form
    {
        SpeechRecognitionEngine recognization = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-UK"));
        public HELP()
        {
            InitializeComponent();
            //Speech
            Choices move = new Choices(new string[] {"Linear", "Reorient","Minus X", "Minus Y", "Minus Z","Plus X","Plus Y","Plus Z","Home","Stop","ABB","Coffee",
                                                     "100","200","300","400","500",
                                                     "150","250","350","450","10","20","30","40","50",
                                                     "X Axis", "Y Axis", "Z Axis","Make a coffee","Give a Present","Dance a Little"});

            GrammarBuilder builder = new GrammarBuilder();
            builder.Append(move);
            Grammar grammar = new Grammar(builder);

            recognization.LoadGrammarAsync(grammar);
            recognization.SetInputToDefaultAudioDevice();
            recognization.SpeechRecognized += Recognization_SpeechRecognized;
        }

        private void Recognization_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            txtHelpSpeak.Text = "";
            txtHelpSpeak.Text += e.Result.Text;
        }

        SpeechSynthesizer reader = new SpeechSynthesizer();
        private void btnHelpHear_Click(object sender, EventArgs e)
        {
            if(txtHelpType.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(txtHelpType.Text);
            }
            else
            {
                MessageBox.Show("Please Enter Some Text First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHelpOff_Click(object sender, EventArgs e)
        {
            reader.Dispose();
            recognization.RecognizeAsyncStop();
            btnHelpSpeak.Enabled = true;
            txtHelpType.Text = txtHelpSpeak.Text = "";
        }

        private void btnHelpSpeak_Click(object sender, EventArgs e)
        {
            recognization.RecognizeAsync(RecognizeMode.Multiple);
            btnHelpSpeak.Enabled = false;
        }

        private void HELP_Load(object sender, EventArgs e)
        {
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=D2kchKTdSaY&list=PLpC3GniHRC0OSOFkgt7dYTpNbvlrT5anz");
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=SINjBjG9z2E&list=PLpC3GniHRC0OSOFkgt7dYTpNbvlrT5anz&index=2");
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=vWe1Bn675BE");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=D2kchKTdSaY&list=PLpC3GniHRC0OSOFkgt7dYTpNbvlrT5anz");
        }

        private void label40_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=SINjBjG9z2E&list=PLpC3GniHRC0OSOFkgt7dYTpNbvlrT5anz&index=2");
        }

        private void label42_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=vWe1Bn675BE");
        }
    }
}
