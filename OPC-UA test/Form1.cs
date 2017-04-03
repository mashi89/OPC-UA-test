using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPC_UA_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connStatusLabel2.Text = "Not connected";
            }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Program.clientAddress = addressTextBox.Text;
            Program.Connect();
            try
            {
                connStatusLabel2.Text = Program.client.Status.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void findNodesButton_Click(object sender, EventArgs e)
        {
            List<string> nodeList = Program.FindNodeChildren(nodeTextBox.Text);
            if (nodeList != null) nodeListBox.DataSource = nodeList;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Program.nodeChildren = "";
            Program.nodeGrandChildren = "";
            var x = nodeListBox.SelectedItem.ToString().IndexOf(":");
            var selection = nodeListBox.SelectedItem.ToString().Substring(0, x);

            List <string> nodeList = Program.SelectNode(selection);
            if (nodeList != null) childrenListBox.DataSource = nodeList;
        }

        private void refreshButton2_Click(object sender, EventArgs e)
        {
            Program.nodeGrandChildren = "";

            var x = childrenListBox.SelectedItem.ToString().IndexOf(":");
            var selection = childrenListBox.SelectedItem.ToString().Substring(0, x);

            List<string> nodeList = Program.SelectNode(selection);
            if (nodeList != null) grandChildrenListBox.DataSource = nodeList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = grandChildrenListBox.SelectedItem.ToString().IndexOf(":");
            var selection = grandChildrenListBox.SelectedItem.ToString().Substring(0, x);

            Program.ShowValues(selection);
            valuesListBox.DataSource = Program.opcNodeItems;
            valuesListBox.Refresh();
        }
    }
}
