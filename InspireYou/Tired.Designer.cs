namespace InspireYou
{
    partial class Tired
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tired));
            this.Tiredheading = new System.Windows.Forms.Label();
            this.ReturntoMain = new System.Windows.Forms.Button();
            this.sheepBox1 = new System.Windows.Forms.PictureBox();
            this.linkcoffee = new System.Windows.Forms.LinkLabel();
            this.pictureBoxcoffee = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.hourlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minutelabel = new System.Windows.Forms.Label();
            this.middlebox = new System.Windows.Forms.ComboBox();
            this.labelthehour = new System.Windows.Forms.Label();
            this.lowerbox = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alarmstart = new System.Windows.Forms.Button();
            this.labelminuteonly = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.sheepBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tiredheading
            // 
            this.Tiredheading.AutoSize = true;
            this.Tiredheading.Font = new System.Drawing.Font("High Tower Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tiredheading.ForeColor = System.Drawing.Color.Aqua;
            this.Tiredheading.Location = new System.Drawing.Point(350, 26);
            this.Tiredheading.Name = "Tiredheading";
            this.Tiredheading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tiredheading.Size = new System.Drawing.Size(103, 37);
            this.Tiredheading.TabIndex = 0;
            this.Tiredheading.Text = "Tired?";
            // 
            // ReturntoMain
            // 
            this.ReturntoMain.ForeColor = System.Drawing.Color.Black;
            this.ReturntoMain.Location = new System.Drawing.Point(618, 434);
            this.ReturntoMain.Name = "ReturntoMain";
            this.ReturntoMain.Size = new System.Drawing.Size(122, 32);
            this.ReturntoMain.TabIndex = 1;
            this.ReturntoMain.Text = "Return to Main Menu";
            this.ReturntoMain.UseVisualStyleBackColor = true;
            this.ReturntoMain.Click += new System.EventHandler(this.ReturntoMain_Click);
            // 
            // sheepBox1
            // 
            this.sheepBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sheepBox1.Image = ((System.Drawing.Image)(resources.GetObject("sheepBox1.Image")));
            this.sheepBox1.Location = new System.Drawing.Point(301, 256);
            this.sheepBox1.Name = "sheepBox1";
            this.sheepBox1.Size = new System.Drawing.Size(153, 146);
            this.sheepBox1.TabIndex = 2;
            this.sheepBox1.TabStop = false;
            // 
            // linkcoffee
            // 
            this.linkcoffee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkcoffee.AutoSize = true;
            this.linkcoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkcoffee.Location = new System.Drawing.Point(68, 183);
            this.linkcoffee.Name = "linkcoffee";
            this.linkcoffee.Size = new System.Drawing.Size(317, 40);
            this.linkcoffee.TabIndex = 1;
            this.linkcoffee.TabStop = true;
            this.linkcoffee.Text = "To find the nearest coffee source, click here\r\n\r\n";
            this.linkcoffee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkcoffee_LinkClicked);
            // 
            // pictureBoxcoffee
            // 
            this.pictureBoxcoffee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxcoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxcoffee.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxcoffee.Image")));
            this.pictureBoxcoffee.InitialImage = null;
            this.pictureBoxcoffee.Location = new System.Drawing.Point(155, 109);
            this.pictureBoxcoffee.Name = "pictureBoxcoffee";
            this.pictureBoxcoffee.Size = new System.Drawing.Size(133, 71);
            this.pictureBoxcoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxcoffee.TabIndex = 0;
            this.pictureBoxcoffee.TabStop = false;
            this.pictureBoxcoffee.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(310, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Need a Nap??";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Time.Location = new System.Drawing.Point(499, 109);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(66, 24);
            this.Time.TabIndex = 4;
            this.Time.Text = "Time:";
            // 
            // hourlabel
            // 
            this.hourlabel.AutoSize = true;
            this.hourlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hourlabel.Location = new System.Drawing.Point(592, 110);
            this.hourlabel.Name = "hourlabel";
            this.hourlabel.Size = new System.Drawing.Size(30, 24);
            this.hourlabel.TabIndex = 5;
            this.hourlabel.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(650, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // minutelabel
            // 
            this.minutelabel.AutoSize = true;
            this.minutelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minutelabel.Location = new System.Drawing.Point(687, 110);
            this.minutelabel.Name = "minutelabel";
            this.minutelabel.Size = new System.Drawing.Size(30, 24);
            this.minutelabel.TabIndex = 7;
            this.minutelabel.Text = "00";
            // 
            // middlebox
            // 
            this.middlebox.FormattingEnabled = true;
            this.middlebox.Location = new System.Drawing.Point(596, 149);
            this.middlebox.Name = "middlebox";
            this.middlebox.Size = new System.Drawing.Size(120, 21);
            this.middlebox.TabIndex = 8;
            // 
            // labelthehour
            // 
            this.labelthehour.AutoSize = true;
            this.labelthehour.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelthehour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelthehour.Location = new System.Drawing.Point(499, 149);
            this.labelthehour.Name = "labelthehour";
            this.labelthehour.Size = new System.Drawing.Size(56, 24);
            this.labelthehour.TabIndex = 9;
            this.labelthehour.Text = "Hour";
            // 
            // lowerbox
            // 
            this.lowerbox.FormattingEnabled = true;
            this.lowerbox.Location = new System.Drawing.Point(597, 194);
            this.lowerbox.Name = "lowerbox";
            this.lowerbox.Size = new System.Drawing.Size(120, 21);
            this.lowerbox.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alarmstart
            // 
            this.alarmstart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.alarmstart.Location = new System.Drawing.Point(618, 230);
            this.alarmstart.Name = "alarmstart";
            this.alarmstart.Size = new System.Drawing.Size(75, 23);
            this.alarmstart.TabIndex = 11;
            this.alarmstart.Text = "Set Alarm";
            this.alarmstart.UseVisualStyleBackColor = true;
            this.alarmstart.Click += new System.EventHandler(this.alarmstart_Click);
            // 
            // labelminuteonly
            // 
            this.labelminuteonly.AutoSize = true;
            this.labelminuteonly.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelminuteonly.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelminuteonly.Location = new System.Drawing.Point(499, 191);
            this.labelminuteonly.Name = "labelminuteonly";
            this.labelminuteonly.Size = new System.Drawing.Size(74, 24);
            this.labelminuteonly.TabIndex = 12;
            this.labelminuteonly.Text = "Minute";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(894, 60);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(175, 193);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Tired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 541);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labelminuteonly);
            this.Controls.Add(this.alarmstart);
            this.Controls.Add(this.lowerbox);
            this.Controls.Add(this.labelthehour);
            this.Controls.Add(this.middlebox);
            this.Controls.Add(this.minutelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hourlabel);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkcoffee);
            this.Controls.Add(this.pictureBoxcoffee);
            this.Controls.Add(this.ReturntoMain);
            this.Controls.Add(this.sheepBox1);
            this.Controls.Add(this.Tiredheading);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tired";
            this.Text = "Tired";
            this.Load += new System.EventHandler(this.Tired_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sheepBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tiredheading;
        private System.Windows.Forms.Button ReturntoMain;
        private System.Windows.Forms.PictureBox sheepBox1;
        private System.Windows.Forms.LinkLabel linkcoffee;
        private System.Windows.Forms.PictureBox pictureBoxcoffee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label hourlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minutelabel;
        private System.Windows.Forms.ComboBox middlebox;
        private System.Windows.Forms.Label labelthehour;
        private System.Windows.Forms.ComboBox lowerbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button alarmstart;
        private System.Windows.Forms.Label labelminuteonly;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}