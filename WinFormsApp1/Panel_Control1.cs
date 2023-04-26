using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Panel_Control1 : UserControl
    {
        public Panel_Control1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_button_Click(object sender, EventArgs e)
        {
            var inputOne_text = this.inputOne_text.Text;
            var inputTwo_text = this.inputTwo_text.Text;

            var parent=this.Parent as Form1;

            parent.input1_text = inputOne_text;
            parent.input2_text = inputTwo_text;

        }
    }
}
