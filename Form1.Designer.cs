namespace GUI20261104
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
            label1 = new Label();
            tbnumin = new TextBox();
            lbdivisor = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "szám:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbnumin
            // 
            tbnumin.Location = new Point(125, 130);
            tbnumin.Name = "tbnumin";
            tbnumin.Size = new Size(170, 27);
            tbnumin.TabIndex = 1;
            // 
            // lbdivisor
            // 
            lbdivisor.FormattingEnabled = true;
            lbdivisor.Location = new Point(12, 163);
            lbdivisor.Name = "lbdivisor";
            lbdivisor.Size = new Size(283, 264);
            lbdivisor.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 495);
            Controls.Add(lbdivisor);
            Controls.Add(tbnumin);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbnumin;
        private ListBox lbdivisor;
    }
}
