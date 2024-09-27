namespace _9._30_hw2
{
    public partial class Form1 : Form
    {
        TimeSpan ts;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Update();
        }
        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            Update();
        }

         public void Update()
        {
            ts = dateTimePickerEnd.Value - dateTimePickerStart.Value;
            if (textBox1.Text != "")
                label7.Text = $"Cost of work: {((int)ts.TotalDays + 1) * int.Parse(textBox1.Text) }";
        }
    }
}
