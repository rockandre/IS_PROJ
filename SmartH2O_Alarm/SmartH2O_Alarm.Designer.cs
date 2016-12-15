namespace SmartH2O_Alarm
{
    partial class SmartH2O_Alarm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.labelStartStop = new System.Windows.Forms.Label();
            this.labelConf = new System.Windows.Forms.Label();
            this.labelPH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPHmin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPHmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNH3min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNH3max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCI2min = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCI2max = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNH3 = new System.Windows.Forms.Label();
            this.labelCI2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPHmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPHmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNH3min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNH3max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCI2min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCI2max)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 261);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 27);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(108, 261);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 27);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // labelStartStop
            // 
            this.labelStartStop.AutoSize = true;
            this.labelStartStop.Location = new System.Drawing.Point(15, 239);
            this.labelStartStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartStop.Name = "labelStartStop";
            this.labelStartStop.Size = new System.Drawing.Size(220, 15);
            this.labelStartStop.TabIndex = 2;
            this.labelStartStop.Text = "Start/Stop Receiving Data From Sensor";
            // 
            // labelConf
            // 
            this.labelConf.AutoSize = true;
            this.labelConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConf.Location = new System.Drawing.Point(64, 9);
            this.labelConf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConf.Name = "labelConf";
            this.labelConf.Size = new System.Drawing.Size(191, 25);
            this.labelConf.TabIndex = 3;
            this.labelConf.Text = "Parameters Range";
            // 
            // labelPH
            // 
            this.labelPH.AutoSize = true;
            this.labelPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPH.Location = new System.Drawing.Point(15, 36);
            this.labelPH.Name = "labelPH";
            this.labelPH.Size = new System.Drawing.Size(31, 18);
            this.labelPH.TabIndex = 4;
            this.labelPH.Text = "PH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "De: ";
            // 
            // numericUpDownPHmin
            // 
            this.numericUpDownPHmin.Location = new System.Drawing.Point(42, 54);
            this.numericUpDownPHmin.Name = "numericUpDownPHmin";
            this.numericUpDownPHmin.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownPHmin.TabIndex = 6;
            // 
            // numericUpDownPHmax
            // 
            this.numericUpDownPHmax.Location = new System.Drawing.Point(134, 54);
            this.numericUpDownPHmax.Name = "numericUpDownPHmax";
            this.numericUpDownPHmax.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownPHmax.TabIndex = 7;
            // 
            // numericUpDownNH3min
            // 
            this.numericUpDownNH3min.Location = new System.Drawing.Point(42, 109);
            this.numericUpDownNH3min.Name = "numericUpDownNH3min";
            this.numericUpDownNH3min.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownNH3min.TabIndex = 8;
            // 
            // numericUpDownNH3max
            // 
            this.numericUpDownNH3max.Location = new System.Drawing.Point(134, 111);
            this.numericUpDownNH3max.Name = "numericUpDownNH3max";
            this.numericUpDownNH3max.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownNH3max.TabIndex = 9;
            // 
            // numericUpDownCI2min
            // 
            this.numericUpDownCI2min.Location = new System.Drawing.Point(42, 169);
            this.numericUpDownCI2min.Name = "numericUpDownCI2min";
            this.numericUpDownCI2min.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownCI2min.TabIndex = 10;
            // 
            // numericUpDownCI2max
            // 
            this.numericUpDownCI2max.Location = new System.Drawing.Point(134, 169);
            this.numericUpDownCI2max.Name = "numericUpDownCI2max";
            this.numericUpDownCI2max.Size = new System.Drawing.Size(59, 21);
            this.numericUpDownCI2max.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "até";
            // 
            // labelNH3
            // 
            this.labelNH3.AutoSize = true;
            this.labelNH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNH3.Location = new System.Drawing.Point(15, 88);
            this.labelNH3.Name = "labelNH3";
            this.labelNH3.Size = new System.Drawing.Size(41, 18);
            this.labelNH3.TabIndex = 13;
            this.labelNH3.Text = "NH3";
            // 
            // labelCI2
            // 
            this.labelCI2.AutoSize = true;
            this.labelCI2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCI2.Location = new System.Drawing.Point(15, 148);
            this.labelCI2.Name = "labelCI2";
            this.labelCI2.Size = new System.Drawing.Size(33, 18);
            this.labelCI2.TabIndex = 14;
            this.labelCI2.Text = "CI2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "De: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "De: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "até";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "até";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(69, 196);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(198, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 20;
            // 
            // SmartH2O_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCI2);
            this.Controls.Add(this.labelNH3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownCI2max);
            this.Controls.Add(this.numericUpDownCI2min);
            this.Controls.Add(this.numericUpDownNH3max);
            this.Controls.Add(this.numericUpDownNH3min);
            this.Controls.Add(this.numericUpDownPHmax);
            this.Controls.Add(this.numericUpDownPHmin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPH);
            this.Controls.Add(this.labelConf);
            this.Controls.Add(this.labelStartStop);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SmartH2O_Alarm";
            this.Text = "SmartH2O Alarm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPHmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPHmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNH3min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNH3max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCI2min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCI2max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labelStartStop;
        private System.Windows.Forms.Label labelConf;
        private System.Windows.Forms.Label labelPH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPHmin;
        private System.Windows.Forms.NumericUpDown numericUpDownPHmax;
        private System.Windows.Forms.NumericUpDown numericUpDownNH3min;
        private System.Windows.Forms.NumericUpDown numericUpDownNH3max;
        private System.Windows.Forms.NumericUpDown numericUpDownCI2min;
        private System.Windows.Forms.NumericUpDown numericUpDownCI2max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNH3;
        private System.Windows.Forms.Label labelCI2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

