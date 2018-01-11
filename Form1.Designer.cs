namespace MousePathRec
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.dirSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.dirText = new System.Windows.Forms.TextBox();
            this.lineSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialogLine = new System.Windows.Forms.ColorDialog();
            this.buttonColorLine = new System.Windows.Forms.Button();
            this.buttonColorBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialogBackground = new System.Windows.Forms.ColorDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.recordingStatus = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            this.textBoxlmb = new System.Windows.Forms.TextBox();
            this.textBoxrmb = new System.Windows.Forms.TextBox();
            this.textBoxScroll = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resetCounter = new System.Windows.Forms.Button();
            this.checkBoxPath = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.lineSize)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(67, 60);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(96, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Start Recording";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(199, 60);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(99, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop Recording";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // dirText
            // 
            this.dirText.Location = new System.Drawing.Point(199, 128);
            this.dirText.Name = "dirText";
            this.dirText.Size = new System.Drawing.Size(99, 20);
            this.dirText.TabIndex = 3;
            this.dirText.Text = "F:\\Coding\\abc.png";
            // 
            // lineSize
            // 
            this.lineSize.DecimalPlaces = 2;
            this.lineSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lineSize.Location = new System.Drawing.Point(199, 154);
            this.lineSize.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lineSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lineSize.Name = "lineSize";
            this.lineSize.Size = new System.Drawing.Size(101, 20);
            this.lineSize.TabIndex = 5;
            this.lineSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Output Path: (.png)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Line Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Line Color:";
            // 
            // buttonColorLine
            // 
            this.buttonColorLine.Location = new System.Drawing.Point(199, 184);
            this.buttonColorLine.Name = "buttonColorLine";
            this.buttonColorLine.Size = new System.Drawing.Size(99, 23);
            this.buttonColorLine.TabIndex = 9;
            this.buttonColorLine.Text = "Select Color";
            this.buttonColorLine.UseVisualStyleBackColor = true;
            this.buttonColorLine.Click += new System.EventHandler(this.buttonColorLine_Click);
            // 
            // buttonColorBack
            // 
            this.buttonColorBack.Location = new System.Drawing.Point(199, 213);
            this.buttonColorBack.Name = "buttonColorBack";
            this.buttonColorBack.Size = new System.Drawing.Size(99, 23);
            this.buttonColorBack.TabIndex = 11;
            this.buttonColorBack.Text = "Select Color";
            this.buttonColorBack.UseVisualStyleBackColor = true;
            this.buttonColorBack.Click += new System.EventHandler(this.buttonColorBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Background Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quartz", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mouse Path Recorder";
            // 
            // recordingStatus
            // 
            this.recordingStatus.AutoSize = true;
            this.recordingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordingStatus.ForeColor = System.Drawing.Color.Crimson;
            this.recordingStatus.Location = new System.Drawing.Point(317, 65);
            this.recordingStatus.Name = "recordingStatus";
            this.recordingStatus.Size = new System.Drawing.Size(89, 13);
            this.recordingStatus.TabIndex = 13;
            this.recordingStatus.Text = "Not Recording";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(320, 125);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(99, 23);
            this.openFile.TabIndex = 14;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // textBoxlmb
            // 
            this.textBoxlmb.Location = new System.Drawing.Point(67, 298);
            this.textBoxlmb.Name = "textBoxlmb";
            this.textBoxlmb.Size = new System.Drawing.Size(99, 20);
            this.textBoxlmb.TabIndex = 15;
            this.textBoxlmb.Text = "0";
            // 
            // textBoxrmb
            // 
            this.textBoxrmb.Location = new System.Drawing.Point(199, 298);
            this.textBoxrmb.Name = "textBoxrmb";
            this.textBoxrmb.Size = new System.Drawing.Size(99, 20);
            this.textBoxrmb.TabIndex = 16;
            this.textBoxrmb.Text = "0";
            // 
            // textBoxScroll
            // 
            this.textBoxScroll.Location = new System.Drawing.Point(320, 298);
            this.textBoxScroll.Name = "textBoxScroll";
            this.textBoxScroll.Size = new System.Drawing.Size(99, 20);
            this.textBoxScroll.TabIndex = 17;
            this.textBoxScroll.Text = "0";
            this.textBoxScroll.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Left Clicks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Right Clicks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Scroll Actions";
            // 
            // resetCounter
            // 
            this.resetCounter.Location = new System.Drawing.Point(199, 324);
            this.resetCounter.Name = "resetCounter";
            this.resetCounter.Size = new System.Drawing.Size(99, 23);
            this.resetCounter.TabIndex = 22;
            this.resetCounter.Text = "Reset Counter";
            this.resetCounter.UseVisualStyleBackColor = true;
            this.resetCounter.Click += new System.EventHandler(this.resetCounter_Click);
            // 
            // checkBoxPath
            // 
            this.checkBoxPath.AutoSize = true;
            this.checkBoxPath.Location = new System.Drawing.Point(189, 105);
            this.checkBoxPath.Name = "checkBoxPath";
            this.checkBoxPath.Size = new System.Drawing.Size(121, 17);
            this.checkBoxPath.TabIndex = 23;
            this.checkBoxPath.Text = "Record Mouse Path";
            this.checkBoxPath.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 448);
            this.Controls.Add(this.checkBoxPath);
            this.Controls.Add(this.resetCounter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxScroll);
            this.Controls.Add(this.textBoxrmb);
            this.Controls.Add(this.textBoxlmb);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.recordingStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonColorBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonColorLine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineSize);
            this.Controls.Add(this.dirText);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lineSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.FolderBrowserDialog dirSelector;
        private System.Windows.Forms.TextBox dirText;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.NumericUpDown lineSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialogLine;
        private System.Windows.Forms.Button buttonColorLine;
        private System.Windows.Forms.Button buttonColorBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialogBackground;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label recordingStatus;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox textBoxlmb;
        private System.Windows.Forms.TextBox textBoxrmb;
        private System.Windows.Forms.TextBox textBoxScroll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button resetCounter;
        private System.Windows.Forms.CheckBox checkBoxPath;
    }
}

