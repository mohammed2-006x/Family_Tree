namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnClearTree = new System.Windows.Forms.Button();
            this.btnRemoveChecked = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.ProBDeletingNodes = new System.Windows.Forms.ProgressBar();
            this.lblCompletedProgress = new System.Windows.Forms.Label();
            this.lblDeletion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Boy.png");
            this.imageList1.Images.SetKeyName(1, "Girl.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 40F);
            this.label1.Location = new System.Drawing.Point(397, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = " Family Tree";
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(19, 188);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(692, 491);
            this.treeView1.TabIndex = 1;
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Font = new System.Drawing.Font("Algerian", 17F);
            this.btnAddRoot.Location = new System.Drawing.Point(745, 364);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(244, 49);
            this.btnAddRoot.TabIndex = 2;
            this.btnAddRoot.Text = " Add Root";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.btnAddRoot_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Font = new System.Drawing.Font("Algerian", 17F);
            this.btnAddChild.Location = new System.Drawing.Point(1015, 364);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(244, 49);
            this.btnAddChild.TabIndex = 3;
            this.btnAddChild.Text = " ADD CHILD";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnClearTree
            // 
            this.btnClearTree.Font = new System.Drawing.Font("Algerian", 17F);
            this.btnClearTree.Location = new System.Drawing.Point(850, 619);
            this.btnClearTree.Name = "btnClearTree";
            this.btnClearTree.Size = new System.Drawing.Size(289, 49);
            this.btnClearTree.TabIndex = 4;
            this.btnClearTree.Text = " clear tree";
            this.btnClearTree.UseVisualStyleBackColor = true;
            this.btnClearTree.Click += new System.EventHandler(this.btnClearTree_Click);
            // 
            // btnRemoveChecked
            // 
            this.btnRemoveChecked.Font = new System.Drawing.Font("Algerian", 17F);
            this.btnRemoveChecked.Location = new System.Drawing.Point(850, 547);
            this.btnRemoveChecked.Name = "btnRemoveChecked";
            this.btnRemoveChecked.Size = new System.Drawing.Size(289, 49);
            this.btnRemoveChecked.TabIndex = 5;
            this.btnRemoveChecked.Text = " Remove checked ";
            this.btnRemoveChecked.UseVisualStyleBackColor = true;
            this.btnRemoveChecked.Click += new System.EventHandler(this.btnRemoveChecked_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Font = new System.Drawing.Font("Algerian", 17F);
            this.btnRemoveSelected.Location = new System.Drawing.Point(850, 475);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(289, 49);
            this.btnRemoveSelected.TabIndex = 6;
            this.btnRemoveSelected.Text = " Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 17F);
            this.txtName.Location = new System.Drawing.Point(891, 182);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 42);
            this.txtName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 17F);
            this.label2.Location = new System.Drawing.Point(761, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = " Name : ";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Algerian", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(891, 256);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(108, 35);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Algerian", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(891, 298);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(140, 35);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // ProBDeletingNodes
            // 
            this.ProBDeletingNodes.BackColor = System.Drawing.Color.Crimson;
            this.ProBDeletingNodes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ProBDeletingNodes.Location = new System.Drawing.Point(294, 157);
            this.ProBDeletingNodes.Name = "ProBDeletingNodes";
            this.ProBDeletingNodes.Size = new System.Drawing.Size(306, 10);
            this.ProBDeletingNodes.Step = 1;
            this.ProBDeletingNodes.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProBDeletingNodes.TabIndex = 11;
            this.ProBDeletingNodes.Visible = false;
            // 
            // lblCompletedProgress
            // 
            this.lblCompletedProgress.AutoSize = true;
            this.lblCompletedProgress.Font = new System.Drawing.Font("Tahoma", 20F);
            this.lblCompletedProgress.Location = new System.Drawing.Point(603, 141);
            this.lblCompletedProgress.Name = "lblCompletedProgress";
            this.lblCompletedProgress.Size = new System.Drawing.Size(70, 41);
            this.lblCompletedProgress.TabIndex = 12;
            this.lblCompletedProgress.Text = "0%";
            this.lblCompletedProgress.Visible = false;
            // 
            // lblDeletion
            // 
            this.lblDeletion.AutoSize = true;
            this.lblDeletion.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblDeletion.Location = new System.Drawing.Point(29, 144);
            this.lblDeletion.Name = "lblDeletion";
            this.lblDeletion.Size = new System.Drawing.Size(256, 33);
            this.lblDeletion.TabIndex = 13;
            this.lblDeletion.Text = "Deletion In Progress";
            this.lblDeletion.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1312, 700);
            this.Controls.Add(this.lblDeletion);
            this.Controls.Add(this.lblCompletedProgress);
            this.Controls.Add(this.ProBDeletingNodes);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnRemoveChecked);
            this.Controls.Add(this.btnClearTree);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnAddRoot);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnClearTree;
        private System.Windows.Forms.Button btnRemoveChecked;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ProgressBar ProBDeletingNodes;
        private System.Windows.Forms.Label lblCompletedProgress;
        private System.Windows.Forms.Label lblDeletion;
    }
}

