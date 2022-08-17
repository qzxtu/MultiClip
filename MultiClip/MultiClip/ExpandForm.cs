using System;
using System.Windows.Forms;

namespace MultiClip
{
    public partial class ExpandForm : Form
    {
        private bool sendData = false;

        public ExpandForm(string Item)
        {
            InitializeComponent();
            fullTextBox.Text = Item;
        }

        public string TextData()
        {
            bool flag = sendData;
            string result = flag ? fullTextBox.Text : "";
            return result;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            sendData = true;
            base.Close();
        }

        private void fullTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool flag = e.KeyChar == '\r';
            if (flag)
            {
                saveButton_Click(null, null);
            }
        }
    }
}