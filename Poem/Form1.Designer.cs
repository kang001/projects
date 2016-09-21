namespace Poem
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
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblSeed = new System.Windows.Forms.Label();
            this.lblTreeOutput = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldisplaySeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxResults = new System.Windows.Forms.TextBox();
            this.lblDisplayTree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(159, 60);
            this.txtSeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(204, 22);
            this.txtSeed.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(80, 151);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(205, 28);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "&Generate List of Words";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(21, 69);
            this.lblSeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(88, 17);
            this.lblSeed.TabIndex = 2;
            this.lblSeed.Text = "Enter Word: ";
            // 
            // lblTreeOutput
            // 
            this.lblTreeOutput.AutoSize = true;
            this.lblTreeOutput.Location = new System.Drawing.Point(13, 196);
            this.lblTreeOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTreeOutput.Name = "lblTreeOutput";
            this.lblTreeOutput.Size = new System.Drawing.Size(152, 17);
            this.lblTreeOutput.TabIndex = 3;
            this.lblTreeOutput.Text = "Words that rhyme with ";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(263, 489);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Use this program to help you write poetry!";
            // 
            // lbldisplaySeed
            // 
            this.lbldisplaySeed.AutoSize = true;
            this.lbldisplaySeed.Location = new System.Drawing.Point(183, 196);
            this.lbldisplaySeed.Name = "lbldisplaySeed";
            this.lbldisplaySeed.Size = new System.Drawing.Size(0, 17);
            this.lbldisplaySeed.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Max number of words:";
            // 
            // txtMaxResults
            // 
            this.txtMaxResults.Location = new System.Drawing.Point(310, 102);
            this.txtMaxResults.Name = "txtMaxResults";
            this.txtMaxResults.Size = new System.Drawing.Size(53, 22);
            this.txtMaxResults.TabIndex = 2;
            // 
            // lblDisplayTree
            // 
            this.lblDisplayTree.AutoSize = true;
            this.lblDisplayTree.Location = new System.Drawing.Point(45, 234);
            this.lblDisplayTree.Name = "lblDisplayTree";
            this.lblDisplayTree.Size = new System.Drawing.Size(0, 17);
            this.lblDisplayTree.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 532);
            this.Controls.Add(this.lblDisplayTree);
            this.Controls.Add(this.txtMaxResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldisplaySeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTreeOutput);
            this.Controls.Add(this.lblSeed);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtSeed);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Rhymes Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.Label lblTreeOutput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldisplaySeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxResults;
        private System.Windows.Forms.Label lblDisplayTree;
    }
}

