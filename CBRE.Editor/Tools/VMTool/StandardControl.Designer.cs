﻿namespace CBRE.Editor.Tools.VMTool
{
    partial class StandardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MergeButton = new System.Windows.Forms.Button();
            this.AutoMerge = new System.Windows.Forms.CheckBox();
            this.SplitButton = new System.Windows.Forms.Button();
            this.MergeResultsLabel = new CBRE.Editor.Tools.VMTool.FadeLabel();
            this.SuspendLayout();
            // 
            // MergeButton
            // 
            this.MergeButton.Location = new System.Drawing.Point(3, 3);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(144, 23);
            this.MergeButton.TabIndex = 8;
            this.MergeButton.Text = "Merge overlapping vertices";
            this.MergeButton.UseVisualStyleBackColor = true;
            this.MergeButton.Click += new System.EventHandler(this.MergeButtonClicked);
            // 
            // AutoMerge
            // 
            this.AutoMerge.AutoSize = true;
            this.AutoMerge.Checked = true;
            this.AutoMerge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoMerge.Location = new System.Drawing.Point(7, 32);
            this.AutoMerge.Name = "AutoMerge";
            this.AutoMerge.Size = new System.Drawing.Size(120, 17);
            this.AutoMerge.TabIndex = 7;
            this.AutoMerge.Text = "Merge automatically";
            this.AutoMerge.UseVisualStyleBackColor = true;
            // 
            // SplitButton
            // 
            this.SplitButton.Location = new System.Drawing.Point(60, 68);
            this.SplitButton.Name = "SplitButton";
            this.SplitButton.Size = new System.Drawing.Size(76, 23);
            this.SplitButton.TabIndex = 8;
            this.SplitButton.Text = "Split face";
            this.SplitButton.UseVisualStyleBackColor = true;
            this.SplitButton.Click += new System.EventHandler(this.SplitButtonClicked);
            // 
            // MergeResultsLabel
            // 
            this.MergeResultsLabel.AutoSize = true;
            this.MergeResultsLabel.FadeTime = 2000;
            this.MergeResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeResultsLabel.Location = new System.Drawing.Point(4, 52);
            this.MergeResultsLabel.Name = "MergeResultsLabel";
            this.MergeResultsLabel.Size = new System.Drawing.Size(88, 13);
            this.MergeResultsLabel.TabIndex = 9;
            this.MergeResultsLabel.Text = "Merge Results";
            // 
            // StandardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MergeResultsLabel);
            this.Controls.Add(this.SplitButton);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.AutoMerge);
            this.Name = "StandardControl";
            this.Size = new System.Drawing.Size(200, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.CheckBox AutoMerge;
        private System.Windows.Forms.Button SplitButton;
        private FadeLabel MergeResultsLabel;
    }
}
