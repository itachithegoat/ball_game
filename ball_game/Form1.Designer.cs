namespace task13
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox pictureBox1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;

        // İstifadə olunmayan resursları təmizləyir.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Formaların və idarəetmə elementlərinin dizaynını qurur.
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();

            pictureBox1.Location = new Point(114, 67);
            pictureBox1.Size = new Size(69, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.White;

            panel1.BackColor = Color.Black;
            panel1.Location = new Point(371, 560);
            panel1.Size = new Size(171, 27);

            timer1.Enabled = true;
            timer1.Interval = 20;

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 667);
            BackColor = Color.White;
            StartPosition = FormStartPosition.CenterScreen;
            DoubleBuffered = true;
            KeyPreview = true;
            Text = "Form1";

            Controls.Add(panel1);
            Controls.Add(pictureBox1);

            KeyDown += Form1_KeyDown;
            Load += Form1_Load;
            timer1.Tick += timer1_Tick;

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
