using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birds_Mangmeant
{
    public partial class ShowBirds : Form
    {
        public ShowBirds(string message)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            // Set the text and read-only properties of the RichTextBox
            richTextBox1.Text = message;
            richTextBox1.ReadOnly = true;


            // Set the TopMost property to true to keep the form on top of other windows
            this.TopMost = true;
        }
    }
}
