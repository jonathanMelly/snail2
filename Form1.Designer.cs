namespace Snail2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            snail = new PictureBox();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            speed = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)snail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)speed).BeginInit();
            SuspendLayout();
            // 
            // snail
            // 
            snail.BackColor = Color.Transparent;
            snail.Image = Properties.Resources.snail2;
            snail.Location = new Point(85, 253);
            snail.Name = "snail";
            snail.Size = new Size(141, 126);
            snail.SizeMode = PictureBoxSizeMode.StretchImage;
            snail.TabIndex = 0;
            snail.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(633, 25);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(155, 58);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // speed
            // 
            speed.Location = new Point(102, 25);
            speed.Maximum = 50;
            speed.Name = "speed";
            speed.Size = new Size(196, 69);
            speed.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 3;
            label1.Text = "Max speed";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = Properties.Resources.salade2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 537);
            Controls.Add(label1);
            Controls.Add(speed);
            Controls.Add(btnStart);
            Controls.Add(snail);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)snail).EndInit();
            ((System.ComponentModel.ISupportInitialize)speed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox snail;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private TrackBar speed;
        private Label label1;
    }
}
