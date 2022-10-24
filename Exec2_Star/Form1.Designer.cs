namespace Exec2_Star
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
			this.rowslbl = new System.Windows.Forms.Label();
			this.rowstxt = new System.Windows.Forms.TextBox();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btbIso = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.lblresult = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rowslbl
			// 
			this.rowslbl.AutoSize = true;
			this.rowslbl.Location = new System.Drawing.Point(114, 52);
			this.rowslbl.Name = "rowslbl";
			this.rowslbl.Size = new System.Drawing.Size(31, 15);
			this.rowslbl.TabIndex = 0;
			this.rowslbl.Text = "列數";
			// 
			// rowstxt
			// 
			this.rowstxt.Location = new System.Drawing.Point(162, 49);
			this.rowstxt.Name = "rowstxt";
			this.rowstxt.Size = new System.Drawing.Size(199, 23);
			this.rowstxt.TabIndex = 1;
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(114, 94);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(65, 23);
			this.btnLeft.TabIndex = 2;
			this.btnLeft.Text = "靠左";
			this.btnLeft.UseVisualStyleBackColor = true;
			// 
			// btbIso
			// 
			this.btbIso.Location = new System.Drawing.Point(0, 0);
			this.btbIso.Name = "btbIso";
			this.btbIso.Size = new System.Drawing.Size(75, 23);
			this.btbIso.TabIndex = 0;
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(0, 0);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(75, 23);
			this.btnRight.TabIndex = 0;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(0, 0);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(100, 23);
			this.txtResult.TabIndex = 0;
			// 
			// lblresult
			// 
			this.lblresult.Location = new System.Drawing.Point(0, 0);
			this.lblresult.Name = "lblresult";
			this.lblresult.Size = new System.Drawing.Size(100, 23);
			this.lblresult.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(122, 102);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.ResumeLayout(false);

		}

        #endregion

        private Label rowslbl;
        private TextBox rowstxt;
        private Button btnLeft;
        private Button btbIso;
        private Button btnRight;
        private TextBox txtResult;
        private Label lblresult;
		private Button button1;
	}
}