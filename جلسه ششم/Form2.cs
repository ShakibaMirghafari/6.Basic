using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace جلسه_ششم
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void lableTimer_Tick(object sender, EventArgs e)
		{
			if (string.Compare(titleLabel.Text, "به کلاس من خوش آمدید", ignoreCase: true) == 0)
			{
				titleLabel.Text = " شکیبا میرغفاری";
				titleLabel.BackColor = System.Drawing.Color.Cyan;
			}
			else
			{
				titleLabel.Text = "به کلاس من خوش آمدید";
				titleLabel.BackColor = System.Drawing.Color.GreenYellow;


			}
		}

		private void formTimer_Tick(object sender, EventArgs e)
		{

			if (Width <= 470)
			{
				Width += 5;
			}
			else
			{
				formTimer.Enabled = false;

			}
		}
	}
}
