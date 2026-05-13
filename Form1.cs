using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();

            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return;
            }

            int IndexOfPhoto = (rbMale.Checked) ? 0 : 1;


            TreeNode Node = new TreeNode(txtName.Text, IndexOfPhoto, IndexOfPhoto);

            treeView1.Nodes.Add(Node);

            txtName.Text = "";


        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();

            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return;
            }


            if (treeView1.Nodes.Count == 0)
            {
                MessageBox.Show("There is No Father to Add a Child to"); return;

            }

            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Selecte Father To Add Child"); return;
            }


            int IndexOfPhoto = (rbMale.Checked) ? 0 : 1;


            TreeNode Node = new TreeNode(txtName.Text, IndexOfPhoto, IndexOfPhoto);

            treeView1.SelectedNode.Nodes.Add(Node);

            txtName.Text = "";




        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Please select a node to remove.");
                return;
            }

            treeView1.SelectedNode.Remove();
        }

        private short CountNumberOfNodeChecked(TreeNodeCollection nodes)
        {
            short Count = 0;

            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    Count++;
                }

                if (node.Nodes.Count > 0)
                {
                    Count += CountNumberOfNodeChecked(node.Nodes);
                }

            }
            return Count;
        }

        private void btnRemoveChecked_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
            {
                MessageBox.Show("There is No Node To Remove");
                return;
            }

            if (CountNumberOfNodeChecked(treeView1.Nodes) == 0)
            {
                return;
            }

            ProgressBarProcessing();

            RemoveCheckedNodes(treeView1.Nodes);
        }

        private void RemoveCheckedNodes(TreeNodeCollection nodes)
        {


            for (int i = nodes.Count - 1; i >= 0; i--)
            {

                if (nodes[i].Nodes.Count > 0)
                {
                    RemoveCheckedNodes(nodes[i].Nodes);
                }

                if (nodes[i].Checked)
                    nodes.RemoveAt(i);

            }

        }

        private void ProgressBarProcessing()
        {

            ProBDeletingNodes.Value = 0;
            lblCompletedProgress.Text = "0%";
            lblDeletion.Visible = true;
            lblCompletedProgress.Visible = true;
            ProBDeletingNodes.Visible = true;

            for (short i = 1; i <= 100; i++)
            {

                Thread.Sleep(1);

                ProBDeletingNodes.Value = i;

                lblCompletedProgress.Text = i + "%";

                ProBDeletingNodes.Refresh();

                lblCompletedProgress.Refresh();

                lblDeletion.Refresh();

            }


            lblDeletion.Visible = false;
            lblCompletedProgress.Visible = false;
            ProBDeletingNodes.Visible = false;

        }

        private void btnClearTree_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }
    }
}
