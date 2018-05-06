using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiGui
{
    public partial class Blacklist : Form
    {
        public Blacklist()
        {
            InitializeComponent();

            loadBlackListView();
        }

        private void loadBlackListView()
        {
            for (int i = 0; i < Form1.blackList.Count; i++)
            {
                listBox.Items.Add(Form1.blackList[i]);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newEntry = entryBox.Text;
            entryBox.Text = "";

            if (!Form1.blackList.Contains(newEntry) && newEntry != "")
            {
                listBox.Items.Add(newEntry);
                Form1.blackList.Add(newEntry);
            }
        }

        private void rmButton_Click(object sender, EventArgs e)
        {
            string deleteEntry;
            try
            {
                deleteEntry = listBox.SelectedItem.ToString();
            }
            catch (System.NullReferenceException)
            {
                return;
            }

            Form1.blackList.Remove(deleteEntry);
            listBox.Items.Clear();
            loadBlackListView();
        }

        private void entryBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                addButton_Click(sender, e);
        }
    }
}