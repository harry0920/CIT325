namespace MegaDesk_3_HarryVashisht
{
    partial class AddQuote
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.inputdepth = new System.Windows.Forms.NumericUpDown();
            this.inputwidth = new System.Windows.Forms.NumericUpDown();
            this.inputdrawers = new System.Windows.Forms.NumericUpDown();
            this.labelwidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputdepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputdrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(167, 334);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(142, 53);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // inputdepth
            // 
            this.inputdepth.Location = new System.Drawing.Point(301, 93);
            this.inputdepth.Name = "inputdepth";
            this.inputdepth.Size = new System.Drawing.Size(120, 20);
            this.inputdepth.TabIndex = 2;
            // 
            // inputwidth
            // 
            this.inputwidth.Location = new System.Drawing.Point(301, 38);
            this.inputwidth.Name = "inputwidth";
            this.inputwidth.Size = new System.Drawing.Size(120, 20);
            this.inputwidth.TabIndex = 1;
            this.inputwidth.ValueChanged += new System.EventHandler(this.inputwidth_ValueChanged);
            this.inputwidth.Validating += new System.ComponentModel.CancelEventHandler(this.inputwidth_Validating);
            // 
            // inputdrawers
            // 
            this.inputdrawers.Location = new System.Drawing.Point(301, 156);
            this.inputdrawers.Name = "inputdrawers";
            this.inputdrawers.Size = new System.Drawing.Size(120, 20);
            this.inputdrawers.TabIndex = 3;
            // 
            // labelwidth
            // 
            this.labelwidth.AutoSize = true;
            this.labelwidth.Location = new System.Drawing.Point(204, 40);
            this.labelwidth.Name = "labelwidth";
            this.labelwidth.Size = new System.Drawing.Size(35, 13);
            this.labelwidth.TabIndex = 4;
            this.labelwidth.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Drawers";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelwidth);
            this.Controls.Add(this.inputdrawers);
            this.Controls.Add(this.inputwidth);
            this.Controls.Add(this.inputdepth);
            this.Controls.Add(this.CloseButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputdepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputdrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.NumericUpDown inputdepth;
        private System.Windows.Forms.NumericUpDown inputwidth;
        private System.Windows.Forms.NumericUpDown inputdrawers;
        private System.Windows.Forms.Label labelwidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}