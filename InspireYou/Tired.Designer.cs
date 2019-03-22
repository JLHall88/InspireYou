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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tired));
            this.Tiredheading = new System.Windows.Forms.Label();
            this.ReturntoMain = new System.Windows.Forms.Button();
            this.sheepBox1 = new System.Windows.Forms.PictureBox();
            this.linkcoffee = new System.Windows.Forms.LinkLabel();
            this.pictureBoxcoffee = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sheepBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcoffee)).BeginInit();
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
            this.sheepBox1.Location = new System.Drawing.Point(300, 256);
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
            this.linkcoffee.Location = new System.Drawing.Point(67, 183);
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
            this.pictureBoxcoffee.Location = new System.Drawing.Point(154, 109);
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
            // Tired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(815, 541);
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
            ((System.ComponentModel.ISupportInitialize)(this.sheepBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxcoffee)).EndInit();
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
    }
}