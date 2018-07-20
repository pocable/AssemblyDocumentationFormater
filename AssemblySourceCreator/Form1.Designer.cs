﻿namespace AssemblySourceCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.UsedReg = new System.Windows.Forms.Label();
            this.usedRegBox = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.returnBox = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.forceSize = new System.Windows.Forms.CheckBox();
            this.forceSizeAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.forceSizeAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TitleLabel.Location = new System.Drawing.Point(131, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(122, 20);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Algorithm Name";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(28, 43);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(324, 20);
            this.titleBox.TabIndex = 1;
            // 
            // UsedReg
            // 
            this.UsedReg.AutoSize = true;
            this.UsedReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsedReg.Location = new System.Drawing.Point(131, 440);
            this.UsedReg.Name = "UsedReg";
            this.UsedReg.Size = new System.Drawing.Size(119, 20);
            this.UsedReg.TabIndex = 2;
            this.UsedReg.Text = "Used Registers";
            // 
            // usedRegBox
            // 
            this.usedRegBox.AcceptsReturn = true;
            this.usedRegBox.Location = new System.Drawing.Point(28, 463);
            this.usedRegBox.Multiline = true;
            this.usedRegBox.Name = "usedRegBox";
            this.usedRegBox.Size = new System.Drawing.Size(324, 127);
            this.usedRegBox.TabIndex = 3;
            // 
            // inputBox
            // 
            this.inputBox.AcceptsReturn = true;
            this.inputBox.Location = new System.Drawing.Point(28, 112);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(324, 127);
            this.inputBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(162, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input";
            // 
            // outputBox
            // 
            this.outputBox.AcceptsReturn = true;
            this.outputBox.Location = new System.Drawing.Point(28, 289);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(324, 127);
            this.outputBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(162, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // returnBox
            // 
            this.returnBox.Location = new System.Drawing.Point(410, 107);
            this.returnBox.Multiline = true;
            this.returnBox.Name = "returnBox";
            this.returnBox.Size = new System.Drawing.Size(404, 491);
            this.returnBox.TabIndex = 8;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(551, 24);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(263, 64);
            this.generate.TabIndex = 9;
            this.generate.Text = "Generate Documentation";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Text will look wierd in the output. Copy and paste it into your source file and i" +
    "t will look better.";
            // 
            // forceSize
            // 
            this.forceSize.AutoSize = true;
            this.forceSize.Location = new System.Drawing.Point(432, 33);
            this.forceSize.Name = "forceSize";
            this.forceSize.Size = new System.Drawing.Size(76, 17);
            this.forceSize.TabIndex = 12;
            this.forceSize.Text = "Force Size";
            this.forceSize.UseVisualStyleBackColor = true;
            this.forceSize.CheckedChanged += new System.EventHandler(this.forceSize_CheckedChanged);
            // 
            // forceSizeAmount
            // 
            this.forceSizeAmount.Location = new System.Drawing.Point(410, 53);
            this.forceSizeAmount.Name = "forceSizeAmount";
            this.forceSizeAmount.Size = new System.Drawing.Size(120, 20);
            this.forceSizeAmount.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 622);
            this.Controls.Add(this.forceSizeAmount);
            this.Controls.Add(this.forceSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.returnBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usedRegBox);
            this.Controls.Add(this.UsedReg);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Assembly Documentation Formater";
            ((System.ComponentModel.ISupportInitialize)(this.forceSizeAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label UsedReg;
        private System.Windows.Forms.TextBox usedRegBox;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox returnBox;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox forceSize;
        private System.Windows.Forms.NumericUpDown forceSizeAmount;
    }
}

