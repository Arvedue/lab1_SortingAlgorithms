namespace lab2
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
            this.listArray = new System.Windows.Forms.ListBox();
            this.listSortedArray = new System.Windows.Forms.ListBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxSteps = new System.Windows.Forms.GroupBox();
            this.listBoxSteps = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioInsertion = new System.Windows.Forms.RadioButton();
            this.radioButtonSelection = new System.Windows.Forms.RadioButton();
            this.radioButtonBubble = new System.Windows.Forms.RadioButton();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.groupBoxSteps.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listArray
            // 
            this.listArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listArray.FormattingEnabled = true;
            this.listArray.ItemHeight = 17;
            this.listArray.Location = new System.Drawing.Point(59, 159);
            this.listArray.Margin = new System.Windows.Forms.Padding(2);
            this.listArray.Name = "listArray";
            this.listArray.Size = new System.Drawing.Size(91, 344);
            this.listArray.TabIndex = 0;
            // 
            // listSortedArray
            // 
            this.listSortedArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listSortedArray.FormattingEnabled = true;
            this.listSortedArray.ItemHeight = 17;
            this.listSortedArray.Location = new System.Drawing.Point(185, 159);
            this.listSortedArray.Margin = new System.Windows.Forms.Padding(2);
            this.listSortedArray.Name = "listSortedArray";
            this.listSortedArray.Size = new System.Drawing.Size(91, 344);
            this.listSortedArray.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGenerate.Location = new System.Drawing.Point(59, 98);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(90, 24);
            this.buttonGenerate.TabIndex = 5;
            this.buttonGenerate.Text = "Generate ";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter array size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Generate values from:";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(200, 63);
            this.textBoxMin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(44, 20);
            this.textBoxMin.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(252, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "to:";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(271, 63);
            this.textBoxMax.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(44, 20);
            this.textBoxMax.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(82, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Array";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(182, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sorted Array";
            // 
            // groupBoxSteps
            // 
            this.groupBoxSteps.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSteps.Controls.Add(this.listBoxSteps);
            this.groupBoxSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSteps.Location = new System.Drawing.Point(341, 159);
            this.groupBoxSteps.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSteps.Name = "groupBoxSteps";
            this.groupBoxSteps.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSteps.Size = new System.Drawing.Size(592, 348);
            this.groupBoxSteps.TabIndex = 14;
            this.groupBoxSteps.TabStop = false;
            this.groupBoxSteps.Text = "Sorting steps";
            // 
            // listBoxSteps
            // 
            this.listBoxSteps.FormattingEnabled = true;
            this.listBoxSteps.HorizontalScrollbar = true;
            this.listBoxSteps.ItemHeight = 17;
            this.listBoxSteps.Location = new System.Drawing.Point(12, 28);
            this.listBoxSteps.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxSteps.Name = "listBoxSteps";
            this.listBoxSteps.Size = new System.Drawing.Size(564, 310);
            this.listBoxSteps.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.radioInsertion);
            this.groupBox1.Controls.Add(this.radioButtonSelection);
            this.groupBox1.Controls.Add(this.radioButtonBubble);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(341, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(179, 98);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select sorting algorithm";
            // 
            // radioInsertion
            // 
            this.radioInsertion.AutoSize = true;
            this.radioInsertion.Location = new System.Drawing.Point(4, 70);
            this.radioInsertion.Margin = new System.Windows.Forms.Padding(2);
            this.radioInsertion.Name = "radioInsertion";
            this.radioInsertion.Size = new System.Drawing.Size(108, 21);
            this.radioInsertion.TabIndex = 2;
            this.radioInsertion.TabStop = true;
            this.radioInsertion.Text = "Insertion sort";
            this.radioInsertion.UseVisualStyleBackColor = true;
            this.radioInsertion.CheckedChanged += new System.EventHandler(this.radioInsertion_CheckedChanged);
            // 
            // radioButtonSelection
            // 
            this.radioButtonSelection.AutoSize = true;
            this.radioButtonSelection.Location = new System.Drawing.Point(4, 46);
            this.radioButtonSelection.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSelection.Name = "radioButtonSelection";
            this.radioButtonSelection.Size = new System.Drawing.Size(112, 21);
            this.radioButtonSelection.TabIndex = 1;
            this.radioButtonSelection.TabStop = true;
            this.radioButtonSelection.Text = "Selection sort";
            this.radioButtonSelection.UseVisualStyleBackColor = true;
            this.radioButtonSelection.CheckedChanged += new System.EventHandler(this.radioButtonSelection_CheckedChanged);
            // 
            // radioButtonBubble
            // 
            this.radioButtonBubble.AutoSize = true;
            this.radioButtonBubble.Location = new System.Drawing.Point(4, 21);
            this.radioButtonBubble.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonBubble.Name = "radioButtonBubble";
            this.radioButtonBubble.Size = new System.Drawing.Size(98, 21);
            this.radioButtonBubble.TabIndex = 0;
            this.radioButtonBubble.TabStop = true;
            this.radioButtonBubble.Text = "Bubble sort";
            this.radioButtonBubble.UseVisualStyleBackColor = true;
            this.radioButtonBubble.CheckedChanged += new System.EventHandler(this.radioButtonBubble_CheckedChanged);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(173, 30);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(46, 20);
            this.textBoxN.TabIndex = 16;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.progressBar.Location = new System.Drawing.Point(550, 79);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(383, 38);
            this.progressBar.TabIndex = 17;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProgress.Location = new System.Drawing.Point(547, 50);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(94, 16);
            this.lblProgress.TabIndex = 18;
            this.lblProgress.Text = "Progress . . .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::lab2.Properties.Resources.sorting;
            this.ClientSize = new System.Drawing.Size(961, 547);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSteps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.listSortedArray);
            this.Controls.Add(this.listArray);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxSteps.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listArray;
        private System.Windows.Forms.ListBox listSortedArray;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxSteps;
        private System.Windows.Forms.ListBox listBoxSteps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioInsertion;
        private System.Windows.Forms.RadioButton radioButtonSelection;
        private System.Windows.Forms.RadioButton radioButtonBubble;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
    }
}

