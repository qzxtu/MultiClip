using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MultiClip
{
    public partial class MultiClip : Form
    {
        private readonly List<string> Items = new List<string>();

        private readonly string ListPath = Directory.GetCurrentDirectory() + "/MultiClipList.ini";

        private readonly string SplitVar = "[][][][][]";

        private string Build = "";

        public void UpdateProgram()
        {
            itemList.Items.Clear();
            Clipboard.Clear();
            Build = "";
            foreach (string text in Items)
            {
                itemList.Items.Add(text);
                Build = Build + text + SplitVar;
            }
            bool flag = File.Exists(ListPath);
            if (flag)
            {
                File.WriteAllText(ListPath, Build);
            }
        }

        public MultiClip()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/qzxtu");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all items?", "MultiClip", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            bool flag = dialogResult == DialogResult.Yes;
            if (flag)
            {
                Items.Clear();
                UpdateProgram();
            }
        }

        private void MultiClip_Load(object sender, EventArgs e)
        {
            bool flag = !File.Exists(ListPath);
            if (flag)
            {
                FileStream fileStream = File.Create(ListPath);
                fileStream.Close();
                MessageBox.Show("Couldn't find a saved list; created new one!", "MultiClip");
                UpdateProgram();
            }
            else
            {
                string[] array = File.ReadAllText(ListPath).Split(new string[]
                {
                    SplitVar
                }, StringSplitOptions.None);
                foreach (string text in array)
                {
                    bool flag2 = text != "";
                    if (flag2)
                    {
                        Items.Add(text);
                        UpdateProgram();
                    }
                }
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            bool flag = itemList.SelectedIndex >= 0;
            if (flag)
            {
                Items.RemoveAt(itemList.SelectedIndex);
                UpdateProgram();
            }
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            bool flag = itemList.SelectedIndex >= 0;
            if (flag)
            {
                ExpandForm expandForm = new ExpandForm(itemList.SelectedItem.ToString());
                _ = expandForm.ShowDialog();
                bool flag2 = expandForm.TextData() != "";
                if (flag2)
                {
                    Items.Remove(itemList.SelectedItem.ToString());
                    Items.Add(expandForm.TextData());
                    UpdateProgram();
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            bool flag = searchBox.Text != "Search";
            if (flag)
            {
                itemList.Items.Clear();
                foreach (string text in Items)
                {
                    bool flag2 = text.ToLower().Contains(searchBox.Text.ToLower());
                    if (flag2)
                    {
                        bool flag3 = !itemList.Items.Contains(text);
                        if (flag3)
                        {
                            itemList.Items.Add(text);
                        }
                    }
                }
            }
        }

        private void checkTimer_Tick(object sender, EventArgs e)
        {
            string text = Clipboard.GetText();
            bool flag = !itemList.Items.Contains(text);
            if (flag)
            {
                bool flag2 = text != "";
                if (flag2)
                {
                    Items.Add(text);
                    UpdateProgram();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://ko-fi.com/nova355");
        }
    }
}