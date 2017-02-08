namespace CoinsCalculator
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
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(53, 16);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(100, 20);
            this.tbWeight.TabIndex = 0;
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(159, 14);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 1;
            this.btCalculate.Text = "Calculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight";
            // 
            // lbResult
            // 
            this.lbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(15, 53);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(35, 13);
            this.lbResult.TabIndex = 3;
            this.lbResult.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 322);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.tbWeight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResult;
    }
}

