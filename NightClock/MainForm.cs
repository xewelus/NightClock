using System;
using System.Drawing;
using System.Windows.Forms;

namespace NightClock
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			this.InitializeComponent();
			this.Location = new Point();
			this.Size = Screen.PrimaryScreen.Bounds.Size;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			DateTime date = DateTime.Now;
			string s = date.ToString("dddd, dd MMMM yyyy").Replace("0", "O");
			s = s.Substring(0, 1).ToUpper() + s.Substring(1);
			string s2 = "";
			for (int i = 0; i < s.Length; i++)
			{
				s2 += s[i] + " ";
			}
			this.lblDate.Text = s2;
			this.lblTime.Text = date.ToString("HH:mm:ss").Replace("0", "O");
		}

		private void lblTime_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			this.Close();
		}
	}
}
