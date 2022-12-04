
namespace UIVoice
{
    partial class IBR1200
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IBR1200));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVoice = new System.Windows.Forms.RadioButton();
            this.rdoText = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelSecond = new System.Windows.Forms.Panel();
            this.btnParameter2 = new System.Windows.Forms.Button();
            this.btnDirection2 = new System.Windows.Forms.Button();
            this.btnFunction2 = new System.Windows.Forms.Button();
            this.btnSecond = new FontAwesome.Sharp.IconButton();
            this.panelThird = new System.Windows.Forms.Panel();
            this.btnParameter3 = new System.Windows.Forms.Button();
            this.btnDirection3 = new System.Windows.Forms.Button();
            this.btnFunction3 = new System.Windows.Forms.Button();
            this.btnThird = new FontAwesome.Sharp.IconButton();
            this.panelFirst = new System.Windows.Forms.Panel();
            this.btnParameter1 = new System.Windows.Forms.Button();
            this.btnDirection1 = new System.Windows.Forms.Button();
            this.btnFunction1 = new System.Windows.Forms.Button();
            this.btnFirst = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClearConfig = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnDistance = new System.Windows.Forms.Button();
            this.btnVoice = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVoice = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelSecond.SuspendLayout();
            this.panelThird.SuspendLayout();
            this.panelFirst.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "VOICE CONTROLLED IRB 1200 ROBOT ARM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVoice);
            this.groupBox1.Controls.Add(this.rdoText);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(523, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(628, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option Control";
            // 
            // rdoVoice
            // 
            this.rdoVoice.AutoSize = true;
            this.rdoVoice.ForeColor = System.Drawing.Color.Black;
            this.rdoVoice.Location = new System.Drawing.Point(307, 53);
            this.rdoVoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoVoice.Name = "rdoVoice";
            this.rdoVoice.Size = new System.Drawing.Size(196, 27);
            this.rdoVoice.TabIndex = 0;
            this.rdoVoice.TabStop = true;
            this.rdoVoice.Text = "Control By Voice";
            this.rdoVoice.UseVisualStyleBackColor = true;
            this.rdoVoice.CheckedChanged += new System.EventHandler(this.rdoVoice_CheckedChanged);
            // 
            // rdoText
            // 
            this.rdoText.AutoSize = true;
            this.rdoText.ForeColor = System.Drawing.Color.Black;
            this.rdoText.Location = new System.Drawing.Point(76, 53);
            this.rdoText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoText.Name = "rdoText";
            this.rdoText.Size = new System.Drawing.Size(176, 27);
            this.rdoText.TabIndex = 0;
            this.rdoText.TabStop = true;
            this.rdoText.Text = "Control By Text";
            this.rdoText.UseVisualStyleBackColor = true;
            this.rdoText.CheckedChanged += new System.EventHandler(this.rdoText_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelSecond);
            this.groupBox2.Controls.Add(this.panelThird);
            this.groupBox2.Controls.Add(this.panelFirst);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.btnClearConfig);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(523, 190);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(628, 232);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration Region";
            // 
            // panelSecond
            // 
            this.panelSecond.Controls.Add(this.btnParameter2);
            this.panelSecond.Controls.Add(this.btnDirection2);
            this.panelSecond.Controls.Add(this.btnFunction2);
            this.panelSecond.Controls.Add(this.btnSecond);
            this.panelSecond.Location = new System.Drawing.Point(223, 76);
            this.panelSecond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSecond.Name = "panelSecond";
            this.panelSecond.Size = new System.Drawing.Size(175, 140);
            this.panelSecond.TabIndex = 12;
            // 
            // btnParameter2
            // 
            this.btnParameter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnParameter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParameter2.FlatAppearance.BorderSize = 0;
            this.btnParameter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParameter2.ForeColor = System.Drawing.Color.Blue;
            this.btnParameter2.Location = new System.Drawing.Point(0, 105);
            this.btnParameter2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParameter2.Name = "btnParameter2";
            this.btnParameter2.Size = new System.Drawing.Size(175, 34);
            this.btnParameter2.TabIndex = 14;
            this.btnParameter2.Text = "Parameter";
            this.btnParameter2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParameter2.UseVisualStyleBackColor = false;
            this.btnParameter2.Click += new System.EventHandler(this.btnParameter2_Click);
            // 
            // btnDirection2
            // 
            this.btnDirection2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDirection2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDirection2.FlatAppearance.BorderSize = 0;
            this.btnDirection2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirection2.ForeColor = System.Drawing.Color.Blue;
            this.btnDirection2.Location = new System.Drawing.Point(0, 71);
            this.btnDirection2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDirection2.Name = "btnDirection2";
            this.btnDirection2.Size = new System.Drawing.Size(175, 34);
            this.btnDirection2.TabIndex = 13;
            this.btnDirection2.Text = "Direction";
            this.btnDirection2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirection2.UseVisualStyleBackColor = false;
            this.btnDirection2.Click += new System.EventHandler(this.btnDirection2_Click);
            // 
            // btnFunction2
            // 
            this.btnFunction2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFunction2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunction2.FlatAppearance.BorderSize = 0;
            this.btnFunction2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunction2.ForeColor = System.Drawing.Color.Blue;
            this.btnFunction2.Location = new System.Drawing.Point(0, 37);
            this.btnFunction2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFunction2.Name = "btnFunction2";
            this.btnFunction2.Size = new System.Drawing.Size(175, 34);
            this.btnFunction2.TabIndex = 12;
            this.btnFunction2.Text = "Function";
            this.btnFunction2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunction2.UseVisualStyleBackColor = false;
            this.btnFunction2.Click += new System.EventHandler(this.btnFunction2_Click);
            // 
            // btnSecond
            // 
            this.btnSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecond.FlatAppearance.BorderSize = 0;
            this.btnSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecond.ForeColor = System.Drawing.Color.White;
            this.btnSecond.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.btnSecond.IconColor = System.Drawing.Color.White;
            this.btnSecond.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSecond.IconSize = 30;
            this.btnSecond.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSecond.Location = new System.Drawing.Point(0, 0);
            this.btnSecond.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(175, 37);
            this.btnSecond.TabIndex = 11;
            this.btnSecond.Text = "Position 2";
            this.btnSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecond.UseMnemonic = false;
            this.btnSecond.UseVisualStyleBackColor = false;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click_1);
            // 
            // panelThird
            // 
            this.panelThird.Controls.Add(this.btnParameter3);
            this.panelThird.Controls.Add(this.btnDirection3);
            this.panelThird.Controls.Add(this.btnFunction3);
            this.panelThird.Controls.Add(this.btnThird);
            this.panelThird.Location = new System.Drawing.Point(404, 76);
            this.panelThird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThird.Name = "panelThird";
            this.panelThird.Size = new System.Drawing.Size(175, 140);
            this.panelThird.TabIndex = 12;
            // 
            // btnParameter3
            // 
            this.btnParameter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnParameter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParameter3.FlatAppearance.BorderSize = 0;
            this.btnParameter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParameter3.ForeColor = System.Drawing.Color.Blue;
            this.btnParameter3.Location = new System.Drawing.Point(0, 105);
            this.btnParameter3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParameter3.Name = "btnParameter3";
            this.btnParameter3.Size = new System.Drawing.Size(175, 34);
            this.btnParameter3.TabIndex = 14;
            this.btnParameter3.Text = "Parameter";
            this.btnParameter3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParameter3.UseVisualStyleBackColor = false;
            this.btnParameter3.Click += new System.EventHandler(this.btnParameter3_Click);
            // 
            // btnDirection3
            // 
            this.btnDirection3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDirection3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDirection3.FlatAppearance.BorderSize = 0;
            this.btnDirection3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirection3.ForeColor = System.Drawing.Color.Blue;
            this.btnDirection3.Location = new System.Drawing.Point(0, 71);
            this.btnDirection3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDirection3.Name = "btnDirection3";
            this.btnDirection3.Size = new System.Drawing.Size(175, 34);
            this.btnDirection3.TabIndex = 13;
            this.btnDirection3.Text = "Direction";
            this.btnDirection3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirection3.UseVisualStyleBackColor = false;
            this.btnDirection3.Click += new System.EventHandler(this.btnDirection3_Click);
            // 
            // btnFunction3
            // 
            this.btnFunction3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFunction3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunction3.FlatAppearance.BorderSize = 0;
            this.btnFunction3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunction3.ForeColor = System.Drawing.Color.Blue;
            this.btnFunction3.Location = new System.Drawing.Point(0, 37);
            this.btnFunction3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFunction3.Name = "btnFunction3";
            this.btnFunction3.Size = new System.Drawing.Size(175, 34);
            this.btnFunction3.TabIndex = 12;
            this.btnFunction3.Text = "Function";
            this.btnFunction3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunction3.UseVisualStyleBackColor = false;
            this.btnFunction3.Click += new System.EventHandler(this.btnFunction3_Click);
            // 
            // btnThird
            // 
            this.btnThird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThird.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThird.FlatAppearance.BorderSize = 0;
            this.btnThird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThird.ForeColor = System.Drawing.Color.White;
            this.btnThird.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.btnThird.IconColor = System.Drawing.Color.White;
            this.btnThird.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThird.IconSize = 30;
            this.btnThird.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThird.Location = new System.Drawing.Point(0, 0);
            this.btnThird.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThird.Name = "btnThird";
            this.btnThird.Size = new System.Drawing.Size(175, 37);
            this.btnThird.TabIndex = 11;
            this.btnThird.Text = "Position 3";
            this.btnThird.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThird.UseMnemonic = false;
            this.btnThird.UseVisualStyleBackColor = false;
            this.btnThird.Click += new System.EventHandler(this.btnThird_Click_1);
            // 
            // panelFirst
            // 
            this.panelFirst.Controls.Add(this.btnParameter1);
            this.panelFirst.Controls.Add(this.btnDirection1);
            this.panelFirst.Controls.Add(this.btnFunction1);
            this.panelFirst.Controls.Add(this.btnFirst);
            this.panelFirst.Location = new System.Drawing.Point(42, 76);
            this.panelFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFirst.Name = "panelFirst";
            this.panelFirst.Size = new System.Drawing.Size(175, 140);
            this.panelFirst.TabIndex = 12;
            // 
            // btnParameter1
            // 
            this.btnParameter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnParameter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParameter1.FlatAppearance.BorderSize = 0;
            this.btnParameter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParameter1.ForeColor = System.Drawing.Color.Blue;
            this.btnParameter1.Location = new System.Drawing.Point(0, 105);
            this.btnParameter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnParameter1.Name = "btnParameter1";
            this.btnParameter1.Size = new System.Drawing.Size(175, 34);
            this.btnParameter1.TabIndex = 14;
            this.btnParameter1.Text = "Parameter";
            this.btnParameter1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParameter1.UseVisualStyleBackColor = false;
            this.btnParameter1.Click += new System.EventHandler(this.btnParameter1_Click);
            // 
            // btnDirection1
            // 
            this.btnDirection1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDirection1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDirection1.FlatAppearance.BorderSize = 0;
            this.btnDirection1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirection1.ForeColor = System.Drawing.Color.Blue;
            this.btnDirection1.Location = new System.Drawing.Point(0, 71);
            this.btnDirection1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDirection1.Name = "btnDirection1";
            this.btnDirection1.Size = new System.Drawing.Size(175, 34);
            this.btnDirection1.TabIndex = 13;
            this.btnDirection1.Text = "Direction";
            this.btnDirection1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirection1.UseVisualStyleBackColor = false;
            this.btnDirection1.Click += new System.EventHandler(this.btnDirection1_Click);
            // 
            // btnFunction1
            // 
            this.btnFunction1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFunction1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunction1.FlatAppearance.BorderSize = 0;
            this.btnFunction1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunction1.ForeColor = System.Drawing.Color.Blue;
            this.btnFunction1.Location = new System.Drawing.Point(0, 37);
            this.btnFunction1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFunction1.Name = "btnFunction1";
            this.btnFunction1.Size = new System.Drawing.Size(175, 34);
            this.btnFunction1.TabIndex = 12;
            this.btnFunction1.Text = "Function";
            this.btnFunction1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunction1.UseVisualStyleBackColor = false;
            this.btnFunction1.Click += new System.EventHandler(this.btnFunction1_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.btnFirst.IconColor = System.Drawing.Color.White;
            this.btnFirst.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFirst.IconSize = 30;
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirst.Location = new System.Drawing.Point(0, 0);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(175, 37);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "Position 1";
            this.btnFirst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirst.UseMnemonic = false;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "THE CONFIGURATION OF COMMAND";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(602, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "P/S: Please configuration before controlling robot";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Gray;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(131, 161);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(157, 63);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClearConfig
            // 
            this.btnClearConfig.BackColor = System.Drawing.Color.Gray;
            this.btnClearConfig.FlatAppearance.BorderSize = 0;
            this.btnClearConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearConfig.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearConfig.ForeColor = System.Drawing.Color.White;
            this.btnClearConfig.Location = new System.Drawing.Point(294, 161);
            this.btnClearConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearConfig.Name = "btnClearConfig";
            this.btnClearConfig.Size = new System.Drawing.Size(198, 63);
            this.btnClearConfig.TabIndex = 9;
            this.btnClearConfig.Text = "Clear Configuration";
            this.btnClearConfig.UseVisualStyleBackColor = false;
            this.btnClearConfig.Click += new System.EventHandler(this.btnClearConfig_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(442, 145);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 46);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(79, 94);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 46);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Gray;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(79, 145);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 46);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.Gray;
            this.btnAuto.FlatAppearance.BorderSize = 0;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.ForeColor = System.Drawing.Color.White;
            this.btnAuto.Location = new System.Drawing.Point(200, 145);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(115, 46);
            this.btnAuto.TabIndex = 9;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.BackColor = System.Drawing.Color.Gray;
            this.btnDisable.FlatAppearance.BorderSize = 0;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.ForeColor = System.Drawing.Color.White;
            this.btnDisable.Location = new System.Drawing.Point(320, 145);
            this.btnDisable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(115, 46);
            this.btnDisable.TabIndex = 9;
            this.btnDisable.Text = "Unvoice";
            this.btnDisable.UseVisualStyleBackColor = false;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnDistance
            // 
            this.btnDistance.BackColor = System.Drawing.Color.Gray;
            this.btnDistance.FlatAppearance.BorderSize = 0;
            this.btnDistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistance.ForeColor = System.Drawing.Color.White;
            this.btnDistance.Location = new System.Drawing.Point(200, 94);
            this.btnDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(115, 46);
            this.btnDistance.TabIndex = 9;
            this.btnDistance.Text = "Distance";
            this.btnDistance.UseVisualStyleBackColor = false;
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // btnVoice
            // 
            this.btnVoice.BackColor = System.Drawing.Color.Gray;
            this.btnVoice.FlatAppearance.BorderSize = 0;
            this.btnVoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoice.ForeColor = System.Drawing.Color.White;
            this.btnVoice.Location = new System.Drawing.Point(320, 94);
            this.btnVoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoice.Name = "btnVoice";
            this.btnVoice.Size = new System.Drawing.Size(115, 46);
            this.btnVoice.TabIndex = 9;
            this.btnVoice.Text = "Voice";
            this.btnVoice.UseVisualStyleBackColor = false;
            this.btnVoice.Click += new System.EventHandler(this.btnVoice_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Gray;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(442, 94);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(115, 46);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(75, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(368, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ex: Linear,X,100   -   Reorient,Y,50   -   R,Z,200";
            // 
            // txtVoice
            // 
            this.txtVoice.Location = new System.Drawing.Point(79, 30);
            this.txtVoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVoice.Name = "txtVoice";
            this.txtVoice.Size = new System.Drawing.Size(478, 32);
            this.txtVoice.TabIndex = 7;
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(180, 73);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(0, 17);
            this.lblHost.TabIndex = 10;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(316, 57);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(0, 17);
            this.lblPort.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDisconnect);
            this.groupBox3.Controls.Add(this.txtHost);
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPort);
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Controls.Add(this.lblStatus1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(8, 91);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(509, 331);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect Region";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.Gray;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(311, 260);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(150, 63);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(124, 40);
            this.txtHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(353, 32);
            this.txtHost.TabIndex = 5;
            this.txtHost.Text = "127.0.0.1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(120, 212);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(106, 21);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Disconnect";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Gray;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(140, 260);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 63);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(34, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "HOST:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(120, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ex: 5000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(120, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ex: 192.168.1.125";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(124, 112);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(353, 32);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "5000";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(124, 178);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(353, 32);
            this.txtStatus.TabIndex = 6;
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblStatus1.Location = new System.Drawing.Point(19, 182);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(80, 23);
            this.lblStatus1.TabIndex = 4;
            this.lblStatus1.Text = "STATUS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(34, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "PORT:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnDistance);
            this.groupBox4.Controls.Add(this.btnSend);
            this.groupBox4.Controls.Add(this.btnVoice);
            this.groupBox4.Controls.Add(this.btnDisable);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnHome);
            this.groupBox4.Controls.Add(this.txtVoice);
            this.groupBox4.Controls.Add(this.btnAuto);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox4.Location = new System.Drawing.Point(254, 437);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(623, 201);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control Region";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // IBR1200
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 783);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IBR1200";
            this.Text = "IBR1200";
            this.Load += new System.EventHandler(this.CONTROLLER_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panelSecond.ResumeLayout(false);
            this.panelThird.ResumeLayout(false);
            this.panelFirst.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVoice;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVoice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnVoice;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnDistance;
        private System.Windows.Forms.Panel panelFirst;
        private System.Windows.Forms.Button btnFunction1;
        private FontAwesome.Sharp.IconButton btnFirst;
        private System.Windows.Forms.Button btnParameter1;
        private System.Windows.Forms.Button btnDirection1;
        private System.Windows.Forms.Panel panelThird;
        private System.Windows.Forms.Button btnParameter3;
        private System.Windows.Forms.Button btnDirection3;
        private System.Windows.Forms.Button btnFunction3;
        private FontAwesome.Sharp.IconButton btnThird;
        private System.Windows.Forms.Panel panelSecond;
        private System.Windows.Forms.Button btnParameter2;
        private System.Windows.Forms.Button btnDirection2;
        private System.Windows.Forms.Button btnFunction2;
        private FontAwesome.Sharp.IconButton btnSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClearConfig;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}