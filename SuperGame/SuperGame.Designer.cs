﻿namespace SuperGame
{
    partial class SuperGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit Points:";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Gold:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Exp:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(110, 19);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(0, 13);
            this.lblHitPoints.TabIndex = 4;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(110, 45);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 13);
            this.lblGold.TabIndex = 5;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(110, 73);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(0, 13);
            this.lblExp.TabIndex = 6;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(110, 99);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 13);
            this.lblLevel.TabIndex = 7;
            // 
            // SuperGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 651);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuperGame";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblLevel;
    }
}

