namespace Enterprise_application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RoundRectRgn = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Lording = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // RoundRectRgn
            // 
            this.RoundRectRgn.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("RoundRectRgn.AnimationFunction")));
            this.RoundRectRgn.AnimationSpeed = 20;
            this.RoundRectRgn.BackColor = System.Drawing.Color.Gainsboro;
            this.RoundRectRgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundRectRgn.ForeColor = System.Drawing.Color.Blue;
            this.RoundRectRgn.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RoundRectRgn.InnerMargin = 2;
            this.RoundRectRgn.InnerWidth = -1;
            this.RoundRectRgn.Location = new System.Drawing.Point(917, 126);
            this.RoundRectRgn.MarqueeAnimationSpeed = 2000;
            this.RoundRectRgn.Name = "RoundRectRgn";
            this.RoundRectRgn.OuterColor = System.Drawing.Color.Gray;
            this.RoundRectRgn.OuterMargin = -20;
            this.RoundRectRgn.OuterWidth = 15;
            this.RoundRectRgn.ProgressColor = System.Drawing.Color.Blue;
            this.RoundRectRgn.ProgressWidth = 20;
            this.RoundRectRgn.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundRectRgn.Size = new System.Drawing.Size(297, 278);
            this.RoundRectRgn.StartAngle = 270;
            this.RoundRectRgn.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RoundRectRgn.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.RoundRectRgn.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.RoundRectRgn.SubscriptText = "";
            this.RoundRectRgn.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.RoundRectRgn.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.RoundRectRgn.SuperscriptText = "";
            this.RoundRectRgn.TabIndex = 0;
            this.RoundRectRgn.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.RoundRectRgn.Value = 68;
            this.RoundRectRgn.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 93);
            this.label1.TabIndex = 1;
            this.label1.Text = "D.D Constructions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lording
            // 
            this.Lording.AutoSize = true;
            this.Lording.Font = new System.Drawing.Font("Book Antiqua", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lording.Location = new System.Drawing.Point(1004, 443);
            this.Lording.Name = "Lording";
            this.Lording.Size = new System.Drawing.Size(135, 34);
            this.Lording.TabIndex = 2;
            this.Lording.Text = "Lording...";
            this.Lording.Click += new System.EventHandler(this.Lording_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1291, 551);
            this.Controls.Add(this.Lording);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoundRectRgn);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularProgressBar.CircularProgressBar RoundRectRgn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lording;
        private System.Windows.Forms.Timer timer1;
    }
}

