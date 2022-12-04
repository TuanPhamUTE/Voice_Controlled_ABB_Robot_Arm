using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Synthesis;
using System.Runtime.InteropServices;
using System.Speech.Recognition;

namespace UIVoice
{
    public partial class IBR1200 : Form
    {
        // Delegate 
        public delegate void TruyenChoCha(string text);
        public TruyenChoCha truyenData;


        //Speech
        SpeechRecognitionEngine recognization = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-UK"));

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

        int enableDisOrAuto = 0;
        public IBR1200()
        {
            InitializeComponent();
            // Speech
            rdoText.Checked = true;

            //Speech
            Choices move = new Choices(new string[] {"Linear", "Reorient","Minus  X", "Minus  Y", "Minus  Z","Plus X","Plus Y"," Plus Z","Home","Stop","ABB",
                                                     "100","200","300","400","500",
                                                     "150","250","350","450","10","20","30","40","50"});

            GrammarBuilder builder = new GrammarBuilder();
            builder.Append(move);
            Grammar grammar = new Grammar(builder);

            recognization.LoadGrammarAsync(grammar);
            recognization.SetInputToDefaultAudioDevice();
            recognization.SpeechRecognized += Recognization_SpeechRecognized;
        }

        

        static int count = 0;

        // Warning variable
        int countWarning = 0;
        int countVoice = 0;
        string checkVoice1, checkVoice2, checkVoice3;
        int checkStatus1 = 0, checkStatus2 = 0, checkStatus3 = 0, checkStatus = 0;
        string[] Function1 =  new string[2] { "Linear", "Reorient" };
        string[] Direction1 = new string[6]  { "Minus X", "Minus Y", "Minus Z", "Plus  X", "Plus  Y", "Plus  Z" };
        string[] Parameter1 = new string[14]  { "100", "200", "300", "400", "500", "150", "250", "350", "450", "10","20","30","40","50"};

        int checkError(string x1, string x2, string x3, int num)
        {
            for(int i=0; i< Function1.Length; i++)
            {
                if(x1 == Function1[i])
                {
                    checkStatus1 = num;
                }
            }
            for(int j =0; j< Direction1.Length; j++)
            {
                if(x2 == Direction1[j])
                {
                    checkStatus2 = num;
                }
            }
            for(int k=0; k< Parameter1.Length; k++)
            {
                if(x3 == Parameter1[k])
                {
                    checkStatus3 = num;
                }
            }
            //rdoText.Text = checkStatus1.ToString() + " " + checkStatus2.ToString() + " " + checkStatus3.ToString();
            return (checkStatus1+checkStatus2+checkStatus3)/ 3;
        }

