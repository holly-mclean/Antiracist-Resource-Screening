namespace Antiracist_Resource_Screening
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.displayFileNameLabel = new System.Windows.Forms.Label();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.displayResultsLabel = new System.Windows.Forms.Label();
            this.categoryCheckedList = new System.Windows.Forms.CheckedListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.submitButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.displayResultsLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.categoryCheckedList, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.24818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.66351F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.35071F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.872038F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.45971F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.40758F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antiracist Resource Screening for PDF, DOCX, and TXT Files\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(794, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Upload a file to screen for racist language:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.Controls.Add(this.displayFileNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.selectFileButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(300, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 57);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // displayFileNameLabel
            // 
            this.displayFileNameLabel.AutoSize = true;
            this.displayFileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayFileNameLabel.Location = new System.Drawing.Point(3, 0);
            this.displayFileNameLabel.Name = "displayFileNameLabel";
            this.displayFileNameLabel.Size = new System.Drawing.Size(80, 29);
            this.displayFileNameLabel.TabIndex = 0;
            this.displayFileNameLabel.Text = "No file selected";
            // 
            // selectFileButton
            // 
            this.selectFileButton.AutoSize = true;
            this.selectFileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFileButton.Location = new System.Drawing.Point(89, 3);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(81, 23);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "Select a file...";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(794, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select category to screen for:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.submitButton.AutoSize = true;
            this.submitButton.Location = new System.Drawing.Point(362, 295);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // displayResultsLabel
            // 
            this.displayResultsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.displayResultsLabel.AutoSize = true;
            this.displayResultsLabel.Location = new System.Drawing.Point(400, 387);
            this.displayResultsLabel.Name = "displayResultsLabel";
            this.displayResultsLabel.Size = new System.Drawing.Size(0, 119);
            this.displayResultsLabel.TabIndex = 7;
            // 
            // categoryCheckedList
            // 
            this.categoryCheckedList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.categoryCheckedList.CheckOnClick = true;
            this.categoryCheckedList.FormattingEnabled = true;
            this.categoryCheckedList.Items.AddRange(new object[] {
            "Anti-Black",
            "Anti-Indigenous"});
            this.categoryCheckedList.Location = new System.Drawing.Point(340, 204);
            this.categoryCheckedList.Name = "categoryCheckedList";
            this.categoryCheckedList.Size = new System.Drawing.Size(120, 79);
            this.categoryCheckedList.TabIndex = 6;
            this.categoryCheckedList.SelectedIndexChanged += new System.EventHandler(this.categoryCheckedList_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF files (*.pdf) |*.pdf|txt files (*.txt) |*.txt|docx files (*.docx) |*.docx|All" +
    " files (*.*) |*.*";
            this.openFileDialog1.FilterIndex = 4;
            this.openFileDialog1.Title = "Select a file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Antiracist Resource Screening";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label displayFileNameLabel;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckedListBox categoryCheckedList;
        private System.Windows.Forms.Label displayResultsLabel;
    }
}

