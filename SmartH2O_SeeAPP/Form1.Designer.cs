namespace SmartH2O_SeeAPP
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
            this.buttonGetDays = new System.Windows.Forms.Button();
            this.listBoxGetDays = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGetDays
            // 
            this.buttonGetDays.Location = new System.Drawing.Point(25, 26);
            this.buttonGetDays.Name = "buttonGetDays";
            this.buttonGetDays.Size = new System.Drawing.Size(332, 23);
            this.buttonGetDays.TabIndex = 0;
            this.buttonGetDays.Text = "Get Days";
            this.buttonGetDays.UseVisualStyleBackColor = true;
            this.buttonGetDays.Click += new System.EventHandler(this.buttonGetDays_Click);
            // 
            // listBoxGetDays
            // 
            this.listBoxGetDays.FormattingEnabled = true;
            this.listBoxGetDays.Location = new System.Drawing.Point(25, 55);
            this.listBoxGetDays.Name = "listBoxGetDays";
            this.listBoxGetDays.Size = new System.Drawing.Size(332, 95);
            this.listBoxGetDays.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 511);
            this.Controls.Add(this.listBoxGetDays);
            this.Controls.Add(this.buttonGetDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetDays;
        private System.Windows.Forms.ListBox listBoxGetDays;
    }
}