        void sendStringVoice()
        {
            Thread.Sleep(0);
            txtStatus.Text = String.Empty;
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtVoice.Text))
                {
                    client.Send(txtVoice.Text);
                    txtVoice.Text = string.Empty;
                }
            }
            else
            {
                client = new SimpleTcpClient(txtHost.Text, Convert.ToInt32(txtPort.Text));
                // client.Connect();
            }
        }

        SimpleTcpClient client;
        string temp;
        private void Recognization_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if(e.Result.Text == "Plus X")
            {
                temp = "Plus  X";
            }
            else if (e.Result.Text == "Plus Y")
            {
                temp = "Plus  Y";
            }
            else if (e.Result.Text == "Plus Z")
            {
                temp = "Plus  Z";
            }
            else
            {
                temp = e.Result.Text;
            }

            if(checkDistanceAndAuto == 1)
            {
                if (temp == "Home" || temp == "Stop")
                {
                    count = 0;
                    txtVoice.Text = temp;
                    sendStringVoice();
                }
                else
                {
                    count++;
                    // Get value from 3 syntax
                    switch (count)
                    {
                        case 1:
                            checkVoice1 = temp;
                            txtVoice.Text += temp + ",";
                            break;
                        case 2:
                            checkVoice2 = temp;
                            txtVoice.Text += temp + ",";
                            break;
                        case 3:
                            checkVoice3 = temp;
                            txtVoice.Text += temp;

                            switch (countWarning)
                            {
                                case 1:
                                    checkStatus = checkError(checkVoice1, checkVoice2, checkVoice3, 1);
                                    if (checkStatus != 1)
                                    {
                                        MessageBox.Show("Syntax Error! Your select is [Function,Direction,Parameter]");
                                        txtVoice.Text = String.Empty;
                                    }
                                    else
                                    {
                                        sendStringVoice();
                                    }
                                    break;
                                case 2:
                                    checkStatus = checkError(checkVoice1, checkVoice3, checkVoice2, 2);
                                    if (checkStatus != 2)
                                    {
                                        MessageBox.Show("Syntax Error! Your select is [Function,Parameter,Direction]");
                                        txtVoice.Text = String.Empty;
                                    }
                                    else
                                    {
                                        sendStringVoice();
                                    }
                                    break;
                                case 3:
                                    checkStatus = checkError(checkVoice2, checkVoice1, checkVoice3, 3);
                                    if (checkStatus != 3)
                                    {
                                        MessageBox.Show("Syntax Error! Your select is [Direction,Function,Parameter]");
                                        txtVoice.Text = String.Empty;
                                    }
                                    else
                                    {
                                        sendStringVoice();
                                    }
                                    break;
                                case 4:
                                    checkStatus = checkError(checkVoice3, checkVoice1, checkVoice2, 4);
                                    if (checkStatus != 4)
                                    {
                                        MessageBox.Show("Syntax Error! Your select is [Direction,Parameter,Function]");
                                        txtVoice.Text = String.Empty;
                                    }
                                    else
                                    {
                                        sendStringVoice();
                                    }
                                    break;
                                case 5:
                                    checkStatus = checkError(checkVoice2, checkVoice3, checkVoice1, 5);
                                    if (checkStatus != 5)
                                    {
                                        MessageBox.Show("Syntax Error! Your select is [Parameter,Function,Direction]");
                                        txtVoice.Text = String.Empty;
                                    }
                                    else
                                    {
                                        sendStringVoice();
                                    }
                                    break;
                                case 6:
                                    checkStatus = checkError(checkVoice3, checkVoice2, checkVoice1, 6);
                                    if (checkStatus != 6)
                                    {
                                        MessageBox.Show("Syntax Error! Your select is [Parameter,Direction,Function]");
                                        txtVoice.Text = String.Empty;
                                    }
                                    else
                                    {
                                        sendStringVoice();
                                    }
                                    break;
                            }
                            // rdoVoice.Text = checkVoice1 + checkVoice2 + checkVoice3;
                            checkStatus1 = checkStatus2 = checkStatus3 = 0;
                            count = 0;
                            break;
                    }
                }
            }
            else if (checkDistanceAndAuto == 2)
            {
                txtVoice.Text = temp;
                if (temp == "Linear" || temp == "Reorient" || temp == "Minus X" || temp == "Minus Y" || temp == "Minus Z" ||
                   temp == "Plus  X" || temp == "Plus  Y" || temp == "Plus  Z" || temp == "Home" || temp == "Stop")
                {
                    sendStringVoice();
                }
                else
                {
                    txtVoice.Text = string.Empty;
                }
            }

            //if (count == 3)
            //{
            //    txtVoice.Text += e.Result.Text;
            //    Thread.Sleep(0);
            //    txtStatus.Text = String.Empty;
            //    if (client.IsConnected)
            //    {
            //        if (!string.IsNullOrEmpty(txtVoice.Text))
            //        {
            //            client.Send(txtVoice.Text);
            //            //lstB_STATUS.Text += $"Me: {txt_SEND_STRING.Text}{Environment.NewLine}";
            //            txtVoice.Text = string.Empty;
            //        }
            //    }
            //    else
            //    {
            //        client = new SimpleTcpClient(txtHost.Text, Convert.ToInt32(txtPort.Text));
            //        // client.Connect();
            //    }
            //    count = 0;
            //}
            //else
            //{
            //    txtVoice.Text += e.Result.Text + ",";
            //}
        }

        private void CONTROLLER_Load(object sender, EventArgs e)
        {
            // Nice button
            //btnSend.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSend.Width, btnSend.Height, 30, 30));
            //btnVoice.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnVoice.Width, btnVoice.Height, 30, 30));
            //btnClear.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 30, 30));
            //btnConnect.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConnect.Width, btnConnect.Height, 30, 30));
            //btnDisconnect.Region = Region.FromHrg n(CreateRoundRectRgn(0, 0, btnDisconnect.Width, btnDisconnect.Height, 30, 30));
            //btnHome.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnHome.Width, btnHome.Height, 30, 30));
            //btnDistance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDistance.Width, btnDistance.Height, 30, 30));
            //btnStop.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnStop.Width, btnStop.Height, 30, 30));
            //btnAuto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAuto.Width, btnAuto.Height, 30, 30));
            //btnDisable.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDisable.Width, btnDisable.Height, 30, 30));

            client = new SimpleTcpClient(txtHost.Text, Convert.ToInt32(txtPort.Text));
            client.Events.Connected += Events_Connected;
            client.Events.DataReceived += Events_DataReceived;
            client.Events.Disconnected += Events_Disconnected;

            // Menu drop down 
            panelFirst.Height = btnFirst.Height;
            panelSecond.Height = btnFirst.Height;
            panelThird.Height = btnFirst.Height;

            // Disable all button 
            btnDisconnect.Enabled = false;
            btnVoice.Enabled = false;
            btnDisable.Enabled = false;
            btnHome.Enabled = false;
            btnStop.Enabled = false;
            btnDistance.Enabled = false;
            btnAuto.Enabled = false;
            btnSend.Enabled = false;
            btnClear.Enabled = false;
            btnSubmit.Enabled = false;
            btnClearConfig.Enabled = false;
            rdoText.Enabled = false;
            rdoVoice.Enabled = false;
            btnFirst.Enabled = false;
            btnSecond.Enabled = false;
            btnThird.Enabled = false;
            txtVoice.Enabled = false;
        }

        private void Events_Disconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtStatus.Text = String.Empty;
                txtStatus.Text += $"Server disconnected.{Environment.NewLine}";
            });
        }

        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtStatus.Text = String.Empty;
                txtStatus.Text += $"{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Connected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtStatus.Text = String.Empty;
                txtStatus.Text += $"Server Connected {Environment.NewLine}";
            });
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            count = 0;
            txtStatus.Text = String.Empty;
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtVoice.Text))
                {
                    client.Send(txtVoice.Text);
                    //lblStatus.Text += $"Me: {txt_SEND_STRING.Text}{Environment.NewLine}";
                    txtVoice.Text = string.Empty;
                }
            }
            else
            {
                client = new SimpleTcpClient(txtHost.Text, Convert.ToInt32(txtPort.Text));
                client.Connect();
            }
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            countVoice = 1;
            recognization.RecognizeAsync(RecognizeMode.Multiple);
            btnVoice.Enabled = false;
            btnVoice.ForeColor = Color.White;
            btnDisable.BackColor = Color.Gray;
            btnDisable.Enabled = true;
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            countVoice = 0;
            recognization.RecognizeAsyncStop();
            btnVoice.Enabled = true;
            btnDisable.ForeColor = Color.White;
            rdoText.Enabled = true;
            btnVoice.BackColor = Color.Gray;
            btnDisable.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVoice.Text = "";
            count = 0;

            //// Menu 
            //btnFirst.Text = "Position 1";
            //btnSecond.Text = "Position 2";
            //btnThird.Text = "Position 2";

            //btnFunction1.Enabled = true;
            //btnFunction2.Enabled = true;
            //btnFunction3.Enabled = true;

            //btnDirection1.Enabled = true;
            //btnDirection2.Enabled = true;
            //btnDirection3.Enabled = true;

            //btnParameter1.Enabled = true;
            //btnParameter2.Enabled = true;
            //btnParameter3.Enabled = true;


            //btnFunction1.BackColor = Color.FromArgb(224,224,224);
            //btnFunction2.BackColor = Color.FromArgb(224, 224, 224);
            //btnFunction3.BackColor = Color.FromArgb(224, 224, 224);

            //btnDirection1.BackColor = Color.FromArgb(224, 224, 224);
            //btnDirection2.BackColor = Color.FromArgb(224, 224, 224);
            //btnDirection3.BackColor = Color.FromArgb(224, 224, 224);

            //btnParameter1.BackColor = Color.FromArgb(224, 224, 224);
            //btnParameter2.BackColor = Color.FromArgb(224, 224, 224);
            //btnParameter3.BackColor = Color.FromArgb(224, 224, 224);

            //status1 = 0;
            //status2 = 0;
            //status3 = 0;
        }

        private void rdoText_CheckedChanged(object sender, EventArgs e)
        {
            txtVoice.Enabled = true;
            txtVoice.ReadOnly = false;
            btnVoice.Enabled = false;
            btnDisable.Enabled = false;
            rdoVoice.ForeColor = Color.Black;
            rdoText.ForeColor = Color.Green;
            btnFirst.Enabled = false;
            btnSecond.Enabled = false;
            btnThird.Enabled = false;
            btnAuto.Enabled = false;
            btnVoice.Enabled = false;
            btnDistance.Enabled = false;
            recognization.RecognizeAsyncStop();
        }

        private void rdoVoice_CheckedChanged(object sender, EventArgs e)
        {
            txtVoice.Enabled = false;
            txtVoice.ReadOnly = true;
            rdoVoice.ForeColor = Color.Green;
            rdoText.ForeColor = Color.Black;
            btnAuto.Enabled = true;
            btnDistance.Enabled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Send data
                client.Connect();
                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "Connected";

                // Enable all button 
                btnDisconnect.Enabled = true;
                //btnVoice.Enabled = true;
                //btnDisable.Enabled = true;
                btnHome.Enabled = true;
                btnStop.Enabled = true;
                btnSend.Enabled = true;
                btnClear.Enabled = true;
                rdoText.Enabled = true;
                rdoVoice.Enabled = true;
                txtVoice.Enabled = true;
                //txtStatus.Text = "Server Connected";

                //Send ON
                string test = "ON";
                if (test.Length > 0)
                {
                    if (truyenData != null)
                    {
                        truyenData(test);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            recognization.RecognizeAsyncStop();
            // Send OFF
            string test = "OFF";
            if (test.Length > 0)
            {
                if (truyenData != null)
                {
                    truyenData(test);
                }
            }

            sendStringToController("7");
            txtVoice.Text = string.Empty;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnDisconnect.Enabled = false;
            btnVoice.Enabled = false;
            btnDisable.Enabled = false;
            btnHome.Enabled = false;
            btnStop.Enabled = false;
            btnDistance.Enabled = false;
            btnAuto.Enabled = false;
            btnSend.Enabled = false;
            btnClear.Enabled = false;
            btnSubmit.Enabled = false;
            btnClearConfig.Enabled = false;
            rdoText.Enabled = false;
            rdoVoice.Enabled = false;
            btnFirst.Enabled = false;
            btnSecond.Enabled = false;
            btnThird.Enabled = false;
            txtVoice.Enabled = false;

            lblStatus.Text = "Disconnect";
            lblStatus.ForeColor = Color.Red;
            btnDistance.BackColor = Color.Gray;
            btnAuto.BackColor = Color.Gray;
            rdoText.Checked = true;
            txtStatus.Text = string.Empty;
        }

        void sendStringToController(string stringsSend)
        {
            if (client.IsConnected) client.Send(stringsSend);
            else client = new SimpleTcpClient(txtHost.Text, Convert.ToInt32(txtHost.Text));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sendStringToController("Home");

            // Distance Auto default
            btnDistance.BackColor = Color.Gray;
            checkDistanceAndAuto = 0;
            btnFirst.Enabled = false;
            btnSecond.Enabled = false;
            btnThird.Enabled = false;
            btnSubmit.Enabled = false;
            btnClearConfig.Enabled = false;

            btnAuto.BackColor = Color.Gray;
            checkDistanceAndAuto = 0;
            btnVoice.Enabled = false;
            btnDisable.Enabled = false;
            recognization.RecognizeAsyncStop();

            countDistance = 0;
            countAuto = 0;

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sendStringToController("Stop");

            // Distance Auto default
            btnDistance.BackColor = Color.Gray;
            checkDistanceAndAuto = 0;
            btnFirst.Enabled = false;
            btnSecond.Enabled = false;
            btnThird.Enabled = false;
            btnSubmit.Enabled = false;
            btnClearConfig.Enabled = false;

            btnAuto.BackColor = Color.Gray;
            checkDistanceAndAuto = 0;
            btnVoice.Enabled = false;
            btnDisable.Enabled = false;
            recognization.RecognizeAsyncStop();

            countDistance = 0;
            countAuto = 0;
        }

        int countDistance = 0;
        int countAuto = 0;

        int checkDistanceAndAuto = 0;
        private void btnDistance_Click(object sender, EventArgs e)
        {
            countDistance++;
            countAuto = 0;
            btnAuto.BackColor = Color.Gray;
            if (countDistance%2 != 0)
            {
                sendStringToController("DISTANCE"); enableDisOrAuto = 1;
                btnDistance.BackColor = Color.Blue;
                checkDistanceAndAuto = 1;
                btnFirst.Enabled = true;
                btnSecond.Enabled = true;
                btnThird.Enabled = true;
                btnSubmit.Enabled = true;
                btnClearConfig.Enabled = true;

                // Disable voice
                recognization.RecognizeAsyncStop();
                btnVoice.Enabled = false;
            }
            else
            {
                sendStringToController("NULL"); 
                btnDistance.BackColor = Color.Gray;
                checkDistanceAndAuto = 0;
                btnFirst.Enabled = false;
                btnSecond.Enabled = false;
                btnThird.Enabled = false;
                btnSubmit.Enabled = false;
                btnClearConfig.Enabled = false;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            countAuto++;
            countDistance = 0;
            btnDistance.BackColor = Color.Gray;
            if (countAuto%2 != 0)
            {
                sendStringToController("AUTO"); enableDisOrAuto = 2;
                btnAuto.BackColor = Color.Blue;
                checkDistanceAndAuto = 2;
                btnVoice.Enabled = true;

                //if(rdoText.Checked == false)
                //{
                //    btnVoice.Enabled = true;
                //    btnDisable.Enabled = false;
                //}
                //else
                //{
                //    btnVoice.Enabled = false;
                //    btnDisable.Enabled = false;
                //}
                
            }
            else
            {
                sendStringToController("NULL");
                btnAuto.BackColor = Color.Gray;
                checkDistanceAndAuto = 0;
                btnVoice.Enabled = false;
                btnDisable.Enabled = false;
                recognization.RecognizeAsyncStop();
            }
            btnFirst.Enabled = false;
            btnSecond.Enabled = false;
            btnThird.Enabled = false;
            btnSubmit.Enabled = false;
            btnClearConfig.Enabled = false;
        }

        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            if (panelFirst.Height == 140)
            {
                panelFirst.Height = btnFirst.Height;
            }
            else
            {
                panelFirst.Height = 140;
                panelSecond.Height = btnFirst.Height;
                panelThird.Height = btnFirst.Height;
            }
        }

        private void btnSecond_Click_1(object sender, EventArgs e)
        {
            if (panelSecond.Height == 140)
            {
                panelSecond.Height = btnFirst.Height;
            }
            else
            {
                panelSecond.Height = 140;
                panelSecond.BringToFront();
                panelFirst.Height = btnFirst.Height;
                panelThird.Height = btnFirst.Height;
            }
        }

        private void btnThird_Click_1(object sender, EventArgs e)
        {
            if (panelThird.Height == 140)
            {
                panelThird.Height = btnFirst.Height;
            }
            else
            {
                panelThird.Height = 140;
                panelFirst.Height = btnFirst.Height;
                panelSecond.Height = btnFirst.Height;
            }
        }

        static int status1 = 0;
        static int status2 = 0;
        static int status3 = 0;
        static int status_generate = 0;


        private void btnFunction1_Click(object sender, EventArgs e)
        {
            if(status1 == 2)
            {
                btnDirection2.Enabled = true;
                btnDirection3.Enabled = true;
            }
            else if(status1 == 3)
            {
                btnParameter2.Enabled = true;
                btnParameter3.Enabled = true;
            }
            status1 = 1;
            btnFunction2.Enabled = false;
            btnFunction3.Enabled = false;
            panelFirst.Height = btnFirst.Height;
            btnFirst.Text = btnFunction1.Text;

            btnFunction1.BackColor = Color.FromArgb(255, 255, 192);
            btnDirection1.BackColor = Color.FromArgb(224,224,224);
            btnParameter1.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnDirection1_Click(object sender, EventArgs e)
        {

            if (status1 == 1)
            {
                btnFunction2.Enabled = true;
                btnFunction3.Enabled = true;
            }
            else if (status1 == 3)
            {
                btnParameter2.Enabled = true;
                btnParameter3.Enabled = true;
            }
            status1 = 2;
            btnDirection2.Enabled = false;
            btnDirection3.Enabled = false;

            panelFirst.Height = btnFirst.Height;
            btnFirst.Text = btnDirection1.Text;

            btnFunction1.BackColor = Color.FromArgb(224, 224, 224);
            btnDirection1.BackColor = Color.FromArgb(255, 255, 192);
            btnParameter1.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnParameter1_Click(object sender, EventArgs e)
        {
            if (status1 == 1)
            {
                btnFunction2.Enabled = true;
                btnFunction3.Enabled = true;
            }
            else if (status1 == 2)
            {
                btnDirection2.Enabled = true;
                btnDirection3.Enabled = true;
            }
            status1 = 3;
            btnParameter2.Enabled = false;
            btnParameter3.Enabled = false;
            panelFirst.Height = btnFirst.Height;
            btnFirst.Text = btnParameter1.Text;

            btnFunction1.BackColor = Color.FromArgb(224, 224, 224);
            btnDirection1.BackColor = Color.FromArgb(224, 224, 224);
            btnParameter1.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void btnFunction2_Click(object sender, EventArgs e)
        {
            if (status2 == 2)
            {
                btnDirection1.Enabled = true;
                btnDirection3.Enabled = true;
            }
            else if (status2 == 3)
            {
                btnParameter1.Enabled = true;
                btnParameter3.Enabled = true;
            }
            status2 = 1;
            btnFunction1.Enabled = false;
            btnFunction3.Enabled = false;
            panelSecond.Height = btnFirst.Height;
            btnSecond.Text = btnFunction2.Text;

            btnFunction2.BackColor = Color.FromArgb(255, 255, 192);
            btnDirection2.BackColor = Color.FromArgb(224, 224, 224);
            btnParameter2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnDirection2_Click(object sender, EventArgs e)
        {
            if (status2 == 1)
            {
                btnFunction1.Enabled = true;
                btnFunction3.Enabled = true;
            }
            else if (status2 == 3)
            {
                btnParameter1.Enabled = true;
                btnParameter3.Enabled = true;
            }
            status2 = 2;
            btnDirection1.Enabled = false;
            btnDirection3.Enabled = false;
            panelSecond.Height = btnFirst.Height;
            btnSecond.Text = btnDirection2.Text;

            btnFunction2.BackColor = Color.FromArgb(224, 224, 224);
            btnDirection2.BackColor = Color.FromArgb(255, 255, 192);
            btnParameter2.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnParameter2_Click(object sender, EventArgs e)
        {
            if (status2 == 1)
            {
                btnFunction1.Enabled = true;
                btnFunction3.Enabled = true;
            }
            else if (status2 == 2)
            {
                btnDirection1.Enabled = true;
                btnDirection3.Enabled = true;
            }
            status2 = 3;
            btnParameter1.Enabled = false;
            btnParameter3.Enabled = false;
            panelSecond.Height = btnFirst.Height;
            btnSecond.Text = btnParameter2.Text;

            btnFunction2.BackColor = Color.FromArgb(224, 224, 224);
            btnDirection2.BackColor = Color.FromArgb(224, 224, 224);
            btnParameter2.BackColor = Color.FromArgb(255, 255, 192);
        }

        private void btnFunction3_Click(object sender, EventArgs e)
        {
            if (status3 == 2)
            {
                btnDirection1.Enabled = true;
                btnDirection2.Enabled = true;
            }
            else if (status3 == 3)
            {
                btnParameter1.Enabled = true;
                btnParameter2.Enabled = true;
            }
            status3 = 1;
            btnFunction1.Enabled = false;
            btnFunction2.Enabled = false;
            panelThird.Height = btnFirst.Height;
            btnThird.Text = btnFunction3.Text;

            btnFunction3.BackColor = Color.FromArgb(255, 255, 192);
            btnDirection3.BackColor = Color.FromArgb(224, 224, 224);
            btnParameter3.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDirection3_Click(object sender, EventArgs e)
        {
            if (status3 == 1)
            {
                btnFunction1.Enabled = true;
                btnFunction2.Enabled = true;
            }
            else if (status3 == 3)
            {
                btnParameter1.Enabled = true;
                btnParameter2.Enabled = true;
            }
            status3 = 2;
            btnDirection1.Enabled = false;
            btnDirection2.Enabled = false;
            panelThird.Height = btnFirst.Height;
            btnThird.Text = btnDirection3.Text;

            btnFunction3.BackColor = Color.FromArgb(224, 224, 224);
            btnDirection3.BackColor = Color.FromArgb(255, 255, 192);
            btnParameter3.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnParameter3_Click(object sender, EventArgs e)
        {
            if (status3 == 1)
            {
                btnFunction1.Enabled = true;
                btnFunction2.Enabled = true;
            }
            else if (status3 == 2)
            {
                btnDirection1.Enabled = true;
                btnDirection2.Enabled = true;
            }
            status3 = 3;
            btnParameter1.Enabled = false;
            btnParameter2.Enabled = false;
            panelThird.Height = btnFirst.Height;
            btnThird.Text = btnParameter3.Text;

            btnFunction3.BackColor = Color.FromArgb(224, 224, 224);
            btnDirection3.BackColor = Color.FromArgb(224, 224, 224);
            btnParameter3.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnFirst.Text == "Function" && btnSecond.Text == "Direction" && btnThird.Text == "Parameter")
            {
                countWarning = 1;
                sendStringToController("1");
            }
            else if (btnFirst.Text == "Function" && btnSecond.Text == "Parameter" && btnThird.Text == "Direction")
            {
                countWarning = 2;
                sendStringToController("2");
            }
            else if (btnFirst.Text == "Direction" && btnSecond.Text == "Function" && btnThird.Text == "Parameter")
            {
                countWarning = 3;
                sendStringToController("3");
            }
            else if (btnFirst.Text == "Direction" && btnSecond.Text == "Parameter" && btnThird.Text == "Function")
            {
                countWarning = 4;
                sendStringToController("4");
            }
            else if (btnFirst.Text == "Parameter" && btnSecond.Text == "Function" && btnThird.Text == "Direction")
            {
                countWarning = 5;
                sendStringToController("5");
            }
            else if (btnFirst.Text == "Parameter" && btnSecond.Text == "Direction" && btnThird.Text == "Function")
            {
                countWarning = 6;
                sendStringToController("6");
            }
            
            if (btnFirst.Text == "Position 1" || btnSecond.Text == "Position 2" || btnThird.Text == "Position 3")
            {
                countWarning = 0;
                MessageBox.Show("Please fill out all menu before clicking submit button","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnVoice.Enabled = false;
            }
            else
            {
                if(rdoVoice.Checked == true)
                {
                    btnVoice.Enabled = true;
                }
                else if(rdoText.Checked == true)
                {
                    btnVoice.Enabled = false;
                }
            }

        }

        private void btnClearConfig_Click(object sender, EventArgs e)
        {
            recognization.RecognizeAsyncStop();
            btnVoice.Enabled = true;
            btnDisable.Enabled = false;


            btnVoice.Enabled = false;
            // Menu 
            btnFirst.Text = "Position 1";
            btnSecond.Text = "Position 2";
            btnThird.Text = "Position 2";

            btnFunction1.Enabled = true;
            btnFunction2.Enabled = true;
            btnFunction3.Enabled = true;

            btnDirection1.Enabled = true;
            btnDirection2.Enabled = true;
            btnDirection3.Enabled = true;

            btnParameter1.Enabled = true;
            btnParameter2.Enabled = true;
            btnParameter3.Enabled = true;


            btnFunction1.BackColor = Color.FromArgb(224, 224, 224);
            btnFunction2.BackColor = Color.FromArgb(224, 224, 224);
            btnFunction3.BackColor = Color.FromArgb(224, 224, 224);

            btnDirection1.BackColor = Color.FromArgb(224, 224, 224);
            btnDirection2.BackColor = Color.FromArgb(224, 224, 224);
            btnDirection3.BackColor = Color.FromArgb(224, 224, 224);

            btnParameter1.BackColor = Color.FromArgb(224, 224, 224);
            btnParameter2.BackColor = Color.FromArgb(224, 224, 224);
            btnParameter3.BackColor = Color.FromArgb(224, 224, 224);

            status1 = 0;
            status2 = 0;
            status3 = 0;
        }
    }
}
