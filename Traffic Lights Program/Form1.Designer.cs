namespace Traffic_Lights_Program
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
            pb_canvas = new PictureBox();
            tmr_changeLight = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pb_canvas).BeginInit();
            SuspendLayout();
            // 
            // pb_canvas
            // 
            pb_canvas.Location = new Point(-1, 1);
            pb_canvas.Name = "pb_canvas";
            pb_canvas.Size = new Size(807, 453);
            pb_canvas.TabIndex = 0;
            pb_canvas.TabStop = false;
            pb_canvas.Paint += pb_canvas_Paint;
            // 
            // tmr_changeLight
            // 
            tmr_changeLight.Enabled = true;
            tmr_changeLight.Interval = 1000;
            tmr_changeLight.Tick += tmr_changeLight_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb_canvas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_canvas;
        private System.Windows.Forms.Timer tmr_changeLight;
    }
}