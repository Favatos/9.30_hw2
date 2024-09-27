namespace _9._30_hw2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            buttonTimer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = SystemColors.MenuHighlight;
            progressBar1.Location = new Point(181, 62);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(648, 29);
            progressBar1.TabIndex = 1;
            progressBar1.UseWaitCursor = true;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // trackBarRed
            // 
            trackBarRed.Location = new Point(92, 159);
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.RightToLeft = RightToLeft.No;
            trackBarRed.Size = new Size(648, 56);
            trackBarRed.TabIndex = 2;
            trackBarRed.TickFrequency = 10;
            trackBarRed.Scroll += trackBar1_Scroll;
            // 
            // trackBarGreen
            // 
            trackBarGreen.Location = new Point(92, 221);
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.RightToLeft = RightToLeft.No;
            trackBarGreen.Size = new Size(648, 56);
            trackBarGreen.TabIndex = 3;
            trackBarGreen.TickFrequency = 10;
            trackBarGreen.Scroll += trackBarGreen_Scroll;
            // 
            // trackBarBlue
            // 
            trackBarBlue.Location = new Point(92, 283);
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.RightToLeft = RightToLeft.No;
            trackBarBlue.Size = new Size(648, 56);
            trackBarBlue.TabIndex = 4;
            trackBarBlue.TickFrequency = 10;
            trackBarBlue.Scroll += trackBarBlue_Scroll;
            // 
            // buttonTimer
            // 
            buttonTimer.Location = new Point(12, 62);
            buttonTimer.Name = "buttonTimer";
            buttonTimer.Size = new Size(94, 29);
            buttonTimer.TabIndex = 5;
            buttonTimer.Text = "start timer";
            buttonTimer.UseVisualStyleBackColor = true;
            buttonTimer.Click += buttonTimer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 159);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 6;
            label1.Text = "red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 221);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 7;
            label2.Text = "green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 283);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 8;
            label3.Text = "blue";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(181, 336);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 9;
            dateTimePickerStart.ValueChanged += dateTimePickerStart_ValueChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(181, 385);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 10;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 435);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 341);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 12;
            label4.Text = "Start date of the work";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 390);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 13;
            label5.Text = "Completion date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 438);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 14;
            label6.Text = "Cost of one day";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(546, 390);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 15;
            label7.Text = "Cost of work: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 494);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonTimer);
            Controls.Add(trackBarBlue);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarRed);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Button buttonTimer;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
