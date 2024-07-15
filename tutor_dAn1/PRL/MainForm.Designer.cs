namespace PRL
{
    partial class MainForm
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
            pn_show = new Panel();
            btn_show = new Button();
            btn_showTest = new Button();
            SuspendLayout();
            // 
            // pn_show
            // 
            pn_show.BackColor = SystemColors.ActiveCaption;
            pn_show.Location = new Point(255, 66);
            pn_show.Name = "pn_show";
            pn_show.Size = new Size(921, 564);
            pn_show.TabIndex = 0;
            // 
            // btn_show
            // 
            btn_show.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btn_show.Location = new Point(46, 69);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(150, 46);
            btn_show.TabIndex = 1;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // btn_showTest
            // 
            btn_showTest.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_showTest.Location = new Point(46, 160);
            btn_showTest.Name = "btn_showTest";
            btn_showTest.Size = new Size(150, 50);
            btn_showTest.TabIndex = 2;
            btn_showTest.Text = "Show test";
            btn_showTest.UseVisualStyleBackColor = true;
            btn_showTest.Click += btn_showTest_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 660);
            Controls.Add(btn_showTest);
            Controls.Add(btn_show);
            Controls.Add(pn_show);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_show;
        private Button btn_show;
        private Button btn_showTest;
    }
}