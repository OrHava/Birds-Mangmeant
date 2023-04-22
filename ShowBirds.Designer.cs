namespace Birds_Mangmeant
{
    partial class ShowBirds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBirds));
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(37, 42, 64);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(56, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(692, 393);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // ShowBirds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowBirds";
            Text = "Cage Birds Info";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
    }
}