namespace AsynchPattern
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
            this.btnSynchCall = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAsynchCall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSynchCall
            // 
            this.btnSynchCall.Location = new System.Drawing.Point(80, 47);
            this.btnSynchCall.Name = "btnSynchCall";
            this.btnSynchCall.Size = new System.Drawing.Size(75, 23);
            this.btnSynchCall.TabIndex = 0;
            this.btnSynchCall.Text = "Synch Call";
            this.btnSynchCall.UseVisualStyleBackColor = true;
            this.btnSynchCall.Click += new System.EventHandler(this.ButtonSynchCall_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnAsynchCall
            // 
            this.btnAsynchCall.Location = new System.Drawing.Point(80, 87);
            this.btnAsynchCall.Name = "btnAsynchCall";
            this.btnAsynchCall.Size = new System.Drawing.Size(75, 23);
            this.btnAsynchCall.TabIndex = 2;
            this.btnAsynchCall.Text = "AsynchCall";
            this.btnAsynchCall.UseVisualStyleBackColor = true;
            this.btnAsynchCall.Click += new System.EventHandler(this.ButtonAsynchCall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAsynchCall);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSynchCall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSynchCall;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAsynchCall;
    }
}

