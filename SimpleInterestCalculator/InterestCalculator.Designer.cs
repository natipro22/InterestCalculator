namespace SimpleInterestCalculator
{
    partial class IterestCalculatorForm
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
            this.gBoxInput = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxInput
            // 
            this.gBoxInput.Controls.Add(this.txtTime);
            this.gBoxInput.Controls.Add(this.txtRate);
            this.gBoxInput.Controls.Add(this.txtPrincipal);
            this.gBoxInput.Controls.Add(this.lblTime);
            this.gBoxInput.Controls.Add(this.lblRate);
            this.gBoxInput.Controls.Add(this.lblPrincipal);
            this.gBoxInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBoxInput.Location = new System.Drawing.Point(0, 0);
            this.gBoxInput.Margin = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.gBoxInput.Name = "gBoxInput";
            this.gBoxInput.Padding = new System.Windows.Forms.Padding(15);
            this.gBoxInput.Size = new System.Drawing.Size(570, 235);
            this.gBoxInput.TabIndex = 0;
            this.gBoxInput.TabStop = false;
            this.gBoxInput.Text = "Input Values";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(233, 147);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(151, 26);
            this.txtTime.TabIndex = 5;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(233, 103);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(151, 26);
            this.txtRate.TabIndex = 4;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(233, 65);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(151, 26);
            this.txtPrincipal.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(163, 150);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 20);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(144, 106);
            this.lblRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(62, 20);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Rate %";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(138, 68);
            this.lblPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(68, 20);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalculate.Location = new System.Drawing.Point(142, 251);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 28);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(286, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // IterestCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 291);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gBoxInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IterestCalculatorForm";
            this.Text = "Interest Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxInput.ResumeLayout(false);
            this.gBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxInput;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCancel;
    }
}

