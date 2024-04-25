using System;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class MainForm : Form
    {
        Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 1000; // Update every second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

       
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the label text with current time
            time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        
    }
}
