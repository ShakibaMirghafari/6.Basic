namespace جلسه_ششم
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			this.titleLabel = new System.Windows.Forms.Label();
			this.lableTimer = new System.Windows.Forms.Timer(this.components);
			this.formTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.titleLabel.BackColor = System.Drawing.Color.Wheat;
			this.titleLabel.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.ForeColor = System.Drawing.Color.Firebrick;
			this.titleLabel.Location = new System.Drawing.Point(23, 28);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(82, 331);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "به کلاس من خوش آمدید";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lableTimer
			// 
			this.lableTimer.Enabled = true;
			this.lableTimer.Interval = 1000;
			this.lableTimer.Tick += new System.EventHandler(this.lableTimer_Tick);
			// 
			// formTimer
			// 
			this.formTimer.Enabled = true;
			this.formTimer.Interval = 1;
			this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(128, 386);
			this.Controls.Add(this.titleLabel);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Timer lableTimer;
		private System.Windows.Forms.Timer formTimer;
	}
}